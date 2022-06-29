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
        //Microsoft.DirectX.AudioVideoPlayback.Video video;
        

        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnName.Width = listView1.Width-2;
           /* panel2.Visible = true;
            video = new Video(@"video\\intro.wmv");
            video.Open(@"video\\intro.wmv");
            video.Owner = WMP;*/
        }


        private void buttonReproduction_Click_1(object sender, EventArgs e)
        {
            if (WMP.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {

                WMP.Ctlcontrols.play();
            }
            else 
            {
                //buttonReproduction.BackgroundImage = Image.FromFile(@"buttonmin\\Pause.png");
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
        {
           
            /*Изменение цвета на фоне кнопке
             * if (panelSound.Visible == true)
            {
                buttonSound100.BackColor = Color.Black;
            }
            else
            {
                buttonSound100.BackColor = Color.Black;
            }*/
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                if ((int)WMP.Ctlcontrols.currentPosition != 0)
                {
                    labelTime.Text = WMP.Ctlcontrols.currentPositionString + " / " + WMP.currentMedia.durationString;// Посмотреть ошибку
                }
            }
            catch (Exception) { }
            try
            {
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
            //Excel.Application ex = new Microsoft.Office.I.Excel.Application();
            /*Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Visible = true;
            ex.Workbooks.Add();*//*

            //object wbAct, wsNew, oTmpEx;
            //Excel.Application ex = new Excel.Application();
            //wbAct = Excel.GetType().InvokenMember();

            *//* for (int y = 0; y < ; y++)
             {
                 for (int x = 0; x < ; x++)
                 {

                 }
             }*/

            //Работающая версия
            /*Excel.Application app = new Excel.Application();
            string exeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Excel.Workbook workbook = app.Workbooks.Open(System.IO.Path.Combine(exeDir, "database/database.xlsx"));

            listView1.Columns.Add("");
            listView1.Columns.Add("");

            var item1 = new ListViewItem();
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            item1.SubItems.RemoveAt(0);

            listView1.Items.Add(item1);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Книга Excel|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet));
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
                    wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.GetSaveAsFilename();
                    app.Quit();
                    MessageBox.Show("Ваши данные успешно сохранены.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }*/

            /*            Excel.Application app = new Excel.Application();
                        string exeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        Excel.Workbook workbook = app.Workbooks.Open(System.IO.Path.Combine(exeDir, "database/database.xlsx"));

                        listView1.Columns.Add("");
                        listView1.Columns.Add("");

                        var item1 = new ListViewItem();
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
                        item1.SubItems.RemoveAt(0);

                        listView1.Items.Add(item1);
                       *//* using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Книга Excel|*.xlsx", ValidateNames = true })
                        {*/
            /*if (sfd.ShowDialog() == DialogResult.OK)
            {*//*

                Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
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
                wb.SaveAs("1.xlsx", Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                app.GetSaveAsFilename();
                app.Quit();
                MessageBox.Show("Ваши данные успешно сохранены.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);*/



            /*Excel.Application app = new Excel.Application();
            string exeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Excel.Workbook workbook = app.Workbooks.Open(System.IO.Path.Combine(exeDir, "database/database.xlsx"));
            app.Visible = false;
            Excel.Workbook wb = app.Workbooks.Add(1);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in listView1.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }
*/
            /* string exeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);*/
            /* Excel.Workbook workbook = app.Workbooks.Open(System.IO.Path.Combine(exeDir, "database/database.xlsx"));*/
            /*Excel.Application xla = new Excel.Application();

            xla.Visible = false;
            *//*Excel.Workbook workbook = xla.Workbooks.Open(System.IO.Path.Combine(exeDir, "database/database.xlsx"));*//*
            Excel.Workbook wb = xla.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)xla.ActiveSheet;
            int i = 1;
            int j = 1;
            foreach (ListViewItem comp in listView1.Items)
            {
                ws.Cells[i, j] = comp.Text.ToString();
                //MessageBox.Show(comp.Text.ToString());
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }*/

            /*}*/
            /* }*/

            /*var path = Path.Combine(Environment.CurrentDirectory, "database", "database.xlsx");

            var wb = new XLWorkbook();
            var sh = wb.Worksheets.Add("VideoOpen");

            for(int i = 0; i < listView1.Columns.Count; i++)
            {
                *//*sh.Cell(i + 1, 1).SetValue();*//*
                sh.Cells[i+ 1, 1] = listView1.Columns[i].Text;
            }*/
            /*var listView1 = new ListView();*/

            /*listView1.Columns.Add("one");
            listView1.Columns.Add("two");*/
            string filename = "database4";
            var item1 = new ListViewItem();
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            item1.SubItems.RemoveAt(0);

            listView1.Items.Add(item1);

            /*            using (SaveFileDialog sfd = new SaveFileDialog() { InitialDirectory = "database\\", Filter = "Excel mon|*.xlsx", FileName = "database.xls", ValidateNames = true })
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {*/

                    Excel.Application app = new Excel.Application();
            /*Excel.Workbook wb = app.Workbooks.Open(@"C:\Users\User\source\repos\EPlayer\EPlayer\bin\Debug\database\database4.xlsx",
                                Type.Missing, false, Type.Missing, Type.Missing,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                Type.Missing, Type.Missing);*/
            Excel.Workbook wb = app.Workbooks.Add(true);
            /*  //Если бы мы открыли несколько книг, то получили ссылку так
              //excelappworkbook=excelappworkbooks[1];
              Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);*/
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
            wb.SaveAs(@"C:\Users\User\source\repos\EPlayer\EPlayer\bin\Debug\database\" + filename + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            wb.Close(true);
            app.Quit();
                    MessageBox.Show("Ваши данные успешно сохранены.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
    /*            }
            }
*/

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
