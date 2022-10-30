namespace ProtoSmasher_Rewrite
{
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ProtoSmasher_Rewrite.Form1));
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new global::System.Windows.Forms.ToolStripTextBox();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.consolebox = new global::System.Windows.Forms.RichTextBox();
			this.newtabbtn = new global::System.Windows.Forms.PictureBox();
			this.settingbtn = new global::System.Windows.Forms.PictureBox();
			this.injectbtn = new global::System.Windows.Forms.PictureBox();
			this.clearbtn = new global::System.Windows.Forms.PictureBox();
			this.OpenFilebtn = new global::System.Windows.Forms.PictureBox();
			this.executebtn = new global::System.Windows.Forms.PictureBox();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.txt = new global::ScintillaNET.Scintilla();
			this.tabControl1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.newtabbtn).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.settingbtn).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.injectbtn).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.clearbtn).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OpenFilebtn).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.executebtn).BeginInit();
			this.tabPage1.SuspendLayout();
			base.SuspendLayout();
			this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.tabControl1.ItemSize = new global::System.Drawing.Size(70, 18);
			this.tabControl1.Location = new global::System.Drawing.Point(12, 9);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(485, 271);
			this.tabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl1.TabIndex = 0;
			this.tabControl1.TabStop = false;
			this.tabControl1.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem_1);
			this.tabControl1.SelectedIndexChanged += new global::System.EventHandler(this.TabControl1_SelectedIndexChanged);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.renameToolStripMenuItem, this.deleteToolStripMenuItem });
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(118, 48);
			this.renameToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripTextBox1 });
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(117, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new global::System.Drawing.Size(100, 23);
			this.toolStripTextBox1.TextChanged += new global::System.EventHandler(this.ToolStripTextBox1_TextChanged);
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(117, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.DeleteToolStripMenuItem_Click);
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(201, 460);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(297, 21);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.openFileDialog1.FileName = "openFileDialog1";
			this.consolebox.BackColor = global::System.Drawing.Color.DimGray;
			this.consolebox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.consolebox.HideSelection = false;
			this.consolebox.Location = new global::System.Drawing.Point(12, 327);
			this.consolebox.Name = "consolebox";
			this.consolebox.ReadOnly = true;
			this.consolebox.Size = new global::System.Drawing.Size(486, 127);
			this.consolebox.TabIndex = 10;
			this.consolebox.Text = "";
			this.newtabbtn.BackColor = global::System.Drawing.Color.Transparent;
			this.newtabbtn.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.newtabbtn.Location = new global::System.Drawing.Point(106, 456);
			this.newtabbtn.Name = "newtabbtn";
			this.newtabbtn.Size = new global::System.Drawing.Size(90, 28);
			this.newtabbtn.TabIndex = 8;
			this.newtabbtn.TabStop = false;
			this.newtabbtn.Click += new global::System.EventHandler(this.Newtabbtn_Click);
			this.settingbtn.BackColor = global::System.Drawing.Color.Transparent;
			this.settingbtn.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.settingbtn.Location = new global::System.Drawing.Point(12, 456);
			this.settingbtn.Name = "settingbtn";
			this.settingbtn.Size = new global::System.Drawing.Size(90, 28);
			this.settingbtn.TabIndex = 7;
			this.settingbtn.TabStop = false;
			this.settingbtn.Click += new global::System.EventHandler(this.Settingbtn_Click);
			this.injectbtn.BackColor = global::System.Drawing.Color.Transparent;
			this.injectbtn.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.injectbtn.Location = new global::System.Drawing.Point(379, 284);
			this.injectbtn.Name = "injectbtn";
			this.injectbtn.Size = new global::System.Drawing.Size(119, 37);
			this.injectbtn.TabIndex = 6;
			this.injectbtn.TabStop = false;
			this.injectbtn.Click += new global::System.EventHandler(this.Injectbtn_Click);
			this.clearbtn.BackColor = global::System.Drawing.Color.Transparent;
			this.clearbtn.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.clearbtn.Location = new global::System.Drawing.Point(257, 284);
			this.clearbtn.Name = "clearbtn";
			this.clearbtn.Size = new global::System.Drawing.Size(119, 37);
			this.clearbtn.TabIndex = 5;
			this.clearbtn.TabStop = false;
			this.clearbtn.Click += new global::System.EventHandler(this.Clearbtn_Click);
			this.OpenFilebtn.BackColor = global::System.Drawing.Color.Transparent;
			this.OpenFilebtn.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.OpenFilebtn.Location = new global::System.Drawing.Point(134, 284);
			this.OpenFilebtn.Name = "OpenFilebtn";
			this.OpenFilebtn.Size = new global::System.Drawing.Size(119, 37);
			this.OpenFilebtn.TabIndex = 4;
			this.OpenFilebtn.TabStop = false;
			this.OpenFilebtn.Click += new global::System.EventHandler(this.OpenFilebtn_Click);
			this.executebtn.BackColor = global::System.Drawing.Color.Transparent;
			this.executebtn.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.executebtn.Location = new global::System.Drawing.Point(11, 284);
			this.executebtn.Name = "executebtn";
			this.executebtn.Size = new global::System.Drawing.Size(119, 37);
			this.executebtn.TabIndex = 3;
			this.executebtn.TabStop = false;
			this.executebtn.Click += new global::System.EventHandler(this.Executebtn_Click);
			this.tabPage1.BackColor = global::System.Drawing.Color.Transparent;
			this.tabPage1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.tabPage1.Controls.Add(this.txt);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(477, 245);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Untitled";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.txt.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txt.IdleStyling = global::ScintillaNET.IdleStyling.All;
			this.txt.Lexer = global::ScintillaNET.Lexer.Lua;
			this.txt.Location = new global::System.Drawing.Point(0, 0);
			this.txt.Name = "txt";
			this.txt.Size = new global::System.Drawing.Size(482, 245);
			this.txt.TabIndex = 1;
			this.txt.Technology = global::ScintillaNET.Technology.DirectWrite;
			this.txt.WrapMode = global::ScintillaNET.WrapMode.Word;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(509, 489);
			base.Controls.Add(this.consolebox);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.newtabbtn);
			base.Controls.Add(this.settingbtn);
			base.Controls.Add(this.injectbtn);
			base.Controls.Add(this.clearbtn);
			base.Controls.Add(this.OpenFilebtn);
			base.Controls.Add(this.executebtn);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProtoSmasher Rewrite";
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ControlAdded += new global::System.Windows.Forms.ControlEventHandler(this.Form1_ControlAdded);
			this.tabControl1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.newtabbtn).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.settingbtn).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.injectbtn).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.clearbtn).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OpenFilebtn).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.executebtn).EndInit();
			this.tabPage1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.TabPage tabPage1;

		private global::System.Windows.Forms.PictureBox executebtn;

		private global::System.Windows.Forms.PictureBox OpenFilebtn;

		private global::System.Windows.Forms.PictureBox clearbtn;

		private global::System.Windows.Forms.PictureBox injectbtn;

		private global::System.Windows.Forms.PictureBox settingbtn;

		private global::System.Windows.Forms.PictureBox newtabbtn;

		private global::System.Windows.Forms.ComboBox comboBox1;

		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		private global::System.Windows.Forms.RichTextBox consolebox;

		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripTextBox toolStripTextBox1;

		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		private global::ScintillaNET.Scintilla txt;

		private global::System.Windows.Forms.TabControl tabControl1;
	}
}
