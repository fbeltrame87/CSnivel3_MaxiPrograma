namespace Gestor_de_Comercio_App
{
    partial class FormNuevoArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxImagenUrl = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.cboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.cboBoxMarca = new System.Windows.Forms.ComboBox();
            this.pBoxNuevaImagen = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblObligatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNuevaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre*";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 83);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(12, 110);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(58, 13);
            this.lblImagenUrl.TabIndex = 3;
            this.lblImagenUrl.Text = "Imagen Url";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 137);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(41, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio*";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 164);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 191);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(74, 26);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCodigo.TabIndex = 0;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(74, 53);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(74, 80);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtBoxDescripcion.TabIndex = 2;
            // 
            // txtBoxImagenUrl
            // 
            this.txtBoxImagenUrl.Location = new System.Drawing.Point(74, 107);
            this.txtBoxImagenUrl.Name = "txtBoxImagenUrl";
            this.txtBoxImagenUrl.Size = new System.Drawing.Size(121, 20);
            this.txtBoxImagenUrl.TabIndex = 3;
            this.txtBoxImagenUrl.Leave += new System.EventHandler(this.txtBoxImagenUrl_Leave);
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(74, 134);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPrecio.TabIndex = 4;
            // 
            // cboBoxCategoria
            // 
            this.cboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCategoria.FormattingEnabled = true;
            this.cboBoxCategoria.Location = new System.Drawing.Point(74, 160);
            this.cboBoxCategoria.Name = "cboBoxCategoria";
            this.cboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboBoxCategoria.TabIndex = 5;
            // 
            // cboBoxMarca
            // 
            this.cboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxMarca.FormattingEnabled = true;
            this.cboBoxMarca.Location = new System.Drawing.Point(74, 188);
            this.cboBoxMarca.Name = "cboBoxMarca";
            this.cboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.cboBoxMarca.TabIndex = 6;
            // 
            // pBoxNuevaImagen
            // 
            this.pBoxNuevaImagen.Location = new System.Drawing.Point(243, 26);
            this.pBoxNuevaImagen.Name = "pBoxNuevaImagen";
            this.pBoxNuevaImagen.Size = new System.Drawing.Size(189, 183);
            this.pBoxNuevaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxNuevaImagen.TabIndex = 14;
            this.pBoxNuevaImagen.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImagen.Location = new System.Drawing.Point(200, 107);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(37, 20);
            this.btnImagen.TabIndex = 15;
            this.btnImagen.Text = "+ img";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(73, 229);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(154, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.lblObligatorio.Location = new System.Drawing.Point(71, 213);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(106, 13);
            this.lblObligatorio.TabIndex = 16;
            this.lblObligatorio.Text = "(*) Campo Obligatorio";
            // 
            // FormNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(444, 257);
            this.Controls.Add(this.lblObligatorio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pBoxNuevaImagen);
            this.Controls.Add(this.cboBoxMarca);
            this.Controls.Add(this.cboBoxCategoria);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxImagenUrl);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormNuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.FormNuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNuevaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxImagenUrl;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.ComboBox cboBoxCategoria;
        private System.Windows.Forms.ComboBox cboBoxMarca;
        private System.Windows.Forms.PictureBox pBoxNuevaImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblObligatorio;
    }
}