
namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        System.Windows.Forms.Button buttonSum;
        System.Windows.Forms.Button buttonMinese;
        System.Windows.Forms.Button buttonMultipicate;
        System.Windows.Forms.Button buttonDivision;
        System.Windows.Forms.Button button1;
        System.Windows.Forms.Button button2;
        System.Windows.Forms.Button button3;
        System.Windows.Forms.Button button4;
        System.Windows.Forms.Button button5;
        System.Windows.Forms.Button button6;
        System.Windows.Forms.Button button7;
        System.Windows.Forms.Button button8;
        System.Windows.Forms.Button button9;
        System.Windows.Forms.Button button0;
        System.Windows.Forms.Button buttonclear_all;
        System.Windows.Forms.Button button10;
        System.Windows.Forms.Button buttonResult;
        System.Windows.Forms.Button buttonPI;
        System.Windows.Forms.Button button12;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            buttonSum = new System.Windows.Forms.Button();
            buttonMinese = new System.Windows.Forms.Button();
            buttonMultipicate = new System.Windows.Forms.Button();
            buttonDivision = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button0 = new System.Windows.Forms.Button();
            buttonclear_all = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            buttonResult = new System.Windows.Forms.Button();
            buttonPI = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(543, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.goldToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.whiteToolStripMenuItem.Text = "Defult (white)";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // goldToolStripMenuItem
            // 
            this.goldToolStripMenuItem.Name = "goldToolStripMenuItem";
            this.goldToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.goldToolStripMenuItem.Text = "Gold";
            this.goldToolStripMenuItem.Click += new System.EventHandler(this.goldToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.aboutMeToolStripMenuItem.Text = "About us";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(5, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 85);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.BackgroundImage = global::Test.Properties.Resources.back_space;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Cursor = System.Windows.Forms.Cursors.Default;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button11.Location = new System.Drawing.Point(256, 194);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(280, 98);
            this.button11.TabIndex = 6;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonSum
            // 
            buttonSum.BackColor = System.Drawing.Color.Yellow;
            buttonSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSum.Location = new System.Drawing.Point(127, 521);
            buttonSum.Margin = new System.Windows.Forms.Padding(4);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new System.Drawing.Size(121, 97);
            buttonSum.TabIndex = 2;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonMinese
            // 
            buttonMinese.BackColor = System.Drawing.Color.Yellow;
            buttonMinese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonMinese.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonMinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonMinese.Location = new System.Drawing.Point(5, 521);
            buttonMinese.Margin = new System.Windows.Forms.Padding(4);
            buttonMinese.Name = "buttonMinese";
            buttonMinese.Size = new System.Drawing.Size(115, 97);
            buttonMinese.TabIndex = 2;
            buttonMinese.Text = "-";
            buttonMinese.UseVisualStyleBackColor = false;
            buttonMinese.Click += new System.EventHandler(this.ButtonMinese_Click);
            // 
            // buttonMultipicate
            // 
            buttonMultipicate.BackColor = System.Drawing.Color.Yellow;
            buttonMultipicate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonMultipicate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonMultipicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonMultipicate.Location = new System.Drawing.Point(127, 418);
            buttonMultipicate.Margin = new System.Windows.Forms.Padding(4);
            buttonMultipicate.Name = "buttonMultipicate";
            buttonMultipicate.Size = new System.Drawing.Size(121, 94);
            buttonMultipicate.TabIndex = 2;
            buttonMultipicate.Text = "×";
            buttonMultipicate.UseVisualStyleBackColor = false;
            buttonMultipicate.Click += new System.EventHandler(this.buttonMultipicate_Click);
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = System.Drawing.Color.Yellow;
            buttonDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDivision.Location = new System.Drawing.Point(5, 418);
            buttonDivision.Margin = new System.Windows.Forms.Padding(4);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new System.Drawing.Size(115, 94);
            buttonDivision.TabIndex = 2;
            buttonDivision.Text = "‍‍‍‍‍‍‍÷";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Aquamarine;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1.Location = new System.Drawing.Point(256, 300);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 74);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Aquamarine;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button2.Location = new System.Drawing.Point(349, 300);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(87, 74);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Aquamarine;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button3.Location = new System.Drawing.Point(447, 300);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(89, 74);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Aquamarine;
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button4.Location = new System.Drawing.Point(447, 383);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(89, 74);
            button4.TabIndex = 2;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Aquamarine;
            button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button5.Location = new System.Drawing.Point(349, 382);
            button5.Margin = new System.Windows.Forms.Padding(4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(88, 74);
            button5.TabIndex = 2;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.Aquamarine;
            button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button6.Location = new System.Drawing.Point(256, 383);
            button6.Margin = new System.Windows.Forms.Padding(4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(87, 74);
            button6.TabIndex = 2;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.Color.Aquamarine;
            button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button7.Location = new System.Drawing.Point(256, 465);
            button7.Margin = new System.Windows.Forms.Padding(4);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(87, 74);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.Color.Aquamarine;
            button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button8.Location = new System.Drawing.Point(351, 465);
            button8.Margin = new System.Windows.Forms.Padding(4);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(87, 74);
            button8.TabIndex = 2;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.Aquamarine;
            button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button9.Location = new System.Drawing.Point(445, 465);
            button9.Margin = new System.Windows.Forms.Padding(4);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(91, 74);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            button0.BackColor = System.Drawing.Color.Aquamarine;
            button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button0.ForeColor = System.Drawing.SystemColors.Desktop;
            button0.Location = new System.Drawing.Point(351, 546);
            button0.Margin = new System.Windows.Forms.Padding(4);
            button0.Name = "button0";
            button0.Size = new System.Drawing.Size(87, 71);
            button0.TabIndex = 2;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonclear_all
            // 
            buttonclear_all.BackColor = System.Drawing.Color.Yellow;
            buttonclear_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonclear_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonclear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonclear_all.Location = new System.Drawing.Point(5, 305);
            buttonclear_all.Margin = new System.Windows.Forms.Padding(4);
            buttonclear_all.Name = "buttonclear_all";
            buttonclear_all.Size = new System.Drawing.Size(115, 106);
            buttonclear_all.TabIndex = 2;
            buttonclear_all.Text = "c";
            buttonclear_all.UseVisualStyleBackColor = false;
            buttonclear_all.Click += new System.EventHandler(this.buttonclear_all_Click);
            buttonclear_all.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonclear_all_KeyDown);
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.Yellow;
            button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button10.Location = new System.Drawing.Point(127, 305);
            button10.Margin = new System.Windows.Forms.Padding(4);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(121, 106);
            button10.TabIndex = 2;
            button10.Text = "%";
            button10.UseVisualStyleBackColor = false;
            button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonResult
            // 
            buttonResult.BackColor = System.Drawing.Color.Green;
            buttonResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonResult.Location = new System.Drawing.Point(5, 194);
            buttonResult.Margin = new System.Windows.Forms.Padding(4);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new System.Drawing.Size(243, 106);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonPI
            // 
            buttonPI.BackColor = System.Drawing.Color.Tan;
            buttonPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPI.ForeColor = System.Drawing.SystemColors.Desktop;
            buttonPI.Location = new System.Drawing.Point(256, 546);
            buttonPI.Margin = new System.Windows.Forms.Padding(4);
            buttonPI.Name = "buttonPI";
            buttonPI.Size = new System.Drawing.Size(87, 73);
            buttonPI.TabIndex = 2;
            buttonPI.Text = " π";
            buttonPI.UseVisualStyleBackColor = false;
            buttonPI.Click += new System.EventHandler(this.buttonPI_Click);
            // 
            // button12
            // 
            button12.AllowDrop = true;
            button12.BackColor = System.Drawing.Color.Tan;
            button12.BackgroundImage = global::Test.Properties.Resources.dot_PNG29;
            button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button12.Cursor = System.Windows.Forms.Cursors.Default;
            button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            button12.Location = new System.Drawing.Point(445, 546);
            button12.Margin = new System.Windows.Forms.Padding(4);
            button12.Name = "button12";
            button12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            button12.Size = new System.Drawing.Size(91, 71);
            button12.TabIndex = 2;
            button12.UseVisualStyleBackColor = false;
            button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 622);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label1);
            this.Controls.Add(buttonDivision);
            this.Controls.Add(button9);
            this.Controls.Add(buttonPI);
            this.Controls.Add(button0);
            this.Controls.Add(button8);
            this.Controls.Add(button7);
            this.Controls.Add(button6);
            this.Controls.Add(button5);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button12);
            this.Controls.Add(button1);
            this.Controls.Add(buttonclear_all);
            this.Controls.Add(buttonResult);
            this.Controls.Add(button10);
            this.Controls.Add(buttonMultipicate);
            this.Controls.Add(buttonMinese);
            this.Controls.Add(buttonSum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator (1.0.0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goldToolStripMenuItem;
        public System.Windows.Forms.Button button11;
    }
}

