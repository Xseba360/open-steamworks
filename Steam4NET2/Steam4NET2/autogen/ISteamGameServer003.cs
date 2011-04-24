// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamGameServer003VTable
	{
		public IntPtr LogOn0;
		public IntPtr LogOff1;
		public IntPtr LoggedOn2;
		public IntPtr Secure3;
		public IntPtr GetSteamID4;
		public IntPtr GetSteam2GetEncryptionKeyToSendToNewClient5;
		public IntPtr SendUserConnect6;
		public IntPtr RemoveUserConnect7;
		public IntPtr SendUserDisconnect8;
		public IntPtr SetSpawnCount9;
		public IntPtr SetServerType10;
		public IntPtr UpdateStatus11;
		public IntPtr CreateUnauthenticatedUser12;
		public IntPtr SetUserData13;
		public IntPtr UpdateSpectatorPort14;
		public IntPtr SetGameType15;
		public IntPtr GetUserAchievementStatus16;
		private IntPtr DTorISteamGameServer00317;
	};
	
	[InteropHelp.InterfaceVersion("SteamGameServer003")]
	public class ISteamGameServer003 : InteropHelp.NativeWrapper<ISteamGameServer003VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOn( IntPtr thisptr );
		public void LogOn(  ) 
		{
			this.GetFunction<NativeLogOn>( this.Functions.LogOn0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOff( IntPtr thisptr );
		public void LogOff(  ) 
		{
			this.GetFunction<NativeLogOff>( this.Functions.LogOff1 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLoggedOn( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool LoggedOn(  ) 
		{
			return this.GetFunction<NativeLoggedOn>( this.Functions.LoggedOn2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSecure( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool Secure(  ) 
		{
			return this.GetFunction<NativeSecure>( this.Functions.Secure3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID GetSteamID(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetSteamID>( this.Functions.GetSteamID4 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetSteam2GetEncryptionKeyToSendToNewClientBUU( IntPtr thisptr, Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetSteam2GetEncryptionKeyToSendToNewClient( Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey ) 
		{
			return this.GetFunction<NativeGetSteam2GetEncryptionKeyToSendToNewClientBUU>( this.Functions.GetSteam2GetEncryptionKeyToSendToNewClient5 )( this.ObjectAddress, pvEncryptionKey, ref pcbEncryptionKey, cbMaxEncryptionKey ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendUserConnectUUUBU( IntPtr thisptr, UInt32 arg0, UInt32 arg1, UInt16 arg2, Byte[] arg3, UInt32 arg4 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendUserConnect( UInt32 arg0, UInt32 arg1, UInt16 arg2, Byte[] arg3, UInt32 arg4 ) 
		{
			return this.GetFunction<NativeSendUserConnectUUUBU>( this.Functions.SendUserConnect6 )( this.ObjectAddress, arg0, arg1, arg2, arg3, arg4 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveUserConnectU( IntPtr thisptr, UInt32 unUserID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RemoveUserConnect( UInt32 unUserID ) 
		{
			return this.GetFunction<NativeRemoveUserConnectU>( this.Functions.RemoveUserConnect7 )( this.ObjectAddress, unUserID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendUserDisconnectCU( IntPtr thisptr, UInt64 steamID, UInt32 unUserID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendUserDisconnect( CSteamID steamID, UInt32 unUserID ) 
		{
			return this.GetFunction<NativeSendUserDisconnectCU>( this.Functions.SendUserDisconnect8 )( this.ObjectAddress, steamID.ConvertToUint64(), unUserID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSpawnCountU( IntPtr thisptr, UInt32 ucSpawn );
		public void SetSpawnCount( UInt32 ucSpawn ) 
		{
			this.GetFunction<NativeSetSpawnCountU>( this.Functions.SetSpawnCount9 )( this.ObjectAddress, ucSpawn ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetServerTypeIUUUUUSSB( IntPtr thisptr, Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 usSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, [MarshalAs(UnmanagedType.I1)] bool bLANMode );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetServerType( Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 usSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, bool bLANMode ) 
		{
			return this.GetFunction<NativeSetServerTypeIUUUUUSSB>( this.Functions.SetServerType10 )( this.ObjectAddress, nGameAppId, unServerFlags, unGameIP, unGamePort, usSpectatorPort, usQueryPort, pchGameDir, pchVersion, bLANMode ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateStatusIIISSS( IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool UpdateStatus( Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName ) 
		{
			return this.GetFunction<NativeUpdateStatusIIISSS>( this.Functions.UpdateStatus11 )( this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pSpectatorServerName, pchMapName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateUnauthenticatedUserC( IntPtr thisptr, ref UInt64 pSteamID );
		public Int32 CreateUnauthenticatedUser( ref CSteamID pSteamID ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeCreateUnauthenticatedUserC>( this.Functions.CreateUnauthenticatedUser12 )( this.ObjectAddress, ref s0 ); pSteamID = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserDataCSU( IntPtr thisptr, UInt64 steamIDUser, string pchPlayerName, UInt32 uScore );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetUserData( CSteamID steamIDUser, string pchPlayerName, UInt32 uScore ) 
		{
			return this.GetFunction<NativeSetUserDataCSU>( this.Functions.SetUserData13 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchPlayerName, uScore ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateSpectatorPortU( IntPtr thisptr, UInt16 unSpectatorPort );
		public void UpdateSpectatorPort( UInt16 unSpectatorPort ) 
		{
			this.GetFunction<NativeUpdateSpectatorPortU>( this.Functions.UpdateSpectatorPort14 )( this.ObjectAddress, unSpectatorPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameTypeS( IntPtr thisptr, string pchGameType );
		public void SetGameType( string pchGameType ) 
		{
			this.GetFunction<NativeSetGameTypeS>( this.Functions.SetGameType15 )( this.ObjectAddress, pchGameType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementStatusCS( IntPtr thisptr, UInt64 steamID, string pchAchievementName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserAchievementStatus( CSteamID steamID, string pchAchievementName ) 
		{
			return this.GetFunction<NativeGetUserAchievementStatusCS>( this.Functions.GetUserAchievementStatus16 )( this.ObjectAddress, steamID.ConvertToUint64(), pchAchievementName ); 
		}
		
	};
}
