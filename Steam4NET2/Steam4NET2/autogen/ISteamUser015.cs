// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUser015VTable
	{
		public IntPtr GetHSteamUser0;
		public IntPtr BLoggedOn1;
		public IntPtr GetSteamID2;
		public IntPtr InitiateGameConnection3;
		public IntPtr TerminateGameConnection4;
		public IntPtr TrackAppUsageEvent5;
		public IntPtr GetUserDataFolder6;
		public IntPtr StartVoiceRecording7;
		public IntPtr StopVoiceRecording8;
		public IntPtr GetAvailableVoice9;
		public IntPtr GetVoice10;
		public IntPtr DecompressVoice11;
		public IntPtr GetVoiceOptimalSampleRate12;
		public IntPtr GetAuthSessionTicket13;
		public IntPtr BeginAuthSession14;
		public IntPtr EndAuthSession15;
		public IntPtr CancelAuthTicket16;
		public IntPtr UserHasLicenseForApp17;
		public IntPtr IsBehindNAT18;
		public IntPtr AdvertiseGame19;
		public IntPtr RequestEncryptedAppTicket20;
		public IntPtr GetEncryptedAppTicket21;
		private IntPtr DTorISteamUser01522;
	};
	
	[InteropHelp.InterfaceVersion("SteamUser015")]
	public class ISteamUser015 : InteropHelp.NativeWrapper<ISteamUser015VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetHSteamUser( IntPtr thisptr );
		public Int32 GetHSteamUser(  ) 
		{
			return this.GetFunction<NativeGetHSteamUser>( this.Functions.GetHSteamUser0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BLoggedOn(  ) 
		{
			return this.GetFunction<NativeBLoggedOn>( this.Functions.BLoggedOn1 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID GetSteamID(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetSteamID>( this.Functions.GetSteamID2 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeInitiateGameConnectionBICUUB( IntPtr thisptr, Byte[] pAuthBlob, Int32 cbMaxAuthBlob, UInt64 steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure );
		public Int32 InitiateGameConnection( Byte[] pAuthBlob, CSteamID steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer, bool bSecure ) 
		{
			return this.GetFunction<NativeInitiateGameConnectionBICUUB>( this.Functions.InitiateGameConnection3 )( this.ObjectAddress, pAuthBlob, (Int32) pAuthBlob.Length, steamIDGameServer.ConvertToUint64(), unIPServer, usPortServer, bSecure ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTerminateGameConnectionUU( IntPtr thisptr, UInt32 unIPServer, UInt16 usPortServer );
		public void TerminateGameConnection( UInt32 unIPServer, UInt16 usPortServer ) 
		{
			this.GetFunction<NativeTerminateGameConnectionUU>( this.Functions.TerminateGameConnection4 )( this.ObjectAddress, unIPServer, usPortServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTrackAppUsageEventCES( IntPtr thisptr, UInt64 gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo );
		public void TrackAppUsageEvent( CGameID gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo ) 
		{
			this.GetFunction<NativeTrackAppUsageEventCES>( this.Functions.TrackAppUsageEvent5 )( this.ObjectAddress, gameID.ConvertToUint64(), eAppUsageEvent, pchExtraInfo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserDataFolderSI( IntPtr thisptr, StringBuilder pchBuffer, Int32 cubBuffer );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserDataFolder( StringBuilder pchBuffer ) 
		{
			return this.GetFunction<NativeGetUserDataFolderSI>( this.Functions.GetUserDataFolder6 )( this.ObjectAddress, pchBuffer, (Int32) pchBuffer.Capacity ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeStartVoiceRecording( IntPtr thisptr );
		public void StartVoiceRecording(  ) 
		{
			this.GetFunction<NativeStartVoiceRecording>( this.Functions.StartVoiceRecording7 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeStopVoiceRecording( IntPtr thisptr );
		public void StopVoiceRecording(  ) 
		{
			this.GetFunction<NativeStopVoiceRecording>( this.Functions.StopVoiceRecording8 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EVoiceResult NativeGetAvailableVoiceUU( IntPtr thisptr, ref UInt32 pcbCompressed, ref UInt32 pcbUncompressed );
		public EVoiceResult GetAvailableVoice( ref UInt32 pcbCompressed, ref UInt32 pcbUncompressed ) 
		{
			return this.GetFunction<NativeGetAvailableVoiceUU>( this.Functions.GetAvailableVoice9 )( this.ObjectAddress, ref pcbCompressed, ref pcbUncompressed ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EVoiceResult NativeGetVoiceBBUUBBUU( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bWantCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten, [MarshalAs(UnmanagedType.I1)] bool bWantUncompressed, Byte[] pUncompressedDestBuffer, UInt32 cbUncompressedDestBufferSize, ref UInt32 nUncompressBytesWritten );
		public EVoiceResult GetVoice( bool bWantCompressed, Byte[] pDestBuffer, ref UInt32 nBytesWritten, bool bWantUncompressed, Byte[] pUncompressedDestBuffer, ref UInt32 nUncompressBytesWritten ) 
		{
			return this.GetFunction<NativeGetVoiceBBUUBBUU>( this.Functions.GetVoice10 )( this.ObjectAddress, bWantCompressed, pDestBuffer, (UInt32) pDestBuffer.Length, ref nBytesWritten, bWantUncompressed, pUncompressedDestBuffer, (UInt32) pUncompressedDestBuffer.Length, ref nUncompressBytesWritten ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EVoiceResult NativeDecompressVoiceBUBUUU( IntPtr thisptr, Byte[] pCompressed, UInt32 cbCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten, UInt32 nSamplesPerSec );
		public EVoiceResult DecompressVoice( Byte[] pCompressed, Byte[] pDestBuffer, ref UInt32 nBytesWritten, UInt32 nSamplesPerSec ) 
		{
			return this.GetFunction<NativeDecompressVoiceBUBUUU>( this.Functions.DecompressVoice11 )( this.ObjectAddress, pCompressed, (UInt32) pCompressed.Length, pDestBuffer, (UInt32) pDestBuffer.Length, ref nBytesWritten, nSamplesPerSec ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetVoiceOptimalSampleRate( IntPtr thisptr );
		public UInt32 GetVoiceOptimalSampleRate(  ) 
		{
			return this.GetFunction<NativeGetVoiceOptimalSampleRate>( this.Functions.GetVoiceOptimalSampleRate12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAuthSessionTicketBIU( IntPtr thisptr, Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket );
		public UInt32 GetAuthSessionTicket( Byte[] pTicket, ref UInt32 pcbTicket ) 
		{
			return this.GetFunction<NativeGetAuthSessionTicketBIU>( this.Functions.GetAuthSessionTicket13 )( this.ObjectAddress, pTicket, (Int32) pTicket.Length, ref pcbTicket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EBeginAuthSessionResult NativeBeginAuthSessionBIC( IntPtr thisptr, Byte[] pAuthTicket, Int32 cbAuthTicket, UInt64 steamID );
		public EBeginAuthSessionResult BeginAuthSession( Byte[] pAuthTicket, CSteamID steamID ) 
		{
			return this.GetFunction<NativeBeginAuthSessionBIC>( this.Functions.BeginAuthSession14 )( this.ObjectAddress, pAuthTicket, (Int32) pAuthTicket.Length, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeEndAuthSessionC( IntPtr thisptr, UInt64 steamID );
		public void EndAuthSession( CSteamID steamID ) 
		{
			this.GetFunction<NativeEndAuthSessionC>( this.Functions.EndAuthSession15 )( this.ObjectAddress, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelAuthTicketU( IntPtr thisptr, UInt32 hAuthTicket );
		public void CancelAuthTicket( UInt32 hAuthTicket ) 
		{
			this.GetFunction<NativeCancelAuthTicketU>( this.Functions.CancelAuthTicket16 )( this.ObjectAddress, hAuthTicket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUserHasLicenseForAppResult NativeUserHasLicenseForAppCU( IntPtr thisptr, UInt64 steamID, UInt32 appID );
		public EUserHasLicenseForAppResult UserHasLicenseForApp( CSteamID steamID, UInt32 appID ) 
		{
			return this.GetFunction<NativeUserHasLicenseForAppCU>( this.Functions.UserHasLicenseForApp17 )( this.ObjectAddress, steamID.ConvertToUint64(), appID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsBehindNAT( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsBehindNAT(  ) 
		{
			return this.GetFunction<NativeIsBehindNAT>( this.Functions.IsBehindNAT18 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAdvertiseGameCUU( IntPtr thisptr, UInt64 steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool AdvertiseGame( CSteamID steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer ) 
		{
			return this.GetFunction<NativeAdvertiseGameCUU>( this.Functions.AdvertiseGame19 )( this.ObjectAddress, steamIDGameServer.ConvertToUint64(), unIPServer, usPortServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestEncryptedAppTicketBI( IntPtr thisptr, ref UInt64 retarg, Byte[] pUserData, Int32 cbUserData );
		public UInt64 RequestEncryptedAppTicket( Byte[] pUserData ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeRequestEncryptedAppTicketBI>( this.Functions.RequestEncryptedAppTicket20 )( this.ObjectAddress, ref ret, pUserData, (Int32) pUserData.Length ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetEncryptedAppTicketBIU( IntPtr thisptr, Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetEncryptedAppTicket( Byte[] pTicket, ref UInt32 pcbTicket ) 
		{
			return this.GetFunction<NativeGetEncryptedAppTicketBIU>( this.Functions.GetEncryptedAppTicket21 )( this.ObjectAddress, pTicket, (Int32) pTicket.Length, ref pcbTicket ); 
		}
		
	};
}
