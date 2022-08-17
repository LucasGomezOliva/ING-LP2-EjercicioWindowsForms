namespace ING_LP2_EjercicioWindowsForms
{
    partial class Form1
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
            this.lbl_Base = new System.Windows.Forms.Label();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.lbl_Radio = new System.Windows.Forms.Label();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxRadio = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.radioButtonRectangulo = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangulo = new System.Windows.Forms.RadioButton();
            this.radioButtonCirculo = new System.Windows.Forms.RadioButton();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Base
            // 
            this.lbl_Base.AutoSize = true;
            this.lbl_Base.Location = new System.Drawing.Point(97, 89);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(31, 13);
            this.lbl_Base.TabIndex = 0;
            this.lbl_Base.Text = "Base";
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Location = new System.Drawing.Point(97, 184);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_Altura.TabIndex = 1;
            this.lbl_Altura.Text = "Altura";
            // 
            // lbl_Radio
            // 
            this.lbl_Radio.AutoSize = true;
            this.lbl_Radio.Location = new System.Drawing.Point(97, 279);
            this.lbl_Radio.Name = "lbl_Radio";
            this.lbl_Radio.Size = new System.Drawing.Size(35, 13);
            this.lbl_Radio.TabIndex = 2;
            this.lbl_Radio.Text = "Radio";
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(231, 82);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxBase.TabIndex = 3;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(231, 177);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 4;
            // 
            // textBoxRadio
            // 
            this.textBoxRadio.Location = new System.Drawing.Point(231, 272);
            this.textBoxRadio.Name = "textBoxRadio";
            this.textBoxRadio.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadio.TabIndex = 5;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(231, 360);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 6;
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(101, 368);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(29, 13);
            this.lbl_Area.TabIndex = 7;
            this.lbl_Area.Text = "Area";
            // 
            // radioButtonRectangulo
            // 
            this.radioButtonRectangulo.AutoSize = true;
            this.radioButtonRectangulo.Location = new System.Drawing.Point(476, 87);
            this.radioButtonRectangulo.Name = "radioButtonRectangulo";
            this.radioButtonRectangulo.Size = new System.Drawing.Size(80, 17);
            this.radioButtonRectangulo.TabIndex = 8;
            this.radioButtonRectangulo.TabStop = true;
            this.radioButtonRectangulo.Text = "Rectangulo";
            this.radioButtonRectangulo.UseVisualStyleBackColor = true;
            this.radioButtonRectangulo.CheckedChanged += new System.EventHandler(this.radioButtonRectangulo_CheckedChanged);
            // 
            // radioButtonTriangulo
            // 
            this.radioButtonTriangulo.AutoSize = true;
            this.radioButtonTriangulo.Location = new System.Drawing.Point(476, 178);
            this.radioButtonTriangulo.Name = "radioButtonTriangulo";
            this.radioButtonTriangulo.Size = new System.Drawing.Size(69, 17);
            this.radioButtonTriangulo.TabIndex = 9;
            this.radioButtonTriangulo.TabStop = true;
            this.radioButtonTriangulo.Text = "Triangulo";
            this.radioButtonTriangulo.UseVisualStyleBackColor = true;
            this.radioButtonTriangulo.CheckedChanged += new System.EventHandler(this.radioButtonTriangulo_CheckedChanged);
            // 
            // radioButtonCirculo
            // 
            this.radioButtonCirculo.AutoSize = true;
            this.radioButtonCirculo.Location = new System.Drawing.Point(476, 277);
            this.radioButtonCirculo.Name = "radioButtonCirculo";
            this.radioButtonCirculo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCirculo.TabIndex = 10;
            this.radioButtonCirculo.TabStop = true;
            this.radioButtonCirculo.Text = "Circulo";
            this.radioButtonCirculo.UseVisualStyleBackColor = true;
            this.radioButtonCirculo.CheckedChanged += new System.EventHandler(this.radioButtonCirculo_CheckedChanged);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(481, 356);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 11;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.radioButtonCirculo);
            this.Controls.Add(this.radioButtonTriangulo);
            this.Controls.Add(this.radioButtonRectangulo);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxRadio);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.lbl_Radio);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.lbl_Base);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Base;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.Label lbl_Radio;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxRadio;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.RadioButton radioButtonRectangulo;
        private System.Windows.Forms.RadioButton radioButtonTriangulo;
        private System.Windows.Forms.RadioButton radioButtonCirculo;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

