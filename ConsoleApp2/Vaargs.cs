using System.Runtime.InteropServices;

namespace ConsoleApp2;

internal class Vaargs
{
    //internal static class NativeMethods
    //{
    //    // C# doesn't support varargs so all arguments must be explicitly defined.
    //    // CallingConvention.Cdecl must be used since the stack is
    //    // cleaned up by the caller.
    //    // int printf(const char *format [, argument]...)
    //    [DllImport("msvcrt.dll", CharSet = CharSet.Ansi,
    //        CallingConvention = CallingConvention.Cdecl)]
    //    internal static extern int printf(string format, int i, double d);

    //    [DllImport("msvcrt.dll", CharSet = CharSet.Ansi,
    //        CallingConvention = CallingConvention.Cdecl)]
    //    internal static extern int printf(string format, int i, string s);
    //}

    //public class App
    //{
    //    public static void Main()
    //    {
    //        NativeMethods.printf("\nPrint params: %i %f", 99, 99.99);
    //        NativeMethods.printf("\nPrint params: %i %s", 99, "abcd");
    //    }
    //}
}