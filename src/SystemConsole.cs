using System;
using System.IO;
using System.Text;

namespace Console.Abstractions
{
    /// <summary>
    /// A wrapper for <see cref="System.Console"/> which implements <see cref="IConsole"/>.
    /// </summary>
    public class SystemConsole : IConsole
    {
        /// <summary>
        /// Singleton instance of <see cref="SystemConsole"/>
        /// </summary>
        public static readonly SystemConsole Instance = new();

        private SystemConsole()
        {
        }

        /// <inheritdoc cref="IConsole.In" />
        public TextReader In => System.Console.In;

        /// <inheritdoc cref="IConsole.InputEncoding" />
        public Encoding InputEncoding => System.Console.InputEncoding;

        /// <inheritdoc cref="IConsole.OutputEncoding" />
        public Encoding OutputEncoding => System.Console.OutputEncoding;

        /// <inheritdoc cref="IConsole.KeyAvailable" />
        public bool KeyAvailable => System.Console.KeyAvailable;

        /// <inheritdoc cref="IConsole.ReadKey()" />
        public ConsoleKeyInfo ReadKey() => System.Console.ReadKey();

        /// <inheritdoc cref="IConsole.ReadKey(bool)" />
        public ConsoleKeyInfo ReadKey(bool intercept) => System.Console.ReadKey(intercept);

        /// <inheritdoc cref="IConsole.Out" />
        public TextWriter Out => System.Console.Out;

        /// <inheritdoc cref="IConsole.Error" />
        public TextWriter Error => System.Console.Error;

        /// <inheritdoc cref="IConsole.IsInputRedirected" />
        public bool IsInputRedirected => System.Console.IsInputRedirected;

        /// <inheritdoc cref="IConsole.IsOutputRedirected" />
        public bool IsOutputRedirected => System.Console.IsOutputRedirected;

        /// <inheritdoc cref="IConsole.IsErrorRedirected" />
        public bool IsErrorRedirected => System.Console.IsErrorRedirected;

        /// <inheritdoc cref="IConsole.CursorSize" />
        public int CursorSize
        {
            get => System.Console.CursorSize;
            set => System.Console.CursorSize = value;
        }

        /// <inheritdoc cref="IConsole.NumberLock" />
        public bool NumberLock => System.Console.NumberLock;

        /// <inheritdoc cref="IConsole.CapsLock" />
        public bool CapsLock => System.Console.CapsLock;

        /// <inheritdoc cref="IConsole.BackgroundColor" />
        public ConsoleColor BackgroundColor
        {
            get => System.Console.BackgroundColor;
            set => System.Console.BackgroundColor = value;
        }

        /// <inheritdoc cref="IConsole.ForegroundColor" />
        public ConsoleColor ForegroundColor
        {
            get => System.Console.ForegroundColor;
            set => System.Console.ForegroundColor = value;
        }

        /// <inheritdoc cref="IConsole.ResetColor()" />
        public void ResetColor() => System.Console.ResetColor();

        /// <inheritdoc cref="IConsole.BufferWidth" />
        public int BufferWidth
        {
            get => System.Console.BufferWidth;
            set => System.Console.BufferWidth = value;
        }

        /// <inheritdoc cref="IConsole.BufferHeight" />
        public int BufferHeight
        {
            get => System.Console.BufferHeight;
            set => System.Console.BufferHeight = value;
        }

        /// <inheritdoc cref="IConsole.SetBufferSize(int, int)" />
        public void SetBufferSize(int width, int height) => System.Console.SetBufferSize(width, height);

        /// <inheritdoc cref="IConsole.WindowLeft" />
        public int WindowLeft
        {
            get => System.Console.WindowLeft;
            set => System.Console.WindowLeft = value;
        }

        /// <inheritdoc cref="IConsole.WindowTop" />
        public int WindowTop
        {
            get => System.Console.WindowTop;
            set => System.Console.WindowTop = value;
        }

        /// <inheritdoc cref="IConsole.WindowWidth" />
        public int WindowWidth
        {
            get => System.Console.WindowWidth;
            set => System.Console.WindowWidth = value;
        }

