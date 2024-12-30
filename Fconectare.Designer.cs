namespace MIPATemp
{
    partial class Fconectare
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fconectare));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            t1Fcon = new TextBox();
            t2Fcon = new TextBox();
            t3Fcon = new TextBox();
            t4Fcon = new TextBox();
            bIesireFcon = new Button();
            bConFcon = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            TSInfo1 = new ToolStripMenuItem();
            TSHelp1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label1.Location = new Point(113, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 0;
            label1.Text = "server =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label2.Location = new Point(149, 92);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 1;
            label2.Text = "id =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label3.Location = new Point(96, 132);
            label3.Name = "label3";
            label3.Size = new Size(106, 16);
            label3.TabIndex = 2;
            label3.Text = "password = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label4.Location = new Point(23, 175);
            label4.Name = "label4";
            label4.Size = new Size(169, 16);
            label4.TabIndex = 3;
            label4.Text = "name of database =";
            // 
            // t1Fcon
            // 
            t1Fcon.Location = new Point(208, 46);
            t1Fcon.Name = "t1Fcon";
            t1Fcon.Size = new Size(100, 23);
            t1Fcon.TabIndex = 4;
            // 
            // t2Fcon
            // 
            t2Fcon.Location = new Point(208, 85);
            t2Fcon.Name = "t2Fcon";
            t2Fcon.Size = new Size(100, 23);
            t2Fcon.TabIndex = 5;
            // 
            // t3Fcon
            // 
            t3Fcon.Location = new Point(208, 125);
            t3Fcon.Name = "t3Fcon";
            t3Fcon.Size = new Size(100, 23);
            t3Fcon.TabIndex = 6;
            // 
            // t4Fcon
            // 
            t4Fcon.Location = new Point(208, 175);
            t4Fcon.Name = "t4Fcon";
            t4Fcon.Size = new Size(100, 23);
            t4Fcon.TabIndex = 7;
            // 
            // bIesireFcon
            // 
            bIesireFcon.Cursor = Cursors.Hand;
            bIesireFcon.Font = new Font("SimSun", 12F, FontStyle.Bold);
            bIesireFcon.Location = new Point(121, 275);
            bIesireFcon.Name = "bIesireFcon";
            bIesireFcon.Size = new Size(129, 23);
            bIesireFcon.TabIndex = 8;
            bIesireFcon.Text = "Exit";
            bIesireFcon.UseVisualStyleBackColor = true;
            bIesireFcon.Click += bIesireFcon_Click;
            // 
            // bConFcon
            // 
            bConFcon.Cursor = Cursors.Hand;
            bConFcon.Font = new Font("SimSun", 12F, FontStyle.Bold);
            bConFcon.Location = new Point(121, 228);
            bConFcon.Name = "bConFcon";
            bConFcon.Size = new Size(129, 23);
            bConFcon.TabIndex = 9;
            bConFcon.Text = "Connect";
            bConFcon.UseVisualStyleBackColor = true;
            bConFcon.Click += bConFcon_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSInfo1, TSHelp1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(345, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSInfo1
            // 
            TSInfo1.Image = (Image)resources.GetObject("TSInfo1.Image");
            TSInfo1.Name = "TSInfo1";
            TSInfo1.Size = new Size(28, 20);
            TSInfo1.Click += TSInfo1_Click;
            // 
            // TSHelp1
            // 
            TSHelp1.Image = (Image)resources.GetObject("TSHelp1.Image");
            TSHelp1.Name = "TSHelp1";
            TSHelp1.Size = new Size(28, 20);
            TSHelp1.Click += TSHelp1_Click;
            // 
            // Fconectare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 324);
            Controls.Add(menuStrip1);
            Controls.Add(bConFcon);
            Controls.Add(bIesireFcon);
            Controls.Add(t4Fcon);
            Controls.Add(t3Fcon);
            Controls.Add(t2Fcon);
            Controls.Add(t1Fcon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Fconectare";
            Text = "Fconectare";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox t1Fcon;
        private TextBox t2Fcon;
        private TextBox t3Fcon;
        private TextBox t4Fcon;
        private Button bIesireFcon;
        private Button bConFcon;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSInfo1;
        private ToolStripMenuItem TSHelp1;
    }
}