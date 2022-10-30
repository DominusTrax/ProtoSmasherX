using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ScintillaNET;


using sxlib;
using sxlib.Specialized;

namespace ProtoSmasher_Rewrite
{
	public partial class Form1 : Form
	
	{
		private SxLibWinForms sxLib;
		

		public Form1()
		{
			this.InitializeComponent();
		}

		private void Label1_Click(object sender, EventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Load Synapse Shit
			this.sxLib = SxLib.InitializeWinForms(this, Directory.GetCurrentDirectory());
			sxLib.LoadEvent += this.SynapseLoadEvent;
			sxLib.AttachEvent += this.SynapseAttachEvent;
			sxLib.Load();


			DirectoryInfo obj = new DirectoryInfo(Form1.directory + "/Theme/ProtoThemes/");
			DirectoryInfo[] folders = obj.GetDirectories();
			this.comboBox1.DataSource = folders;
			object maintheme = Path.GetFileName(Form1.directory + "/Theme/ProtoThemes/MainTheme/");
			this.tabControl1.BackColor = Color.Transparent;
			this.consolebox.Text = "";
			this.consolebox.AppendText("MOTD: Welcome to ProtoSmasher Rewrite!" + Environment.NewLine, Color.DarkViolet);
			this.comboBox1.SelectedItem = "MainTheme";
			this.BackgroundImage = Image.FromFile(Form1.directory + "/Theme/ProtoThemes/MainTheme/background-main.png");
			this.executebtn.BackgroundImage = Image.FromFile(Form1.directory + "/Theme/ProtoThemes/MainTheme/execute-btn.png");
			this.OpenFilebtn.BackgroundImage = Image.FromFile(Form1.directory + "/Theme/ProtoThemes/MainTheme/openfile-btn.png");
			this.clearbtn.BackgroundImage = Image.FromFile(Form1.directory + "/Theme/ProtoThemes/MainTheme/clear-btn.png");
			this.injectbtn.BackgroundImage = Image.FromFile(Form1.directory + "/Theme/ProtoThemes/MainTheme/inject-btn.png");
			this.settingbtn.BackgroundImage = Image.FromFile(Form1.directory + "/Theme/ProtoThemes/MainTheme/settings-btn.png");
			this.newtabbtn.BackgroundImage = Image.FromFile(Form1.directory + "/Theme/ProtoThemes/MainTheme/newtab-btn.png");
			this.tabControl1.BackColor = Color.Transparent;
			this.tabControl1.SelectedTab.BackColor = Color.Transparent;
			this.tabControl1.Appearance = TabAppearance.Normal;
		}

		private void ChangeTabColor(DrawItemEventArgs e)
		{
			Brush BackBrush = new SolidBrush(Color.Transparent);
			e.Graphics.FillRectangle(BackBrush, e.Bounds);
			BackBrush.Dispose();
		}

		private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
		{
			this.ChangeTabColor(e);
		}

		private void Executebtn_Click(object sender, EventArgs e)
		{
			string script = this.txt.Text;
			this.exec(this.tabControl1.SelectedTab);
		}

		private void exec(Control parent)
        {
			foreach (object obj in parent.Controls)
			{
				Control child = (Control)obj;
				Scintilla textBox = child as Scintilla;
				string script = textBox.Text;
				sxLib.Execute(script);
			}
        }

