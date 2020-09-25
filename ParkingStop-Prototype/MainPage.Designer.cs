namespace ParkingStop_Prototype
{
    partial class MainPage
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
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.dTimePickOut = new System.Windows.Forms.DateTimePicker();
            this.dTimePickIn = new System.Windows.Forms.DateTimePicker();
            this.cmbBxModel = new System.Windows.Forms.ComboBox();
            this.cmbBxType = new System.Windows.Forms.ComboBox();
            this.txBxPayment = new System.Windows.Forms.TextBox();
            this.txBxDuration = new System.Windows.Forms.TextBox();
            this.txBxTag = new System.Windows.Forms.TextBox();
            this.lbl_OutTxt = new System.Windows.Forms.Label();
            this.lblPaymentTxt = new System.Windows.Forms.Label();
            this.lblDurationTxt = new System.Windows.Forms.Label();
            this.lbl_InTxt = new System.Windows.Forms.Label();
            this.lblModelTxt = new System.Windows.Forms.Label();
            this.lblTypeTxt = new System.Windows.Forms.Label();
            this.lblTagTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dGrdViewList = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewList)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_Buttons.Controls.Add(this.dTimePickOut);
            this.pnl_Buttons.Controls.Add(this.dTimePickIn);
            this.pnl_Buttons.Controls.Add(this.cmbBxModel);
            this.pnl_Buttons.Controls.Add(this.btnAdd);
            this.pnl_Buttons.Controls.Add(this.cmbBxType);
            this.pnl_Buttons.Controls.Add(this.txBxPayment);
            this.pnl_Buttons.Controls.Add(this.txBxDuration);
            this.pnl_Buttons.Controls.Add(this.txBxTag);
            this.pnl_Buttons.Controls.Add(this.lbl_OutTxt);
            this.pnl_Buttons.Controls.Add(this.lblPaymentTxt);
            this.pnl_Buttons.Controls.Add(this.lblDurationTxt);
            this.pnl_Buttons.Controls.Add(this.lbl_InTxt);
            this.pnl_Buttons.Controls.Add(this.lblModelTxt);
            this.pnl_Buttons.Controls.Add(this.lblTypeTxt);
            this.pnl_Buttons.Controls.Add(this.lblTagTxt);
            this.pnl_Buttons.Controls.Add(this.label1);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 0);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(146, 450);
            this.pnl_Buttons.TabIndex = 0;
            // 
            // dTimePickOut
            // 
            this.dTimePickOut.CustomFormat = "hh:mm  tt";
            this.dTimePickOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimePickOut.Location = new System.Drawing.Point(15, 241);
            this.dTimePickOut.Name = "dTimePickOut";
            this.dTimePickOut.ShowUpDown = true;
            this.dTimePickOut.Size = new System.Drawing.Size(100, 20);
            this.dTimePickOut.TabIndex = 4;
            this.dTimePickOut.Value = new System.DateTime(2020, 9, 25, 11, 0, 0, 0);
            // 
            // dTimePickIn
            // 
            this.dTimePickIn.CustomFormat = "hh:mm  tt";
            this.dTimePickIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimePickIn.Location = new System.Drawing.Point(15, 190);
            this.dTimePickIn.Name = "dTimePickIn";
            this.dTimePickIn.ShowUpDown = true;
            this.dTimePickIn.Size = new System.Drawing.Size(100, 20);
            this.dTimePickIn.TabIndex = 4;
            this.dTimePickIn.Value = new System.DateTime(2020, 9, 25, 10, 0, 0, 0);
            // 
            // cmbBxModel
            // 
            this.cmbBxModel.FormattingEnabled = true;
            this.cmbBxModel.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Forc",
            "Honda"});
            this.cmbBxModel.Location = new System.Drawing.Point(15, 140);
            this.cmbBxModel.Name = "cmbBxModel";
            this.cmbBxModel.Size = new System.Drawing.Size(100, 21);
            this.cmbBxModel.TabIndex = 3;
            // 
            // cmbBxType
            // 
            this.cmbBxType.FormattingEnabled = true;
            this.cmbBxType.Items.AddRange(new object[] {
            "Car",
            "Motorcycle"});
            this.cmbBxType.Location = new System.Drawing.Point(15, 91);
            this.cmbBxType.Name = "cmbBxType";
            this.cmbBxType.Size = new System.Drawing.Size(100, 21);
            this.cmbBxType.TabIndex = 3;
            // 
            // txBxPayment
            // 
            this.txBxPayment.Location = new System.Drawing.Point(15, 341);
            this.txBxPayment.Name = "txBxPayment";
            this.txBxPayment.ReadOnly = true;
            this.txBxPayment.Size = new System.Drawing.Size(100, 20);
            this.txBxPayment.TabIndex = 2;
            // 
            // txBxDuration
            // 
            this.txBxDuration.Location = new System.Drawing.Point(15, 294);
            this.txBxDuration.Name = "txBxDuration";
            this.txBxDuration.ReadOnly = true;
            this.txBxDuration.Size = new System.Drawing.Size(100, 20);
            this.txBxDuration.TabIndex = 2;
            // 
            // txBxTag
            // 
            this.txBxTag.Location = new System.Drawing.Point(15, 47);
            this.txBxTag.Name = "txBxTag";
            this.txBxTag.Size = new System.Drawing.Size(100, 20);
            this.txBxTag.TabIndex = 2;
            // 
            // lbl_OutTxt
            // 
            this.lbl_OutTxt.AutoSize = true;
            this.lbl_OutTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_OutTxt.Location = new System.Drawing.Point(12, 223);
            this.lbl_OutTxt.Name = "lbl_OutTxt";
            this.lbl_OutTxt.Size = new System.Drawing.Size(65, 15);
            this.lbl_OutTxt.TabIndex = 0;
            this.lbl_OutTxt.Text = "Time Out";
            // 
            // lblPaymentTxt
            // 
            this.lblPaymentTxt.AutoSize = true;
            this.lblPaymentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaymentTxt.Location = new System.Drawing.Point(12, 323);
            this.lblPaymentTxt.Name = "lblPaymentTxt";
            this.lblPaymentTxt.Size = new System.Drawing.Size(62, 15);
            this.lblPaymentTxt.TabIndex = 0;
            this.lblPaymentTxt.Text = "Payment";
            // 
            // lblDurationTxt
            // 
            this.lblDurationTxt.AutoSize = true;
            this.lblDurationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDurationTxt.Location = new System.Drawing.Point(12, 276);
            this.lblDurationTxt.Name = "lblDurationTxt";
            this.lblDurationTxt.Size = new System.Drawing.Size(62, 15);
            this.lblDurationTxt.TabIndex = 0;
            this.lblDurationTxt.Text = "Duration";
            // 
            // lbl_InTxt
            // 
            this.lbl_InTxt.AutoSize = true;
            this.lbl_InTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_InTxt.Location = new System.Drawing.Point(12, 172);
            this.lbl_InTxt.Name = "lbl_InTxt";
            this.lbl_InTxt.Size = new System.Drawing.Size(55, 15);
            this.lbl_InTxt.TabIndex = 0;
            this.lbl_InTxt.Text = "Time In";
            // 
            // lblModelTxt
            // 
            this.lblModelTxt.AutoSize = true;
            this.lblModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModelTxt.Location = new System.Drawing.Point(12, 122);
            this.lblModelTxt.Name = "lblModelTxt";
            this.lblModelTxt.Size = new System.Drawing.Size(47, 15);
            this.lblModelTxt.TabIndex = 0;
            this.lblModelTxt.Text = "Model";
            // 
            // lblTypeTxt
            // 
            this.lblTypeTxt.AutoSize = true;
            this.lblTypeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTypeTxt.Location = new System.Drawing.Point(12, 73);
            this.lblTypeTxt.Name = "lblTypeTxt";
            this.lblTypeTxt.Size = new System.Drawing.Size(37, 15);
            this.lblTypeTxt.TabIndex = 0;
            this.lblTypeTxt.Text = "Type";
            // 
            // lblTagTxt
            // 
            this.lblTagTxt.AutoSize = true;
            this.lblTagTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagTxt.Location = new System.Drawing.Point(12, 29);
            this.lblTagTxt.Name = "lblTagTxt";
            this.lblTagTxt.Size = new System.Drawing.Size(31, 15);
            this.lblTagTxt.TabIndex = 0;
            this.lblTagTxt.Text = "Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop Park";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(713, 48);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 40);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dGrdViewList
            // 
            this.dGrdViewList.AllowUserToAddRows = false;
            this.dGrdViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrdViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Type,
            this.Model,
            this.Duration,
            this.Payment});
            this.dGrdViewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGrdViewList.Location = new System.Drawing.Point(146, 300);
            this.dGrdViewList.Name = "dGrdViewList";
            this.dGrdViewList.Size = new System.Drawing.Size(654, 150);
            this.dGrdViewList.TabIndex = 2;
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Car Tag";
            this.Tag.Name = "Tag";
            // 
            // Type
            // 
            this.Type.HeaderText = "Car Type";
            this.Type.Name = "Type";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Silver;
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtBxPassword);
            this.pnlLogin.Controls.Add(this.txtBxUser);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblMessage);
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Location = new System.Drawing.Point(0, -1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(816, 460);
            this.pnlLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(345, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 25);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(332, 227);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBxPassword.TabIndex = 2;
            // 
            // txtBxUser
            // 
            this.txtBxUser.Location = new System.Drawing.Point(332, 173);
            this.txtBxUser.Name = "txtBxUser";
            this.txtBxUser.Size = new System.Drawing.Size(100, 20);
            this.txtBxUser.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUser.Location = new System.Drawing.Point(364, 147);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(351, 202);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 15);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Location = new System.Drawing.Point(228, 324);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(308, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "The User is \"user\", Password is \"123\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Park Stop App - Prototype";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dGrdViewList);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.btnRemove);
            this.Name = "MainPage";
            this.Text = "Stop Park";
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewList)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dGrdViewList;
        private System.Windows.Forms.DateTimePicker dTimePickOut;
        private System.Windows.Forms.DateTimePicker dTimePickIn;
        private System.Windows.Forms.ComboBox cmbBxModel;
        private System.Windows.Forms.ComboBox cmbBxType;
        private System.Windows.Forms.TextBox txBxTag;
        private System.Windows.Forms.Label lbl_OutTxt;
        private System.Windows.Forms.Label lbl_InTxt;
        private System.Windows.Forms.Label lblModelTxt;
        private System.Windows.Forms.Label lblTypeTxt;
        private System.Windows.Forms.Label lblTagTxt;
        private System.Windows.Forms.TextBox txBxDuration;
        private System.Windows.Forms.Label lblDurationTxt;
        private System.Windows.Forms.TextBox txBxPayment;
        private System.Windows.Forms.Label lblPaymentTxt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
    }
}

