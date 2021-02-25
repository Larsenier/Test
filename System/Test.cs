using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursovaiaKovrizhin
{
    public class Test
    {
        public List<string> ReadTestTextFromFile(string line)
        {
            List<string> localTest = new List<string>();
            using (StreamReader testFile = new StreamReader(string.Format("{0}.txt", line)))
            {
                string text;
                while ((text = testFile.ReadLine()) != null)
                {
                    string[] lines = text.Split('/');
                    for (int i = 0; i < lines.GetUpperBound(0); i++)
                    {
                        localTest.Add(lines[i]);
                    }
                }
                testFile.Close();
            }
            return localTest;
        }
        public string PickTest(string line)
        {
            string localField = "";
            List<string> neededTest = ReadTestTextFromFile(line);
            for (int i = 0; i < neededTest.Count; i++)
            {
                localField += string.Format(neededTest[i] + "\n");
            }
            return localField;
        }
    }
}
