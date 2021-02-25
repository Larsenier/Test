using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursovaiaKovrizhin
{
    public class Human:Manager
    {
        List<string> redactorList = ReadListOfPeople();
        static List<string> ReadListOfPeople()
        {
            List<string> nameLibrary = new List<string>();
            using (StreamReader file = new StreamReader("Redactors.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] lines = line.Split('/');
                    for (int i = 0; i < lines.GetUpperBound(0); i++)
                    {
                        nameLibrary.Add(lines[i]);
                    }
                }
                return nameLibrary;
            }
        }
        public void Choosing(string line) 
        {
            RedactorForm redactorMenu = new RedactorForm();
            ClientForm clientMenu = new ClientForm();
            for (int i = 0; i < redactorList.Count; i++)
            {

                if (line == string.Format(redactorList[i]))
                {
                    redactorMenu.Show();
                }

                else
                {
                    Registrate(line);
                    clientMenu.Show();
                }
            }
        }
        
    }

}
