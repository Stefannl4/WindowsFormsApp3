namespace WindowsFormsApp3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CoachField = new System.Windows.Forms.TextBox();
            this.TeamField1 = new System.Windows.Forms.TextBox();
            this.TeamField2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpslaanButton = new System.Windows.Forms.Button();
            this.NieuwButton = new System.Windows.Forms.Button();
            this.SoortSport = new System.Windows.Forms.Label();
            this.SoortSportField = new System.Windows.Forms.TextBox();
            this.InitButton = new System.Windows.Forms.Button();
            this.AnnulerenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSource1;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp3.Country);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team lijst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coach";
            // 
            // CoachField
            // 
            this.CoachField.Location = new System.Drawing.Point(220, 100);
            this.CoachField.Name = "CoachField";
            this.CoachField.Size = new System.Drawing.Size(174, 26);
            this.CoachField.TabIndex = 3;
            // 
            // TeamField1
            // 
            this.TeamField1.Location = new System.Drawing.Point(220, 160);
            this.TeamField1.Name = "TeamField1";
            this.TeamField1.Size = new System.Drawing.Size(184, 26);
            this.TeamField1.TabIndex = 4;
            // 
            // TeamField2
            // 
            this.TeamField2.Location = new System.Drawing.Point(220, 220);
            this.TeamField2.Name = "TeamField2";
            this.TeamField2.Size = new System.Drawing.Size(184, 26);
            this.TeamField2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TeamLid1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TeamLid2";
            // 
            // OpslaanButton
            // 
            this.OpslaanButton.Location = new System.Drawing.Point(220, 464);
            this.OpslaanButton.Name = "OpslaanButton";
            this.OpslaanButton.Size = new System.Drawing.Size(160, 35);
            this.OpslaanButton.TabIndex = 8;
            this.OpslaanButton.Text = "Opslaan";
            this.OpslaanButton.UseVisualStyleBackColor = true;
            this.OpslaanButton.Click += new System.EventHandler(this.OpslaanButton_Click);
            // 
            // NieuwButton
            // 
            this.NieuwButton.Location = new System.Drawing.Point(448, 464);
            this.NieuwButton.Name = "NieuwButton";
            this.NieuwButton.Size = new System.Drawing.Size(160, 35);
            this.NieuwButton.TabIndex = 9;
            this.NieuwButton.Text = "Nieuw";
            this.NieuwButton.UseVisualStyleBackColor = true;
            this.NieuwButton.Click += new System.EventHandler(this.NieuwButton_Click);
            // 
            // SoortSport
            // 
            this.SoortSport.AutoSize = true;
            this.SoortSport.Location = new System.Drawing.Point(50, 60);
            this.SoortSport.Name = "SoortSport";
            this.SoortSport.Size = new System.Drawing.Size(49, 20);
            this.SoortSport.TabIndex = 10;
            this.SoortSport.Text = "Team";
            // 
            // SoortSportField
            // 
            this.SoortSportField.Location = new System.Drawing.Point(220, 60);
            this.SoortSportField.Name = "SoortSportField";
            this.SoortSportField.Size = new System.Drawing.Size(174, 26);
            this.SoortSportField.TabIndex = 11;
            // 
            // InitButton
            // 
            this.InitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InitButton.Location = new System.Drawing.Point(608, 24);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(160, 35);
            this.InitButton.TabIndex = 12;
            this.InitButton.Text = "Init";
            this.InitButton.UseVisualStyleBackColor = false;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // AnnulerenButton
            // 
            this.AnnulerenButton.Location = new System.Drawing.Point(648, 464);
            this.AnnulerenButton.Name = "AnnulerenButton";
            this.AnnulerenButton.Size = new System.Drawing.Size(160, 35);
            this.AnnulerenButton.TabIndex = 13;
            this.AnnulerenButton.Text = "Annuleren";
            this.AnnulerenButton.UseVisualStyleBackColor = true;
            this.AnnulerenButton.Click += new System.EventHandler(this.AnnulerenButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 537);
            this.Controls.Add(this.AnnulerenButton);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.SoortSportField);
            this.Controls.Add(this.SoortSport);
            this.Controls.Add(this.NieuwButton);
            this.Controls.Add(this.OpslaanButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamField2);
            this.Controls.Add(this.TeamField1);
            this.Controls.Add(this.CoachField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoachField;
        private System.Windows.Forms.TextBox TeamField1;
        private System.Windows.Forms.TextBox TeamField2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpslaanButton;
        private System.Windows.Forms.Button NieuwButton;
        private System.Windows.Forms.Label SoortSport;
        private System.Windows.Forms.TextBox SoortSportField;
        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button AnnulerenButton;
    }
}