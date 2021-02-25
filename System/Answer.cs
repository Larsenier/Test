using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KursovaiaKovrizhin
{
    public class Answer:Manager
    {
        public List<int> testAnswer = new List<int>();
        int m_points;
        public int points
        {
            get { return m_points; }
            set { m_points = value; }
        }

        public Answer(int p)
        {
            points = p;
        }

        List<string> resultsList = ReadResultsFromFile();
        static List<string> ReadResultsFromFile()
        {
            List<string> localResults = new List<string>();
            using (StreamReader resultsFile = new StreamReader("Clients.txt"))
            {
                string line;
                while ((line = resultsFile.ReadLine()) != null)
                {
                    string[] lines = line.Split('_');
                    for (int i = 0; i < lines.GetUpperBound(0); i++)
                    {
                        localResults.Add(lines[i]);
                    }
                }
                resultsFile.Close();
            }
            return localResults;
        }
        public string ShowResults()
        {
            string localField = "";
            for (int i = 0; i < resultsList.Count; i++)
            {
                localField += string.Format(resultsList[i] + "\n");
            }
            return localField;
        }

        public void CountPoints(string line, string line1, string line2, string line3, string line4, string line5)
        {
            testAnswer.Add(Convert.ToInt32(line1));
            testAnswer.Add(Convert.ToInt32(line2));
            testAnswer.Add(Convert.ToInt32(line3));
            testAnswer.Add(Convert.ToInt32(line4));
            testAnswer.Add(Convert.ToInt32(line5));
            List<int> answerText = ReadAnswerTextFromFile(line);
            for (int i = 0; i < answerText.Count; i++)
            {
                if (answerText[i] == testAnswer[i])
                {
                    points += 20;
                }
            }
            ShowPoints(line);
        }
        static List<int> ReadAnswerTextFromFile(string line)
        {
            List<int> localAnswer = new List<int>();
            using (StreamReader testFile = new StreamReader(string.Format("Ответы{0}.txt", line)))
            {
                string text;
                while ((text = testFile.ReadLine()) != null)
                {
                    string[] lines = text.Split('/');
                    for (int i = 0; i < lines.GetUpperBound(0); i++)
                    {
                        localAnswer.Add(Convert.ToInt32(lines[i]));
                    }
                }
                testFile.Close();
            }
            return localAnswer;
        }
        public void ShowPoints(string line)
        {
            MessageBox.Show("Ваш результат:\n" + points + "%");
            SaveResult(line, points);
            testAnswer.Clear();
            points = 0;
        }
        
    }
}
