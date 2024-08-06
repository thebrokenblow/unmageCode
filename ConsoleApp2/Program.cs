using ConsoleApp2;
using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);
MessageBox(IntPtr.Zero, new Class1("Серёжа").ToString(), "My Message", 0);
