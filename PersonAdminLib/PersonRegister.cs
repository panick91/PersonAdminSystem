using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    class PersonRegister
    {
        private List<Person> personList = new List<Person>();
        private int Count
        {
            get
            {
                return personList.Count;
            }
        }

        public Person this[int index]
        {
            get
            {
                return personList[index];
            }
            set
            {
                personList[index] = value;
            }
        }

        public int ReadPersonsFromFile(string filename)
        {
            int personCounter = 0;

            using (StreamReader reader = new StreamReader(filename))
            {
                String line = reader.ReadLine();
                while (line != "")
                {
                    string[] input = line.Split('\t');
                    Person newPerson = new Person(input[0], input[1]);
                    personCounter++;
                    line = reader.ReadLine();
                }
            }

            return personCounter;
        }
    }
}
