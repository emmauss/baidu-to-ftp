/*
 * Created by SharpDevelop.
 * User: cbiney
 * Date: 8/3/2016
 * Time: 10:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace baidutoftp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public class transfer_container
		{
			public string [] aria = new string [1000];
			public int url_num;
			public int succeed_num =0;
			public int failed_num =0;
		}
		void StartButtonClick(object sender, EventArgs e)
		{
			transfer_container trans = new transfer_container();
			if (inputTextBox.Lines.Length<1)
			{
				MessageBox.Show("Please enter aria rpc urls","Empty list",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			else
			{
				transfer(trans);
			}
			
			
		}
		public void transfer( transfer_container input)
		{
			WebClient client = new WebClient ();
			string fname;
			string arguements;
			string directory;
			string aria2 = "aria2c";
			string extension = extensiontxt.Text ;
			for (int i = 0; i < inputTextBox.Lines.Length;i++)
			{
				input.aria[i]= inputTextBox.Lines[i].ToString();
				arguements = input.aria[i];
				arguements = arguements.Remove(arguements.IndexOf(aria2),aria2.Length);
				aria_download(arguements);
				directory=Directory.GetCurrentDirectory();
				DirectoryInfo di = new DirectoryInfo(directory);
				foreach (var file in Directory.GetFiles(directory, "*." + extension, SearchOption.AllDirectories))
        {
					string filepath = file.ToString();
					fname = Path.GetFileName(filepath);
					logTextBox.Text=fname;
					ftpupload(fname , filepath);
					File.Delete(fname);
        }
				}
			
			
		}
		public void aria_download(string input)
		{
			var process = Process.Start("aria2c",input);
			process.WaitForExit();
				return;
			
		}
		
		public void ftpupload( string file, string path)
		{
			string pass = passTextBox.Text ;
			using (WebClient client = new WebClient())
{
    client.Credentials = new NetworkCredential("emmaushansen",pass);
    client.UploadFile("ftp://www2.jheberg.net/" + file , "STOR", path);
}
            return;
			
		}
	}
}
