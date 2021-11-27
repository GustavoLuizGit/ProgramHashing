using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_hashing_com_deslocamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MetodoHashing mh = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {

            mh = new MetodoHashing(txtChave.Text);
            mh.MetodoHash();
            switch (mh.testeretun())
            {
                case 0:
                    txtResto0.Text += mh.Mostra();
                    break;
                case 1:
                    txtResto1.Text += mh.Mostra();
                    break;
                case 2:
                    txtResto2.Text += mh.Mostra();
                    break;
                case 3:
                    txtResto3.Text += mh.Mostra();
                    break;
                case 4:
                    txtResto4.Text += mh.Mostra();
                    break;
                case 5:
                    txtResto5.Text += mh.Mostra();
                    break;
                case 6:
                    txtResto6.Text += mh.Mostra();
                    break;
            }
        }
    }
}
