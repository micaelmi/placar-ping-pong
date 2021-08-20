
namespace Placar_Ping_Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.English = new System.Windows.Forms.PictureBox();
            this.Brasil = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lbDevBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.English)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brasil)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(50, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(605, 61);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Table Tennis Scoreboard";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 390);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // English
            // 
            this.English.Image = global::Placar_Ping_Pong.Properties.Resources.united_states;
            this.English.Location = new System.Drawing.Point(659, 180);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(39, 37);
            this.English.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.English.TabIndex = 24;
            this.English.TabStop = false;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Brasil
            // 
            this.Brasil.Image = global::Placar_Ping_Pong.Properties.Resources.brazil1;
            this.Brasil.Location = new System.Drawing.Point(659, 223);
            this.Brasil.Name = "Brasil";
            this.Brasil.Size = new System.Drawing.Size(39, 37);
            this.Brasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Brasil.TabIndex = 25;
            this.Brasil.TabStop = false;
            this.Brasil.Click += new System.EventHandler(this.Brasil_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(610, 418);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 39);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // lbDevBy
            // 
            this.lbDevBy.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevBy.Location = new System.Drawing.Point(449, 460);
            this.lbDevBy.Name = "lbDevBy";
            this.lbDevBy.Size = new System.Drawing.Size(266, 25);
            this.lbDevBy.TabIndex = 27;
            this.lbDevBy.Text = "Developed by: Micael Miranda Inácio - 2020";
            this.lbDevBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.lbDevBy);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.Brasil);
            this.Controls.Add(this.English);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.English)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brasil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox English;
        private System.Windows.Forms.PictureBox Brasil;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lbDevBy;
    }
}