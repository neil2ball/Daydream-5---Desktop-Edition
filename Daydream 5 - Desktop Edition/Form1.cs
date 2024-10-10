using System.Diagnostics;
using System.Globalization;

namespace Daydream_5___Desktop_Edition
{
    public partial class Form1 : Form
    {
        Sorter sorter = new Sorter(true, 252);
        public Form1()
        {
            InitializeComponent();

            FillRichTextBoxes();
        }

        private void getPicksButton_Click(object sender, EventArgs e)
        {
            GC.Collect(); //Just for kicks.

            sorter = new Sorter(sortedCheckBox.Checked, Decimal.ToByte(pickLimit.Value));

            FillRichTextBoxes();
        }

        private void selectFolderButton_Click(Object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderPathTextBox.Text = dialog.SelectedPath;
            }
        }

        private void printPicksButton_Click(Object sender, EventArgs e)
        {

            bool[] drawTimeEz = { middayDrawTimeButton.Checked, eveningDrawTimeButton.Checked, bothDrawTimeButton.Checked, ezMatchCheckBox.Checked };

            byte dayAmount = new byte();

            if (advancePlayComboBox.SelectedItem != null)
            {
                dayAmount = Convert.ToByte(advancePlayComboBox.SelectedItem);
            }
            else
            {
                dayAmount = 1;
            }

            PlayslipFiller playslipPrint = new PlayslipFiller(sorter.picks, folderPathTextBox.Text, drawTimeEz, dayAmount, Decimal.ToByte(picksPerPlayslip.Value));

            TextOutput(playslipPrint);

            Process.Start("notepad", playslipPrint.pathRoot + playslipPrint.fileName + ".txt");

            try
            {
                Process.Start("\"C:\\Program Files\\Adobe\\Acrobat DC\\Acrobat\\Acrobat.exe\"", "/p " + playslipPrint.pathRoot + playslipPrint.fileName + ".pdf");
            }
            catch (Exception ex)
            {
                Process.Start("explorer", playslipPrint.pathRoot);
            }



            GC.Collect(); //This prevents extra playslipfiller objects from filling memory.
        }

        private void FillRichTextBoxes()
        {
            string buffer = string.Empty;

            for (byte x = 0; x < sorter.pickStrings.Count; x++)
            {
                if (x == sorter.pickStrings.Count - 1)
                {
                    buffer += sorter.pickStrings[x];
                }
                else
                {
                    buffer += sorter.pickStrings[x] + "\n";
                }
            }

            this.picksRichTextBox.Text = buffer;

            buffer = string.Empty;

            for (byte x = 0; x < sorter.pickCountList.Count; x++)
            {
                if (x == sorter.pickCountList.Count - 1)
                {
                    buffer += sorter.pickCountList[x];
                }
                else
                {
                    buffer += sorter.pickCountList[x] + "\n";
                }
            }

            this.pickCountRichTextBox.Text = buffer;
        }

        private void TextOutput(PlayslipFiller playslip)
        {
            string output = "Pick limit: " + pickLimit.Value.ToString() + "\n\n";
            output += "Sorted: " + sortedCheckBox.Checked.ToString() + "\n\n";

            output += "Draw Time: ";

            if (noDrawTimeButton.Checked)
            {
                output += "Nearest\n\n";
            }
            else if (middayDrawTimeButton.Checked)
            {
                output += "Midday\n\n";
            }
            else if (eveningDrawTimeButton.Checked)
            {
                output += "Evening\n\n";
            }
            else if (bothDrawTimeButton.Checked)
            {
                output += "Both\n\n";
            }

            output += "EZmatch: " + ezMatchCheckBox.Checked.ToString() + "\n\n";

            if (advancePlayComboBox.SelectedItem != null)
            {
                output += "Advance Play: " + advancePlayComboBox.SelectedItem.ToString() + "\n\n";
            }
            else
            {
                output += "Advance Play: 1\n\n";
            }


            output += "Picks per playslip: " + picksPerPlayslip.Value.ToString() + "\n\n";

            output += "File path: " + playslip.pathRoot + playslip.fileName + ".pdf" + "\n\n";

            output += "Picks:\n";
            output += picksRichTextBox.Text + "\n\n";

            output += "Number count:\n";

            output += pickCountRichTextBox.Text;

            File.WriteAllText(Path.Combine(playslip.pathRoot, playslip.fileName + ".txt"), output);
        }

        private void getHelpToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(Object sender, EventArgs e) 
        {
            string message = "Copyright 2024 Neil Edward Ball, II\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:\r\n\r\nThe above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.\r\n\r\nTHE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.\r\n";
            MessageBox.Show(message);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
