namespace SuperheroDatabaseSystem
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.heroTable = new System.Windows.Forms.DataGridView();
            this.lblHeroData = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExamScore = new System.Windows.Forms.TextBox();
            this.txtSuperPower = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeroID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeroID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gpAverageAge = new System.Windows.Forms.GroupBox();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.gpExamScore = new System.Windows.Forms.GroupBox();
            this.lblExamScore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpNoRank = new System.Windows.Forms.GroupBox();
            this.gpTotalno = new System.Windows.Forms.GroupBox();
            this.lblTotalNoHeros = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.lblS = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gpAverageAge.SuspendLayout();
            this.gpExamScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpNoRank.SuspendLayout();
            this.gpTotalno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 67);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(42, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 75);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(164, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = " SuperHero Management System ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Yellow;
            this.btnClose.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1434, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.heroTable);
            this.panel2.Controls.Add(this.lblHeroData);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 337);
            this.panel2.TabIndex = 1;
            // 
            // heroTable
            // 
            this.heroTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.heroTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heroTable.Location = new System.Drawing.Point(20, 37);
            this.heroTable.Name = "heroTable";
            this.heroTable.RowHeadersWidth = 51;
            this.heroTable.RowTemplate.Height = 24;
            this.heroTable.Size = new System.Drawing.Size(970, 285);
            this.heroTable.TabIndex = 1;
            // 
            // lblHeroData
            // 
            this.lblHeroData.AutoSize = true;
            this.lblHeroData.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroData.Location = new System.Drawing.Point(16, 12);
            this.lblHeroData.Name = "lblHeroData";
            this.lblHeroData.Size = new System.Drawing.Size(89, 22);
            this.lblHeroData.TabIndex = 0;
            this.lblHeroData.Text = "Hero Data";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnView);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtExamScore);
            this.panel3.Controls.Add(this.txtSuperPower);
            this.panel3.Controls.Add(this.txtAge);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.txtHeroID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblHeroID);
            this.panel3.Location = new System.Drawing.Point(12, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 240);
            this.panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(709, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 51);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnView.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(497, 147);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(169, 51);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(709, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 55);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(497, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 55);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExamScore
            // 
            this.txtExamScore.Location = new System.Drawing.Point(148, 203);
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(192, 22);
            this.txtExamScore.TabIndex = 4;
            // 
            // txtSuperPower
            // 
            this.txtSuperPower.Location = new System.Drawing.Point(148, 162);
            this.txtSuperPower.Name = "txtSuperPower";
            this.txtSuperPower.Size = new System.Drawing.Size(192, 22);
            this.txtSuperPower.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(109, 126);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(215, 22);
            this.txtAge.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtHeroID
            // 
            this.txtHeroID.Location = new System.Drawing.Point(109, 38);
            this.txtHeroID.Name = "txtHeroID";
            this.txtHeroID.Size = new System.Drawing.Size(215, 22);
            this.txtHeroID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exam Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "SuperPower :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // lblHeroID
            // 
            this.lblHeroID.AutoSize = true;
            this.lblHeroID.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroID.Location = new System.Drawing.Point(26, 37);
            this.lblHeroID.Name = "lblHeroID";
            this.lblHeroID.Size = new System.Drawing.Size(77, 22);
            this.lblHeroID.TabIndex = 4;
            this.lblHeroID.Text = "Hero ID :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.gpAverageAge);
            this.panel4.Controls.Add(this.gpExamScore);
            this.panel4.Controls.Add(this.gpNoRank);
            this.panel4.Controls.Add(this.lblReport);
            this.panel4.Controls.Add(this.gpTotalno);
            this.panel4.Controls.Add(this.btnGenerateSummary);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1056, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 629);
            this.panel4.TabIndex = 3;
            // 
            // gpAverageAge
            // 
            this.gpAverageAge.BackColor = System.Drawing.Color.White;
            this.gpAverageAge.Controls.Add(this.lblAverageAge);
            this.gpAverageAge.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAverageAge.Location = new System.Drawing.Point(38, 263);
            this.gpAverageAge.Name = "gpAverageAge";
            this.gpAverageAge.Size = new System.Drawing.Size(360, 91);
            this.gpAverageAge.TabIndex = 14;
            this.gpAverageAge.TabStop = false;
            this.gpAverageAge.Text = "Average Age";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.Location = new System.Drawing.Point(150, 31);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(40, 45);
            this.lblAverageAge.TabIndex = 2;
            this.lblAverageAge.Text = "0";
            // 
            // gpExamScore
            // 
            this.gpExamScore.BackColor = System.Drawing.Color.White;
            this.gpExamScore.Controls.Add(this.lblExamScore);
            this.gpExamScore.Controls.Add(this.pictureBox2);
            this.gpExamScore.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpExamScore.Location = new System.Drawing.Point(38, 159);
            this.gpExamScore.Name = "gpExamScore";
            this.gpExamScore.Size = new System.Drawing.Size(360, 91);
            this.gpExamScore.TabIndex = 0;
            this.gpExamScore.TabStop = false;
            this.gpExamScore.Text = "Average Exam Score";
            // 
            // lblExamScore
            // 
            this.lblExamScore.AutoSize = true;
            this.lblExamScore.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamScore.Location = new System.Drawing.Point(240, 24);
            this.lblExamScore.Name = "lblExamScore";
            this.lblExamScore.Size = new System.Drawing.Size(40, 45);
            this.lblExamScore.TabIndex = 2;
            this.lblExamScore.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // gpNoRank
            // 
            this.gpNoRank.BackColor = System.Drawing.Color.White;
            this.gpNoRank.Controls.Add(this.lblB);
            this.gpNoRank.Controls.Add(this.lblA);
            this.gpNoRank.Controls.Add(this.lblC);
            this.gpNoRank.Controls.Add(this.lblS);
            this.gpNoRank.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpNoRank.Location = new System.Drawing.Point(38, 377);
            this.gpNoRank.Name = "gpNoRank";
            this.gpNoRank.Size = new System.Drawing.Size(400, 159);
            this.gpNoRank.TabIndex = 0;
            this.gpNoRank.TabStop = false;
            this.gpNoRank.Text = "Number of Heros Per Rank";
            // 
            // gpTotalno
            // 
            this.gpTotalno.BackColor = System.Drawing.Color.White;
            this.gpTotalno.Controls.Add(this.lblTotalNoHeros);
            this.gpTotalno.Controls.Add(this.pictureBox1);
            this.gpTotalno.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTotalno.Location = new System.Drawing.Point(38, 54);
            this.gpTotalno.Name = "gpTotalno";
            this.gpTotalno.Size = new System.Drawing.Size(360, 90);
            this.gpTotalno.TabIndex = 13;
            this.gpTotalno.TabStop = false;
            this.gpTotalno.Text = "Total Number of Heros";
            // 
            // lblTotalNoHeros
            // 
            this.lblTotalNoHeros.AutoSize = true;
            this.lblTotalNoHeros.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNoHeros.Location = new System.Drawing.Point(240, 27);
            this.lblTotalNoHeros.Name = "lblTotalNoHeros";
            this.lblTotalNoHeros.Size = new System.Drawing.Size(40, 45);
            this.lblTotalNoHeros.TabIndex = 1;
            this.lblTotalNoHeros.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.White;
            this.lblReport.Location = new System.Drawing.Point(175, 3);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(130, 45);
            this.lblReport.TabIndex = 12;
            this.lblReport.Text = "Report";
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerateSummary.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSummary.ForeColor = System.Drawing.Color.White;
            this.btnGenerateSummary.Location = new System.Drawing.Point(134, 548);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(194, 69);
            this.btnGenerateSummary.TabIndex = 11;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = false;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(21, 39);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(88, 24);
            this.lblS.TabIndex = 0;
            this.lblS.Text = "S -RANK :";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(228, 112);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(85, 24);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "C-RANK :";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(226, 39);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(87, 24);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A- RANK:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(21, 112);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(82, 24);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B-RANK:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1568, 696);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gpAverageAge.ResumeLayout(false);
            this.gpAverageAge.PerformLayout();
            this.gpExamScore.ResumeLayout(false);
            this.gpExamScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpNoRank.ResumeLayout(false);
            this.gpNoRank.PerformLayout();
            this.gpTotalno.ResumeLayout(false);
            this.gpTotalno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView heroTable;
        private System.Windows.Forms.Label lblHeroData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeroID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtExamScore;
        private System.Windows.Forms.TextBox txtSuperPower;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeroID;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.GroupBox gpExamScore;
        private System.Windows.Forms.GroupBox gpNoRank;
        private System.Windows.Forms.GroupBox gpTotalno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpAverageAge;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblExamScore;
        private System.Windows.Forms.Label lblTotalNoHeros;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblS;
    }
}

