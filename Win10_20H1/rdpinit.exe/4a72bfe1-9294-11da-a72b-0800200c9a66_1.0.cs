//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\rdpinit.exe
// Interface ID: 4a72bfe1-9294-11da-a72b-0800200c9a66
// Interface Version: 1.0

namespace rpc_4a72bfe1_9294_11da_a72b_0800200c9a66_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, int Member8, int MemberC)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("4a72bfe1-9294-11da-a72b-0800200c9a66", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcAcquireContextHandle(string p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcReleaseContextHandle(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcRailShellExecute(string p0, string p1, string p2, int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(2, m);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcOnTaskbarPosition(Struct_0 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int RpcOnDisplayChange()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int RpcStartRailTray()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int RpcStopRailTray(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int RpcOnTrayNotifyEvent(int p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int RpcNotifyLogoffParameterChange(int p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
        public int RpcUpdateMaxIconSize(int p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int RpcRailActivateApplication(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int RpcUpdateAppBarRemotingSupport(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int RpcWindowCloakingTrackerAddWindow(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int RpcWindowCloakingTrackerRemoveWindow(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int RpcWindowCloakingTrackerReset()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(14, m);
            return u.ReadInt32();
        }
        public int RpcOnWindowCloakStateChanged(int p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
        public int RpcGetMarkerWindow(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(16, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcDestroyMarkerWindow()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(17, m);
            return u.ReadInt32();
        }
        public int RpcSetWindowSnapArrangement(int p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadInt32();
        }
        public int RpcAcquireRdpInitPID(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(19, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}
