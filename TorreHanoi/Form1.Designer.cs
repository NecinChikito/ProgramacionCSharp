namespace TorreHanoi
{
    partial class Hanoi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInicio = new System.Windows.Forms.Button();
            this.comboInicio = new System.Windows.Forms.ComboBox();
            this.comboFinal = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnResolver = new System.Windows.Forms.Button();
            this.comboNumDiscos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = global::TorreHanoi.Properties.Resources.image_processing20210627_9645_gggjz1;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(12, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(129, 104);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // comboInicio
            // 
            this.comboInicio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboInicio.FormattingEnabled = true;
            this.comboInicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboInicio.Location = new System.Drawing.Point(147, 58);
            this.comboInicio.Name = "comboInicio";
            this.comboInicio.Size = new System.Drawing.Size(121, 21);
            this.comboInicio.TabIndex = 3;
            this.comboInicio.Text = "Torre inicial";
            this.comboInicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboFinal
            // 
            this.comboFinal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboFinal.FormattingEnabled = true;
            this.comboFinal.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboFinal.Location = new System.Drawing.Point(147, 95);
            this.comboFinal.Name = "comboFinal";
            this.comboFinal.Size = new System.Drawing.Size(121, 21);
            this.comboFinal.TabIndex = 4;
            this.comboFinal.Text = "Torre final";
            this.comboFinal.SelectedIndexChanged += new System.EventHandler(this.comboFinal_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 316);
            this.panel1.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::TorreHanoi.Properties.Resources.image_processing20210627_9645_r5owm1;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(566, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(266, 110);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.Transparent;
            this.btnResolver.BackgroundImage = global::TorreHanoi.Properties.Resources.image_processing20210627_9645_1xi0g58;
            this.btnResolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolver.FlatAppearance.BorderSize = 0;
            this.btnResolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.Location = new System.Drawing.Point(316, 12);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(244, 104);
            this.btnResolver.TabIndex = 0;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click_1);
            // 
            // comboNumDiscos
            // 
            this.comboNumDiscos.FormattingEnabled = true;
            this.comboNumDiscos.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.comboNumDiscos.Location = new System.Drawing.Point(147, 22);
            this.comboNumDiscos.Name = "comboNumDiscos";
            this.comboNumDiscos.Size = new System.Drawing.Size(121, 21);
            this.comboNumDiscos.TabIndex = 6;
            this.comboNumDiscos.Text = "Número de discos";
            this.comboNumDiscos.SelectedIndexChanged += new System.EventHandler(this.comboNumDiscos_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 90);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(276, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terminado!";
            this.label1.Visible = false;
            // 
            // Hanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = global::TorreHanoi.Properties.Resources.b9c8f893c9a782033a01f47e0c0b1d6e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.comboNumDiscos);
            this.Controls.Add(this.comboFinal);
            this.Controls.Add(this.comboInicio);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hanoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torre de hanoi";
            this.Load += new System.EventHandler(this.Hanoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboInicio;
        private System.Windows.Forms.ComboBox comboFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboNumDiscos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

