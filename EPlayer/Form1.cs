using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;


namespace EPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnName.Width = listView1.Width-2;
        }


        private void buttonReproduction_Click_1(object sender, EventArgs e)
        {
            if (WMP.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                WMP.Ctlcontrols.play();
            }
            else 
            {
                WMP.Ctlcontrols.pause();
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }  
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult OFD = openFileDialog1.ShowDialog();
            if (OFD == DialogResult.OK)
            {
                try
                {
                    WMP.URL = openFileDialog1.FileName;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void SliderSound_Scroll(object sender, ScrollEventArgs e)
        {
            WMP.settings.volume = SliderSound.Value;
        }

        private void buttonSound100_Click(object sender, EventArgs e)
        {
            if (panelSound.Visible == false)
            {
                panelSound.Visible = true;
            }
            else
            {
                panelSound.Visible = false;
            }
            
        }

        private void SliderSound_ValueChanged(object sender, EventArgs e)
        {
            WMP.settings.volume = SliderSound.Value;
            int Vol =SliderSound.Value;
            
            if (Vol<=100)
            {
                buttonSound100.BackgroundImage = Properties.Resources.Sound100;
            }
            if (Vol <= 75)
            {
                buttonSound100.BackgroundImage = Properties.Resources.Sound75;
            }
             if (Vol <= 50)
            {
                buttonSound100.BackgroundImage = Properties.Resources.Sound50;
            }
            if (Vol <= 25)
            {
                buttonSound100.BackgroundImage = Properties.Resources.Sound25;
            }
            if (Vol <=0)
            {
                 buttonSound100.BackgroundImage = Properties.Resources.Sound0;
            }
        }

        private void buttonStopB_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.stop();
        }

        private void buttonClosePanel2_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {}

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                if ((int)WMP.Ctlcontrols.currentPosition != 0)
                {
                    labelTime.Text = WMP.Ctlcontrols.currentPositionString + " / " + WMP.currentMedia.durationString;
                }
            }
            catch (Exception) { }

            try
            {
                if (WMP.currentMedia == null) return;
                SliderVideo.Maximum = (int)WMP.currentMedia.duration;
                SliderVideo.Value = (int)WMP.Ctlcontrols.currentPosition;
            }
            catch (Exception)
            {
                SliderVideo.Value = 0;
                SliderVideo.Maximum = 1;
            }

            if (WMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                buttonReproduction.BackgroundImage = Properties.Resources.Pause1;
            }
            else 
            {
                buttonReproduction.BackgroundImage = Properties.Resources.Reproduction;//Изменение картинки на фоне кнопке
            }

            if (panelSound.Visible == true)
            {
                buttonSound100.BackColor = Color.Silver;
            }
            else
            {
                buttonSound100.BackColor = Color.Transparent;
            }

            if (splitContainer1.Panel1Collapsed == false)
            {
                buttonClosePanel2.BackColor = Color.Silver;
            }
            else
            {
                buttonClosePanel2.BackColor=Color.Transparent;
            }
        }

        private void SliderVideo_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                WMP.Ctlcontrols.currentPosition = SliderVideo.Value;
            }
            catch (Exception){ }

        }

        private void buttonIncrease_in_SpeedB_Click(object sender, EventArgs e)
        {
            try
            {
                WMP.Ctlcontrols.currentPosition += 5;
            }
            catch (Exception) { }
        }

        private void buttonDecrease_speedB_Click(object sender, EventArgs e)
        {
            try
            {
                WMP.Ctlcontrols.currentPosition -= 5;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void timerDefault_Tick(object sender, EventArgs e)
        {
            if (WMP.playState != WMPLib.WMPPlayState.wmppsPaused && WMP.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                SliderVideo.Value = 0;
                SliderVideo.Maximum = 1;
                labelTime.Text = "00:00:00 / 00:00:00";
            }
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string line in openFileDialog1.FileNames)
            {
                ListViewItem LVI = new ListViewItem(Path.GetFileName(line));
                LVI.SubItems.Add(Path.GetFullPath(line));
                listView1.Items.Add(LVI);
            }

            //Путь к расположение БД
            var dir = Path.GetFullPath(@"database\");
            //Реальная дата
            string filename = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");

            var item1 = new ListViewItem();
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            item1.SubItems.RemoveAt(0);

            listView1.Items.Add(item1);

            Excel.Application app = new Excel.Application();

            Excel.Workbook wb = app.Workbooks.Add(true);

            Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
            app.Visible = false;
            foreach (ListViewItem item in listView1.Items)
            {
                try
                {
                    for (int ia = 0; ia < listView1.Columns.Count; ia++)
                        ws.Cells[1, ia + 1] = listView1.Columns[ia].Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            int i = 2;
            foreach (ListViewItem item in listView1.Items)
            {
                ws.Cells[i, 1] = item.SubItems[0].Text;
                ws.Cells[i, 2] = item.SubItems[1].Text;
                i++;
            }
            app.DisplayAlerts = false;
            wb.SaveAs(dir + filename + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            wb.Close(true);
            app.Quit();
            MessageBox.Show("Ваши данные успешно сохранены.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                WMP.URL = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception) { }
        }

        private void buttonForwardB_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items[listView1.SelectedItems[0].Index + 1].Selected = true;
                WMP.URL = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception) { }
        }

        private void buttonBackB_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items[listView1.SelectedItems[0].Index - 1].Selected = true;
                WMP.URL = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception) { }
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            ColumnName.Width = listView1.Width - 2;
        }

        private void buttonDeletList_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].SubItems[1].Text == WMP.URL)
            {
                WMP.Ctlcontrols.stop();
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void buttonCleaningList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            WMP.URL = "";
        }

        private void SliderVideo_ValueChanged(object sender, EventArgs e)
        {
            if (SliderVideo.Value == SliderVideo.Maximum && WMP.settings.playCount != 100)// Переход к следующему видео, после оканчания предыдущего
            {
                try
                {
                    listView1.Items[listView1.SelectedItems[0].Index + 1].Selected = true;
                    WMP.URL = listView1.SelectedItems[0].SubItems[1].Text;
                }
                catch (Exception) { }
            }
        }
    }
}