        /// <inheritdoc cref="IConsole.WindowHeight" />
        public int WindowHeight
        {
            get => System.Console.WindowHeight;
            set => System.Console.WindowHeight = value;
        }

        /// <inheritdoc cref="IConsole.SetWindowPosition(int, int)" />
        public void SetWindowPosition(int left, int top) => System.Console.SetWindowPosition(left, top);

        /// <inheritdoc cref="IConsole.SetWindowSize(int, int)" />
        public void SetWindowSize(int width, int height) => System.Console.SetWindowSize(width, height);

        /// <inheritdoc cref="IConsole.LargestWindowWidth" />
        public int LargestWindowWidth => System.Console.LargestWindowWidth;

        /// <inheritdoc cref="IConsole.LargestWindowHeight" />
        public int LargestWindowHeight => System.Console.LargestWindowHeight;

        /// <inheritdoc cref="IConsole.CursorVisible" />
        public bool CursorVisible
        {
            get => System.Console.CursorVisible;
            set => System.Console.CursorVisible = value;
        }

        /// <inheritdoc cref="IConsole.CursorLeft" />
        public int CursorLeft
        {
            get => System.Console.CursorLeft;
            set => System.Console.CursorLeft = value;
        }

        /// <inheritdoc cref="IConsole.CursorTop" />
        public int CursorTop
        {
            get => System.Console.CursorTop;
            set => System.Console.CursorTop = value;
        }

        /// <inheritdoc cref="IConsole.Title" />
        public string Title
        {
            get => System.Console.Title;
            set => System.Console.Title = value;
        }

        /// <inheritdoc cref="IConsole.Beep()" />
        public void Beep() => System.Console.Beep();

        /// <inheritdoc cref="IConsole.Beep(int, int)" />
        public void Beep(int frequency, int duration) => System.Console.Beep(frequency, duration);

        /// <inheritdoc cref="IConsole.MoveBufferArea(int, int, int, int, int, int)" />
        public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
            => System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);

