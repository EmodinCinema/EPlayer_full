
namespace EPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonCleaningList = new System.Windows.Forms.Button();
            this.buttonDeletList = new System.Windows.Forms.Button();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClosePanel2 = new System.Windows.Forms.Button();
            this.panelSound = new System.Windows.Forms.Panel();
            this.SliderSound = new MB.Controls.ColorSlider();
            this.buttonReproduction = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonSound100 = new System.Windows.Forms.Button();
            this.buttonForwardB = new System.Windows.Forms.Button();
            this.buttonIncrease_in_SpeedB = new System.Windows.Forms.Button();
            this.buttonBackB = new System.Windows.Forms.Button();
            this.buttonDecrease_speedB = new System.Windows.Forms.Button();
            this.buttonStopB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SliderVideo = new MB.Controls.ColorSlider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDefault = new System.Windows.Forms.Timer(this.components);
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSound.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.WMP1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 511);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.WMP);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 403);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(166, 335);
            this.panel6.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gainsboro;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnPath});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(166, 335);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "File Name";
            this.ColumnName.Width = 69;
            // 
            // ColumnPath
            // 
            this.ColumnPath.Text = "File Path";
            this.ColumnPath.Width = 108;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonCleaningList);
            this.panel5.Controls.Add(this.buttonDeletList);
            this.panel5.Controls.Add(this.buttonAddList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 68);
            this.panel5.TabIndex = 1;
            // 
            // buttonCleaningList
            // 
            this.buttonCleaningList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleaningList.BackgroundImage = global::EPlayer.Properties.Resources.CleaningList;
            this.buttonCleaningList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCleaningList.FlatAppearance.BorderSize = 0;
            this.buttonCleaningList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCleaningList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCleaningList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleaningList.Location = new System.Drawing.Point(106, 16);
            this.buttonCleaningList.Name = "buttonCleaningList";
            this.buttonCleaningList.Size = new System.Drawing.Size(30, 30);
            this.buttonCleaningList.TabIndex = 15;
            this.buttonCleaningList.UseVisualStyleBackColor = true;
            this.buttonCleaningList.Click += new System.EventHandler(this.buttonCleaningList_Click);
            // 
            // buttonDeletList
            // 
            this.buttonDeletList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeletList.BackgroundImage = global::EPlayer.Properties.Resources.DeletList;
            this.buttonDeletList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeletList.FlatAppearance.BorderSize = 0;
            this.buttonDeletList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDeletList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDeletList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletList.Location = new System.Drawing.Point(59, 16);
            this.buttonDeletList.Name = "buttonDeletList";
            this.buttonDeletList.Size = new System.Drawing.Size(30, 30);
            this.buttonDeletList.TabIndex = 14;
            this.buttonDeletList.UseVisualStyleBackColor = true;
            this.buttonDeletList.Click += new System.EventHandler(this.buttonDeletList_Click);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddList.BackgroundImage = global::EPlayer.Properties.Resources.AddList;
            this.buttonAddList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddList.FlatAppearance.BorderSize = 0;
            this.buttonAddList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddList.Location = new System.Drawing.Point(12, 16);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(30, 30);
            this.buttonAddList.TabIndex = 13;
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 403);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClosePanel2);
            this.panel2.Controls.Add(this.panelSound);
            this.panel2.Controls.Add(this.buttonReproduction);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.buttonSound100);
            this.panel2.Controls.Add(this.buttonForwardB);
            this.panel2.Controls.Add(this.buttonIncrease_in_SpeedB);
            this.panel2.Controls.Add(this.buttonBackB);
            this.panel2.Controls.Add(this.buttonDecrease_speedB);
            this.panel2.Controls.Add(this.buttonStopB);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 84);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // buttonClosePanel2
            // 
            this.buttonClosePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClosePanel2.BackgroundImage = global::EPlayer.Properties.Resources.ClosePane2;
            this.buttonClosePanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClosePanel2.FlatAppearance.BorderSize = 0;
            this.buttonClosePanel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClosePanel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClosePanel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClosePanel2.Location = new System.Drawing.Point(12, 21);
            this.buttonClosePanel2.Name = "buttonClosePanel2";
            this.buttonClosePanel2.Size = new System.Drawing.Size(60, 60);
            this.buttonClosePanel2.TabIndex = 12;
            this.buttonClosePanel2.UseVisualStyleBackColor = true;
            this.buttonClosePanel2.Click += new System.EventHandler(this.buttonClosePanel2_Click);
            // 
            // panelSound
            // 
            this.panelSound.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelSound.Controls.Add(this.SliderSound);
            this.panelSound.Location = new System.Drawing.Point(842, 21);
            this.panelSound.Name = "panelSound";
            this.panelSound.Size = new System.Drawing.Size(119, 60);
            this.panelSound.TabIndex = 11;
            // 
            // SliderSound
            // 
            this.SliderSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SliderSound.BackColor = System.Drawing.Color.Transparent;
            this.SliderSound.BarInnerColor = System.Drawing.Color.MediumSlateBlue;
            this.SliderSound.BarOuterColor = System.Drawing.Color.Cyan;
            this.SliderSound.BarPenColor = System.Drawing.Color.WhiteSmoke;
            this.SliderSound.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderSound.DrawFocusRectangle = false;
            this.SliderSound.DrawSemitransparentThumb = false;
            this.SliderSound.ElapsedInnerColor = System.Drawing.Color.Black;
            this.SliderSound.ElapsedOuterColor = System.Drawing.Color.MidnightBlue;
            this.SliderSound.LargeChange = ((uint)(5u));
            this.SliderSound.Location = new System.Drawing.Point(0, 19);
            this.SliderSound.Name = "SliderSound";
            this.SliderSound.Size = new System.Drawing.Size(119, 21);
            this.SliderSound.SmallChange = ((uint)(1u));
            this.SliderSound.TabIndex = 1;
            this.SliderSound.Text = "colorSlider2";
            this.SliderSound.ThumbInnerColor = System.Drawing.Color.Silver;
            this.SliderSound.ThumbPenColor = System.Drawing.Color.Black;
            this.SliderSound.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderSound.ValueChanged += new System.EventHandler(this.SliderSound_ValueChanged);
            this.SliderSound.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SliderSound_Scroll);
            // 
            // buttonReproduction
            // 
            this.buttonReproduction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReproduction.BackgroundImage = global::EPlayer.Properties.Resources.Reproduction;
            this.buttonReproduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonReproduction.FlatAppearance.BorderSize = 0;
            this.buttonReproduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReproduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonReproduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReproduction.Location = new System.Drawing.Point(512, 21);
            this.buttonReproduction.Name = "buttonReproduction";
            this.buttonReproduction.Size = new System.Drawing.Size(60, 60);
            this.buttonReproduction.TabIndex = 10;
            this.buttonReproduction.UseVisualStyleBackColor = true;
            this.buttonReproduction.Click += new System.EventHandler(this.buttonReproduction_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelTime);
            this.panel4.Location = new System.Drawing.Point(146, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 21);
            this.panel4.TabIndex = 9;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(152, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00 / 00:00:00";
            // 
            // buttonSound100
            // 
            this.buttonSound100.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSound100.BackgroundImage = global::EPlayer.Properties.Resources.Sound100;
            this.buttonSound100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSound100.FlatAppearance.BorderSize = 0;
            this.buttonSound100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSound100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSound100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSound100.Location = new System.Drawing.Point(776, 21);
            this.buttonSound100.Name = "buttonSound100";
            this.buttonSound100.Size = new System.Drawing.Size(60, 60);
            this.buttonSound100.TabIndex = 8;
            this.buttonSound100.UseVisualStyleBackColor = true;
            this.buttonSound100.Click += new System.EventHandler(this.buttonSound100_Click);
            // 
            // buttonForwardB
            // 
            this.buttonForwardB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonForwardB.BackgroundImage = global::EPlayer.Properties.Resources.ForwardB;
            this.buttonForwardB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonForwardB.FlatAppearance.BorderSize = 0;
            this.buttonForwardB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonForwardB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForwardB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForwardB.Location = new System.Drawing.Point(710, 21);
            this.buttonForwardB.Name = "buttonForwardB";
            this.buttonForwardB.Size = new System.Drawing.Size(60, 60);
            this.buttonForwardB.TabIndex = 6;
            this.buttonForwardB.UseVisualStyleBackColor = true;
            this.buttonForwardB.Click += new System.EventHandler(this.buttonForwardB_Click);
            // 
            // buttonIncrease_in_SpeedB
            // 
            this.buttonIncrease_in_SpeedB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonIncrease_in_SpeedB.BackgroundImage = global::EPlayer.Properties.Resources.Increase_in_SpeedB;
            this.buttonIncrease_in_SpeedB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIncrease_in_SpeedB.FlatAppearance.BorderSize = 0;
            this.buttonIncrease_in_SpeedB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonIncrease_in_SpeedB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonIncrease_in_SpeedB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncrease_in_SpeedB.Location = new System.Drawing.Point(644, 21);
            this.buttonIncrease_in_SpeedB.Name = "buttonIncrease_in_SpeedB";
            this.buttonIncrease_in_SpeedB.Size = new System.Drawing.Size(60, 60);
            this.buttonIncrease_in_SpeedB.TabIndex = 5;
            this.buttonIncrease_in_SpeedB.UseVisualStyleBackColor = true;
            this.buttonIncrease_in_SpeedB.Click += new System.EventHandler(this.buttonIncrease_in_SpeedB_Click);
            // 
            // buttonBackB
            // 
            this.buttonBackB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBackB.BackgroundImage = global::EPlayer.Properties.Resources.BackB;
            this.buttonBackB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBackB.FlatAppearance.BorderSize = 0;
            this.buttonBackB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBackB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBackB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackB.Location = new System.Drawing.Point(380, 21);
            this.buttonBackB.Name = "buttonBackB";
            this.buttonBackB.Size = new System.Drawing.Size(60, 60);
            this.buttonBackB.TabIndex = 4;
            this.buttonBackB.UseVisualStyleBackColor = true;
            this.buttonBackB.Click += new System.EventHandler(this.buttonBackB_Click);
            // 
            // buttonDecrease_speedB
            // 
            this.buttonDecrease_speedB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDecrease_speedB.BackgroundImage = global::EPlayer.Properties.Resources.Decrease_speedB;
            this.buttonDecrease_speedB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDecrease_speedB.FlatAppearance.BorderSize = 0;
            this.buttonDecrease_speedB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDecrease_speedB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDecrease_speedB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrease_speedB.Location = new System.Drawing.Point(446, 21);
            this.buttonDecrease_speedB.Name = "buttonDecrease_speedB";
            this.buttonDecrease_speedB.Size = new System.Drawing.Size(60, 60);
            this.buttonDecrease_speedB.TabIndex = 3;
            this.buttonDecrease_speedB.UseVisualStyleBackColor = true;
            this.buttonDecrease_speedB.Click += new System.EventHandler(this.buttonDecrease_speedB_Click);
            // 
            // buttonStopB
            // 
            this.buttonStopB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStopB.BackgroundImage = global::EPlayer.Properties.Resources.StopB;
            this.buttonStopB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStopB.FlatAppearance.BorderSize = 0;
            this.buttonStopB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStopB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStopB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopB.Location = new System.Drawing.Point(578, 21);
            this.buttonStopB.Name = "buttonStopB";
            this.buttonStopB.Size = new System.Drawing.Size(60, 60);
            this.buttonStopB.TabIndex = 2;
            this.buttonStopB.UseVisualStyleBackColor = true;
            this.buttonStopB.Click += new System.EventHandler(this.buttonStopB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.SliderVideo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 15);
            this.panel3.TabIndex = 1;
            // 
            // SliderVideo
            // 
            this.SliderVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SliderVideo.BackColor = System.Drawing.Color.Transparent;
            this.SliderVideo.BarInnerColor = System.Drawing.Color.MediumSlateBlue;
            this.SliderVideo.BarOuterColor = System.Drawing.Color.Cyan;
            this.SliderVideo.BarPenColor = System.Drawing.Color.WhiteSmoke;
            this.SliderVideo.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderVideo.DrawFocusRectangle = false;
            this.SliderVideo.DrawSemitransparentThumb = false;
            this.SliderVideo.ElapsedInnerColor = System.Drawing.Color.Black;
            this.SliderVideo.ElapsedOuterColor = System.Drawing.Color.MidnightBlue;
            this.SliderVideo.LargeChange = ((uint)(5u));
            this.SliderVideo.Location = new System.Drawing.Point(12, 0);
            this.SliderVideo.Name = "SliderVideo";
            this.SliderVideo.Size = new System.Drawing.Size(1014, 15);
            this.SliderVideo.SmallChange = ((uint)(1u));
            this.SliderVideo.TabIndex = 0;
            this.SliderVideo.Text = "colorSlider1";
            this.SliderVideo.ThumbInnerColor = System.Drawing.Color.Silver;
            this.SliderVideo.ThumbPenColor = System.Drawing.Color.Black;
            this.SliderVideo.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderVideo.ValueChanged += new System.EventHandler(this.SliderVideo_ValueChanged);
            this.SliderVideo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SliderVideo_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timerDefault
            // 
            this.timerDefault.Enabled = true;
            this.timerDefault.Interval = 1000;
            this.timerDefault.Tick += new System.EventHandler(this.timerDefault_Tick);
            // 
            // WMP
            // 
            this.WMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 0);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(868, 403);
            this.WMP.TabIndex = 0;
            // 
            // WMP1
            // 
            this.WMP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WMP1.CausesValidation = false;
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(302, -54);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(503, 217);
            this.WMP1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1038, 511);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelSound.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSound100;
        private System.Windows.Forms.Button buttonForwardB;
        private System.Windows.Forms.Button buttonIncrease_in_SpeedB;
        private System.Windows.Forms.Button buttonBackB;
        private System.Windows.Forms.Button buttonDecrease_speedB;
        private System.Windows.Forms.Button buttonStopB;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTime;
        private MB.Controls.ColorSlider SliderVideo;
        private System.Windows.Forms.Button buttonReproduction;
        private System.Windows.Forms.Panel panelSound;
        private MB.Controls.ColorSlider SliderSound;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonClosePanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timerDefault;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader ColumnPath;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonCleaningList;
        private System.Windows.Forms.Button buttonDeletList;
        private System.Windows.Forms.Button buttonAddList;
    }
}

