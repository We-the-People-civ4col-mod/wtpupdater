﻿namespace WtPUpdater
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// Required constructor variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// Release all used resources.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		/// <param name="disposing">true if the managed resource should be disposed; otherwise false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows = Code automatically generated by the Windows Form Designer

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте содержимое этого метода с помощью редактора кода.
		/// Required method for constructor support - do not modify the contents of this method using a code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RefreshButton = new System.Windows.Forms.Button();
			this.ActionLog = new System.Windows.Forms.TextBox();
			this.VersionList = new System.Windows.Forms.ListBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.FindCivButton = new System.Windows.Forms.Button();
			this.UnzipButton = new System.Windows.Forms.Button();
			this.ModDirName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// RefreshButton
			// 
			this.RefreshButton.Location = new System.Drawing.Point(13, 13);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(75, 23);
			this.RefreshButton.TabIndex = 0;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// ActionLog
			// 
			this.ActionLog.Location = new System.Drawing.Point(13, 43);
			this.ActionLog.Multiline = true;
			this.ActionLog.Name = "ActionLog";
			this.ActionLog.Size = new System.Drawing.Size(660, 395);
			this.ActionLog.TabIndex = 1;
			// 
			// VersionList
			// 
			this.VersionList.FormattingEnabled = true;
			this.VersionList.Location = new System.Drawing.Point(679, 43);
			this.VersionList.Name = "VersionList";
			this.VersionList.Size = new System.Drawing.Size(120, 394);
			this.VersionList.TabIndex = 2;
			this.VersionList.SelectedIndexChanged += new System.EventHandler(this.VersionList_SelectedIndexChanged);
			// 
			// SaveButton
			// 
			this.SaveButton.Enabled = false;
			this.SaveButton.Location = new System.Drawing.Point(94, 14);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(492, 13);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(307, 23);
			this.progressBar.TabIndex = 4;
			// 
			// FindCivButton
			// 
			this.FindCivButton.Location = new System.Drawing.Point(175, 14);
			this.FindCivButton.Name = "FindCivButton";
			this.FindCivButton.Size = new System.Drawing.Size(75, 23);
			this.FindCivButton.TabIndex = 5;
			this.FindCivButton.Text = "FindDir";
			this.FindCivButton.UseVisualStyleBackColor = true;
			this.FindCivButton.Click += new System.EventHandler(this.FindCivButton_Click);
			// 
			// UnzipButton
			// 
			this.UnzipButton.Enabled = false;
			this.UnzipButton.Location = new System.Drawing.Point(256, 14);
			this.UnzipButton.Name = "UnzipButton";
			this.UnzipButton.Size = new System.Drawing.Size(75, 23);
			this.UnzipButton.TabIndex = 6;
			this.UnzipButton.Text = "Unzip";
			this.UnzipButton.UseVisualStyleBackColor = true;
			this.UnzipButton.Click += new System.EventHandler(this.UnzipButton_Click);
			// 
			// ModDirName
			// 
			this.ModDirName.Location = new System.Drawing.Point(338, 14);
			this.ModDirName.Name = "ModDirName";
			this.ModDirName.Size = new System.Drawing.Size(148, 20);
			this.ModDirName.TabIndex = 7;
			this.ModDirName.Text = "WeThePeople";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 450);
			this.Controls.Add(this.ModDirName);
			this.Controls.Add(this.UnzipButton);
			this.Controls.Add(this.FindCivButton);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.VersionList);
			this.Controls.Add(this.ActionLog);
			this.Controls.Add(this.RefreshButton);
			this.Name = "MainForm";
			this.Text = "Downloader";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.TextBox ActionLog;
		private System.Windows.Forms.ListBox VersionList;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button FindCivButton;
		private System.Windows.Forms.Button UnzipButton;
		private System.Windows.Forms.TextBox ModDirName;
	}
}

