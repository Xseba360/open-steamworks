// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUserStats009VTable
	{
		public IntPtr RequestCurrentStats0;
		public IntPtr GetStat1;
		public IntPtr GetStat2;
		public IntPtr SetStat3;
		public IntPtr SetStat4;
		public IntPtr UpdateAvgRateStat5;
		public IntPtr GetAchievement6;
		public IntPtr SetAchievement7;
		public IntPtr ClearAchievement8;
		public IntPtr GetAchievementAndUnlockTime9;
		public IntPtr StoreStats10;
		public IntPtr GetAchievementIcon11;
		public IntPtr GetAchievementDisplayAttribute12;
		public IntPtr IndicateAchievementProgress13;
		public IntPtr RequestUserStats14;
		public IntPtr GetUserStat15;
		public IntPtr GetUserStat16;
		public IntPtr GetUserAchievement17;
		public IntPtr GetUserAchievementAndUnlockTime18;
		public IntPtr ResetAllStats19;
		public IntPtr FindOrCreateLeaderboard20;
		public IntPtr FindLeaderboard21;
		public IntPtr GetLeaderboardName22;
		public IntPtr GetLeaderboardEntryCount23;
		public IntPtr GetLeaderboardSortMethod24;
		public IntPtr GetLeaderboardDisplayType25;
		public IntPtr DownloadLeaderboardEntries26;
		public IntPtr DownloadLeaderboardEntriesForUsers27;
		public IntPtr GetDownloadedLeaderboardEntry28;
		public IntPtr UploadLeaderboardScore29;
		public IntPtr AttachLeaderboardUGC30;
		public IntPtr GetNumberOfCurrentPlayers31;
		private IntPtr DTorISteamUserStats00932;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUSERSTATS_INTERFACE_VERSION009")]
	public class ISteamUserStats009 : InteropHelp.NativeWrapper<ISteamUserStats009VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestCurrentStats( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RequestCurrentStats(  ) 
		{
			return this.GetFunction<NativeRequestCurrentStats>( this.Functions.RequestCurrentStats0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatSI( IntPtr thisptr, string pchName, ref Int32 pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetStat( string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetStatSI>( this.Functions.GetStat1 )( this.ObjectAddress, pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatSF( IntPtr thisptr, string pchName, ref float pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetStat( string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetStatSF>( this.Functions.GetStat2 )( this.ObjectAddress, pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatSI( IntPtr thisptr, string pchName, Int32 nData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetStat( string pchName, Int32 nData ) 
		{
			return this.GetFunction<NativeSetStatSI>( this.Functions.SetStat3 )( this.ObjectAddress, pchName, nData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatSF( IntPtr thisptr, string pchName, float fData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetStat( string pchName, float fData ) 
		{
			return this.GetFunction<NativeSetStatSF>( this.Functions.SetStat4 )( this.ObjectAddress, pchName, fData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateAvgRateStatSFD( IntPtr thisptr, string pchName, float flCountThisSession, double dSessionLength );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool UpdateAvgRateStat( string pchName, float flCountThisSession, double dSessionLength ) 
		{
			return this.GetFunction<NativeUpdateAvgRateStatSFD>( this.Functions.UpdateAvgRateStat5 )( this.ObjectAddress, pchName, flCountThisSession, dSessionLength ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementSB( IntPtr thisptr, string pchName, ref bool pbAchieved );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetAchievement( string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetAchievementSB>( this.Functions.GetAchievement6 )( this.ObjectAddress, pchName, ref pbAchieved ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAchievementS( IntPtr thisptr, string pchName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetAchievement( string pchName ) 
		{
			return this.GetFunction<NativeSetAchievementS>( this.Functions.SetAchievement7 )( this.ObjectAddress, pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearAchievementS( IntPtr thisptr, string pchName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool ClearAchievement( string pchName ) 
		{
			return this.GetFunction<NativeClearAchievementS>( this.Functions.ClearAchievement8 )( this.ObjectAddress, pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementAndUnlockTimeSBU( IntPtr thisptr, string pchName, ref bool pbAchieved, ref UInt32 prtTime );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetAchievementAndUnlockTime( string pchName, ref bool pbAchieved, ref UInt32 prtTime ) 
		{
			return this.GetFunction<NativeGetAchievementAndUnlockTimeSBU>( this.Functions.GetAchievementAndUnlockTime9 )( this.ObjectAddress, pchName, ref pbAchieved, ref prtTime ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStoreStats( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool StoreStats(  ) 
		{
			return this.GetFunction<NativeStoreStats>( this.Functions.StoreStats10 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAchievementIconS( IntPtr thisptr, string pchName );
		public Int32 GetAchievementIcon( string pchName ) 
		{
			return this.GetFunction<NativeGetAchievementIconS>( this.Functions.GetAchievementIcon11 )( this.ObjectAddress, pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetAchievementDisplayAttributeSS( IntPtr thisptr, string pchName, string pchKey );
		public string GetAchievementDisplayAttribute( string pchName, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetAchievementDisplayAttributeSS>( this.Functions.GetAchievementDisplayAttribute12 )( this.ObjectAddress, pchName, pchKey ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIndicateAchievementProgressSUU( IntPtr thisptr, string pchName, UInt32 nCurProgress, UInt32 nMaxProgress );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IndicateAchievementProgress( string pchName, UInt32 nCurProgress, UInt32 nMaxProgress ) 
		{
			return this.GetFunction<NativeIndicateAchievementProgressSUU>( this.Functions.IndicateAchievementProgress13 )( this.ObjectAddress, pchName, nCurProgress, nMaxProgress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUserStatsC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDUser );
		public UInt64 RequestUserStats( CSteamID steamIDUser ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeRequestUserStatsC>( this.Functions.RequestUserStats14 )( this.ObjectAddress, ref ret, steamIDUser.ConvertToUint64() ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSI( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref Int32 pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSI>( this.Functions.GetUserStat15 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSF( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref float pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSF>( this.Functions.GetUserStat16 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementCSB( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref bool pbAchieved );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserAchievement( CSteamID steamIDUser, string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetUserAchievementCSB>( this.Functions.GetUserAchievement17 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pbAchieved ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementAndUnlockTimeCSBU( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref bool pbAchieved, ref UInt32 prtTime );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserAchievementAndUnlockTime( CSteamID steamIDUser, string pchName, ref bool pbAchieved, ref UInt32 prtTime ) 
		{
			return this.GetFunction<NativeGetUserAchievementAndUnlockTimeCSBU>( this.Functions.GetUserAchievementAndUnlockTime18 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pbAchieved, ref prtTime ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeResetAllStatsB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bAchievementsToo );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool ResetAllStats( bool bAchievementsToo ) 
		{
			return this.GetFunction<NativeResetAllStatsB>( this.Functions.ResetAllStats19 )( this.ObjectAddress, bAchievementsToo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindOrCreateLeaderboardSEE( IntPtr thisptr, ref UInt64 retarg, string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType );
		public UInt64 FindOrCreateLeaderboard( string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeFindOrCreateLeaderboardSEE>( this.Functions.FindOrCreateLeaderboard20 )( this.ObjectAddress, ref ret, pchLeaderboardName, eLeaderboardSortMethod, eLeaderboardDisplayType ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindLeaderboardS( IntPtr thisptr, ref UInt64 retarg, string pchLeaderboardName );
		public UInt64 FindLeaderboard( string pchLeaderboardName ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeFindLeaderboardS>( this.Functions.FindLeaderboard21 )( this.ObjectAddress, ref ret, pchLeaderboardName ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLeaderboardNameU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public string GetLeaderboardName( UInt64 hSteamLeaderboard ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLeaderboardNameU>( this.Functions.GetLeaderboardName22 )( this.ObjectAddress, hSteamLeaderboard ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLeaderboardEntryCountU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public Int32 GetLeaderboardEntryCount( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardEntryCountU>( this.Functions.GetLeaderboardEntryCount23 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardSortMethod NativeGetLeaderboardSortMethodU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardSortMethod GetLeaderboardSortMethod( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardSortMethodU>( this.Functions.GetLeaderboardSortMethod24 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardDisplayType NativeGetLeaderboardDisplayTypeU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardDisplayType GetLeaderboardDisplayType( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardDisplayTypeU>( this.Functions.GetLeaderboardDisplayType25 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadLeaderboardEntriesUEII( IntPtr thisptr, ref UInt64 retarg, UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd );
		public UInt64 DownloadLeaderboardEntries( UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeDownloadLeaderboardEntriesUEII>( this.Functions.DownloadLeaderboardEntries26 )( this.ObjectAddress, ref ret, hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadLeaderboardEntriesForUsersUCI( IntPtr thisptr, ref UInt64 retarg, UInt64 hSteamLeaderboard, ref UInt64 arg1, Int32 arg2 );
		public UInt64 DownloadLeaderboardEntriesForUsers( UInt64 hSteamLeaderboard, ref CSteamID arg1, Int32 arg2 ) 
		{
			UInt64 s0 = 0; UInt64 ret = 0; this.GetFunction<NativeDownloadLeaderboardEntriesForUsersUCI>( this.Functions.DownloadLeaderboardEntriesForUsers27 )( this.ObjectAddress, ref ret, hSteamLeaderboard, ref s0, arg2 );  ret = new CSteamID(s0); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetDownloadedLeaderboardEntryUILII( IntPtr thisptr, UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry002_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetDownloadedLeaderboardEntry( UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry002_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax ) 
		{
			return this.GetFunction<NativeGetDownloadedLeaderboardEntryUILII>( this.Functions.GetDownloadedLeaderboardEntry28 )( this.ObjectAddress, hSteamLeaderboardEntries, index, ref pLeaderboardEntry, ref pDetails, cDetailsMax ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUploadLeaderboardScoreUEIII( IntPtr thisptr, ref UInt64 retarg, UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount );
		public UInt64 UploadLeaderboardScore( UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeUploadLeaderboardScoreUEIII>( this.Functions.UploadLeaderboardScore29 )( this.ObjectAddress, ref ret, hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, ref pScoreDetails, cScoreDetailsCount ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeAttachLeaderboardUGCUU( IntPtr thisptr, ref UInt64 retarg, UInt64 hSteamLeaderboard, UInt64 Unk1 );
		public UInt64 AttachLeaderboardUGC( UInt64 hSteamLeaderboard, UInt64 Unk1 ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeAttachLeaderboardUGCUU>( this.Functions.AttachLeaderboardUGC30 )( this.ObjectAddress, ref ret, hSteamLeaderboard, Unk1 ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetNumberOfCurrentPlayers( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 GetNumberOfCurrentPlayers(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetNumberOfCurrentPlayers>( this.Functions.GetNumberOfCurrentPlayers31 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
	};
}
