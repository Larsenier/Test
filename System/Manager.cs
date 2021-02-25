using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursovaiaKovrizhin
{
    public class Manager
    {
        string[] m_parts = new string[1];
        public string[] parts
        {
            get { return m_parts; }
            set { m_parts = value; }
        }

        public void Registrate(string line)
        {
            using (StreamWriter clientFile = new StreamWriter("Clients.txt", true))
            {
                clientFile.WriteLine("\n" + line + "_");
            }
        }

        public void SaveResult(string line, int clientPoints)
        {
            using (StreamWriter clientFile = new StreamWriter("Clients.txt", true))
            {
                clientFile.WriteLine(line + ":" + clientPoints + "%_");
            }
        }
    }
}