		private void OpenFilebtn_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
			this.openFileDialog1.FilterIndex = 2;
			this.openFileDialog1.RestoreDirectory = true;
			bool flag = this.openFileDialog1.ShowDialog() != DialogResult.OK;
			if (!flag)
			{
				try
				{
					Stream stream;
					bool flag2 = (stream = this.openFileDialog1.OpenFile()) == null;
					if (!flag2)
					{
						using (stream)
						{
							this.Opendiag(this.tabControl1.SelectedTab);
						}
					}
				}
				catch (Exception)
                {
					int num = (int)MessageBox.Show("An unexpected error has occurred.", "ProtoSmasher ReWrite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void Clearbtn_Click(object sender, EventArgs e)
		{
			this.ClearTextBoxes(this.tabControl1.SelectedTab);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.ExitThread();
			Environment.Exit(Environment.ExitCode);
		}

		private void Injectbtn_Click(object sender, EventArgs e)
		{
			sxLib.Attach();
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.comboBox1.SelectedIndex;
			object selectedItem = this.comboBox1.SelectedItem;
			Console.WriteLine(selectedItem);
			this.BackgroundImage = Image.FromFile(string.Concat(new object[]
			{
				Form1.directory,
				"/Theme/ProtoThemes/",
				selectedItem,
				"/background-main.png"
			}));
			this.executebtn.BackgroundImage = Image.FromFile(string.Concat(new object[]
			{
				Form1.directory,
				"/Theme/ProtoThemes/",
				selectedItem,
				"/execute-btn.png"
			}));
			this.OpenFilebtn.BackgroundImage = Image.FromFile(string.Concat(new object[]
			{
				Form1.directory,
				"/Theme/ProtoThemes/",
				selectedItem,
				"/openfile-btn.png"
			}));
			this.clearbtn.BackgroundImage = Image.FromFile(string.Concat(new object[]
			{
				Form1.directory,
				"/Theme/ProtoThemes/",
				selectedItem,
				"/clear-btn.png"
			}));
			this.injectbtn.BackgroundImage = Image.FromFile(string.Concat(new object[]
			{
				Form1.directory,
				"/Theme/ProtoThemes/",
				selectedItem,
				"/inject-btn.png"
			}));
			this.settingbtn.BackgroundImage = Image.FromFile(string.Concat(new object[]
			{
				Form1.directory,
				"/Theme/ProtoThemes/",
				selectedItem,
				"/settings-btn.png"
			}));
			this.newtabbtn.BackgroundImage = Image.FromFile(string.Concat(new object[]
			{
				Form1.directory,
				"/Theme/ProtoThemes/",
				selectedItem,
				"/newtab-btn.png"
			}));
		}

		private void Newtabbtn_Click(object sender, EventArgs e)
		{
			this.tabControl1.BackColor = Color.Transparent;
			string title = "Untitled" + (this.tabControl1.TabCount + 1).ToString();
			TabPage myTabPage = new TabPage(title);
			bool flag = this.amountoftabs < 9;
			if (flag)
			{
				this.tabControl1.TabPages.Add(myTabPage);
				this.amountoftabs++;
			}
		}

		private void ClearTextBoxes(Control parent)
		{
			foreach (object obj in parent.Controls)
			{
				Control child = (Control)obj;
				Scintilla textBox = child as Scintilla;
				bool flag = textBox == null;
				if (flag)
				{
					this.ClearTextBoxes(child);
				}
				else
				{
					textBox.Text = string.Empty;
				}
			}
		}

		private void Opendiag(Control parent)
		{
			foreach (object obj in parent.Controls)
			{
				Control child = (Control)obj;
				Scintilla textBox = child as Scintilla;
				textBox.Text = File.ReadAllText(this.openFileDialog1.FileName);
				string strPath = this.openFileDialog1.FileName;
				string filename = Path.GetFileName(strPath);
				this.tabControl1.SelectedTab.Text = filename;
			}
		}

		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RichTextBox dynamictextbox = new RichTextBox();
			Scintilla txt = new Scintilla();
			txt.BackColor = Color.FromArgb(64, 64, 64);
			txt.BorderStyle = BorderStyle.None;
			txt.Size = this.txt.Size;
			TabPage seltab = this.tabControl1.SelectedTab;
			int cur = this.tabControl1.SelectedIndex;
			seltab.Controls.Add(txt);
		}

		private void Settingbtn_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab.Text = this.toolStripTextBox1.Text;
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.amountoftabs >= 2;
			if (flag)
			{
				this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
				this.amountoftabs--;
			}
		}

		private void TabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
		{
		}

		private void Form1_ControlAdded(object sender, ControlEventArgs e)
		{
		}

		public void SynapseAttachEvent(SxLibBase.SynAttachEvents Event, object e)
		{
			switch (Event)
			{
				case SxLibBase.SynAttachEvents.CHECKING:
					break;
				case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
					this.consolebox.AppendText("Checking Whitelist!" + Environment.NewLine, Color.WhiteSmoke);
					break;
				case SxLibBase.SynAttachEvents.FAILED_TO_ATTACH:
					this.consolebox.AppendText("Synapse Failed to attach!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
					this.consolebox.AppendText("Synapse Failed to find roblox!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynAttachEvents.FAILED_TO_UPDATE:
					this.consolebox.AppendText("Synapse couldnt update!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynAttachEvents.INJECTING:
					this.consolebox.AppendText("Synapse Injecting!" + Environment.NewLine, Color.GreenYellow);
					break;
				case SxLibBase.SynAttachEvents.NOT_INJECTED:
					break;
				case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
					this.consolebox.AppendText("Synapse already injected!" + Environment.NewLine, Color.GreenYellow);
					break;
				case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
					this.consolebox.AppendText("Synapse running on an older version!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynAttachEvents.NOT_UPDATED:
					this.consolebox.AppendText("Synapse not updated!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynAttachEvents.REINJECTING:
					this.consolebox.AppendText("Synapse reinjecting!" + Environment.NewLine, Color.Yellow);
					break;
				case SxLibBase.SynAttachEvents.SCANNING:
					this.consolebox.AppendText("Synapse scanning!" + Environment.NewLine, Color.Yellow);
					break;
				case SxLibBase.SynAttachEvents.UPDATING_DLLS:
					this.consolebox.AppendText("Synapse updating DLLs!" + Environment.NewLine, Color.Yellow);
					break;
				case SxLibBase.SynAttachEvents.READY:
					this.consolebox.AppendText("Synapse is ready!" + Environment.NewLine, Color.LightGreen);
					break;
			}
		}

		public void SynapseLoadEvent(SxLibBase.SynLoadEvents Event, object e)
		{
			switch (Event)
			{
				case SxLibBase.SynLoadEvents.CHECKING_WL:
					this.consolebox.AppendText("Checking Whitelist!" + Environment.NewLine, Color.WhiteSmoke);
					break;
				case SxLibBase.SynLoadEvents.ALREADY_EXISTING_WL:
					this.consolebox.AppendText("Whitelist Already Exists!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynLoadEvents.CHANGING_WL:
					this.consolebox.AppendText("Whitelist Already Exists!" + Environment.NewLine, Color.WhiteSmoke);
					break;
				case SxLibBase.SynLoadEvents.CHECKING_DATA:
					this.consolebox.AppendText("Checking Synapse Data!" + Environment.NewLine, Color.WhiteSmoke);
					break;
				case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
					this.consolebox.AppendText("Downloading Synapse Data!" + Environment.NewLine, Color.WhiteSmoke);
					break;
				case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
					this.consolebox.AppendText("Downloading Synapse DLLs!" + Environment.NewLine, Color.WhiteSmoke);
					break;
				case SxLibBase.SynLoadEvents.FAILED_TO_DOWNLOAD:
					this.consolebox.AppendText("Failed to download Synapse Files!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynLoadEvents.NOT_ENOUGH_TIME:
					this.consolebox.AppendText("Failed to change whitelist, wait 24 hours!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynLoadEvents.NOT_LOGGED_IN:
					this.consolebox.AppendText("Login to Synapse! (Use the main Synapse App)" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynLoadEvents.NOT_UPDATED:
					this.consolebox.AppendText("Synapse hasn't updated!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynLoadEvents.UNAUTHORIZED_HWID:
					this.consolebox.AppendText("Unauthorized HWID, contact synapse staff if you think this is false error" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynLoadEvents.FAILED_TO_VERIFY:
					this.consolebox.AppendText("Failed to verify files" + Environment.NewLine, Color.Red);
					Environment.Exit(Environment.ExitCode);
					break;
				case SxLibBase.SynLoadEvents.UNKNOWN:
					this.consolebox.AppendText("Unknown Error!" + Environment.NewLine, Color.Red);
					break;
				case SxLibBase.SynLoadEvents.READY:
					this.consolebox.AppendText("Synapse is Ready!" + Environment.NewLine, Color.LightGreen);
					break;
			}
		}

		public static AppDomain currentDomain = AppDomain.CurrentDomain;

		public static string directory = Directory.GetCurrentDirectory();

		public static bool attached = false;

		public static bool isReady = false;

		public static bool autoAttach = false;

		public static bool failedtofind = false;

		public static List<SxLibBase.SynHubEntry> Scripts;

		public static SxLibWinForms SLib;

		public List<string> items = new List<string>();

		public static object selectedItem;

		public int amountoftabs = 1;

		public bool procdeleted = false;

		public Form1 frm1;
	}
}
