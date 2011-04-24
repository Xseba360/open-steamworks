// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUserItems001VTable
	{
		public IntPtr LoadItems0;
		public IntPtr GetItemCount1;
		public IntPtr GetItemIterative2;
		public IntPtr GetItemByID3;
		public IntPtr GetItemAttribute4;
		public IntPtr UpdateInventoryPos5;
		public IntPtr DropItem6;
		private IntPtr DTorISteamUserItems0017;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUSERITEMS_INTERFACE_VERSION001")]
	public class ISteamUserItems001 : InteropHelp.NativeWrapper<ISteamUserItems001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeLoadItems( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 LoadItems(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeLoadItems>( this.Functions.LoadItems0 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetItemCount( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 GetItemCount(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetItemCount>( this.Functions.GetItemCount1 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetItemIterativeUUUUEUUU( IntPtr thisptr, UInt32 index, ref UInt64 UniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetItemIterative( UInt32 index, ref UInt64 UniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute ) 
		{
			return this.GetFunction<NativeGetItemIterativeUUUUEUUU>( this.Functions.GetItemIterative2 )( this.ObjectAddress, index, ref UniqueID, ref ItemType, ref ItemLevel, ref Quality, ref Flags, ref Quantity, ref NbOfAttribute ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetItemByIDUUUEUUU( IntPtr thisptr, UInt64 uniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetItemByID( UInt64 uniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute ) 
		{
			return this.GetFunction<NativeGetItemByIDUUUEUUU>( this.Functions.GetItemByID3 )( this.ObjectAddress, uniqueID, ref ItemType, ref ItemLevel, ref Quality, ref Flags, ref Quantity, ref NbOfAttribute ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetItemAttributeUUUF( IntPtr thisptr, UInt64 uniqueID, UInt32 index, ref UInt32 attribId, ref float value );
		public void GetItemAttribute( UInt64 uniqueID, UInt32 index, ref UInt32 attribId, ref float value ) 
		{
			this.GetFunction<NativeGetItemAttributeUUUF>( this.Functions.GetItemAttribute4 )( this.ObjectAddress, uniqueID, index, ref attribId, ref value ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateInventoryPosUU( IntPtr thisptr, UInt64 uniqueID, UInt32 pos );
		public void UpdateInventoryPos( UInt64 uniqueID, UInt32 pos ) 
		{
			this.GetFunction<NativeUpdateInventoryPosUU>( this.Functions.UpdateInventoryPos5 )( this.ObjectAddress, uniqueID, pos ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeDropItemU( IntPtr thisptr, UInt64 itemId );
		public void DropItem( UInt64 itemId ) 
		{
			this.GetFunction<NativeDropItemU>( this.Functions.DropItem6 )( this.ObjectAddress, itemId ); 
		}
		
	};
}
