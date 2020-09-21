using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace CompressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string inFilename = @"d:\ttt.txt";
            string outFilename = @"d:\ttt.txt.gz";
            string inFilename1 = @"d:\tttt.txt";
            FileStream sourceFile = File.OpenRead(outFilename);
            FileStream destFile = File.Create(inFilename1);
            GZipStream compStream =
            new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

            compStream.Close();


        }
    }
}
