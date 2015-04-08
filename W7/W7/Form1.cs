using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace W7
{
    public partial class Form1 : Form
    {
        private List<Player> playerList;
        public Form1()
        {
            InitializeComponent();
            playerList = new List<Player>();
            CsVConverter();
           

        }

        public void CsVConverter()
        {
            
            using (StreamReader r = new StreamReader(@"C:\Users\Guus\Source\Repos\SE2\W7\W7\cust.csv"))
                
            {
                string file_contents = " ";
                while (!r.EndOfStream)
                {
                    file_contents = r.ReadLine();
                    int indexofcomma = file_contents.IndexOf(',', 0);
                    

                    string playername = file_contents.Substring(0, indexofcomma);
                    int oldindex = indexofcomma;

                    indexofcomma = file_contents.IndexOf(',', indexofcomma + 1);

                    int dollar = Convert.ToInt32(file_contents.Substring(oldindex + 1, indexofcomma - oldindex - 4));
                    oldindex  = indexofcomma;

                    indexofcomma = file_contents.Length;
                    int euro = Convert.ToInt32(file_contents.Substring(oldindex + 1, indexofcomma - oldindex - 4));

                    Player player = new Player(playername, dollar, euro);
                    
                    playerList.Add(player);

                }
                BinaryFormatter fmt;    // interpreteer als binair object

                using (FileStream g = new FileStream("file.bin", FileMode.Create, FileAccess.ReadWrite))
                {

                }
                foreach (Player player in playerList)
                {
                    using (FileStream f = new FileStream("file.bin", FileMode.Open, FileAccess.ReadWrite))
                    {
                        
                        fmt = new BinaryFormatter();
                        fmt.Serialize(f, player);             // schrijf naar file 
                    }
                }
               

                
            }

            


        }

    }

}
