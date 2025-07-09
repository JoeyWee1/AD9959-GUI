using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CSharp_To_Generated_Arduino
{   
internal class Program
    {
        static string WorkingDirectory = @"C:\Users\Joey\Desktop\Imperial\UROP\Y3-UROP\AD9959-GUI\CSharp-Generated-Sketch";

        static void WriteCommandToCLI(string commands)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = WorkingDirectory,
                Arguments = commands,
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
                Console.WriteLine($"Command executed: {commands}");
                Console.WriteLine("Output: \n" + output);
                if (!string.IsNullOrEmpty(error))
                {
                    Console.WriteLine("Error: \n" + error);
                }
            }
        }

        static void Main(string[] args)
        {
            // Begin by creating a new Arduino sketch
            WriteCommandToCLI("arduino-cli config init"
                              + "&& arduino-cli sketch new Generated-Working-Sketch" // This is the sketch we will manipulate
            );

            // Now we must manipulate the sketch at @"./Generated-Working-Sketch/Generated-Working-Sketch.ino"
            string sketchPath = @"C:\Users\Joey\Desktop\Imperial\UROP\Y3-UROP\AD9959-GUI\CSharp-Generated-Sketch\Generated-Working-Sketch\Generated-Working-Sketch.ino";
            string writeToSketch = """
            /*
              Blink.ino
              Demonstrates basic pin toggling
            */
            void setup() {
              pinMode(13, OUTPUT);
            }

            void loop() {
              digitalWrite(13, HIGH);
              delay(100);
              digitalWrite(13, LOW);
              delay(100);
            }
            """; // Write everything to this string to write later

            // Writes the writeToSketch string to the sketch

            File.WriteAllText(sketchPath, writeToSketch, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

        }
    }
}
