namespace LOIC
{
	partial class frmWtf
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
            this.SuspendLayout();
            // 
            // frmWtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LLOIC.Properties.Resources.what_the_fuck_are_you_doing_cripp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 445);
            this.ControlBox = false;
            this.Icon = global::LLOIC.Properties.Resources.LOIC_ICO;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWtf";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWtf_FormClosed);
            this.Click += new System.EventHandler(this.frmWtf_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmWtf_KeyDown);
            this.ResumeLayout(false);

		}

		#endregion
	}
}