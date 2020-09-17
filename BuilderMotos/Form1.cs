using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuilderMotocicletas;

namespace BuilderMotos
{
    public partial class Form1 : Form
    {

        List<BuilderMotocicletas.BuilderMotos> modelos;
        public Form1()
        {
            InitializeComponent();
            modelos = new List<BuilderMotocicletas.BuilderMotos>();
            modelos.Add(new Scooter());
            modelos.Add(new Enduro());
            modelos.Add(new Pistera());

            comboBox1.DataSource = modelos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuilderMotocicletas.BuilderMotos builder = (BuilderMotocicletas.BuilderMotos)comboBox1.SelectedItem;
            Motocicleta moto = builder.buildMotocicleta();

            listBox1.Items.Add(moto);
        }
    }
}
