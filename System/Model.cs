using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaiaKovrizhin
{
    public class Model
    {
        TestStorage list = new TestStorage();
        Answer newAnswer = new Answer(0);
        Test localTest = new Test();


        public string[] BreakInToParts() 
        {
            string[] ourParts = list.parts;
            return ourParts;

        }

        public string[] GetTestsList()
        {
            string[] localList = list.GetTestsList();
            return localList;
        }
        public void CountPoints() 
        {
        
        }

       
            
    }
    
}
