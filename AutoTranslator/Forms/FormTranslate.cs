using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;
using System.Net;
using System.Runtime.InteropServices;
using System.CodeDom;
using Newtonsoft.Json.Linq;
using AutoTranslator.Forms;

namespace AutoTranslator
{
    public partial class FormTranslate : Form
    {

        public FormTranslate()
        {

            InitializeComponent();

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;

    // private  LowLevelKeyboardProc _proc;

        private static IntPtr hhook = IntPtr.Zero;

        private IntPtr _ClipboardViewerNext;
        private const int WM_DRAWCLIPBOARD = 0x0308;

        private void StartClipboardViewer()
        {
            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
        }

        private void StopClipboardViewer()
        {
            ChangeClipboardChain(this.Handle, _ClipboardViewerNext);
        }
        static bool clipboardstate = false;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                clipboardstate = true;
                SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
            }
            else
            {
                base.WndProc(ref m);
                clipboardstate = false;
            }
        }



        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
        }

        public  void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }
        static bool checkZ = false;
        static bool checkX = false;

        public IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {   
                int vkCode = Marshal.ReadInt32(lParam);
           
               if(vkCode.ToString() == "90" && checkX && clipboardstate)
                {
                    checkZ = false;
                    checkX = false;
                    clipboardstate = false;
               
                    String s = Clipboard.GetText();
                    String[] split = s.Split('\n');
                    String tmp = "";
                    for(int i = 0; i< split.Length; i++)
                    {
                        tmp +=  (PapagoTranslate(split[i])+"\n");
                    }
                    showDialog(tmp, Color.Aqua);
                    MessageBox.Show(tmp);
                  //  labelSentence.Text = tmp.ToString();
                  //  Clipboard.Clear();

                }
                else if (vkCode.ToString() == "88" && checkZ && clipboardstate)
                {
                    checkZ = false;
                    checkX = false;
                    clipboardstate = false;
                    String s = Clipboard.GetText();
                    String[] split = s.Split('\n');
                    String tmp = "";
                    for (int i = 0; i < split.Length; i++)
                    {
                        tmp += (PapagoTranslate(split[i]) + "\n");
                    }
                    //  labelSentence.Text = tmp.ToString();
                    showDialog(tmp, Color.White);
                    MessageBox.Show(tmp);
                   // Clipboard.Clear();
                }
                else if (vkCode.ToString() == "90")
                {
                    checkZ = true;

                }
                else if (vkCode.ToString() == "88")
                {
                    checkX = true;
                }
                else
                {
                    checkZ = false;
                    checkX = false;

                }
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }
       
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UnHook();
            StopClipboardViewer();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetHook();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartClipboardViewer();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private String PapagoTranslate(String query)
        {
            string url = "https://openapi.naver.com/v1/papago/n2mt";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "XdgqIdvyLe_uchiPxLLu");
            request.Headers.Add("X-Naver-Client-Secret", "6NoRI1jT_4");
            request.Method = "POST";

            byte[] byteDataParams = Encoding.UTF8.GetBytes("source=en&target=ko&text=" + query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
           
            stream.Close();
            response.Close();
            reader.Close();
          
            JObject jObject = JObject.Parse(text);
            String result = jObject["message"]["result"]["translatedText"].ToString();

            return result;
;
        }
        private void showDialog(String message, Color bgColor)
        {
            ResultDialog dialog = new ResultDialog(message, bgColor);
            dialog.Show();
        }
    }

    

}



