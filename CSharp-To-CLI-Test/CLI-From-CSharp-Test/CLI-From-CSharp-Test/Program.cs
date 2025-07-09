using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        var psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/C echo guten tag",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = false
        };

        using (Process proc = new Process { StartInfo = psi })
        {
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            string error = proc.StandardError.ReadToEnd();
            proc.WaitForExit();

            Console.WriteLine("Output: \n" + output);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine("Error: \n" + error);
            }
        }
    }

}


