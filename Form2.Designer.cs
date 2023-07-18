
namespace Aula06Streaming
{
    partial class Form2
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
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.wvVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFundo
            // 
            this.imgFundo.Location = new System.Drawing.Point(4, 12);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(793, 434);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFundo.TabIndex = 0;
            this.imgFundo.TabStop = false;
            this.imgFundo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(22, 102);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(62, 16);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "TÍTULO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Assistir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(12, 244);
            this.lbldescricao.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(170, 16);
            this.lbldescricao.TabIndex = 5;
            this.lbldescricao.Text = "DESCRIÇÂO LONGA AQUI";
            this.lbldescricao.Click += new System.EventHandler(this.lbldescricao_Click);
            // 
            // wvVideo
            // 
            this.wvVideo.AllowExternalDrop = true;
            this.wvVideo.CreationProperties = null;
            this.wvVideo.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvVideo.Location = new System.Drawing.Point(4, 12);
            this.wvVideo.Name = "wvVideo";
            this.wvVideo.Size = new System.Drawing.Size(793, 434);
            this.wvVideo.TabIndex = 6;
            this.wvVideo.Visible = false;
            this.wvVideo.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wvVideo);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgFundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.PictureBox imgFundo;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvVideo;
    }
}