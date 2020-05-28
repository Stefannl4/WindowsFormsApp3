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
            this.TeamFieldL1 = new System.Windows.Forms.TextBox();
            this.TeamFieldL2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpslaanButton = new System.Windows.Forms.Button();
            this.NieuwButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TeamField = new System.Windows.Forms.TextBox();
            this.InitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSource1;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp3.Country);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coach";
            // 
            // CoachField
            // 
            this.CoachField.Location = new System.Drawing.Point(221, 102);
            this.CoachField.Name = "CoachField";
            this.CoachField.Size = new System.Drawing.Size(174, 26);
            this.CoachField.TabIndex = 3;
            this.CoachField.Text = "CoachField";
            // 
            // TeamFieldL1
            // 
            this.TeamFieldL1.Location = new System.Drawing.Point(221, 141);
            this.TeamFieldL1.Name = "TeamFieldL1";
            this.TeamFieldL1.Size = new System.Drawing.Size(184, 26);
            this.TeamFieldL1.TabIndex = 4;
            // 
            // TeamFieldL2
            // 
            this.TeamFieldL2.Location = new System.Drawing.Point(221, 198);
            this.TeamFieldL2.Name = "TeamFieldL2";
            this.TeamFieldL2.Size = new System.Drawing.Size(184, 26);
            this.TeamFieldL2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TeamLid1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TeamLid2";
            // 
            // OpslaanButton
            // 
            this.OpslaanButton.Location = new System.Drawing.Point(221, 274);
            this.OpslaanButton.Name = "OpslaanButton";
            this.OpslaanButton.Size = new System.Drawing.Size(158, 35);
            this.OpslaanButton.TabIndex = 8;
            this.OpslaanButton.Text = "Opslaan";
            this.OpslaanButton.UseVisualStyleBackColor = true;
            this.OpslaanButton.Click += new System.EventHandler(this.OpslaanButton_Click);
            // 
            // NieuwButton
            // 
            this.NieuwButton.Location = new System.Drawing.Point(221, 326);
            this.NieuwButton.Name = "NieuwButton";
            this.NieuwButton.Size = new System.Drawing.Size(158, 32);
            this.NieuwButton.TabIndex = 9;
            this.NieuwButton.Text = "Nieuw";
            this.NieuwButton.UseVisualStyleBackColor = true;
            this.NieuwButton.Click += new System.EventHandler(this.NieuwButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Team";
            // 
            // TeamField
            // 
            this.TeamField.Location = new System.Drawing.Point(221, 70);
            this.TeamField.Name = "TeamField";
            this.TeamField.Size = new System.Drawing.Size(174, 26);
            this.TeamField.TabIndex = 11;
            this.TeamField.Text = "TeamField";
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(502, 73);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(143, 49);
            this.InitButton.TabIndex = 12;
            this.InitButton.Text = "Init";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.TeamField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NieuwButton);
            this.Controls.Add(this.OpslaanButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamFieldL2);
            this.Controls.Add(this.TeamFieldL1);
            this.Controls.Add(this.CoachField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoachField;
        private System.Windows.Forms.TextBox TeamFieldL1;
        private System.Windows.Forms.TextBox TeamFieldL2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpslaanButton;
        private System.Windows.Forms.Button NieuwButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TeamField;
        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}