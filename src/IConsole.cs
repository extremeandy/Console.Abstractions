using System;
using System.IO;
using System.Text;

namespace Console.Abstractions
{
    /// <summary>
    /// A wrapper interface for <see cref="System.Console"/> which allows for testing using the console.
    /// </summary>
    public interface IConsole
    {
        /// <inheritdoc cref="System.Console.In" />
        TextReader In { get; }

        /// <inheritdoc cref="System.Console.InputEncoding" />
        Encoding InputEncoding { get; }

        /// <inheritdoc cref="System.Console.OutputEncoding" />
        Encoding OutputEncoding { get; }

        /// <inheritdoc cref="System.Console.KeyAvailable" />
        bool KeyAvailable { get; }

        /// <inheritdoc cref="System.Console.ReadKey()" />
        ConsoleKeyInfo ReadKey();

        /// <inheritdoc cref="System.Console.ReadKey(bool)" />
        ConsoleKeyInfo ReadKey(bool intercept);

        /// <inheritdoc cref="System.Console.Out" />
        TextWriter Out { get; }

        /// <inheritdoc cref="System.Console.Error" />
        TextWriter Error { get; }

        /// <inheritdoc cref="System.Console.IsInputRedirected" />
        bool IsInputRedirected { get; }

        /// <inheritdoc cref="System.Console.IsOutputRedirected" />
        bool IsOutputRedirected { get; }

        /// <inheritdoc cref="System.Console.IsErrorRedirected" />
        bool IsErrorRedirected { get; }

        /// <inheritdoc cref="System.Console.CursorSize" />
        int CursorSize { get; set; }

        /// <inheritdoc cref="System.Console.NumberLock" />
        bool NumberLock { get; }

        /// <inheritdoc cref="System.Console.CapsLock" />
        bool CapsLock { get; }

        /// <inheritdoc cref="System.Console.BackgroundColor" />
        ConsoleColor BackgroundColor { get; set; }

        /// <inheritdoc cref="System.Console.ForegroundColor" />
        ConsoleColor ForegroundColor { get; set; }

        /// <inheritdoc cref="System.Console.ResetColor" />
        void ResetColor();

        /// <inheritdoc cref="System.Console.BufferWidth" />
        int BufferWidth { get; set; }

        /// <inheritdoc cref="System.Console.BufferHeight" />
        int BufferHeight { get; set; }

        /// <inheritdoc cref="System.Console.SetBufferSize" />
        void SetBufferSize(int width, int height);

        /// <inheritdoc cref="System.Console.WindowLeft" />
        int WindowLeft { get; set; }

        /// <inheritdoc cref="System.Console.WindowTop" />
        int WindowTop { get; set; }

        /// <inheritdoc cref="System.Console.WindowWidth" />
        int WindowWidth { get; set; }

        /// <inheritdoc cref="System.Console.WindowHeight" />
        int WindowHeight { get; set; }

        /// <inheritdoc cref="System.Console.SetWindowPosition" />
        void SetWindowPosition(int left, int top);

        /// <inheritdoc cref="System.Console.SetWindowSize" />
        void SetWindowSize(int width, int height);

        /// <inheritdoc cref="System.Console.LargestWindowWidth" />
        int LargestWindowWidth { get; }

        /// <inheritdoc cref="System.Console.LargestWindowHeight" />
        int LargestWindowHeight { get; }

        /// <inheritdoc cref="System.Console.CursorVisible" />
        bool CursorVisible { get; set; }

        /// <inheritdoc cref="System.Console.CursorLeft" />
        int CursorLeft { get; set; }

        /// <inheritdoc cref="System.Console.CursorTop" />
        int CursorTop { get; set; }

        /// <inheritdoc cref="System.Console.Title" />
        string Title { get; set; }

        /// <inheritdoc cref="System.Console.Beep()" />
        void Beep();

        /// <inheritdoc cref="System.Console.Beep(int, int)" />
        void Beep(int frequency, int duration);

        /// <inheritdoc cref="System.Console.MoveBufferArea(int, int, int, int, int, int)" />
        void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop);

