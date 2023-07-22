using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace tibia_info
{
    public class address
    {
        public IntPtr health = new IntPtr(0x063FE94);
        public IntPtr mana = new IntPtr(0x063FE78);
        public IntPtr level = new IntPtr(0x063FE88);

        public byte[] health_value = new byte[2];
        public byte[] mana_value = new byte[2];
        public byte[] level_value = new byte[4];

        public address() { }
        public bool Read(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead)
        {
            if (!dllImport.ReadProcessMemory(hProcess, lpBaseAddress, lpBuffer, dwSize, out lpNumberOfBytesRead))
            {
                return false;
            }

            return true;
        }
    }
}
