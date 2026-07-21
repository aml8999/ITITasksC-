using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace tasks
{
    internal class PhoneBook
    {
        /// <summary>
        /// ///////////////Day5task
        /// </summary>

        private Dictionary<string, int> NameToNum = new Dictionary<string, int>();
        private Dictionary<int, string> NumToName = new Dictionary<int, string>();
      
        public string this[int numper]
        {
            get { if (!NumToName.ContainsKey(numper))
                    throw new KeyNotFoundException("numper not found");
                return NumToName[numper];
            }
            set { NumToName[numper] = value;
                NameToNum[value] = numper;
             }
        }

        public int this[string name ]
        {
            get
            {
                if (!NameToNum.ContainsKey(name))
                    throw new KeyNotFoundException("numper not found");
                return NameToNum[name];
            }
            set {
                NameToNum[name] = value;
                NumToName[value] =name;
            }
        }





    }
}
