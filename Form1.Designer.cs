namespace Calculadora
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
            tableLayoutPanel1 = new TableLayoutPanel();
            porcentagem = new Button();
            clearAll = new Button();
            clear = new Button();
            clearLastCase = new Button();
            number_7 = new Button();
            number_8 = new Button();
            number9 = new Button();
            divisao = new Button();
            number_6 = new Button();
            menos = new Button();
            number_3 = new Button();
            mais = new Button();
            igual = new Button();
            number_5 = new Button();
            number_2 = new Button();
            number_4 = new Button();
            number_1 = new Button();
            maisOuMenos = new Button();
            number_0 = new Button();
            ponto = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(43, 44, 45);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(porcentagem, 0, 0);
            tableLayoutPanel1.Controls.Add(clearAll, 1, 0);
            tableLayoutPanel1.Controls.Add(clear, 2, 0);
            tableLayoutPanel1.Controls.Add(clearLastCase, 3, 0);
            tableLayoutPanel1.Controls.Add(number_7, 0, 1);
            tableLayoutPanel1.Controls.Add(number_8, 1, 1);
            tableLayoutPanel1.Controls.Add(number9, 2, 1);
            tableLayoutPanel1.Controls.Add(divisao, 3, 1);
            tableLayoutPanel1.Controls.Add(number_6, 2, 2);
            tableLayoutPanel1.Controls.Add(menos, 3, 2);
            tableLayoutPanel1.Controls.Add(number_3, 2, 3);
            tableLayoutPanel1.Controls.Add(mais, 3, 3);
            tableLayoutPanel1.Controls.Add(igual, 3, 4);
            tableLayoutPanel1.Controls.Add(number_5, 1, 2);
            tableLayoutPanel1.Controls.Add(number_2, 1, 3);
            tableLayoutPanel1.Controls.Add(number_4, 0, 2);
            tableLayoutPanel1.Controls.Add(number_1, 0, 3);
            tableLayoutPanel1.Controls.Add(maisOuMenos, 0, 4);
            tableLayoutPanel1.Controls.Add(number_0, 1, 4);
            tableLayoutPanel1.Controls.Add(ponto, 2, 4);
            tableLayoutPanel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(0, 124);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(523, 476);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // porcentagem
            // 
            porcentagem.BackColor = Color.FromArgb(77, 85, 204);
            porcentagem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            porcentagem.ForeColor = Color.Black;
            porcentagem.Location = new Point(3, 3);
            porcentagem.Name = "porcentagem";
            porcentagem.Size = new Size(120, 89);
            porcentagem.TabIndex = 16;
            porcentagem.Text = "*";
            porcentagem.UseVisualStyleBackColor = false;
            porcentagem.Click += porcentagem_Click;
            // 
            // clearAll
            // 
            clearAll.BackColor = Color.FromArgb(255, 128, 128);
            clearAll.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            clearAll.Location = new Point(133, 3);
            clearAll.Name = "clearAll";
            clearAll.Size = new Size(120, 89);
            clearAll.TabIndex = 17;
            clearAll.Text = "CE";
            clearAll.UseVisualStyleBackColor = false;
            clearAll.Click += clearAll_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.White;
            clear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            clear.Location = new Point(263, 3);
            clear.Name = "clear";
            clear.Size = new Size(120, 89);
            clear.TabIndex = 18;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // clearLastCase
            // 
            clearLastCase.BackColor = Color.FromArgb(237, 71, 75);
            clearLastCase.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            clearLastCase.ForeColor = Color.Black;
            clearLastCase.Location = new Point(393, 3);
            clearLastCase.Name = "clearLastCase";
            clearLastCase.Size = new Size(118, 89);
            clearLastCase.TabIndex = 19;
            clearLastCase.Text = "<";
            clearLastCase.UseVisualStyleBackColor = false;
            clearLastCase.Click += clearLastCase_Click;
            // 
            // number_7
            // 
            number_7.BackColor = Color.FromArgb(77, 85, 204);
            number_7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_7.ForeColor = Color.Black;
            number_7.Location = new Point(3, 98);
            number_7.Name = "number_7";
            number_7.Size = new Size(120, 89);
            number_7.TabIndex = 12;
            number_7.Text = "7";
            number_7.UseVisualStyleBackColor = false;
            number_7.Click += number_7_Click;
            // 
            // number_8
            // 
            number_8.BackColor = Color.FromArgb(77, 85, 204);
            number_8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_8.ForeColor = Color.Black;
            number_8.Location = new Point(133, 98);
            number_8.Name = "number_8";
            number_8.Size = new Size(120, 89);
            number_8.TabIndex = 13;
            number_8.Text = "8";
            number_8.UseVisualStyleBackColor = false;
            number_8.Click += number_8_Click;
            // 
            // number9
            // 
            number9.BackColor = Color.FromArgb(77, 85, 204);
            number9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number9.ForeColor = Color.Black;
            number9.Location = new Point(263, 98);
            number9.Name = "number9";
            number9.Size = new Size(120, 89);
            number9.TabIndex = 14;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = false;
            number9.Click += number_9_Click;
            // 
            // divisao
            // 
            divisao.BackColor = Color.FromArgb(77, 85, 204);
            divisao.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            divisao.ForeColor = Color.Black;
            divisao.Location = new Point(393, 98);
            divisao.Name = "divisao";
            divisao.Size = new Size(118, 89);
            divisao.TabIndex = 15;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = false;
            divisao.Click += divisao_Click;
            // 
            // number_6
            // 
            number_6.BackColor = Color.FromArgb(77, 85, 204);
            number_6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            number_6.ForeColor = Color.Black;
            number_6.Location = new Point(263, 193);
            number_6.Name = "number_6";
            number_6.Size = new Size(120, 89);
            number_6.TabIndex = 10;
            number_6.Text = "6";
            number_6.UseVisualStyleBackColor = false;
            number_6.Click += number_6_Click;
            // 
            // menos
            // 
            menos.BackColor = Color.FromArgb(77, 85, 204);
            menos.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            menos.ForeColor = Color.Black;
            menos.Location = new Point(393, 193);
            menos.Name = "menos";
            menos.Size = new Size(118, 89);
            menos.TabIndex = 11;
            menos.Text = "-";
            menos.UseVisualStyleBackColor = false;
            menos.Click += menos_Click;
            // 
            // number_3
            // 
            number_3.BackColor = Color.FromArgb(77, 85, 204);
            number_3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_3.ForeColor = Color.Black;
            number_3.Location = new Point(263, 288);
            number_3.Name = "number_3";
            number_3.Size = new Size(120, 89);
            number_3.TabIndex = 6;
            number_3.Text = "3";
            number_3.UseVisualStyleBackColor = false;
            number_3.Click += number_3_Click;
            // 
            // mais
            // 
            mais.BackColor = Color.FromArgb(77, 85, 204);
            mais.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            mais.ForeColor = Color.Black;
            mais.Location = new Point(393, 288);
            mais.Name = "mais";
            mais.Size = new Size(118, 89);
            mais.TabIndex = 7;
            mais.Text = "+";
            mais.UseVisualStyleBackColor = false;
            mais.Click += mais_Click;
            // 
            // igual
            // 
            igual.BackColor = Color.FromArgb(213, 133, 36);
            igual.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            igual.Location = new Point(393, 383);
            igual.Name = "igual";
            igual.Size = new Size(118, 90);
            igual.TabIndex = 3;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += igual_Click;
            // 
            // number_5
            // 
            number_5.BackColor = Color.FromArgb(77, 85, 204);
            number_5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_5.ForeColor = Color.Black;
            number_5.Location = new Point(133, 193);
            number_5.Name = "number_5";
            number_5.Size = new Size(120, 89);
            number_5.TabIndex = 9;
            number_5.Text = "5";
            number_5.UseVisualStyleBackColor = false;
            number_5.Click += number_5_Click;
            // 
            // number_2
            // 
            number_2.BackColor = Color.FromArgb(77, 85, 204);
            number_2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_2.ForeColor = Color.Black;
            number_2.Location = new Point(133, 288);
            number_2.Name = "number_2";
            number_2.Size = new Size(120, 89);
            number_2.TabIndex = 5;
            number_2.Text = "2";
            number_2.UseVisualStyleBackColor = false;
            number_2.Click += number_2_Click;
            // 
            // number_4
            // 
            number_4.BackColor = Color.FromArgb(77, 85, 204);
            number_4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_4.ForeColor = Color.Black;
            number_4.Location = new Point(3, 193);
            number_4.Name = "number_4";
            number_4.Size = new Size(120, 89);
            number_4.TabIndex = 8;
            number_4.Text = "4";
            number_4.UseVisualStyleBackColor = false;
            number_4.Click += number_4_Click;
            // 
            // number_1
            // 
            number_1.BackColor = Color.FromArgb(77, 85, 204);
            number_1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_1.ForeColor = Color.Black;
            number_1.Location = new Point(3, 288);
            number_1.Name = "number_1";
            number_1.Size = new Size(120, 89);
            number_1.TabIndex = 4;
            number_1.Text = "1";
            number_1.UseVisualStyleBackColor = false;
            number_1.Click += number_1_Click;
            // 
            // maisOuMenos
            // 
            maisOuMenos.BackColor = Color.FromArgb(77, 85, 204);
            maisOuMenos.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            maisOuMenos.ForeColor = Color.Black;
            maisOuMenos.Location = new Point(3, 383);
            maisOuMenos.Name = "maisOuMenos";
            maisOuMenos.Size = new Size(120, 90);
            maisOuMenos.TabIndex = 0;
            maisOuMenos.Text = "+/-";
            maisOuMenos.UseVisualStyleBackColor = false;
            maisOuMenos.Click += maisOuMenos_Click;
            // 
            // number_0
            // 
            number_0.BackColor = Color.FromArgb(77, 85, 204);
            number_0.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            number_0.ForeColor = Color.Black;
            number_0.Location = new Point(133, 383);
            number_0.Name = "number_0";
            number_0.Size = new Size(120, 90);
            number_0.TabIndex = 1;
            number_0.Text = "0";
            number_0.UseVisualStyleBackColor = false;
            number_0.Click += number_0_Click;
            // 
            // ponto
            // 
            ponto.BackColor = Color.FromArgb(77, 85, 204);
            ponto.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            ponto.ForeColor = Color.Black;
            ponto.Location = new Point(263, 383);
            ponto.Name = "ponto";
            ponto.Size = new Size(120, 90);
            ponto.TabIndex = 2;
            ponto.Text = ".";
            ponto.UseVisualStyleBackColor = false;
            ponto.Click += ponto_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(234, 234, 234);
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(521, 92);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(234, 234, 234);
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(0, 91);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(521, 30);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.ForeColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(518, 121);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 600);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button clearLastCase;
        private Button clear;
        private Button clearAll;
        private Button porcentagem;
        private Button number_7;
        private Button number_8;
        private Button number9;
        private Button divisao;
        private Button number_6;
        private Button menos;
        private Button number_3;
        private Button mais;
        private Button igual;
        private Button number_5;
        private Button number_2;
        private Button number_4;
        private Button number_1;
        private Button maisOuMenos;
        private Button number_0;
        private Button ponto;
        private TextBox textBox1;
        private TextBox textBox2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
