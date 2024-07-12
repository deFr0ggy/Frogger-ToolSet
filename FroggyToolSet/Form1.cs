using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace FroggyToolSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void barclearbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {

                MessageBox.Show("Everything Clean", "Cleaning Stuff", MessageBoxButtons.OK);


            } else
            {

                DialogResult result = MessageBox.Show("Are you sure?", "Cleaning Stuff", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    richTextBox1.Clear();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exitting The Program", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            } else
            {
                System.Diagnostics.Process.Start("https://www.shodan.io/search?query=" + HttpUtility.UrlEncode(richTextBox1.Text));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PostmanSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {

                System.Diagnostics.Process.Start("https://www.postman.com/search?q=" + HttpUtility.UrlEncode(richTextBox1.Text));
            }
        }

        private void SwaggerSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start("https://app.swaggerhub.com/search?query=" + HttpUtility.UrlEncode(richTextBox1.Text) + "&sort=BEST_MATCH&order=DESC");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start("https://s3digger.com/#gsc.tab=0&gsc.q=" + HttpUtility.UrlEncode(richTextBox1.Text) + "&gsc.sort=");
            }
        }

        private void MamontFTPSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.mmnt.ru/int/get?st=" + HttpUtility.UrlEncode(richTextBox1.Text));
            }
        }

        private void YaDigger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start("https://yadigger.com/#gsc.tab=0&gsc.q=" + HttpUtility.UrlEncode(richTextBox1.Text) + "&gsc.sort=");
            }
        }

        private void ShortDigger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start("https://shortdigger.com/#gsc.tab=0&gsc.q=" + HttpUtility.UrlEncode(richTextBox1.Text) + "&gsc.sort=date");
            }
        }
        private void DropBoxDigger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start("https://drodigger.com/#gsc.tab=0&gsc.q=" + HttpUtility.UrlEncode(richTextBox1.Text) + "&gsc.sort=");
            }
        }

        private void FTPIndexer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("No IP/URL Provided", "Error", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.searchftps.net/");
            }
        
        }
    }
    }
