using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursovaiaKovrizhin
{
    public class TestCreator:Manager
    {
        public void CreateTrueAnswerFile(string line, List<string> answer)
        {
            using (StreamWriter testsFile = new StreamWriter(string.Format("Ответы{0}.txt", line)))
            {
                string text = "";
                for (int i = 0; i < answer.Count; i++)
                {
                    text += answer[i];
                }
                testsFile.WriteLine(text);
            }
        }
        public void OverwriteTrueAnswerFile(string line, List<string> answer)
        {
            using (StreamWriter clientFile = new StreamWriter(string.Format("Ответы{0}.txt", line)))
            {
                string text = "";
                for (int i = 0; i < answer.Count; i++)
                {
                    text += answer[i];
                }
                clientFile.WriteLine(text);
            }

        }
        public void OverwriteTest(string line, List<string> field)
        {
            using (StreamWriter rewriteFile = new StreamWriter(string.Format("{0}.txt", line)))
            {
                string text = "";
                for (int i = 0; i < field.Count; i++)
                {
                    text += field[i];
                }
                rewriteFile.WriteLine(text);
            }
        }
        public void CreateTest(List<string> field, string line)
        {
            using (StreamWriter testFile = new StreamWriter(string.Format("{0}.txt", line)))
            {
                string text = "";
                for (int i = 0; i < field.Count; i++)
                {
                    text += field[i];
                }
                testFile.WriteLine(text);
            }

        }
        public void CreateTestList(string line)
        {
            using (StreamWriter testsFile = new StreamWriter("Tests.txt", true))
            {
                testsFile.WriteLine(line);
            }

        }
    }
}
