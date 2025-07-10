using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


class Program
{
    static string WorkingDirectory = @"C:\Users\Joey\Desktop\Imperial\UROP\Y3-UROP\AD9959-GUI\CSharp-Generated-Sketch";

    static void WriteCommandToCLI(string commands)
    {
        var psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            WorkingDirectory = WorkingDirectory,
            Arguments = "/C " + commands,
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

    static void Main(string[] args)
    {
        // Begin by creating a new Arduino sketch
        WriteCommandToCLI("arduino-cli config init --overwrite"
                          + "&& arduino-cli sketch new Generated-Working-Sketch" // This is the sketch we will manipulate
        );

        // Now we must manipulate the sketch at @"./Generated-Working-Sketch/Generated-Working-Sketch.ino"
        string sketchPath = @"C:\Users\Joey\Desktop\Imperial\UROP\Y3-UROP\AD9959-GUI\CSharp-Generated-Sketch\Generated-Working-Sketch\Generated-Working-Sketch.ino";
        string writeToSketch = "/*\n  Blink.ino\n  Demonstrates basic pin toggling\n*/\nvoid setup() {\n  pinMode(13, OUTPUT);\n}\n\nvoid loop() {\n  digitalWrite(13, HIGH);\n  delay(100);\n  digitalWrite(13, LOW);\n  delay(100);\n}"; // Write everything to this string to write later

        // Writes the writeToSketch string to the sketch
        File.WriteAllText(sketchPath, writeToSketch, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

        //WriteCommandToCLI("echo holy shit does this still work?");

    }
}

