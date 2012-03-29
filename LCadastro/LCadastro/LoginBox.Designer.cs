namespace LCadastro
{
    partial class LoginBox
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lCadastroDBDataSet = new LCadastro.LCadastroDBDataSet();
            this.funcionarioTableAdapter = new LCadastro.LCadastroDBDataSetTableAdapters.FuncionarioTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCadastroDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSenha.Location = new System.Drawing.Point(77, 58);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(232, 20);
            this.textBoxSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.DataSource = this.funcionarioBindingSource;
            this.comboBoxFuncionario.DisplayMember = "first_name";
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(77, 25);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(232, 21);
            this.comboBoxFuncionario.TabIndex = 5;
            this.comboBoxFuncionario.ValueMember = "user";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.lCadastroDBDataSet;
            // 
            // lCadastroDBDataSet
            // 
            this.lCadastroDBDataSet.DataSetName = "LCadastroDBDataSet";
            this.lCadastroDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Funcionario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFuncionario);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSenha);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autenticar:";
            // 
            // LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 152);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "LoginBox";
            this.ShowIcon = false;
            this.Text = "LCadastro - Entrar";
            this.Load += new System.EventHandler(this.LoginBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCadastroDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private LCadastroDBDataSet lCadastroDBDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private LCadastroDBDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

