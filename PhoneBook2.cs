using System;
using System.Collections.Generic;
using System.Net.Http.Metrics;
using System.Text;
using System.Xml.Linq;

namespace tasks
{
    internal class PhoneBook2
    {
        /// <summary>
        /// ///////////////Day5task
        /// </summary>


        public Dictionary<string, int> Entrirs { get; private set; }

        public int this[string name]
        {
            get
            {
                if (!Entrirs.ContainsKey(name))
                    throw new KeyNotFoundException("not found this num");
                return Entrirs[name];
            }
            set
            {
                Entrirs[name] = value;
            }
        }
        public string this [int num]
        {

            get
            {
                //object جديد نوعه KeyValuePair<string, int>

                var entry = Entrirs.FirstOrDefault(e => e.Value == num);
                if(entry.Key==null)
                    throw new KeyNotFoundException("not found this num");
                return entry.Key;

            }
            set
            {
                var Oldentry = Entrirs.FirstOrDefault(e => e.Value == num);
                if (Oldentry.Key != null)
                    Entrirs.Remove(Oldentry.Key);
                Entrirs[value] = num;
            }


        }

    }
}
