namespace ControlesAvanzados
{
    partial class FormularioProyecto
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 1;
            label1.Text = "Formulario de Nuevo Proyecto";
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 63);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(179, 34);
            button1.TabIndex = 2;
            button1.Text = "Crear Tarea";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormularioProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormularioProyecto";
            Text = "FormularioProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}