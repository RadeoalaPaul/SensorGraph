namespace MIPATemp
{
    partial class Meniu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu_principal));
            bIesire = new Button();
            bGE = new Button();
            bSE = new Button();
            bNou = new Button();
            bConectare = new Button();
            menuStrip1 = new MenuStrip();
            TSInfo = new ToolStripMenuItem();
            TSHelp = new ToolStripMenuItem();
            TSSave = new ToolStripMenuItem();
            continut_bd = new DataGridView();
            gfTemperatura = new ScottPlot.WinForms.FormsPlot();
            gfUmiditate = new ScottPlot.WinForms.FormsPlot();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)continut_bd).BeginInit();
            SuspendLayout();
            // 
            // bIesire
            // 
            bIesire.Cursor = Cursors.Hand;
            bIesire.Font = new Font("SimSun", 12F, FontStyle.Bold);
            bIesire.Location = new Point(50, 501);
            bIesire.Name = "bIesire";
            bIesire.Size = new Size(157, 66);
            bIesire.TabIndex = 0;
            bIesire.Text = "Exit";
            bIesire.UseVisualStyleBackColor = true;
            bIesire.Click += bIesire_Click;
            // 
            // bGE
            // 
            bGE.Cursor = Cursors.Hand;
            bGE.Font = new Font("SimSun", 12F, FontStyle.Bold);
            bGE.Location = new Point(50, 300);
            bGE.Name = "bGE";
            bGE.Size = new Size(157, 110);
            bGE.TabIndex = 1;
            bGE.Text = "Existent Graph";
            bGE.UseVisualStyleBackColor = true;
            bGE.Click += bGE_Click;
            // 
            // bSE
            // 
            bSE.Cursor = Cursors.Hand;
            bSE.Font = new Font("SimSun", 12F, FontStyle.Bold);
            bSE.Location = new Point(50, 175);
            bSE.Name = "bSE";
            bSE.Size = new Size(157, 110);
            bSE.TabIndex = 2;
            bSE.Text = "Delete Existent Graph";
            bSE.UseVisualStyleBackColor = true;
            bSE.Click += bSE_Click;
            // 
            // bNou
            // 
            bNou.Cursor = Cursors.Hand;
            bNou.Font = new Font("SimSun", 12F, FontStyle.Bold);
            bNou.Location = new Point(50, 50);
            bNou.Name = "bNou";
            bNou.Size = new Size(157, 110);
            bNou.TabIndex = 3;
            bNou.Text = "New Graph";
            bNou.UseVisualStyleBackColor = true;
            bNou.Click += bNou_Click;
            // 
            // bConectare
            // 
            bConectare.Cursor = Cursors.Hand;
            bConectare.Font = new Font("SimSun", 12F, FontStyle.Bold);
            bConectare.Location = new Point(839, 501);
            bConectare.Name = "bConectare";
            bConectare.Size = new Size(157, 66);
            bConectare.TabIndex = 4;
            bConectare.Text = "Connect to database";
            bConectare.UseVisualStyleBackColor = true;
            bConectare.Click += bConectare_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSInfo, TSHelp, TSSave });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 40);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSInfo
            // 
            TSInfo.AutoSize = false;
            TSInfo.Image = (Image)resources.GetObject("TSInfo.Image");
            TSInfo.Name = "TSInfo";
            TSInfo.Size = new Size(35, 30);
            TSInfo.Click += TSInfo_Click;
            // 
            // TSHelp
            // 
            TSHelp.AutoSize = false;
            TSHelp.Image = (Image)resources.GetObject("TSHelp.Image");
            TSHelp.Name = "TSHelp";
            TSHelp.Size = new Size(35, 30);
            TSHelp.Click += TSHelp_Click;
            // 
            // TSSave
            // 
            TSSave.Alignment = ToolStripItemAlignment.Right;
            TSSave.Image = (Image)resources.GetObject("TSSave.Image");
            TSSave.Margin = new Padding(0, 0, 25, 0);
            TSSave.Name = "TSSave";
            TSSave.Size = new Size(44, 36);
            TSSave.Click += TSSave_Click;
            // 
            // continut_bd
            // 
            continut_bd.AllowUserToAddRows = false;
            continut_bd.AllowUserToDeleteRows = false;
            continut_bd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            continut_bd.EditMode = DataGridViewEditMode.EditProgrammatically;
            continut_bd.Location = new Point(213, 37);
            continut_bd.Name = "continut_bd";
            continut_bd.Size = new Size(783, 530);
            continut_bd.TabIndex = 6;
            continut_bd.CellDoubleClick += continut_bd_CellDoubleClick;
            // 
            // gfTemperatura
            // 
            gfTemperatura.DisplayScale = 1F;
            gfTemperatura.Location = new Point(213, 37);
            gfTemperatura.Name = "gfTemperatura";
            gfTemperatura.Size = new Size(783, 295);
            gfTemperatura.TabIndex = 7;
            // 
            // gfUmiditate
            // 
            gfUmiditate.DisplayScale = 1F;
            gfUmiditate.Location = new Point(213, 334);
            gfUmiditate.Name = "gfUmiditate";
            gfUmiditate.Size = new Size(783, 233);
            gfUmiditate.TabIndex = 8;
            // 
            // Meniu_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 611);
            Controls.Add(bNou);
            Controls.Add(bSE);
            Controls.Add(bGE);
            Controls.Add(bIesire);
            Controls.Add(menuStrip1);
            Controls.Add(gfUmiditate);
            Controls.Add(bConectare);
            Controls.Add(gfTemperatura);
            Controls.Add(continut_bd);
            MainMenuStrip = menuStrip1;
            Name = "Meniu_principal";
            Text = "Main Menu";
            Shown += Meniu_principal_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)continut_bd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bIesire;
        private Button bGE;
        private Button bSE;
        private Button bNou;
        private Button bConectare;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSInfo;
        private ToolStripMenuItem TSHelp;
        private DataGridView continut_bd;
        private ScottPlot.WinForms.FormsPlot gfTemperatura;
        private ScottPlot.WinForms.FormsPlot gfUmiditate;
        private ToolStripMenuItem TSSave;
    }
}
