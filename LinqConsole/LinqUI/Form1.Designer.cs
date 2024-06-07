namespace LinqUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ComboBoxTodosAlunos = new ComboBox();
            label2 = new Label();
            NumericUpDownDisciplinasFeitas = new NumericUpDown();
            ButtonUpdate = new Button();
            label3 = new Label();
            ListBoxFiltro = new ListBox();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownDisciplinasFeitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 62);
            label1.Name = "label1";
            label1.Size = new Size(124, 16);
            label1.TabIndex = 0;
            label1.Text = "Todos os Alunos";
            // 
            // ComboBoxTodosAlunos
            // 
            ComboBoxTodosAlunos.FormattingEnabled = true;
            ComboBoxTodosAlunos.Location = new Point(56, 106);
            ComboBoxTodosAlunos.Name = "ComboBoxTodosAlunos";
            ComboBoxTodosAlunos.Size = new Size(229, 23);
            ComboBoxTodosAlunos.TabIndex = 1;
            ComboBoxTodosAlunos.SelectedIndexChanged += ComboBoxTodosAlunos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 232);
            label2.Name = "label2";
            label2.Size = new Size(139, 16);
            label2.TabIndex = 2;
            label2.Text = "Disciplinas Feitas :";
            // 
            // NumericUpDownDisciplinasFeitas
            // 
            NumericUpDownDisciplinasFeitas.Location = new Point(213, 232);
            NumericUpDownDisciplinasFeitas.Name = "NumericUpDownDisciplinasFeitas";
            NumericUpDownDisciplinasFeitas.Size = new Size(120, 23);
            NumericUpDownDisciplinasFeitas.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonUpdate.Location = new Point(56, 338);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(95, 35);
            ButtonUpdate.TabIndex = 4;
            ButtonUpdate.Text = "UPDATE";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(413, 62);
            label3.Name = "label3";
            label3.Size = new Size(119, 16);
            label3.TabIndex = 5;
            label3.Text = "Alunos Filtrados";
            // 
            // ListBoxFiltro
            // 
            ListBoxFiltro.FormattingEnabled = true;
            ListBoxFiltro.ItemHeight = 15;
            ListBoxFiltro.Location = new Point(413, 106);
            ListBoxFiltro.Name = "ListBoxFiltro";
            ListBoxFiltro.Size = new Size(362, 334);
            ListBoxFiltro.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxFiltro);
            Controls.Add(label3);
            Controls.Add(ButtonUpdate);
            Controls.Add(NumericUpDownDisciplinasFeitas);
            Controls.Add(label2);
            Controls.Add(ComboBoxTodosAlunos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownDisciplinasFeitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ComboBoxTodosAlunos;
        private Label label2;
        private NumericUpDown NumericUpDownDisciplinasFeitas;
        private Button ButtonUpdate;
        private Label label3;
        private ListBox ListBoxFiltro;
    }
}