        /// <inheritdoc cref="System.Console.MoveBufferArea(int, int, int, int, int, int, char, ConsoleColor, ConsoleColor)" />
        void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor);

        /// <inheritdoc cref="System.Console.Clear" />
        void Clear();

        /// <inheritdoc cref="System.Console.SetCursorPosition" />
        void SetCursorPosition(int left, int top);

        /// <inheritdoc cref="System.Console.CancelKeyPress" />
        event ConsoleCancelEventHandler CancelKeyPress;

        /// <inheritdoc cref="System.Console.TreatControlCAsInput" />
        bool TreatControlCAsInput { get; set; }

        /// <inheritdoc cref="System.Console.OpenStandardInput()" />
        Stream OpenStandardInput();

        /// <inheritdoc cref="System.Console.OpenStandardInput(int)" />
        Stream OpenStandardInput(int bufferSize);

        /// <inheritdoc cref="System.Console.OpenStandardOutput()" />
        Stream OpenStandardOutput();

        /// <inheritdoc cref="System.Console.OpenStandardOutput(int)" />
        Stream OpenStandardOutput(int bufferSize);

        /// <inheritdoc cref="System.Console.OpenStandardError()" />
        Stream OpenStandardError();

        /// <inheritdoc cref="System.Console.OpenStandardError(int)" />
        Stream OpenStandardError(int bufferSize);

        /// <inheritdoc cref="System.Console.SetIn" />
        void SetIn(TextReader newIn);

        /// <inheritdoc cref="System.Console.SetOut" />
        void SetOut(TextWriter newOut);

        /// <inheritdoc cref="System.Console.SetError" />
        void SetError(TextWriter newError);

        /// <inheritdoc cref="System.Console.Read" />
        int Read();

        /// <inheritdoc cref="System.Console.ReadLine()" />
        string ReadLine();

        /// <inheritdoc cref="System.Console.WriteLine()" />
        void WriteLine();

        /// <inheritdoc cref="System.Console.WriteLine(bool)" />
        void WriteLine(bool value);

        /// <inheritdoc cref="System.Console.WriteLine(char)" />
        void WriteLine(char value);

        /// <inheritdoc cref="System.Console.WriteLine(char[])" />
        void WriteLine(char[] buffer);

        /// <inheritdoc cref="System.Console.WriteLine(char[], int, int)" />
        void WriteLine(char[] buffer, int index, int count);

        /// <inheritdoc cref="System.Console.WriteLine(decimal)" />
        void WriteLine(decimal value);

        /// <inheritdoc cref="System.Console.WriteLine(double)" />
        void WriteLine(double value);

        /// <inheritdoc cref="System.Console.WriteLine(float)" />
        void WriteLine(float value);

        /// <inheritdoc cref="System.Console.WriteLine(int)" />
        void WriteLine(int value);

        /// <inheritdoc cref="System.Console.WriteLine(uint)" />
        void WriteLine(uint value);

        /// <inheritdoc cref="System.Console.WriteLine(long)" />
        void WriteLine(long value);

        /// <inheritdoc cref="System.Console.WriteLine(ulong)" />
        void WriteLine(ulong value);

        /// <inheritdoc cref="System.Console.WriteLine(object)" />
        void WriteLine(object value);

        /// <inheritdoc cref="System.Console.WriteLine(string)" />
        void WriteLine(string value);

        /// <inheritdoc cref="System.Console.WriteLine(string, object)" />
        void WriteLine(string format, object arg0);

        /// <inheritdoc cref="System.Console.WriteLine(string, object, object)" />
        void WriteLine(string format, object arg0, object arg1);

        /// <inheritdoc cref="System.Console.WriteLine(string, object, object, object)" />
        void WriteLine(string format, object arg0, object arg1, object arg2);

        /// <inheritdoc cref="System.Console.WriteLine(string, object[])" />
        void WriteLine(string format, params object[] arg);

        /// <inheritdoc cref="System.Console.Write(string, object)" />
        void Write(string format, object arg0);

        /// <inheritdoc cref="System.Console.Write(string, object, object)" />
        void Write(string format, object arg0, object arg1);

        /// <inheritdoc cref="System.Console.Write(string, object, object, object)" />
        void Write(string format, object arg0, object arg1, object arg2);

        /// <inheritdoc cref="System.Console.Write(string, object[])" />
        void Write(string format, params object[] arg);

        /// <inheritdoc cref="System.Console.Write(bool)" />
        void Write(bool value);

        /// <inheritdoc cref="System.Console.Write(char)" />
        void Write(char value);

        /// <inheritdoc cref="System.Console.Write(char[])" />
        void Write(char[] buffer);

        /// <inheritdoc cref="System.Console.Write(char[], int, int)" />
        void Write(char[] buffer, int index, int count);

        /// <inheritdoc cref="System.Console.Write(double)" />
        void Write(double value);

        /// <inheritdoc cref="System.Console.Write(decimal)" />
        void Write(decimal value);

        /// <inheritdoc cref="System.Console.Write(float)" />
        void Write(float value);

        /// <inheritdoc cref="System.Console.Write(int)" />
        void Write(int value);

        /// <inheritdoc cref="System.Console.Write(uint)" />
        void Write(uint value);

        /// <inheritdoc cref="System.Console.Write(long)" />
        void Write(long value);

        /// <inheritdoc cref="System.Console.Write(ulong)" />
        void Write(ulong value);

        /// <inheritdoc cref="System.Console.Write(object)" />
        void Write(object value);

        /// <inheritdoc cref="System.Console.Write(string)" />
        void Write(string value);

    }
}
