/*
 * Created by Anton Tkach. 
 * First build 9/22/2016. 
 * Second build 2/10/2016.
 * This library contains methods to provide access 
 * to Console library for later use.
 */
using System;

namespace MyConsoleLibrary
{
    public class MyConsole
    {
        public static MyConsoleColor BackgroundColor { get; set; }
        public static MyConsoleColor ForegroundColor { get; set; }

        //public static void Temp()
        //{
        //    Console
        //}  // this line is a draft for all Console. methods

        public static void Beep()
        {
            Console.Beep();
        }
        public static void Beep(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void Read()
        {
            Console.Read();
        }
        public static void ReadKey()
        {
            Console.ReadKey();
        }
        public static void ReadKey(bool intercept)
        {
            Console.ReadKey(intercept);
        }
        public static void ReadLine()
        {
            Console.ReadLine();
        }
        public static void ResetColor()
        {
            Console.ResetColor();
        }
        public static void SetBufferSize(int width, int height)
        {
            Console.SetBufferSize(width, height);
        }
        public static void SetCursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }
        public static void SetWindowPosition(int left, int top)
        {
            Console.SetWindowPosition(left, top);
        }
        public static void SetWindowSize(int width, int height)
        {
            Console.SetWindowSize(width, height);
        }

        // Write section
        public static void Write(bool value)
        {
            Console.WriteLine(value);
        }
        public static void Write(char value)
        {
            Console.WriteLine(value);
        }
        public static void Write(char[] buffer)
        {
            Console.WriteLine(buffer);
        }
        public static void Write(decimal value)
        {
            Console.WriteLine(value);
        }
        public static void Write(double value)
        {
            Console.WriteLine(value);
        }
        public static void Write(float value)
        {
            Console.WriteLine(value);
        }
        public static void Write(int value)
        {
            Console.WriteLine(value);
        }
        public static void Write(long value)
        {
            Console.WriteLine(value);
        }
        public static void Write(object value)
        {
            Console.WriteLine(value);
        }
        public static void Write(string value)
        {
            Console.WriteLine(value);
        }
        public static void Write(uint value)
        {
            Console.WriteLine(value);
        }
        public static void Write(ulong value)
        {
            Console.WriteLine(value);
        }
        public static void Write(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }
        public static void Write(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }
        public static void Write(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }
        public static void Write(string format, object arg0, object arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }
        public static void Write(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }
        public static void Write(string format, object arg0, object arg1, object arg2, object arg3)
        {
            Console.WriteLine(format, arg0, arg1, arg2, arg3);
        }

        // WriteLine section
        public static void WriteLine()
        {
            Console.WriteLine();
        }
        public static void WriteLine(bool value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(char value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(char[] buffer)
        {
            Console.WriteLine(buffer);
        }
        public static void WriteLine(decimal value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(double value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(float value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(int value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(long value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(uint value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(ulong value)
        {
            Console.WriteLine(value);
        }
        public static void WriteLine(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }
        public static void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }
        public static void WriteLine(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }
        public static void WriteLine(string format, object arg0, object arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }
        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }
        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
        {
            Console.WriteLine(format, arg0, arg1, arg2, arg3);
        }

        //static public string GetInputString(string text)
        //{
        //    Console.Write(text);
        //    return Console.ReadLine();
        //}


        public enum MyConsoleColor
        {
            Black,
            Blue,
            Cyan,
            DarkBlue,
            DarkCyan,
            DarkGrey,
            DarkGreen,
            DarkMagenta,
            DarkRed,
            DarkYellow,
            Grey,
            Green,
            Magenta,
            Red,
            White,
            Yellow

        }
        static public void Test()
        {
            MyConsole.ForegroundColor = MyConsoleColor.Cyan;
        }
    }
}
