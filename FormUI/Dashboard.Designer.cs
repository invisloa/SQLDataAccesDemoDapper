namespace FormUI
{
	partial class Dashboard
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
			peopleFoundListbox = new ListBox();
			lastNameTextbox = new TextBox();
			label1 = new Label();
			SearchBtn = new Button();
			label2 = new Label();
			InsFirstName = new TextBox();
			label3 = new Label();
			InsLastName = new TextBox();
			label4 = new Label();
			InsEmail = new TextBox();
			label5 = new Label();
			InsPhoneNo = new TextBox();
			InsRecordBtn = new Button();
			DeleteByLastNameBtn = new Button();
			SuspendLayout();
			// 
			// peopleFoundListbox
			// 
			peopleFoundListbox.FormattingEnabled = true;
			peopleFoundListbox.ItemHeight = 15;
			peopleFoundListbox.Location = new Point(12, 63);
			peopleFoundListbox.Name = "peopleFoundListbox";
			peopleFoundListbox.Size = new Size(311, 184);
			peopleFoundListbox.TabIndex = 0;
			// 
			// lastNameTextbox
			// 
			lastNameTextbox.Location = new Point(121, 28);
			lastNameTextbox.Name = "lastNameTextbox";
			lastNameTextbox.Size = new Size(100, 23);
			lastNameTextbox.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(36, 32);
			label1.Name = "label1";
			label1.Size = new Size(66, 15);
			label1.TabIndex = 2;
			label1.Text = "Last Name:";
			// 
			// SearchBtn
			// 
			SearchBtn.Location = new Point(248, 28);
			SearchBtn.Name = "SearchBtn";
			SearchBtn.Size = new Size(75, 23);
			SearchBtn.TabIndex = 3;
			SearchBtn.Text = "Search";
			SearchBtn.UseVisualStyleBackColor = true;
			SearchBtn.Click += SearchBtn_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 277);
			label2.Name = "label2";
			label2.Size = new Size(67, 15);
			label2.TabIndex = 5;
			label2.Text = "First Name:";
			// 
			// InsFirstName
			// 
			InsFirstName.Location = new Point(121, 274);
			InsFirstName.Name = "InsFirstName";
			InsFirstName.Size = new Size(100, 23);
			InsFirstName.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 306);
			label3.Name = "label3";
			label3.Size = new Size(66, 15);
			label3.TabIndex = 7;
			label3.Text = "Last Name:";
			// 
			// InsLastName
			// 
			InsLastName.Location = new Point(121, 303);
			InsLastName.Name = "InsLastName";
			InsLastName.Size = new Size(100, 23);
			InsLastName.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 335);
			label4.Name = "label4";
			label4.Size = new Size(39, 15);
			label4.TabIndex = 9;
			label4.Text = "Email:";
			// 
			// InsEmail
			// 
			InsEmail.Location = new Point(121, 332);
			InsEmail.Name = "InsEmail";
			InsEmail.Size = new Size(100, 23);
			InsEmail.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(21, 364);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 11;
			label5.Text = "Phone No:";
			// 
			// InsPhoneNo
			// 
			InsPhoneNo.Location = new Point(121, 361);
			InsPhoneNo.Name = "InsPhoneNo";
			InsPhoneNo.Size = new Size(100, 23);
			InsPhoneNo.TabIndex = 10;
			// 
			// InsRecordBtn
			// 
			InsRecordBtn.Location = new Point(74, 404);
			InsRecordBtn.Name = "InsRecordBtn";
			InsRecordBtn.Size = new Size(75, 23);
			InsRecordBtn.TabIndex = 12;
			InsRecordBtn.Text = "Insert Data";
			InsRecordBtn.UseVisualStyleBackColor = true;
			InsRecordBtn.Click += InsRecordBtn_Click;
			// 
			// DeleteByLastNameBtn
			// 
			DeleteByLastNameBtn.Location = new Point(184, 404);
			DeleteByLastNameBtn.Name = "DeleteByLastNameBtn";
			DeleteByLastNameBtn.Size = new Size(125, 23);
			DeleteByLastNameBtn.TabIndex = 13;
			DeleteByLastNameBtn.Text = "Delete by Last Name";
			DeleteByLastNameBtn.UseVisualStyleBackColor = true;
			DeleteByLastNameBtn.Click += DeleteByLastNameBtn_Click;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(DeleteByLastNameBtn);
			Controls.Add(InsRecordBtn);
			Controls.Add(label5);
			Controls.Add(InsPhoneNo);
			Controls.Add(label4);
			Controls.Add(InsEmail);
			Controls.Add(label3);
			Controls.Add(InsLastName);
			Controls.Add(label2);
			Controls.Add(InsFirstName);
			Controls.Add(SearchBtn);
			Controls.Add(label1);
			Controls.Add(lastNameTextbox);
			Controls.Add(peopleFoundListbox);
			Name = "Dashboard";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox peopleFoundListbox;
		private TextBox lastNameTextbox;
		private Label label1;
		private Button SearchBtn;
		private Label label2;
		private TextBox InsFirstName;
		private Label label3;
		private TextBox InsLastName;
		private Label label4;
		private TextBox InsEmail;
		private Label label5;
		private TextBox InsPhoneNo;
		private Button InsRecordBtn;
		private Button DeleteByLastNameBtn;
	}
}