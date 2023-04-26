namespace memo
{
    partial class GestionMemos
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
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMemo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Realizado = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(33, 39);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(159, 20);
            this.TxtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // TxtMemo
            // 
            this.TxtMemo.Location = new System.Drawing.Point(33, 100);
            this.TxtMemo.Name = "TxtMemo";
            this.TxtMemo.Size = new System.Drawing.Size(727, 273);
            this.TxtMemo.TabIndex = 2;
            this.TxtMemo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memo";
            // 
            // TxtFecha
            // 
            this.TxtFecha.AutoSize = true;
            this.TxtFecha.Location = new System.Drawing.Point(630, 46);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(37, 13);
            this.TxtFecha.TabIndex = 4;
            this.TxtFecha.Text = "Fecha";
            this.TxtFecha.Click += new System.EventHandler(this.txtFecha_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(577, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(672, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Realizado
            // 
            this.Realizado.AutoSize = true;
            this.Realizado.Enabled = false;
            this.Realizado.Location = new System.Drawing.Point(33, 389);
            this.Realizado.Name = "Realizado";
            this.Realizado.Size = new System.Drawing.Size(221, 17);
            this.Realizado.TabIndex = 7;
            this.Realizado.Text = "Marcar Como Realizado.. ( Se Archivara )";
            this.Realizado.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(218, 42);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(38, 13);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "labelId";
            this.labelId.Visible = false;
            // 
            // GestionMemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.Realizado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMemo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTitulo);
            this.Name = "GestionMemos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GestionMemos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TxtMemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox Realizado;
        private System.Windows.Forms.Label labelId;
    }
}