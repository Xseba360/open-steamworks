// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUserStats004VTable
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
		public IntPtr StoreStats9;
		public IntPtr GetAchievementIcon10;
		public IntPtr GetAchievementDisplayAttribute11;
		public IntPtr IndicateAchievementProgress12;
		public IntPtr RequestUserStats13;
		public IntPtr GetUserStat14;
		public IntPtr GetUserStat15;
		public IntPtr GetUserAchievement16;
		public IntPtr ResetAllStats17;
		private IntPtr DTorISteamUserStats00418;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUSERSTATS_INTERFACE_VERSION004")]
	public class ISteamUserStats004 : InteropHelp.NativeWrapper<ISteamUserStats004VTable>
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
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateAvgRateStatSFD( IntPtr thisptr, string pchName, float arg1, double dSessionLength );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool UpdateAvgRateStat( string pchName, float arg1, double dSessionLength ) 
		{
			return this.GetFunction<NativeUpdateAvgRateStatSFD>( this.Functions.UpdateAvgRateStat5 )( this.ObjectAddress, pchName, arg1, dSessionLength ); 
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
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStoreStats( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool StoreStats(  ) 
		{
			return this.GetFunction<NativeStoreStats>( this.Functions.StoreStats9 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAchievementIconS( IntPtr thisptr, string pchName );
		public Int32 GetAchievementIcon( string pchName ) 
		{
			return this.GetFunction<NativeGetAchievementIconS>( this.Functions.GetAchievementIcon10 )( this.ObjectAddress, pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetAchievementDisplayAttributeSS( IntPtr thisptr, string pchName, string pchKey );
		public string GetAchievementDisplayAttribute( string pchName, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetAchievementDisplayAttributeSS>( this.Functions.GetAchievementDisplayAttribute11 )( this.ObjectAddress, pchName, pchKey ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIndicateAchievementProgressSUU( IntPtr thisptr, string pchName, UInt32 nCurProgress, UInt32 nMaxProgress );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IndicateAchievementProgress( string pchName, UInt32 nCurProgress, UInt32 nMaxProgress ) 
		{
			return this.GetFunction<NativeIndicateAchievementProgressSUU>( this.Functions.IndicateAchievementProgress12 )( this.ObjectAddress, pchName, nCurProgress, nMaxProgress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUserStatsC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDUser );
		public UInt64 RequestUserStats( CSteamID steamIDUser ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeRequestUserStatsC>( this.Functions.RequestUserStats13 )( this.ObjectAddress, ref ret, steamIDUser.ConvertToUint64() ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSI( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref Int32 pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSI>( this.Functions.GetUserStat14 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSF( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref float pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSF>( this.Functions.GetUserStat15 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementCSB( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref bool pbAchieved );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserAchievement( CSteamID steamIDUser, string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetUserAchievementCSB>( this.Functions.GetUserAchievement16 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pbAchieved ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeResetAllStatsB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bAchievementsToo );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool ResetAllStats( bool bAchievementsToo ) 
		{
			return this.GetFunction<NativeResetAllStatsB>( this.Functions.ResetAllStats17 )( this.ObjectAddress, bAchievementsToo ); 
		}
		
	};
}
