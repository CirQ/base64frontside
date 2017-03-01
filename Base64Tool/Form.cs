using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Base64Tool {
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();
        }

        private void enBtn_Click(object sender, EventArgs e) {
            if(!plain.Text.Equals("")) {
                byte[] bs = Encoding.UTF8.GetBytes(plain.Text);
                IntPtr ip = encode(bs);
                cipher.Text = Marshal.PtrToStringAnsi(ip);
            }
        }

        private void deBtn_Click(object sender, EventArgs e) {
            if(!cipher.Text.Equals("")) {
                if(valid_cipher(cipher.Text)) {
                    byte[] bs = Encoding.Default.GetBytes(cipher.Text);
                    IntPtr src = decode(bs);
                    int length = bs.Length*3/4 - Regex.Matches(cipher.Text, "=").Count;
                    byte[] dst = new byte[length];
                    Marshal.Copy(src, dst, 0, length);
                    plain.Text = Encoding.UTF8.GetString(dst);
                }
                else
                    MessageBox.Show("Invalid base64 cipher format.");
            }
        }

        private bool valid_cipher(string c) {
            return (c.Length % 4 == 0)  //Equivalent: Regex.IsMatch(c, "(.{4})+")
                && Regex.IsMatch(c, "[A-Za-z0-9+/]*={0,2}$");
        }

        [DllImport(@"base64.dll", EntryPoint="encode", CallingConvention=CallingConvention.Cdecl)]
        private static extern IntPtr encode(byte[] p);
        [DllImport(@"base64.dll", EntryPoint="decode", CallingConvention=CallingConvention.Cdecl)]
        private static extern IntPtr decode(byte[] c);
    }
}