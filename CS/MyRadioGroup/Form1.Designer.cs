namespace GridProject
{
    partial class Form1
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
            this.myRadioGroup1 = new EditorDescendant.MyRadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.myRadioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myRadioGroup1
            // 
            this.myRadioGroup1.Location = new System.Drawing.Point(12, 12);
            this.myRadioGroup1.Name = "myRadioGroup1";
            this.myRadioGroup1.Properties.AllowHtmlString = true;
            this.myRadioGroup1.Properties.Appearance.Options.UseTextOptions = true;
            this.myRadioGroup1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.myRadioGroup1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.myRadioGroup1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.myRadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "<size=14>Some text <br> <size=12>Some text<br><br> <size=10>Some text<br>"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "<size=14>Some text <br> <size=12>Some text<br><br> <size=10>Some text<br>"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "<size=14>Some text <br> <size=12>Some text<br><br> <size=10>Some text<br>")});
            this.myRadioGroup1.Properties.MinItemHeight = 100;
            this.myRadioGroup1.Size = new System.Drawing.Size(577, 560);
            this.myRadioGroup1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 584);
            this.Controls.Add(this.myRadioGroup1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myRadioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EditorDescendant.MyRadioGroup myRadioGroup1;


    }
}

