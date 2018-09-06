using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BinaryToStringConverter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            if(isbin(textBox1.Text)) {
                label3.Text = BinaryToString(textBox1.Text);
            } else {
                label3.Text = "Not Binary";
            }

        }

        private static bool isbin(string s) {
            foreach (var c in s)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }

        private static string BinaryToString(string data) {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8) {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

    }
}
