using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciFormu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listBox1.Items.Add("");
            listBox1.Items.Add("  Öğrenci Bilgi Sistemi");
            listBox1.Items.Add("");
            listBox1.Items.Add("  Versiyon 1.0.1");
            listBox1.Items.Add("");
            listBox1.Items.Add("  Copyright © 2022 Etem Şahin");
            listBox1.Items.Add("");
            listBox1.Items.Add("  Eskişehir Osmangazi Üniversitesi");

            listBox2.Items.Add("Uyarı: Bu bilgisayar programı,");
            listBox2.Items.Add("telif hakkı yasası ve uluslararası");
            listBox2.Items.Add("anlaşmalarla korunmaktadır.");
            listBox2.Items.Add("Bu programın veya herhangi ");
            listBox2.Items.Add("bir kısmının izinsiz çoğaltılması");
            listBox2.Items.Add("veya dağıtılması, ciddi hukuki ve");
            listBox2.Items.Add("cezai cezalara neden olabilir ve");
            listBox2.Items.Add("kanunen mümkün olan en geniş");
            listBox2.Items.Add("kapsamda kovuşturmaya ");
            listBox2.Items.Add("tabi tutulacaktır.");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
