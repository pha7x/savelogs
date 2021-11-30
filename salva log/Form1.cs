using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.IO;

namespace salva_log
{
    public partial class form12 : Form
    {

        string sourceFileT = @"xxx";
        string destFileT = @"zzz";
        public string dataz;
        
        string sourceFile = @"C:\Users\Positivo\Desktop\infinix\Release\TestResult\";
        string sourceFile2 = @"C:\Users\Positivo\Desktop\infinix\Release\TestResult";
        string destFile = @"\\10.70.120.249\LogsTestesNaLinha\Infinix\TestResult\Grava\";
        string destFile2 = @"\\10.70.120.249\LogsTestesNaLinha\Infinix2\Grava\";


        string[] result;
        public form12()
        {
            InitializeComponent();
            btz.Hide();
            Timer tmr = new Timer();
            tmr.Interval = 50;
            tmr.Tick += tmr_Tick;
            tmr.Start();

          
        }

        public void tmr_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;

            DateTime dataEntrada = DateTime.Now;
            lb3timer.Text = dataEntrada.ToString("HH:mm:ss");
            dataz = DateTime.Today.ToString("yyyyMMdd");
            lbdata.Text = dataz;


            if(lb3timer.Text =="15:48:00")
            {
                lbl2.Text = "Transferindo para o servidor";
                DirectoryCopy(sourceFile+dataz, destFile+dataz,true);
                btz.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // File.copy(@"C:\Users\Positivo\Desktop\DA",@"\\10.70.120.240\temp\Paulo\TP_NEW", true);

            //result = System.IO.Directory.GetFileSystemEntries(sourceFile);
            //  txt1.Text = result[0];
            btz.Show();
            DirectoryCopy(sourceFile+dataz, destFile+dataz, true);
            
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

       public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            
            //pega os subdiretorios
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
            lbl2.Text = "ARQUIVOS ENVIADOS";
            lbl2.BackColor = Color.Green;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //   lbl2.Text = "CHECK HORARIO E DATA";
            //  lbl2.BackColor = Color.Red;
            label1.Text = sourceFile+dataz;
            DirectoryCopy(sourceFile2, destFile2, true);

            

    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttps_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string app = @"C:\Users\Positivo\Desktop\infinix\Release\TPSTester.exe";
            
            string param = "http://raphaelcardoso.com.br";
            
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);
        }
    }
}
