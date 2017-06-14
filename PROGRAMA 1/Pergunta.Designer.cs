namespace PROGRAMA_1
{
    partial class Pergunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta));
            this.Iniciação = new System.Windows.Forms.Button();
            this.Planejamento = new System.Windows.Forms.Button();
            this.Execução = new System.Windows.Forms.Button();
            this.Monitoramento = new System.Windows.Forms.Button();
            this.Finalização = new System.Windows.Forms.Button();
            this.Questão = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Iniciação
            // 
            this.Iniciação.BackColor = System.Drawing.Color.White;
            this.Iniciação.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciação.Location = new System.Drawing.Point(316, 173);
            this.Iniciação.Name = "Iniciação";
            this.Iniciação.Size = new System.Drawing.Size(289, 52);
            this.Iniciação.TabIndex = 0;
            this.Iniciação.Text = "Iniciação";
            this.Iniciação.UseVisualStyleBackColor = false;
            this.Iniciação.Click += new System.EventHandler(this.Iniciação_Click);
            // 
            // Planejamento
            // 
            this.Planejamento.BackColor = System.Drawing.Color.White;
            this.Planejamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Planejamento.Location = new System.Drawing.Point(316, 231);
            this.Planejamento.Name = "Planejamento";
            this.Planejamento.Size = new System.Drawing.Size(289, 52);
            this.Planejamento.TabIndex = 1;
            this.Planejamento.Text = "Planejamento";
            this.Planejamento.UseVisualStyleBackColor = false;
            this.Planejamento.Click += new System.EventHandler(this.Planejamento_Click);
            // 
            // Execução
            // 
            this.Execução.BackColor = System.Drawing.Color.White;
            this.Execução.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execução.Location = new System.Drawing.Point(316, 289);
            this.Execução.Name = "Execução";
            this.Execução.Size = new System.Drawing.Size(289, 52);
            this.Execução.TabIndex = 2;
            this.Execução.Text = "Execução";
            this.Execução.UseVisualStyleBackColor = false;
            this.Execução.Click += new System.EventHandler(this.Execução_Click);
            // 
            // Monitoramento
            // 
            this.Monitoramento.BackColor = System.Drawing.Color.White;
            this.Monitoramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitoramento.Location = new System.Drawing.Point(316, 347);
            this.Monitoramento.Name = "Monitoramento";
            this.Monitoramento.Size = new System.Drawing.Size(289, 52);
            this.Monitoramento.TabIndex = 3;
            this.Monitoramento.Text = "Monitoramento e controle";
            this.Monitoramento.UseVisualStyleBackColor = false;
            this.Monitoramento.Click += new System.EventHandler(this.Monitoramento_Click);
            // 
            // Finalização
            // 
            this.Finalização.BackColor = System.Drawing.Color.White;
            this.Finalização.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalização.Location = new System.Drawing.Point(316, 405);
            this.Finalização.Name = "Finalização";
            this.Finalização.Size = new System.Drawing.Size(289, 52);
            this.Finalização.TabIndex = 4;
            this.Finalização.Text = "Finalização";
            this.Finalização.UseVisualStyleBackColor = false;
            this.Finalização.Click += new System.EventHandler(this.Finalização_Click);
            // 
            // Questão
            // 
            this.Questão.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Questão.Location = new System.Drawing.Point(237, 463);
            this.Questão.Name = "Questão";
            this.Questão.Size = new System.Drawing.Size(448, 52);
            this.Questão.TabIndex = 5;
            this.Questão.Text = "Próxima questão";
            this.Questão.UseVisualStyleBackColor = true;
            this.Questão.Click += new System.EventHandler(this.Questão_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 92);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pergunta 1";
            // 
            // Pergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Questão);
            this.Controls.Add(this.Finalização);
            this.Controls.Add(this.Monitoramento);
            this.Controls.Add(this.Execução);
            this.Controls.Add(this.Planejamento);
            this.Controls.Add(this.Iniciação);
            this.Name = "Pergunta";
            this.Text = "Pergunta1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iniciação;
        private System.Windows.Forms.Button Planejamento;
        private System.Windows.Forms.Button Execução;
        private System.Windows.Forms.Button Monitoramento;
        private System.Windows.Forms.Button Finalização;
        private System.Windows.Forms.Button Questão;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}