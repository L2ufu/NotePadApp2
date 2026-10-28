using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace NotePadApp
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
        }




        private void ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.Write(richTxtBox.Rtf);
                }
            }

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    richTxtBox.Rtf = reader.ReadToEnd();
                }
            }


        }

 

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.SelectionFont = fontDialog1.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void PrintToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

    }
}