        /// <inheritdoc cref="IConsole.MoveBufferArea(int, int, int, int, int, int, char, ConsoleColor, ConsoleColor)" />
        public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
            => System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);

        /// <inheritdoc cref="IConsole.Clear()" />
        public void Clear() => System.Console.Clear();

        /// <inheritdoc cref="IConsole.SetCursorPosition(int, int)" />
        public void SetCursorPosition(int left, int top) => System.Console.SetCursorPosition(left, top);

        /// <inheritdoc cref="IConsole.CancelKeyPress" />
        public event ConsoleCancelEventHandler CancelKeyPress
        {
            add => System.Console.CancelKeyPress += value;
            remove => System.Console.CancelKeyPress -= value;
        }

        /// <inheritdoc cref="IConsole.TreatControlCAsInput" />
        public bool TreatControlCAsInput
        {
            get => System.Console.TreatControlCAsInput;
            set => System.Console.TreatControlCAsInput = value;
        }

        /// <inheritdoc cref="IConsole.OpenStandardInput()" />
        public Stream OpenStandardInput() => System.Console.OpenStandardInput();

        /// <inheritdoc cref="IConsole.OpenStandardInput(int)" />
        public Stream OpenStandardInput(int bufferSize) => System.Console.OpenStandardInput(bufferSize);

        /// <inheritdoc cref="IConsole.OpenStandardOutput()" />
        public Stream OpenStandardOutput() => System.Console.OpenStandardOutput();

        /// <inheritdoc cref="IConsole.OpenStandardOutput(int)" />
        public Stream OpenStandardOutput(int bufferSize) => System.Console.OpenStandardOutput(bufferSize);

        /// <inheritdoc cref="IConsole.OpenStandardError()" />
        public Stream OpenStandardError() => System.Console.OpenStandardError();

        /// <inheritdoc cref="IConsole.OpenStandardError(int)" />
        public Stream OpenStandardError(int bufferSize) => System.Console.OpenStandardError(bufferSize);

        /// <inheritdoc cref="IConsole.SetIn(TextReader)" />
        public void SetIn(TextReader newIn) => System.Console.SetIn(newIn);

        /// <inheritdoc cref="IConsole.SetOut(TextWriter)" />
        public void SetOut(TextWriter newOut) => System.Console.SetOut(newOut);

        /// <inheritdoc cref="IConsole.SetError(TextWriter)" />
        public void SetError(TextWriter newError) => System.Console.SetError(newError);

        /// <inheritdoc cref="IConsole.Read()" />
        public int Read() => System.Console.Read();

        /// <inheritdoc cref="IConsole.ReadLine()" />
        public string ReadLine() => System.Console.ReadLine();

        /// <inheritdoc cref="IConsole.WriteLine()" />
        public void WriteLine() => System.Console.WriteLine();

        /// <inheritdoc cref="IConsole.WriteLine(bool)" />
        public void WriteLine(bool value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(char)" />
        public void WriteLine(char value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(char[])" />
        public void WriteLine(char[] buffer) => System.Console.WriteLine(buffer);

        /// <inheritdoc cref="IConsole.WriteLine(char[], int, int)" />
        public void WriteLine(char[] buffer, int index, int count) => System.Console.WriteLine(buffer, index, count);

        /// <inheritdoc cref="IConsole.WriteLine(decimal)" />
        public void WriteLine(decimal value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(double)" />
        public void WriteLine(double value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(float)" />
        public void WriteLine(float value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(int)" />
        public void WriteLine(int value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(uint)" />
        public void WriteLine(uint value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(long)" />
        public void WriteLine(long value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(ulong)" />
        public void WriteLine(ulong value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(object)" />
        public void WriteLine(object value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(string)" />
        public void WriteLine(string value) => System.Console.WriteLine(value);

        /// <inheritdoc cref="IConsole.WriteLine(string, object)" />
        public void WriteLine(string format, object arg0) => System.Console.WriteLine(format, arg0);

        /// <inheritdoc cref="IConsole.WriteLine(string, object, object)" />
        public void WriteLine(string format, object arg0, object arg1) => System.Console.WriteLine(format, arg0, arg1);

        /// <inheritdoc cref="IConsole.WriteLine(string, object, object, object)" />
        public void WriteLine(string format, object arg0, object arg1, object arg2) => System.Console.WriteLine(format, arg0, arg1, arg2);

        /// <inheritdoc cref="IConsole.Write(string, object[])" />
        public void WriteLine(string format, params object[] arg) => System.Console.WriteLine(format, arg);

        /// <inheritdoc cref="IConsole.Write(string, object)" />
        public void Write(string format, object arg0) => System.Console.Write(format, arg0);

        /// <inheritdoc cref="IConsole.Write(string, object, object)" />
        public void Write(string format, object arg0, object arg1) => System.Console.Write(format, arg0, arg1);

        /// <inheritdoc cref="IConsole.Write(string, object, object, object)" />
        public void Write(string format, object arg0, object arg1, object arg2) => System.Console.Write(format, arg0, arg1, arg2);

        /// <inheritdoc cref="IConsole.Write(string, object[])" />
        public void Write(string format, params object[] arg) => System.Console.Write(format, arg);

        /// <inheritdoc cref="IConsole.Write(bool)" />
        public void Write(bool value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(char)" />
        public void Write(char value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.WriteLine(string)" />
        public void Write(char[] buffer) => System.Console.Write(buffer);

        /// <inheritdoc cref="IConsole.Write(char[], int, int)" />
        public void Write(char[] buffer, int index, int count) => System.Console.Write(buffer, index, count);
        
        /// <inheritdoc cref="IConsole.Write(double)" />
        public void Write(double value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(decimal)" />
        public void Write(decimal value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(float)" />
        public void Write(float value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(int)" />
        public void Write(int value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(uint)" />
        public void Write(uint value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(long)" />
        public void Write(long value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(ulong)" />
        public void Write(ulong value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(object)" />
        public void Write(object value) => System.Console.Write(value);

        /// <inheritdoc cref="IConsole.Write(string)" />
        public void Write(string value) => System.Console.Write(value);
    }
}