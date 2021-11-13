using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MajiroStringEditor {
    class MajiroStringEditor {
        static void Main(string[] args) {
            if (args.Length == 0)
                printHelp();

            else if (args[0].ToLower() == "--extract") {
                if (args.Length < 3)
                    error("Expected 2 arguments, " + (args.Length - 1) + " provided");
                else
                    extract(args[1], args[2]);
            }

            else if (args[0].ToLower() == "--inject") {
                if (args.Length < 4)
                    error("Expected 3 arguments, " + (args.Length - 1) + " provided");
                else
                    inject(args[1], args[2], args[3]);
            }

            else
                error("Unknown command " + args[0]);
        }

        private static void error(string error) {
            Console.Error.WriteLine(error);
            printHelp();
        }

        private static void printHelp() {
            Console.WriteLine("Usage:");
            Console.WriteLine(" --extract [input MJO file] [output txt file]");
            Console.WriteLine(" --inject [input MJO file] [input txt file] [output MJO file]");
        }

        private static void extract(string inputMjoFile, string outputTxtFile) {
            byte[] input = File.ReadAllBytes(inputMjoFile);
            string[] lines = new Parser(input).Import();
            File.WriteAllLines(outputTxtFile, lines);
        }

        private static void inject(string inputMjoFile, string inputTxtFile, string outputMjoFile) {
            byte[] inputBytes = File.ReadAllBytes(inputMjoFile);
            string[] linesToInject = File.ReadAllLines(inputTxtFile);

            Parser parser = new Parser(inputBytes);
            parser.Import();
            byte[] outputBytes = parser.Export(linesToInject, true);

            File.WriteAllBytes(outputMjoFile, outputBytes);
        }
    }
}
