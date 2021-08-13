﻿
namespace TrackerUI
{
  partial class TournamentDashboardForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
      this.TournamentDashboardLabel = new System.Windows.Forms.Label();
      this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
      this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
      this.LoadTournamentButton = new System.Windows.Forms.Button();
      this.createTournamentButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TournamentDashboardLabel
      // 
      this.TournamentDashboardLabel.AutoSize = true;
      this.TournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TournamentDashboardLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.TournamentDashboardLabel.Location = new System.Drawing.Point(196, 47);
      this.TournamentDashboardLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
      this.TournamentDashboardLabel.Size = new System.Drawing.Size(295, 37);
      this.TournamentDashboardLabel.TabIndex = 13;
      this.TournamentDashboardLabel.Text = "Tournament Dashboard";
      // 
      // loadExistingTournamentDropDown
      // 
      this.loadExistingTournamentDropDown.FormattingEnabled = true;
      this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(193, 188);
      this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
      this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(301, 38);
      this.loadExistingTournamentDropDown.TabIndex = 20;
      // 
      // loadExistingTournamentLabel
      // 
      this.loadExistingTournamentLabel.AutoSize = true;
      this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.loadExistingTournamentLabel.Location = new System.Drawing.Point(217, 155);
      this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
      this.loadExistingTournamentLabel.Size = new System.Drawing.Size(252, 30);
      this.loadExistingTournamentLabel.TabIndex = 19;
      this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
      // 
      // LoadTournamentButton
      // 
      this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LoadTournamentButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.LoadTournamentButton.Location = new System.Drawing.Point(207, 232);
      this.LoadTournamentButton.Name = "LoadTournamentButton";
      this.LoadTournamentButton.Size = new System.Drawing.Size(273, 41);
      this.LoadTournamentButton.TabIndex = 26;
      this.LoadTournamentButton.Text = "Load Tournament";
      this.LoadTournamentButton.UseVisualStyleBackColor = true;
      // 
      // createTournamentButton
      // 
      this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTournamentButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.createTournamentButton.Location = new System.Drawing.Point(207, 350);
      this.createTournamentButton.Name = "createTournamentButton";
      this.createTournamentButton.Size = new System.Drawing.Size(273, 41);
      this.createTournamentButton.TabIndex = 27;
      this.createTournamentButton.Text = "Create Tournament";
      this.createTournamentButton.UseVisualStyleBackColor = true;
      // 
      // TournamentDashboardForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(669, 497);
      this.Controls.Add(this.createTournamentButton);
      this.Controls.Add(this.LoadTournamentButton);
      this.Controls.Add(this.loadExistingTournamentDropDown);
      this.Controls.Add(this.loadExistingTournamentLabel);
      this.Controls.Add(this.TournamentDashboardLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentDashboardForm";
      this.Text = "Tournament Dashboard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label TournamentDashboardLabel;
    private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
    private System.Windows.Forms.Label loadExistingTournamentLabel;
    private System.Windows.Forms.Button LoadTournamentButton;
    private System.Windows.Forms.Button createTournamentButton;
  }
}