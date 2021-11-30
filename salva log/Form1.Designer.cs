
namespace salva_log
{
    partial class form12
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lb3timer = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bttps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar Logs Diários";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salvar Logs Geral";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Location = new System.Drawing.Point(40, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Lime;
            this.lbl2.Location = new System.Drawing.Point(113, 430);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 76);
            this.lbl2.TabIndex = 4;
            // 
            // lb3timer
            // 
            this.lb3timer.AutoSize = true;
            this.lb3timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3timer.Location = new System.Drawing.Point(697, 213);
            this.lb3timer.Name = "lb3timer";
            this.lb3timer.Size = new System.Drawing.Size(79, 36);
            this.lb3timer.TabIndex = 5;
            this.lb3timer.Text = "Hora";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata.Location = new System.Drawing.Point(697, 325);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(76, 36);
            this.lbdata.TabIndex = 6;
            this.lbdata.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "soft.teste 1.0.0v";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btz
            // 
            this.btz.BackColor = System.Drawing.SystemColors.Control;
            this.btz.BackgroundImage = global::salva_log.Properties.Resources.xdd;
            this.btz.Location = new System.Drawing.Point(279, 59);
            this.btz.Name = "btz";
            this.btz.Size = new System.Drawing.Size(376, 352);
            this.btz.TabIndex = 9;
            this.btz.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Grave Imei";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImage = global::salva_log.Properties.Resources.xdds;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(749, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 106);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttps
            // 
            this.bttps.AutoSize = true;
            this.bttps.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttps.Location = new System.Drawing.Point(732, 134);
            this.bttps.Name = "bttps";
            this.bttps.Size = new System.Drawing.Size(140, 36);
            this.bttps.TabIndex = 12;
            this.bttps.Text = " Tps Tool";
            this.bttps.Click += new System.EventHandler(this.bttps_Click);
            // 
            // form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::salva_log.Properties.Resources.xd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(945, 518);
            this.Controls.Add(this.bttps);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbdata);
            this.Controls.Add(this.lb3timer);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "form12";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lb3timer;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label bttps;
    }
}

