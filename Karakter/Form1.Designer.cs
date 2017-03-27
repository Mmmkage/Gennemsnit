namespace WindowsFormsApplication1
{
    partial class Gennemsnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gennemsnit));
            this.buttonBeregnGns = new System.Windows.Forms.Button();
            this.textBoxDansk = new System.Windows.Forms.TextBox();
            this.labelGennemsnit = new System.Windows.Forms.Label();
            this.labelDansk = new System.Windows.Forms.Label();
            this.labelEngelsk = new System.Windows.Forms.Label();
            this.textBoxEngelsk = new System.Windows.Forms.TextBox();
            this.labelMatematik = new System.Windows.Forms.Label();
            this.textBoxMatematik = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButtonSyvTrin = new System.Windows.Forms.RadioButton();
            this.radioButtonTrettenSkala = new System.Windows.Forms.RadioButton();
            this.radioButtonECTSSkala = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBeregnGns
            // 
            this.buttonBeregnGns.Location = new System.Drawing.Point(197, 226);
            this.buttonBeregnGns.Name = "buttonBeregnGns";
            this.buttonBeregnGns.Size = new System.Drawing.Size(75, 23);
            this.buttonBeregnGns.TabIndex = 0;
            this.buttonBeregnGns.Text = "Beregn";
            this.buttonBeregnGns.UseVisualStyleBackColor = true;
            this.buttonBeregnGns.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDansk
            // 
            this.textBoxDansk.Location = new System.Drawing.Point(12, 25);
            this.textBoxDansk.Name = "textBoxDansk";
            this.textBoxDansk.Size = new System.Drawing.Size(100, 20);
            this.textBoxDansk.TabIndex = 1;
            // 
            // labelGennemsnit
            // 
            this.labelGennemsnit.AutoSize = true;
            this.labelGennemsnit.Location = new System.Drawing.Point(9, 226);
            this.labelGennemsnit.Name = "labelGennemsnit";
            this.labelGennemsnit.Size = new System.Drawing.Size(75, 13);
            this.labelGennemsnit.TabIndex = 2;
            this.labelGennemsnit.Text = "Gennemsnit er";
            // 
            // labelDansk
            // 
            this.labelDansk.AutoSize = true;
            this.labelDansk.Location = new System.Drawing.Point(9, 9);
            this.labelDansk.Name = "labelDansk";
            this.labelDansk.Size = new System.Drawing.Size(38, 13);
            this.labelDansk.TabIndex = 3;
            this.labelDansk.Text = "Dansk";
            // 
            // labelEngelsk
            // 
            this.labelEngelsk.AutoSize = true;
            this.labelEngelsk.Location = new System.Drawing.Point(9, 53);
            this.labelEngelsk.Name = "labelEngelsk";
            this.labelEngelsk.Size = new System.Drawing.Size(45, 13);
            this.labelEngelsk.TabIndex = 4;
            this.labelEngelsk.Text = "Engelsk";
            // 
            // textBoxEngelsk
            // 
            this.textBoxEngelsk.Location = new System.Drawing.Point(12, 69);
            this.textBoxEngelsk.Name = "textBoxEngelsk";
            this.textBoxEngelsk.Size = new System.Drawing.Size(100, 20);
            this.textBoxEngelsk.TabIndex = 5;
            // 
            // labelMatematik
            // 
            this.labelMatematik.AutoSize = true;
            this.labelMatematik.Location = new System.Drawing.Point(9, 97);
            this.labelMatematik.Name = "labelMatematik";
            this.labelMatematik.Size = new System.Drawing.Size(56, 13);
            this.labelMatematik.TabIndex = 6;
            this.labelMatematik.Text = "Matematik";
            // 
            // textBoxMatematik
            // 
            this.textBoxMatematik.Location = new System.Drawing.Point(12, 113);
            this.textBoxMatematik.Name = "textBoxMatematik";
            this.textBoxMatematik.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatematik.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButtonSyvTrin
            // 
            this.radioButtonSyvTrin.AutoSize = true;
            this.radioButtonSyvTrin.Checked = true;
            this.radioButtonSyvTrin.Location = new System.Drawing.Point(186, 13);
            this.radioButtonSyvTrin.Name = "radioButtonSyvTrin";
            this.radioButtonSyvTrin.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSyvTrin.TabIndex = 8;
            this.radioButtonSyvTrin.TabStop = true;
            this.radioButtonSyvTrin.Text = "7 trin skalaen";
            this.radioButtonSyvTrin.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrettenSkala
            // 
            this.radioButtonTrettenSkala.AutoSize = true;
            this.radioButtonTrettenSkala.Location = new System.Drawing.Point(186, 36);
            this.radioButtonTrettenSkala.Name = "radioButtonTrettenSkala";
            this.radioButtonTrettenSkala.Size = new System.Drawing.Size(77, 17);
            this.radioButtonTrettenSkala.TabIndex = 9;
            this.radioButtonTrettenSkala.Text = "13 skalaen";
            this.radioButtonTrettenSkala.UseVisualStyleBackColor = true;
            // 
            // radioButtonECTSSkala
            // 
            this.radioButtonECTSSkala.AutoSize = true;
            this.radioButtonECTSSkala.Location = new System.Drawing.Point(186, 59);
            this.radioButtonECTSSkala.Name = "radioButtonECTSSkala";
            this.radioButtonECTSSkala.Size = new System.Drawing.Size(93, 17);
            this.radioButtonECTSSkala.TabIndex = 10;
            this.radioButtonECTSSkala.Text = "ECTS skalaen";
            this.radioButtonECTSSkala.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(116, 226);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Nulstil";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Gennemsnit
            // 
            this.AcceptButton = this.buttonBeregnGns;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.radioButtonECTSSkala);
            this.Controls.Add(this.radioButtonTrettenSkala);
            this.Controls.Add(this.radioButtonSyvTrin);
            this.Controls.Add(this.textBoxMatematik);
            this.Controls.Add(this.labelMatematik);
            this.Controls.Add(this.textBoxEngelsk);
            this.Controls.Add(this.labelEngelsk);
            this.Controls.Add(this.labelDansk);
            this.Controls.Add(this.labelGennemsnit);
            this.Controls.Add(this.textBoxDansk);
            this.Controls.Add(this.buttonBeregnGns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gennemsnit";
            this.Text = "Gennemsnit beregner";
            this.Load += new System.EventHandler(this.Gennemsnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBeregnGns;
        private System.Windows.Forms.TextBox textBoxDansk;
        private System.Windows.Forms.Label labelGennemsnit;
        private System.Windows.Forms.Label labelDansk;
        private System.Windows.Forms.Label labelEngelsk;
        private System.Windows.Forms.TextBox textBoxEngelsk;
        private System.Windows.Forms.Label labelMatematik;
        private System.Windows.Forms.TextBox textBoxMatematik;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButtonSyvTrin;
        private System.Windows.Forms.RadioButton radioButtonTrettenSkala;
        private System.Windows.Forms.RadioButton radioButtonECTSSkala;
        private System.Windows.Forms.Button buttonReset;
    }
}

