using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursovaiaKovrizhin
{
    public class TestStorage:Manager
    {       
        public string[] GetTestsList()
        {
            string[] allLines = File.ReadAllLines("Tests.txt", Encoding.UTF8);
            return allLines;
        }

    }
}
