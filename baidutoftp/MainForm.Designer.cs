/*
 * Created by SharpDevelop.
 * User: cbiney
 * Date: 8/3/2016
 * Time: 10:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace baidutoftp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.logTextBox = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.passTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.extensionf = new System.Windows.Forms.Label();
			this.extensiontxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(12, 42);
			this.inputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputTextBox.Multiline = true;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(433, 253);
			this.inputTextBox.TabIndex = 0;
			// 
			// logTextBox
			// 
			this.logTextBox.Location = new System.Drawing.Point(12, 321);
			this.logTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logTextBox.Multiline = true;
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.Size = new System.Drawing.Size(143, 147);
			this.logTextBox.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(291, 352);
			this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(115, 23);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(291, 410);
			this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(115, 23);
			this.stopButton.TabIndex = 1;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter aria2 rpc links";
			// 
			// passTextBox
			// 
			this.passTextBox.Location = new System.Drawing.Point(268, 459);
			this.passTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.Size = new System.Drawing.Size(177, 22);
			this.passTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(163, 458);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "jheberg pass";
			// 
			// extensionf
			// 
			this.extensionf.Location = new System.Drawing.Point(163, 321);
			this.extensionf.Name = "extensionf";
			this.extensionf.Size = new System.Drawing.Size(100, 23);
			this.extensionf.TabIndex = 5;
			this.extensionf.Text = "Extension";
			// 
			// extensiontxt
			// 
			this.extensiontxt.Location = new System.Drawing.Point(278, 321);
			this.extensiontxt.Name = "extensiontxt";
			this.extensiontxt.Size = new System.Drawing.Size(100, 22);
			this.extensiontxt.TabIndex = 6;
			this.extensiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 496);
			this.Controls.Add(this.extensiontxt);
			this.Controls.Add(this.extensionf);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.passTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.logTextBox);
			this.Controls.Add(this.inputTextBox);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "baidutoftp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox extensiontxt;
		private System.Windows.Forms.Label extensionf;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.TextBox logTextBox;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button startButton;
	}
}
