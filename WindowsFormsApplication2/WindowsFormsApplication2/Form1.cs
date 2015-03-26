using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int[] array = { 40, 2, 1, 43, 433, 65, 0, 11, 58, 1223, 42, 4,123,1444,123123,435,35,6,75,3,132,23,5,67,89,65,4,25,5,6546,45,62,46,723, };

        public Form1()
        {
            InitializeComponent();
            ListUpdater();
           }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            int tempvalue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[i] < array[j])
                    {
                        tempvalue = array[i];
                        array[i] = array[j];
                        array[j] = tempvalue;

                    }
                }
            }

            ListUpdater();
        }

        private void ListUpdater()
        {
            listBox1.Items.Clear();

            foreach (int i in array)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            int tempvalue = 0;

            for (int i = 0; i < array.Length; i++)
            {

                int j = i;

                while (j > 0)
                {
                    if (array[j-1] > array [j])
                    {
                        tempvalue = array[j-1];
                        array[j - 1] = array[j];
                        array[j] = tempvalue;
                        j--;

                    }
                    else
                    {
                        break;
                    }
                }
                ListUpdater();
                
            }

        }

    }
}
