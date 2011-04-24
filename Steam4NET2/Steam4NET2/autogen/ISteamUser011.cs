// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUser011VTable
	{
		public IntPtr GetHSteamUser0;
		public IntPtr LoggedOn1;
		public IntPtr GetSteamID2;
		public IntPtr InitiateGameConnection3;
		public IntPtr TerminateGameConnection4;
		public IntPtr TrackAppUsageEvent5;
		public IntPtr GetUserDataFolder6;
		public IntPtr StartVoiceRecording7;
		public IntPtr StopVoiceRecording8;
		public IntPtr GetCompressedVoice9;
		public IntPtr DecompressVoice10;
		private IntPtr DTorISteamUser01111;
	};
	
	[InteropHelp.InterfaceVersion("SteamUser011")]
	public class ISteamUser011 : InteropHelp.NativeWrapper<ISteamUser011VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetHSteamUser( IntPtr thisptr );
		public Int32 GetHSteamUser(  ) 
		{
			return this.GetFunction<NativeGetHSteamUser>( this.Functions.GetHSteamUser0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLoggedOn( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool LoggedOn(  ) 
		{
			return this.GetFunction<NativeLoggedOn>( this.Functions.LoggedOn1 )( this.ObjectAddress ); 
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
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EVoiceResult NativeGetCompressedVoiceBUU( IntPtr thisptr, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten );
		public EVoiceResult GetCompressedVoice( Byte[] pDestBuffer, ref UInt32 nBytesWritten ) 
		{
			return this.GetFunction<NativeGetCompressedVoiceBUU>( this.Functions.GetCompressedVoice9 )( this.ObjectAddress, pDestBuffer, (UInt32) pDestBuffer.Length, ref nBytesWritten ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EVoiceResult NativeDecompressVoiceBUBUU( IntPtr thisptr, Byte[] pCompressed, UInt32 cbCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten );
		public EVoiceResult DecompressVoice( Byte[] pCompressed, Byte[] pDestBuffer, ref UInt32 nBytesWritten ) 
		{
			return this.GetFunction<NativeDecompressVoiceBUBUU>( this.Functions.DecompressVoice10 )( this.ObjectAddress, pCompressed, (UInt32) pCompressed.Length, pDestBuffer, (UInt32) pDestBuffer.Length, ref nBytesWritten ); 
		}
		
	};
}
