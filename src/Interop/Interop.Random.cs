using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Libsodium
    {
        [DllImport(Libraries.Libsodium, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void randombytes_buf(
            byte[] buf,
            IntPtr size);

        [DllImport(Libraries.Libsodium, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void randombytes_buf(
            SecureMemoryHandle buf,
            IntPtr size);

        [DllImport(Libraries.Libsodium, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void randombytes_buf(
            ref byte buf,
            IntPtr size);
    }
}
