using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        var psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            WorkingDirectory = @"C:\Users\Joey\Desktop\Imperial\UROP\Y3-UROP\AD9959-GUI\CLI-Test-Sketch",
            //Arguments = "/C arduino-cli core update-index"   // Update the core index
            //            + "&& arduino-cli compile --fqbn arduino:avr:uno "  // Compile the sketch
            //            + "&& arduino-cli upload -p COM6 --fqbn arduino:avr:uno", //Upload the sketch
            Arguments = "/C echo konichiwaa",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
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


