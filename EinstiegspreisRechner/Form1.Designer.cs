namespace EinstiegspreisRechner
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridViewPosition = new DataGridView();
            Positionsgroesse = new DataGridViewTextBoxColumn();
            PreisProCcoin = new DataGridViewTextBoxColumn();
            lblEinsteigspreis = new Label();
            BtnBerechnen = new Button();
            BtnNeu = new Button();
            BtnDelete = new Button();
            AnteileGesamt = new Label();
            PositinGesamt = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosition).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridViewPosition
            // 
            dataGridViewPosition.AllowDrop = true;
            dataGridViewPosition.AllowUserToOrderColumns = true;
            dataGridViewPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPosition.Columns.AddRange(new DataGridViewColumn[] { Positionsgroesse, PreisProCcoin });
            dataGridViewPosition.Location = new Point(12, 12);
            dataGridViewPosition.MinimumSize = new Size(300, 100);
            dataGridViewPosition.Name = "dataGridViewPosition";
            dataGridViewPosition.Size = new Size(350, 150);
            dataGridViewPosition.TabIndex = 0;
            dataGridViewPosition.CellValidating += dataGridViewPosition_CellValidating;
            // 
            // Positionsgroesse
            // 
            Positionsgroesse.HeaderText = "Positionsgröße";
            Positionsgroesse.Name = "Positionsgroesse";
            Positionsgroesse.Width = 150;
            // 
            // PreisProCcoin
            // 
            PreisProCcoin.HeaderText = "Preis/pro coin";
            PreisProCcoin.Name = "PreisProCcoin";
            PreisProCcoin.Width = 150;
            // 
            // lblEinsteigspreis
            // 
            lblEinsteigspreis.AutoSize = true;
            lblEinsteigspreis.Location = new Point(191, 220);
            lblEinsteigspreis.Name = "lblEinsteigspreis";
            lblEinsteigspreis.Size = new Size(19, 21);
            lblEinsteigspreis.TabIndex = 9;
            lblEinsteigspreis.Text = "0";
            // 
            // BtnBerechnen
            // 
            BtnBerechnen.Dock = DockStyle.Fill;
            BtnBerechnen.Location = new Point(3, 3);
            BtnBerechnen.Name = "BtnBerechnen";
            BtnBerechnen.Size = new Size(110, 43);
            BtnBerechnen.TabIndex = 1;
            BtnBerechnen.Text = "Berechnen";
            BtnBerechnen.UseVisualStyleBackColor = true;
            BtnBerechnen.Click += BtnBerechnen_Click;
            // 
            // BtnNeu
            // 
            BtnNeu.Dock = DockStyle.Fill;
            BtnNeu.Location = new Point(119, 3);
            BtnNeu.Name = "BtnNeu";
            BtnNeu.Size = new Size(110, 43);
            BtnNeu.TabIndex = 2;
            BtnNeu.Text = "Neu";
            BtnNeu.UseVisualStyleBackColor = true;
            BtnNeu.Click += BtnNeu_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Dock = DockStyle.Fill;
            BtnDelete.Location = new Point(235, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 43);
            BtnDelete.TabIndex = 3;
            BtnDelete.Text = "Löschen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // AnteileGesamt
            // 
            AnteileGesamt.AutoSize = true;
            AnteileGesamt.Location = new Point(191, 262);
            AnteileGesamt.Name = "AnteileGesamt";
            AnteileGesamt.Size = new Size(19, 21);
            AnteileGesamt.TabIndex = 15;
            AnteileGesamt.Text = "0";
            // 
            // PositinGesamt
            // 
            PositinGesamt.AutoSize = true;
            PositinGesamt.Location = new Point(191, 241);
            PositinGesamt.Name = "PositinGesamt";
            PositinGesamt.Size = new Size(19, 21);
            PositinGesamt.TabIndex = 16;
            PositinGesamt.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 17;
            label3.Text = "Anteile Gesamt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(173, 21);
            label4.TabIndex = 18;
            label4.Text = "Positionsgröße Gesamt:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 220);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 19;
            label1.Text = "Einstiegspreis:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(BtnBerechnen, 0, 0);
            tableLayoutPanel1.Controls.Add(BtnNeu, 1, 0);
            tableLayoutPanel1.Controls.Add(BtnDelete, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 168);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(350, 49);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PositinGesamt);
            Controls.Add(AnteileGesamt);
            Controls.Add(lblEinsteigspreis);
            Controls.Add(dataGridViewPosition);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Einstiegspreis Rechner";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosition).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridViewPosition;
        private Label lblEinsteigspreis;
        private Button BtnBerechnen;
        private Button BtnNeu;
        private Button BtnDelete;
        private Label AnteileGesamt;
        private Label PositinGesamt;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Positionsgroesse;
        private DataGridViewTextBoxColumn PreisProCcoin;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
