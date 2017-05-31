// Decompiled with JetBrains decompiler
// Type: Wolf.NativeMethods
// Assembly: WOLF, Version=0.4.5.2, Culture=neutral, PublicKeyToken=null
// MVID: ABFEDC93-69E6-4FC7-894A-27A810AAB3FE
// Assembly location: C:\Users\airyimbin\Downloads\WOLFx64 v 0.3583\WOLFx64.exe

using System;
using System.Runtime.InteropServices;

namespace Hypo
{
    internal class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint EnumSystemFirmwareTables(uint FirmwareTableProviderSignature, IntPtr pFirmwareTableBuffer, uint BufferSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetSystemFirmwareTable(uint FirmwareTableProviderSignature, uint FirmwareTableID, IntPtr pFirmwareTableBuffer, uint BufferSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool Wow64RevertWow64FsRedirection(ref IntPtr ptr);
    }
}
