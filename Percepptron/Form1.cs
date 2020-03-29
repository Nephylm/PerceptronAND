using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percepptron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inicio(); 
        }
        List<And> Lista = new List<And>();
        And and;
        double w1, w2,w3, u;
        int y, b=0;
        public void Inicio()
        {
            and = new And(-1, -1, -1, -1);
            Lista.Add(and);
            and = new And(-1, -1, 1, -1);
            Lista.Add(and);
            and = new And(-1, 1, -1, -1);
            Lista.Add(and);
            and = new And(-1, 1, 1, -1);
            Lista.Add(and);
            and = new And(1, -1, -1, -1);
            Lista.Add(and);
            and = new And(1, -1, 1, -1);
            Lista.Add(and);
            and = new And(1, 1, -1, -1);
            Lista.Add(and);
            and = new And(1, 1, 1, 1);
            Lista.Add(and);

        }
        private void tbW1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            w1 = double.Parse(tbW1.Text);
            w2 = double.Parse(tbW2.Text);
            w3 = double.Parse(tbW3.Text);
            u = double.Parse(tbU.Text);
            Ciclo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Ciclo()
        {
            do
            {
            
                foreach(And a in Lista)
                {
                    Calcular(a);
                }
            } while (b == Lista.Count);
            tbU.Text = u.ToString();
            tbW1.Text = w1.ToString();
            tbW2.Text = w2.ToString();
            tbW3.Text = w3.ToString();
            MessageBox.Show("Listo");
        }
        public void Calcular( And a)
        {
            y = (a.x1 * w1 + a.x2 * w2 + a.x3 * w3) + u > 0 ? 1 : -1;
            if (y != a.dx)
                Recalcular(a);
            else
                this.b++;
        }
        public void Recalcular(And a)
        {
            w1 = w1 + (a.dx * a.x1);
            w2 = w2 + (a.dx * a.x2);
            w2 = w2 + (a.dx * a.x2);
            u = u + a.dx;
            this.b = 0;
        }
    }
}
