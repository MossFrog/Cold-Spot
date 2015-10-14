using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ColdSpot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c netsh wlan show hostednetwork";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            StreamReader outputWriter = p.StandardOutput;
            richTextBox1.Text += outputWriter.ReadToEnd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c netsh wlan show hostednetwork";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            StreamReader outputWriter = p.StandardOutput;
            richTextBox1.Text += outputWriter.ReadToEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start Network Button //

            if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("Password Must be at least 5 Characters");
            }

            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a network Name");
            }

            else
            {
                richTextBox2.Clear();
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/c netsh wlan set hostednetwork mode=allow ssid=" + textBox1.Text + " key=" + textBox2.Text + " ";
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                p.Start();

                StreamReader outputWriter = p.StandardOutput;
                richTextBox2.Text += outputWriter.ReadToEnd();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stop Network Button //
            richTextBox2.Clear();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c netsh wlan stop hostednetwork";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            StreamReader outputWriter = p.StandardOutput;
            richTextBox2.Text += outputWriter.ReadToEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Stop Network Button //
            richTextBox2.Clear();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c netsh wlan start hostednetwork";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            StreamReader outputWriter = p.StandardOutput;
            richTextBox2.Text += outputWriter.ReadToEnd();
        }
    }
}
