using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace W7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CsVConverter();

        }

        public void CsVConverter()
        {

            FileStream file;        // koppeling met bestand
            StreamReader reader;    // interpreteer als tekst
            try
            {
                file = new FileStream("file.txt", FileMode.Open,
                                                  FileAccess.Read);
                reader = new StreamReader(file);
                string line = reader.ReadLine();

                reader.Close();
                file.Close();
            }
            catch (IOException) { }

            reader.Read()

        }
    }

}
