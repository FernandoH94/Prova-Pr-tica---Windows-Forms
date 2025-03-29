namespace Prova_Prática___Windows_Forms
{
    partial class Cadastro
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
            label2 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            Lista = new ListView();
            Nome = new ColumnHeader();
            Telefone = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(38, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(152, 23);
            txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(38, 108);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(152, 23);
            txtTelefone.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(280, 411);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Lista
            // 
            Lista.Columns.AddRange(new ColumnHeader[] { Nome, Telefone });
            Lista.Location = new Point(53, 179);
            Lista.Name = "Lista";
            Lista.Size = new Size(256, 166);
            Lista.TabIndex = 5;
            Lista.UseCompatibleStateImageBehavior = false;
            Lista.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "nome";
            // 
            // Telefone
            // 
            Telefone.Text = "telefone";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 456);
            Controls.Add(Lista);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private ListView Lista;
        private ColumnHeader Nome;
        private ColumnHeader Telefone;
    }
}
