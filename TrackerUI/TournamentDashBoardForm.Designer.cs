
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
      this.createPrizeLabel = new System.Windows.Forms.Label();
      this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
      this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // createPrizeLabel
      // 
      this.createPrizeLabel.AutoSize = true;
      this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createPrizeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.createPrizeLabel.Location = new System.Drawing.Point(200, 32);
      this.createPrizeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.createPrizeLabel.Name = "createPrizeLabel";
      this.createPrizeLabel.Size = new System.Drawing.Size(295, 37);
      this.createPrizeLabel.TabIndex = 13;
      this.createPrizeLabel.Text = "Tournament Dashboard";
      // 
      // loadExistingTournamentDropDown
      // 
      this.loadExistingTournamentDropDown.FormattingEnabled = true;
      this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(213, 167);
      this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
      this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(268, 38);
      this.loadExistingTournamentDropDown.TabIndex = 20;
      // 
      // loadExistingTournamentLabel
      // 
      this.loadExistingTournamentLabel.AutoSize = true;
      this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.loadExistingTournamentLabel.Location = new System.Drawing.Point(244, 134);
      this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
      this.loadExistingTournamentLabel.Size = new System.Drawing.Size(207, 30);
      this.loadExistingTournamentLabel.TabIndex = 19;
      this.loadExistingTournamentLabel.Text = "Select Team Member";
      // 
      // TournamentDashboardForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(669, 610);
      this.Controls.Add(this.loadExistingTournamentDropDown);
      this.Controls.Add(this.loadExistingTournamentLabel);
      this.Controls.Add(this.createPrizeLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentDashboardForm";
      this.Text = "Tournament Dashboard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label createPrizeLabel;
    private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
    private System.Windows.Forms.Label loadExistingTournamentLabel;
  }
}