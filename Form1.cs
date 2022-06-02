using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            string accountSid = "AC2371e6fb4aea58d871c103461c67fbd4";
            string authToken = "a9f21e6d4a1a5072eeb41e21d4be5e2a";

            TwilioClient.Init(accountSid, authToken);
            string number = textBox1.Text;
            string message = textBox2.Text;
            if (String.IsNullOrEmpty(number) == true || String.IsNullOrEmpty(message) == true)
            {
                lblHelloWorld.Text = "Sorry entering a phone number and message is required please do so and try again!";
            }
            MessageResource.Create(
               to: new PhoneNumber($"{number}"),
               from: new PhoneNumber("+19378284910"),
               body: $"{message}");
            lblHelloWorld.Text = "Text has been sent!";
            System.Diagnostics.Debug.WriteLine($"{number}, {message}");
            textBox1.Clear();
            textBox2.Clear();
        }

   }
}

