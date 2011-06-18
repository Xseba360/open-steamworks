﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Steam4NET;

namespace SkypeStatus
{
    public partial class MainForm : Form
    {
        bool steamAttached, skypeAttached;


        public MainForm()
        {
            SkypeContext.Denied += SkypeContext_Denied;
            SkypeContext.Ready += SkypeContext_Ready;

            SteamContext.PersonaStateChange.OnRun += PersonaStateChange_OnRun;

            InitializeComponent();

            AttachSteam();
            AttachSkype();
        }

        void PersonaStateChange_OnRun( PersonaStateChange_t param )
        {
            if ( param.m_ulSteamID != SteamContext.SteamUser.GetSteamID() )
            {
                // we're only interested in our own persona changes
                return;
            }

            if ( !SkypeContext.IsReady )
            {
                Log( "Warning: Detect game launch, but skype isn't attached!" );
                return;
            }

            if ( ( param.m_nChangeFlags & EPersonaChange.k_EPersonaChangeGamePlayed ) != 0 )
            {
                this.Invoke( new MethodInvoker( () =>
                {
                    UpdateSkypeMood( param );
                } ) );
            }
        }

        private void UpdateSkypeMood( PersonaStateChange_t param )
        {
            FriendGameInfo_t gameInfo = new FriendGameInfo_t();

            if ( !SteamContext.SteamFriends.GetFriendGamePlayed( param.m_ulSteamID, ref gameInfo ) )
            {
                // this happens when we stop playing a game
                SetSkypeMood( "Stopped playing" );
                return;
            }

            CGameID gameId = gameInfo.m_gameID;

            if ( gameId.AppType != CGameID.EGameID.k_EGameIDTypeApp )
            {
                Log( "Info: Detected game launch, but wasn't steam game. Only official steam apps are supported!" );
                return;
            }

            StringBuilder sb = new StringBuilder( 256 );
            SteamContext.SteamApps.GetAppData( gameId.AppID, "name", sb );

            string name = sb.ToString();

            if ( string.IsNullOrEmpty( name ) )
            {
                Log( "Warning: Detect game launch, but wasn't able to get the name! AppID: {0}, GameID: {1}", gameId.AppID, gameId.ConvertToUint64() );
                return;
            }

            SetSkypeMood( "Now Playing: ", name );
        }

        private void SetSkypeMood( string steamGame, params object[] args )
        {
            try
            {
                SkypeContext.Skype.CurrentUserProfile.MoodText = string.Format( "[Steam] {0}", string.Format( steamGame, args ) );
            }
            catch ( Exception ex )
            {
                Log( "Error: Unable to set skype mood! {0}", ex );
            }
        }


        void AttachSteam()
        {
            Log( "Trying to attach Steam..." );

            try
            {

                SteamContext.Init();

                steamAttached = true;
                lblSteam.Text = "Steam Status: Ready";
                btnSteamAttach.Enabled = false;

                Log( "Done!" );

            }
            catch ( SteamException ex )
            {

                steamAttached = false;
                lblSteam.Text = string.Format( "Steam Status: Error: {0}", ex.Message );
                btnSteamAttach.Enabled = true;

                Log( "Error: {0}", ex );

            }
        }

        void AttachSkype()
        {
            Log( "Trying to attach Skype..." );
            SkypeContext.Init();
        }

        void Log( string msg, params object[] args )
        {
            string logText = string.Format
            (
                "[{0}] {1}\r\n",
                DateTime.Now.ToShortTimeString(),
                string.Format( msg, args )
            );

            txtLog.AppendText( logText );
        }


        private void SkypeContext_Ready( object sender, EventArgs e )
        {
            this.Invoke( new MethodInvoker( () =>
            {
                skypeAttached = true;
                lblSkype.Text = "Skype Status: Ready";
                btnSkypeAttach.Enabled = false;

                Log( "Done!" );
            } ) );
        }

        private void SkypeContext_Denied( object sender, EventArgs e )
        {
            this.Invoke( new MethodInvoker( () =>
            {
                skypeAttached = false;
                lblSkype.Text = "Skype Status: Access Denied!";
                btnSkypeAttach.Enabled = true;

                Log( "Error: Access to Skype was denied. Please press the \"attach\" button and allow access." );
            } ) );
        }

        private void btnSteamAttach_Click( object sender, EventArgs e )
        {
            AttachSteam();
        }

        private void btnSkypeAttach_Click( object sender, EventArgs e )
        {
            AttachSkype();
        }

        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            SteamContext.Shutdown();
        }

    }
}