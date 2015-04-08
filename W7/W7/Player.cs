using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7
{
    [Serializable]
    class Player
    {
        public string PlayerName;
        public double DollarBankRoll;
        public double EuroBankRoll;

        public Player(string playerName, double dollarBankRoll, double euroBankRoll)
        {
            this.PlayerName = playerName;
            this.DollarBankRoll = dollarBankRoll;
            this.EuroBankRoll = euroBankRoll;
        }
    }
}
