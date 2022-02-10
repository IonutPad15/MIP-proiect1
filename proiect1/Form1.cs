using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
namespace Lab3
{
    public partial class Form1 : Form
    {
        //private string[] blocked = { "sport", "yahoo", "digi" };
        private List<string> lstBlock = new List<string>() { "sport", "yahoo", "facebook", "digi" };
        private SQLiteConnection conn = null;
        private BooleanSwitch sw;
        public Form1()
        {
            FileStream file = new FileStream("testLog.txt", FileMode.OpenOrCreate);
            TextWriterTraceListener traceListener = new TextWriterTraceListener(file);
            Trace.Listeners.Add(traceListener);
            Trace.AutoFlush = true;

            sw = new BooleanSwitch("Switch1", "Trace switch");

            InitializeComponent();

      
            this.conn = SQLiteHandler.ConnectToDb();
            Console.WriteLine("Connected to db");
            lstBlock = SQLiteHandler.GetAllKeywords(this.conn);
            cmbBox.Items.Clear();
            foreach (string s in lstBlock)
            {
                cmbBox.Items.Add(s);
                Console.WriteLine(s);
            }
            SQLiteHandler.DisconnectFromDb(this.conn);
            Console.WriteLine("Disconnected from db");
        }

        private void tsBtnGO_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(this.toolStripTextBox1.Text);
         
        }

        private void tsBtnHome_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://google.ro/");
            //webBrowser1.GoHome();
        }

        private void tsBtnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void tsBtnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                //this.webBrowser1.Navigate(this.toolStripTextBox1.Text);
                this.webBrowser1.Navigate(((ToolStripTextBox)sender).Text);
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string url = e.Url.ToString();
            this.toolStripTextBox1.Text = url;
            /*foreach(string s in lstBlock)
            {
                if (url.Contains(s))
                {
                    e.Cancel = true;
                    MessageBox.Show(null, "Am blocat pagina "+ url + " *** " + s, "Eroare");
                    break;
                }
            }*/
            /*bool found = false;
            found = lstBlock.Any(s => url.Contains(s));
            if (found)
            {
                e.Cancel = true;
                MessageBox.Show(null, "Am blocat pagina " + url + " *** ", "Eroare");
            }*/
            /*int count;
            count = (from s in lstBlock
                     where url.Contains(s)
                     select s).Count();
            if(count > 0)
            {
                e.Cancel = true;
                MessageBox.Show(null, "Am blocat pagina " + url + " *** ", "Eroare");
            }*/
            var res = Task.Run(() => CheckAsync(url));
            res.Wait();
            if(res.Result==true)
            {
                e.Cancel = true;
                MessageBox.Show(null, "Am blocat pagina " + url + " *** ", "Eroare");
                Task.Run(() => WriteTrace("pagina blocata"));
            }
        }
        private async Task<bool> CheckAsync(string url)
        {
            bool res = await Task.Run(
                async () =>
                { 
                    return (from s in lstBlock
                            where url.Contains(s)
                            select s).Count() > 0;
                }
                );
            return res;
        }
        private async Task WriteTrace(string text)
        {
            await Task.Run(
                async () =>
                {
                    Trace.WriteLineIf(sw.Enabled, DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss::fff tt") + "    "+text);
                }
                );
           
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.conn = SQLiteHandler.ConnectToDb();
            Console.WriteLine("Connected to db");
            Task.Run(() => WriteTrace("Connected to db"));
        }

        private void dissconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteHandler.DisconnectFromDb(this.conn);
            Console.WriteLine("Disconnected from db");
            Task.Run(() => WriteTrace("Disconnected from db"));

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            if (addform.ShowDialog() == DialogResult.OK)
            {

                this.conn = SQLiteHandler.ConnectToDb();
                Console.WriteLine("Connected to db");
                Task.Run(() => WriteTrace("Connected to db"));
                string keyword = addform.getInput();
                SQLiteHandler.InsertKeyword(this.conn, addform.getInput());
                cmbBox.Items.Add(keyword);
                Console.WriteLine("Keyword added.");
                Task.Run(() => WriteTrace("Keyword added."));
                lstBlock = SQLiteHandler.GetAllKeywords(this.conn);
                SQLiteHandler.DisconnectFromDb(this.conn);
                Console.WriteLine("Disconnected from db");
                Task.Run(() => WriteTrace("Disconnected from db"));
            }
        }

        private void viewKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBlock = SQLiteHandler.GetAllKeywords(this.conn);
            cmbBox.Items.Clear();
            foreach(string s in lstBlock)
            {
                cmbBox.Items.Add(s);
                Console.WriteLine(s);
            }
        }
    }
}
