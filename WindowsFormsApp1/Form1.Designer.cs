namespace WindowsFormsApp1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblDirectorName = new System.Windows.Forms.Label();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.tlblContactNumber = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(454, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(535, 392);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(616, 392);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tournament Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 280);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(135, 90);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.Size = new System.Drawing.Size(228, 20);
            this.txtTeamId.TabIndex = 7;
            // 
            // lblTeamId
            // 
            this.lblTeamId.AutoSize = true;
            this.lblTeamId.Location = new System.Drawing.Point(48, 97);
            this.lblTeamId.Name = "lblTeamId";
            this.lblTeamId.Size = new System.Drawing.Size(48, 13);
            this.lblTeamId.TabIndex = 8;
            this.lblTeamId.Text = "Team ID";
            this.lblTeamId.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(48, 123);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(65, 13);
            this.lblTeamName.TabIndex = 10;
            this.lblTeamName.Text = "Team Name";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(135, 116);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(228, 20);
            this.txtTeamName.TabIndex = 9;
            // 
            // lblDirectorName
            // 
            this.lblDirectorName.AutoSize = true;
            this.lblDirectorName.Location = new System.Drawing.Point(48, 175);
            this.lblDirectorName.Name = "lblDirectorName";
            this.lblDirectorName.Size = new System.Drawing.Size(75, 13);
            this.lblDirectorName.TabIndex = 14;
            this.lblDirectorName.Text = "Director Name";
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(135, 168);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(228, 20);
            this.txtDirectorName.TabIndex = 13;
            // 
            // lblCoachName
            // 
            this.lblCoachName.AutoSize = true;
            this.lblCoachName.Location = new System.Drawing.Point(48, 149);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(69, 13);
            this.lblCoachName.TabIndex = 12;
            this.lblCoachName.Text = "Coach Name";
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(135, 142);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(228, 20);
            this.txtCoachName.TabIndex = 11;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(48, 227);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(74, 13);
            this.lblAddressLine2.TabIndex = 18;
            this.lblAddressLine2.Text = "Address Line2";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(135, 220);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(228, 20);
            this.txtAddressLine2.TabIndex = 17;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(48, 201);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 16;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(135, 194);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(228, 20);
            this.txtAddressLine1.TabIndex = 15;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(48, 276);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(135, 272);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(228, 20);
            this.txtCity.TabIndex = 21;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(48, 253);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(56, 13);
            this.lblPostCode.TabIndex = 20;
            this.lblPostCode.Text = "Post Code";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(135, 246);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(228, 20);
            this.txtPostCode.TabIndex = 19;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(48, 357);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(58, 13);
            this.lblCreatedBy.TabIndex = 28;
            this.lblCreatedBy.Text = "Created by";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(135, 350);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(228, 20);
            this.txtCreatedBy.TabIndex = 27;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(48, 331);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 26;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(135, 324);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(228, 20);
            this.txtEmailAddress.TabIndex = 25;
            // 
            // tlblContactNumber
            // 
            this.tlblContactNumber.AutoSize = true;
            this.tlblContactNumber.Location = new System.Drawing.Point(48, 305);
            this.tlblContactNumber.Name = "tlblContactNumber";
            this.tlblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.tlblContactNumber.TabIndex = 24;
            this.tlblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(135, 298);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(228, 20);
            this.txtContactNumber.TabIndex = 23;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Select an action to do :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.tlblContactNumber);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.lblDirectorName);
            this.Controls.Add(this.txtDirectorName);
            this.Controls.Add(this.lblCoachName);
            this.Controls.Add(this.txtCoachName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamId);
            this.Controls.Add(this.txtTeamId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTeamId;
        private System.Windows.Forms.Label lblTeamId;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblDirectorName;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label tlblContactNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

