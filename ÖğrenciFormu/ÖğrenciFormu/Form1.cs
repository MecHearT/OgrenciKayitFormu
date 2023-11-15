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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            string soyad;
            string il;
            string ilçe;
            string cinsiyet;
            string müzik;
            string kitap;
            string sinema;





            ad = textBox1.Text;
            soyad = textBox2.Text;
            il = comboBox1.Text;
            ilçe = listBox1.SelectedItem.ToString();
            cinsiyet = "Erkek";

            if (radioButton1.Checked == true)
                cinsiyet = "Erkek";

            else if (radioButton2.Checked == true)
                cinsiyet = "Kadın";


            if (checkBox1.Checked == true) 
                müzik = "EVET";
            else
                müzik = "HAYIR";


            if (checkBox2.Checked == true)
                kitap = "EVET";
            else
                kitap = "HAYIR";

            if (checkBox3.Checked == true)
                sinema = "EVET";
            else
                sinema = "HAYIR";


            string[] datas = { ad, soyad, il,   ilçe, cinsiyet, müzik, kitap, sinema};

            ListViewItem liste = new ListViewItem(datas);
            listView1.Items.Add(liste);
                

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ankara")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Beypazarı");
                listBox1.Items.Add("Çankaya");
                listBox1.Items.Add("Gölbaşı");
                listBox1.Items.Add("Mamak");
                listBox1.Items.Add("Merkez");
                listBox1.Items.Add("Polatlı");
                listBox1.Items.Add("Sincan");
            }
            if (comboBox1.Text == "Eskişehir")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Alpu");
                listBox1.Items.Add("Çifteler");
                listBox1.Items.Add("Merkez");
                listBox1.Items.Add("Odunpazarı");
                listBox1.Items.Add("Sarıcakaya");
                listBox1.Items.Add("Seyitgazi");
                listBox1.Items.Add("Sivrihisar");
            }
            if (comboBox1.Text == "İstanbul")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Bakırköy");
                listBox1.Items.Add("Beşiktaş");
                listBox1.Items.Add("Beylikdüzü");
                listBox1.Items.Add("Beyöğlu");
                listBox1.Items.Add("Eyüp");
                listBox1.Items.Add("Kadıköy");
                listBox1.Items.Add("Şişli");
                listBox1.Items.Add("Üsküdar");
                listBox1.Items.Add("Zeytinburnu");
                
            }
            if (comboBox1.Text == "İzmir")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Bornova");
                listBox1.Items.Add("Çeşme");
                listBox1.Items.Add("Dikili");
                listBox1.Items.Add("Foça");
                listBox1.Items.Add("Karşıyaka");
                listBox1.Items.Add("Konak");
                listBox1.Items.Add("Torbalı");
                listBox1.Items.Add("Urla");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

          
        }

        private void bilgileriTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Clear();


            if (comboBox2.Text == "Büyük İkon (Large Icon)")
            {
                listView1.Columns.Add("Adı", 120);
                listView1.Columns.Add("Soyadı", 120);
                listView1.Columns.Add("İli", 100);
                listView1.Columns.Add("İlçesi", 100);
                listView1.Columns.Add("Cinsiyet", 50);
                listView1.Columns.Add("Müzik", 50);
                listView1.Columns.Add("Kitap", 50);
                listView1.Columns.Add("Sinema", 50);

            }
            if (comboBox2.Text == "Detay (Detail)")
            {
                listView1.Columns.Add("Adı", 120);
                listView1.Columns.Add("Soyadı", 120);
                listView1.Columns.Add("İli", 100);
                listView1.Columns.Add("İlçesi", 100);
                listView1.Columns.Add("Cinsiyet", 50);
                listView1.Columns.Add("Müzik", 50);
                listView1.Columns.Add("Kitap", 50);
                listView1.Columns.Add("Sinema", 50);

            }
            if (comboBox2.Text == "Döşeme (Tile)")
            {
                listView1.Columns.Add("Adı", 120);
                listView1.Columns.Add("Soyadı", 120);
                listView1.Columns.Add("İli", 100);
                listView1.Columns.Add("İlçesi", 100);
                listView1.Columns.Add("Cinsiyet", 50);
                listView1.Columns.Add("Müzik", 50);
                listView1.Columns.Add("Kitap", 50);
                listView1.Columns.Add("Sinema", 50);

            }
            if (comboBox2.Text == "Küçük İkon (Small Icon)")
            {
                listView1.Columns.Add("Adı", 120);
                listView1.Columns.Add("Soyadı", 120);
                listView1.Columns.Add("İli", 100);
                listView1.Columns.Add("İlçesi", 100);
                listView1.Columns.Add("Cinsiyet", 50);
                listView1.Columns.Add("Müzik", 50);
                listView1.Columns.Add("Kitap", 50);
                listView1.Columns.Add("Sinema", 50);

            }
            if (comboBox2.Text == "Liste (List)")
            {
                listView1.Columns.Add("Adı", 120);
                listView1.Columns.Add("Soyadı", 120);
                listView1.Columns.Add("İli", 100);
                listView1.Columns.Add("İlçesi", 100);
                listView1.Columns.Add("Cinsiyet", 50);
                listView1.Columns.Add("Müzik", 50);
                listView1.Columns.Add("Kitap", 50);
                listView1.Columns.Add("Sinema", 50);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem = -1 ;
            listBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
