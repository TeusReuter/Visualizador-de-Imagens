
namespace VisualizadorImagens
{
    partial class VisualizadorImagens
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.checkBoxEsticar = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnBackground = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxEsticar, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-5, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1042, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSelecionar);
            this.flowLayoutPanel1.Controls.Add(this.btnLimpar);
            this.flowLayoutPanel1.Controls.Add(this.btnBackground);
            this.flowLayoutPanel1.Controls.Add(this.btnFechar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(160, 429);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(885, 42);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(3, 3);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(115, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar Imagem";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(124, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar Imagem";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(370, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(127, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // checkBoxEsticar
            // 
            this.checkBoxEsticar.AutoSize = true;
            this.checkBoxEsticar.Location = new System.Drawing.Point(3, 429);
            this.checkBoxEsticar.Name = "checkBoxEsticar";
            this.checkBoxEsticar.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEsticar.TabIndex = 2;
            this.checkBoxEsticar.Text = "checkBox1";
            this.checkBoxEsticar.UseVisualStyleBackColor = true;
            this.checkBoxEsticar.CheckedChanged += new System.EventHandler(this.checkBoxEsticar_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(245, 3);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(119, 23);
            this.btnBackground.TabIndex = 1;
            this.btnBackground.Text = "Cor de Fundo";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // VisualizadorImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 477);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VisualizadorImagens";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.CheckBox checkBoxEsticar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnBackground;
    }
}

