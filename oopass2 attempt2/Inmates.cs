using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopass2_attempt2
{
    internal class Inmates :HumansAtThePrison
    {
        private string Region;
        private int NumOfCrimes;
        private string SentenceDate;

        public Inmates(string name, int age, string region, int NumOfCrimes,string SentenceDate) : base(name, age)
        {
            this.SentenceDate = SentenceDate;
            this.Region = region;
            this.NumOfCrimes = NumOfCrimes;
        }
        public string getRegion()
        {
            return this.Region; 
        }
        public string getSentenceDate()
        {
            return this.SentenceDate;
        }
        public int getNumCrimes()
        {
            return this.NumOfCrimes;
        }
    }
}
