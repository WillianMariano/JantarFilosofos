namespace JantarFilosofos
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
            this.components = new System.ComponentModel.Container();
            this.cmdExecutar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdExecutar
            // 
            this.cmdExecutar.Location = new System.Drawing.Point(186, 12);
            this.cmdExecutar.Name = "cmdExecutar";
            this.cmdExecutar.Size = new System.Drawing.Size(75, 23);
            this.cmdExecutar.TabIndex = 1;
            this.cmdExecutar.Text = "Executar";
            this.cmdExecutar.UseVisualStyleBackColor = true;
            this.cmdExecutar.Click += new System.EventHandler(this.cmdExecutar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(415, 277);
            this.listBox1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 348);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdExecutar);
            this.Name = "Form1";
            this.Text = "JantarFilosofos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdExecutar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

