

using MpcDigitize.Wtv.FFprobe.Wrapper.Enums;
using System;
using System.Diagnostics;
using System.IO;


namespace MpcDigitize.Wtv.FFprobe.Wrapper
{
    public class MetadataReader
    {
        private string _programmPath;
        private ReaderArguments _arguments;

        public MetadataReader(string programmPath)
        {
            _programmPath = programmPath;
            _arguments = new ReaderArguments();
        }

        public string DoWork(string inputFile, OutputFormat outputFormat)
        {


            Process process = new Process();
            string readerOutput = "";


            process.StartInfo.Arguments = _arguments.GetValue(outputFormat.ToString()) + inputFile;
            process.StartInfo.FileName = _programmPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            

           process.Start();
    
            using (StreamReader reader = process.StandardOutput)
            {
        
                    readerOutput = reader.ReadToEnd();
             
            }


           process.WaitForExit();

           return readerOutput;

        }

    }



    }

