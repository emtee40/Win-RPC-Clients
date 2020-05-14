//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\sensorservice.dll
// Interface ID: 97be9507-17da-4999-87d7-66c0b2d83cc7
// Interface Version: 1.0



namespace rpc_97be9507_17da_4999_87d7_66c0b2d83cc7_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
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
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
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
            m.Write_1(Member0);
            m.WriteEnum16(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
            Member8 = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_1 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(Struct_1 Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("97be9507-17da-4999-87d7-66c0b2d83cc7", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RSensorBrokerServerOpen(string p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RSensorBrokerServerClose(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RSensorBrokerServerDoesSdoExist(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RSensorBrokerServerStart(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int RSensorBrokerServerStop(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int RSensorBrokerServerGetDeviceID(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int RSensorBrokerServerGetCurrentOrientation(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_0> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            return u.ReadInt32();
        }
        public int RSensorBrokerServerGetProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_2), false);
            return u.ReadInt32();
        }
        public int RSensorBrokerServerEnableInLowPowerMode(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
        public int RSensorBrokerServerDisableInLowPowerMode(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
    }
    #endregion
}
