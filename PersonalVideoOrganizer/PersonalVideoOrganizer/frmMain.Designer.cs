namespace PersonalVideoOrganizer {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.textUser = new System.Windows.Forms.TextBox();
			this.dateFrom = new System.Windows.Forms.DateTimePicker();
			this.listVideos = new System.Windows.Forms.ListView();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.labelUser, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelDate, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textUser, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.dateFrom, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.listVideos, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.buttonLoad, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 554);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelUser.Location = new System.Drawing.Point(3, 0);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(104, 25);
			this.labelUser.TabIndex = 0;
			this.labelUser.Text = "Username:";
			this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDate.Location = new System.Drawing.Point(3, 25);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(104, 25);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "Videos starting from:";
			this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textUser
			// 
			this.textUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textUser.Location = new System.Drawing.Point(113, 3);
			this.textUser.Name = "textUser";
			this.textUser.Size = new System.Drawing.Size(683, 20);
			this.textUser.TabIndex = 2;
			// 
			// dateFrom
			// 
			this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateFrom.Location = new System.Drawing.Point(113, 28);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(683, 20);
			this.dateFrom.TabIndex = 3;
			// 
			// listVideos
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.listVideos, 2);
			this.listVideos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listVideos.FullRowSelect = true;
			this.listVideos.Location = new System.Drawing.Point(3, 53);
			this.listVideos.MultiSelect = false;
			this.listVideos.Name = "listVideos";
			this.listVideos.Size = new System.Drawing.Size(793, 498);
			this.listVideos.TabIndex = 4;
			this.listVideos.UseCompatibleStateImageBehavior = false;
			this.listVideos.View = System.Windows.Forms.View.Details;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonLoad.Location = new System.Drawing.Point(802, 3);
			this.buttonLoad.Name = "buttonLoad";
			this.tableLayoutPanel1.SetRowSpan(this.buttonLoad, 2);
			this.buttonLoad.Size = new System.Drawing.Size(94, 44);
			this.buttonLoad.TabIndex = 5;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.buttonOpen, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(802, 53);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(94, 498);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// buttonOpen
			// 
			this.buttonOpen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOpen.Location = new System.Drawing.Point(3, 227);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(88, 44);
			this.buttonOpen.TabIndex = 0;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 554);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmMain";
			this.Text = "Personal Video Organizer";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.TextBox textUser;
		private System.Windows.Forms.DateTimePicker dateFrom;
		private System.Windows.Forms.ListView listVideos;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button buttonOpen;
	}
}

