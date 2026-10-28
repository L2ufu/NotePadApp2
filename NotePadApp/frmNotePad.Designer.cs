using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NotePadApp
{
    partial class frmNotePad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTxtBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            параметрыСтраницыToolStripMenuItem = new ToolStripMenuItem();
            PrintToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            впвапваToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copeToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            searchWithBingToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            findNextToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            goToToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            timeDateToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            WordWarpToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            viewHelpToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            aboutNotepadToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            openFileDialog1 = new OpenFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTxtBox
            // 
            richTxtBox.BackColor = SystemColors.ButtonHighlight;
            richTxtBox.Dock = DockStyle.Fill;
            richTxtBox.Location = new Point(0, 24);
            richTxtBox.Name = "richTxtBox";
            richTxtBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTxtBox.Size = new Size(1032, 582);
            richTxtBox.TabIndex = 0;
            richTxtBox.Text = "";
            richTxtBox.WordWrap = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, впвапваToolStripMenuItem, formatToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1032, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, openToolStripMenuItem, ToolStripMenuItem, сохранитьToolStripMenuItem1, toolStripSeparator3, параметрыСтраницыToolStripMenuItem, PrintToolStripMenuItem, toolStripSeparator4, выходToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "&File";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(180, 22);
            создатьToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(180, 22);
            ToolStripMenuItem.Text = "Save";
            ToolStripMenuItem.Click += ToolStripMenuItem_Click_1;
            // 
            // сохранитьToolStripMenuItem1
            // 
            сохранитьToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2 });
            сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            сохранитьToolStripMenuItem1.Size = new Size(180, 22);
            сохранитьToolStripMenuItem1.Text = "Save as...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(57, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            параметрыСтраницыToolStripMenuItem.Size = new Size(180, 22);
            параметрыСтраницыToolStripMenuItem.Text = "Page setup";
            // 
            // PrintToolStripMenuItem
            // 
            PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            PrintToolStripMenuItem.Size = new Size(180, 22);
            PrintToolStripMenuItem.Text = "Print";
            PrintToolStripMenuItem.Click += PrintToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Exit";
            // 
            // впвапваToolStripMenuItem
            // 
            впвапваToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, cutToolStripMenuItem, copeToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator5, searchWithBingToolStripMenuItem, findToolStripMenuItem, findNextToolStripMenuItem, replaceToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator1, selectAllToolStripMenuItem, timeDateToolStripMenuItem });
            впвапваToolStripMenuItem.Name = "впвапваToolStripMenuItem";
            впвапваToolStripMenuItem.Size = new Size(39, 20);
            впвапваToolStripMenuItem.Text = "Edit";
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.Size = new Size(171, 22);
            отменитьToolStripMenuItem.Text = "Undo";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(171, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copeToolStripMenuItem
            // 
            copeToolStripMenuItem.Name = "copeToolStripMenuItem";
            copeToolStripMenuItem.Size = new Size(171, 22);
            copeToolStripMenuItem.Text = "Cope";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(171, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(171, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(168, 6);
            // 
            // searchWithBingToolStripMenuItem
            // 
            searchWithBingToolStripMenuItem.Name = "searchWithBingToolStripMenuItem";
            searchWithBingToolStripMenuItem.Size = new Size(171, 22);
            searchWithBingToolStripMenuItem.Text = "Search with Bing...";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(171, 22);
            findToolStripMenuItem.Text = "Find...";
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.Size = new Size(171, 22);
            findNextToolStripMenuItem.Text = "Find next";
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(171, 22);
            replaceToolStripMenuItem.Text = "Replace...";
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.Size = new Size(171, 22);
            goToToolStripMenuItem.Text = "Go To...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(168, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(171, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            // 
            // timeDateToolStripMenuItem
            // 
            timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            timeDateToolStripMenuItem.Size = new Size(171, 22);
            timeDateToolStripMenuItem.Text = "Time/Date";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { WordWarpToolStripMenuItem, fontToolStripMenuItem, colorToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // WordWarpToolStripMenuItem
            // 
            WordWarpToolStripMenuItem.Name = "WordWarpToolStripMenuItem";
            WordWarpToolStripMenuItem.Size = new Size(134, 22);
            WordWarpToolStripMenuItem.Text = "Word Wrap";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(134, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(134, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, statusBarToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(126, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(126, 22);
            statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHelpToolStripMenuItem, toolStripSeparator6, aboutNotepadToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            viewHelpToolStripMenuItem.Size = new Size(156, 22);
            viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(153, 6);
            // 
            // aboutNotepadToolStripMenuItem
            // 
            aboutNotepadToolStripMenuItem.Name = "aboutNotepadToolStripMenuItem";
            aboutNotepadToolStripMenuItem.Size = new Size(156, 22);
            aboutNotepadToolStripMenuItem.Text = "About Notepad";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNotePad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 606);
            Controls.Add(richTxtBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmNotePad";
            Text = "NotePad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private RichTextBox richTxtBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem впвапваToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem1;
        private ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private ToolStripMenuItem PrintToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem WordWarpToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copeToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem searchWithBingToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem findNextToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem goToToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem timeDateToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem aboutNotepadToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontDialog fontDialog1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog colorDialog1;
    }
}