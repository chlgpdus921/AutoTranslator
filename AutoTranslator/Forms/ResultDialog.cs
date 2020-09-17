using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoTranslator.Forms
{
    public partial class ResultDialog : Form
    {
        public ResultDialog(String message, Color bgColor)
        {
            InitializeComponent();
            Top = 20;
            Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2;
            BackColor = bgColor;
            lbMessage.Text = message;
            
            timerClose.Start();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);


        /*private void label1_Click(object sender, EventArgs e)
        {
            
            timerClose.Start();
        }*/

      

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void ResultDialog_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void lbMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
