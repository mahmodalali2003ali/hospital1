namespace hospital1.models
{
    partial class FormPatient
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
            Button button1;
            Button delate;
            upda = new Button();
            addMA = new Button();
            blood_group = new TextBox();
            label5 = new Label();
            gender = new TextBox();
            label6 = new Label();
            email = new TextBox();
            label7 = new Label();
            phon = new TextBox();
            label8 = new Label();
            adders = new TextBox();
            label4 = new Label();
            Age = new TextBox();
            label2 = new Label();
            last_Name = new TextBox();
            label1 = new Label();
            first_Name = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            nameIllness = new TextBox();
            button1 = new Button();
            delate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.CausesValidation = false;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Variable Small Light", 15F, FontStyle.Bold);
            button1.Location = new Point(585, 560);
            button1.Name = "button1";
            button1.Size = new Size(161, 76);
            button1.TabIndex = 89;
            button1.Text = "cloes";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // delate
            // 
            delate.BackColor = Color.Maroon;
            delate.CausesValidation = false;
            delate.FlatAppearance.BorderColor = Color.White;
            delate.FlatAppearance.BorderSize = 0;
            delate.Font = new Font("Segoe UI Variable Small Light", 15F, FontStyle.Bold);
            delate.Location = new Point(347, 560);
            delate.Name = "delate";
            delate.Size = new Size(161, 76);
            delate.TabIndex = 88;
            delate.Text = "delate";
            delate.UseCompatibleTextRendering = true;
            delate.UseVisualStyleBackColor = false;
            // 
            // upda
            // 
            upda.BackColor = Color.Silver;
            upda.CausesValidation = false;
            upda.FlatAppearance.BorderSize = 10;
            upda.Font = new Font("Segoe UI Variable Small Light", 15F, FontStyle.Bold);
            upda.Location = new Point(68, 555);
            upda.Name = "upda";
            upda.Size = new Size(161, 76);
            upda.TabIndex = 87;
            upda.Text = " Update";
            upda.UseCompatibleTextRendering = true;
            upda.UseVisualStyleBackColor = false;
            // 
            // addMA
            // 
            addMA.BackColor = Color.DarkBlue;
            addMA.CausesValidation = false;
            addMA.FlatAppearance.BorderSize = 10;
            addMA.Font = new Font("Segoe UI Variable Small Light", 15F, FontStyle.Bold);
            addMA.Location = new Point(1150, 82);
            addMA.Name = "addMA";
            addMA.Size = new Size(161, 76);
            addMA.TabIndex = 86;
            addMA.Text = " Add";
            addMA.UseCompatibleTextRendering = true;
            addMA.UseVisualStyleBackColor = false;
            addMA.Click += addMA_Click;
            // 
            // blood_group
            // 
            blood_group.BackColor = Color.DodgerBlue;
            blood_group.Location = new Point(878, 32);
            blood_group.Multiline = true;
            blood_group.Name = "blood_group";
            blood_group.Size = new Size(212, 34);
            blood_group.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 15F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(706, 33);
            label5.Name = "label5";
            label5.Size = new Size(166, 33);
            label5.TabIndex = 76;
            label5.Text = "blood_group  :";
            // 
            // gender
            // 
            gender.BackColor = Color.DodgerBlue;
            gender.Location = new Point(460, 140);
            gender.Multiline = true;
            gender.Name = "gender";
            gender.Size = new Size(258, 34);
            gender.TabIndex = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 15F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(347, 141);
            label6.Name = "label6";
            label6.Size = new Size(98, 33);
            label6.TabIndex = 74;
            label6.Text = "gender :";
            // 
            // email
            // 
            email.BackColor = Color.DodgerBlue;
            email.Location = new Point(449, 84);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(251, 34);
            email.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 15F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(358, 85);
            label7.Name = "label7";
            label7.Size = new Size(81, 33);
            label7.TabIndex = 72;
            label7.Text = "email :";
            // 
            // phon
            // 
            phon.BackColor = Color.DodgerBlue;
            phon.Location = new Point(447, 33);
            phon.Multiline = true;
            phon.Name = "phon";
            phon.Size = new Size(253, 34);
            phon.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 15F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(357, 32);
            label8.Name = "label8";
            label8.Size = new Size(83, 33);
            label8.TabIndex = 70;
            label8.Text = "Phon :";
            // 
            // adders
            // 
            adders.BackColor = Color.DodgerBlue;
            adders.Location = new Point(132, 194);
            adders.Multiline = true;
            adders.Name = "adders";
            adders.Size = new Size(200, 34);
            adders.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(44, 194);
            label4.Name = "label4";
            label4.Size = new Size(94, 33);
            label4.TabIndex = 68;
            label4.Text = "adders :";
            // 
            // Age
            // 
            Age.BackColor = Color.DodgerBlue;
            Age.Location = new Point(120, 141);
            Age.Multiline = true;
            Age.Name = "Age";
            Age.Size = new Size(212, 34);
            Age.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(46, 141);
            label2.Name = "label2";
            label2.Size = new Size(68, 33);
            label2.TabIndex = 66;
            label2.Text = "Age :";
            // 
            // last_Name
            // 
            last_Name.BackColor = Color.DodgerBlue;
            last_Name.Location = new Point(176, 86);
            last_Name.Multiline = true;
            last_Name.Name = "last_Name";
            last_Name.Size = new Size(156, 34);
            last_Name.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(46, 82);
            label1.Name = "label1";
            label1.Size = new Size(123, 33);
            label1.TabIndex = 64;
            label1.Text = "last name :";
            // 
            // first_Name
            // 
            first_Name.BackColor = Color.DodgerBlue;
            first_Name.Location = new Point(176, 27);
            first_Name.Multiline = true;
            first_Name.Name = "first_Name";
            first_Name.Size = new Size(156, 34);
            first_Name.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 25);
            label3.Name = "label3";
            label3.Size = new Size(130, 33);
            label3.TabIndex = 62;
            label3.Text = "first name :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1424, 303);
            dataGridView1.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 15F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(706, 87);
            label9.Name = "label9";
            label9.Size = new Size(152, 33);
            label9.TabIndex = 90;
            label9.Text = "nameIllness  :";
            // 
            // nameIllness
            // 
            nameIllness.BackColor = Color.DodgerBlue;
            nameIllness.Location = new Point(864, 89);
            nameIllness.Multiline = true;
            nameIllness.Name = "nameIllness";
            nameIllness.Size = new Size(212, 34);
            nameIllness.TabIndex = 91;
            // 
            // FormPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1413, 657);
            Controls.Add(nameIllness);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(delate);
            Controls.Add(upda);
            Controls.Add(addMA);
            Controls.Add(blood_group);
            Controls.Add(label5);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(email);
            Controls.Add(label7);
            Controls.Add(phon);
            Controls.Add(label8);
            Controls.Add(adders);
            Controls.Add(label4);
            Controls.Add(Age);
            Controls.Add(label2);
            Controls.Add(last_Name);
            Controls.Add(label1);
            Controls.Add(first_Name);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "FormPatient";
            Text = "FormPatient";
            Load += FormPatient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button upda;
        private Button addMA;
        private TextBox blood_group;
        private Label label5;
        private TextBox gender;
        private Label label6;
        private TextBox email;
        private Label label7;
        private TextBox phon;
        private Label label8;
        private TextBox adders;
        private Label label4;
        private TextBox Age;
        private Label label2;
        private TextBox last_Name;
        private Label label1;
        private TextBox first_Name;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox nameIllness;
    }
}