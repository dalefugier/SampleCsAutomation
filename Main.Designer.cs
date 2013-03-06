namespace TestRhinoAutomation
{
  partial class Main
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
      this.buttonRun = new System.Windows.Forms.Button();
      this.buttonShow = new System.Windows.Forms.Button();
      this.buttonOpen = new System.Windows.Forms.Button();
      this.buttonHide = new System.Windows.Forms.Button();
      this.buttonClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonRun
      // 
      this.buttonRun.Location = new System.Drawing.Point(12, 12);
      this.buttonRun.Name = "buttonRun";
      this.buttonRun.Size = new System.Drawing.Size(201, 23);
      this.buttonRun.TabIndex = 3;
      this.buttonRun.Text = "Run Rhino";
      this.buttonRun.UseVisualStyleBackColor = true;
      this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
      // 
      // buttonShow
      // 
      this.buttonShow.Location = new System.Drawing.Point(12, 42);
      this.buttonShow.Name = "buttonShow";
      this.buttonShow.Size = new System.Drawing.Size(201, 23);
      this.buttonShow.TabIndex = 4;
      this.buttonShow.Text = "Show Rhino";
      this.buttonShow.UseVisualStyleBackColor = true;
      this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
      // 
      // buttonOpen
      // 
      this.buttonOpen.Location = new System.Drawing.Point(12, 72);
      this.buttonOpen.Name = "buttonOpen";
      this.buttonOpen.Size = new System.Drawing.Size(203, 23);
      this.buttonOpen.TabIndex = 5;
      this.buttonOpen.Text = "Open...";
      this.buttonOpen.UseVisualStyleBackColor = true;
      this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
      // 
      // buttonHide
      // 
      this.buttonHide.Location = new System.Drawing.Point(13, 102);
      this.buttonHide.Name = "buttonHide";
      this.buttonHide.Size = new System.Drawing.Size(200, 23);
      this.buttonHide.TabIndex = 6;
      this.buttonHide.Text = "Hide Rhino";
      this.buttonHide.UseVisualStyleBackColor = true;
      this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
      // 
      // buttonClose
      // 
      this.buttonClose.Location = new System.Drawing.Point(13, 132);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(200, 23);
      this.buttonClose.TabIndex = 7;
      this.buttonClose.Text = "Close Rhino";
      this.buttonClose.UseVisualStyleBackColor = true;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(227, 173);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.buttonHide);
      this.Controls.Add(this.buttonOpen);
      this.Controls.Add(this.buttonShow);
      this.Controls.Add(this.buttonRun);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Main";
      this.Text = "TestRhinoAutomation";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonRun;
    private System.Windows.Forms.Button buttonShow;
    private System.Windows.Forms.Button buttonOpen;
    private System.Windows.Forms.Button buttonHide;
    private System.Windows.Forms.Button buttonClose;
  }
}

