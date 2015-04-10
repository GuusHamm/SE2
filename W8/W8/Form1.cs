using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8
{
    public partial class Form1 : Form
    {
        private MessageBuilder messageBuilder = new MessageBuilder("@", "#");
        public Form1()
        {
            InitializeComponent();
            messageBuilder.MessageComplete += message;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            messageBuilder.Append(textBox1.Text);
        }
        private void message(string message)
        {
            MessageBox.Show(message);
        }
    }
}
