using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{

    [Serializable]
    public class Party
    {
        public string Name { get; set; }
        public int VotesPerUnit { get; set; }
       

        public Party()
        {
            
            
        }
        public Party(string name, int votesPerUnit)
        {
            Name = name;
            VotesPerUnit = votesPerUnit;
          
        }

      

        public override string ToString()
        {
            return String.Format("{0} {1}",Name, VotesPerUnit);
        }
    }


}
