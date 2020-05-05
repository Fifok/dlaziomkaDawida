using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obwody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            double E, R1, R2, R3, R4, R5, R6;
            
            double.TryParse(tbE.Text, out E);
            double.TryParse(tbR1.Text, out R1);
            double.TryParse(tbR2.Text, out R2);
            double.TryParse(tbR3.Text, out R3);
            double.TryParse(tbR4.Text, out R4);
            double.TryParse(tbR5.Text, out R5);
            double.TryParse(tbR6.Text, out R6);

            double I = E / (R1 + R2 + R3 + R4 + R5 + R6);

            tbV1.Text = LiczNapiecie(I, R1).ToString();
            tbV2.Text = LiczNapiecie(I, R2).ToString();
            tbV3.Text = LiczNapiecie(I, R3).ToString();
            tbV4.Text = LiczNapiecie(I, R4).ToString();
            tbV5.Text = LiczNapiecie(I, R5).ToString();
            tbV6.Text = LiczNapiecie(I, R6).ToString();
        }

        private double LiczNapiecie(double I, double R)
        {
            return I * R;
        }
    }
}
