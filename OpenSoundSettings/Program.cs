using System.Diagnostics;

namespace OpenSoundSettings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecuteFile(@"control.exe mmsys.cpl,,1");
        }

        public static void ExecuteFile(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo(@"cmd.exe", "/c" + command);
            Process process;

            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);

            process.Close();
        }
    }
}
