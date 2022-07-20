namespace CloneBen
{
    partial class CloneBen
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
            this.components = new System.ComponentModel.Container();
            this.killEnemy = new System.Windows.Forms.Timer(this.components);
            this.showBen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // killEnemy
            // 
            this.killEnemy.Enabled = true;
            this.killEnemy.Interval = 200;
            this.killEnemy.Tick += new System.EventHandler(this.killEnemy_Tick);
            // 
            // showBen
            // 
            this.showBen.Enabled = true;
            this.showBen.Interval = 200;
            this.showBen.Tick += new System.EventHandler(this.showBen_Tick);
            // 
            // CloneBen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CloneBen.Properties.Resources.Ben1;
            this.ClientSize = new System.Drawing.Size(170, 294);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CloneBen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloneBen_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloneBen_MouseDown);
            this.MouseEnter += new System.EventHandler(this.CloneBen_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloneBen_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer killEnemy;
        private System.Windows.Forms.Timer showBen;
    }
}

