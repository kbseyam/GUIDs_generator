using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUID_Gen {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e) {
            LbGUID.Text = Guid.NewGuid().ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {
            LbGUID.Text = Guid.NewGuid().ToString();
        }

        private void BtnCopy_Click(object sender, EventArgs e) {
            Clipboard.SetText(LbGUID.Text);
        }

        private void BtnGenerateToFile_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "Text file|*.txt";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                string path = saveFileDialog1.FileName;

                if (File.Exists(path)) {
                    File.Delete(path);
                }

                using (FileStream fs = File.Create(path)) {
                    for (int i = 0; i < NumUpDownOfGUID.Value; i++) {
                        AddTextLine(fs, Guid.NewGuid().ToString());
                    }
                }
            }
            saveFileDialog1.FileName = string.Empty;
        }

        private static void AddText(FileStream fs, string value) {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private static void AddTextLine(FileStream fs, string value) {
            AddText(fs, $"{value}\n");
        }
    }
}
