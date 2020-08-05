using Domain;
using System;

namespace CLI
{
    class FileInputOutput : IInputOutput
    {
        public string path = @"C:\IO.txt";
        public void Write(string text)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.WriteLine(text);

        }
        public string Read()
        {
            using (StreamReader sr = new StreamReader(path, true))
                return sr.ReadLine();
        }

    }
}
