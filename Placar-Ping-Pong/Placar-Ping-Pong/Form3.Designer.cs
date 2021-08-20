
namespace Placar_Ping_Pong
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.jogador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sets1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sets2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDevBy = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(2, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(767, 61);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Registros";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.AllowUserToOrderColumns = true;
            this.dgLista.AllowUserToResizeColumns = false;
            this.dgLista.AllowUserToResizeRows = false;
            this.dgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLista.BackgroundColor = System.Drawing.Color.White;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jogador1,
            this.sets1,
            this.pontos1,
            this.pontos2,
            this.sets2,
            this.jogador2,
            this.data});
            this.dgLista.GridColor = System.Drawing.Color.White;
            this.dgLista.Location = new System.Drawing.Point(56, 85);
            this.dgLista.Name = "dgLista";
            this.dgLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(255)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(210)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLista.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(210)))), ((int)(((byte)(144)))));
            this.dgLista.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgLista.Size = new System.Drawing.Size(643, 331);
            this.dgLista.TabIndex = 2;
            // 
            // jogador1
            // 
            this.jogador1.HeaderText = "Jogador 1";
            this.jogador1.Name = "jogador1";
            // 
            // sets1
            // 
            this.sets1.HeaderText = "Sets 1";
            this.sets1.Name = "sets1";
            // 
            // pontos1
            // 
            this.pontos1.HeaderText = "Pontos 1";
            this.pontos1.Name = "pontos1";
            // 
            // pontos2
            // 
            this.pontos2.HeaderText = "Pontos 2";
            this.pontos2.Name = "pontos2";
            // 
            // sets2
            // 
            this.sets2.HeaderText = "Sets 2";
            this.sets2.Name = "sets2";
            // 
            // jogador2
            // 
            this.jogador2.HeaderText = "Jogador 2";
            this.jogador2.Name = "jogador2";
            // 
            // lbDevBy
            // 
            this.lbDevBy.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevBy.Location = new System.Drawing.Point(507, 473);
            this.lbDevBy.Name = "lbDevBy";
            this.lbDevBy.Size = new System.Drawing.Size(266, 25);
            this.lbDevBy.TabIndex = 29;
            this.lbDevBy.Text = "Developed by: Micael Miranda Inácio - 2020";
            this.lbDevBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(668, 431);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 39);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 493);
            this.Controls.Add(this.lbDevBy);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Label lbDevBy;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sets1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sets2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}