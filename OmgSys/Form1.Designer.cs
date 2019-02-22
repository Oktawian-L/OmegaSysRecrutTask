namespace OmgSys
{
    partial class Form1
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
            this.numer1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numer2 = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.responseBox = new System.Windows.Forms.TextBox();
            this.oper = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Wynik = new System.Windows.Forms.Label();
            this.cOperBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cOperBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOperBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // numer1
            // 
            this.numer1.Location = new System.Drawing.Point(182, 22);
            this.numer1.Name = "numer1";
            this.numer1.Size = new System.Drawing.Size(100, 20);
            this.numer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liczba1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liczba2";
            // 
            // numer2
            // 
            this.numer2.Location = new System.Drawing.Point(182, 66);
            this.numer2.Name = "numer2";
            this.numer2.Size = new System.Drawing.Size(100, 20);
            this.numer2.TabIndex = 4;
            this.numer2.TextChanged += new System.EventHandler(this.handle_TextChanged);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(64, 184);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "Oblicz";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operacja";
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(182, 141);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(100, 20);
            this.responseBox.TabIndex = 10;
            // 
            // oper
            // 
            this.oper.FormattingEnabled = true;
            this.oper.Location = new System.Drawing.Point(182, 105);
            this.oper.Name = "oper";
            this.oper.Size = new System.Drawing.Size(100, 21);
            this.oper.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 222);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Generuj XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Location = new System.Drawing.Point(64, 147);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(37, 13);
            this.Wynik.TabIndex = 14;
            this.Wynik.Text = "Wynik";
            this.Wynik.Click += new System.EventHandler(this.label4_Click);
            // 
            // cOperBindingSource3
            // 
            this.cOperBindingSource3.DataSource = typeof(OmgSys.COper);
            // 
            // cOperBindingSource1
            // 
            this.cOperBindingSource1.DataSource = typeof(OmgSys.COper);
            // 
            // cOperBindingSource
            // 
            this.cOperBindingSource.DataSource = typeof(OmgSys.COper);
            // 
            // cOperBindingSource2
            // 
            this.cOperBindingSource2.DataSource = typeof(OmgSys.COper);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 447);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.oper);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.numer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOperBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox numer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numer2;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cOperBindingSource;
        private System.Windows.Forms.BindingSource cOperBindingSource1;
        private System.Windows.Forms.TextBox responseBox;
        private System.Windows.Forms.ComboBox oper;
        private System.Windows.Forms.BindingSource cOperBindingSource3;
        private System.Windows.Forms.BindingSource cOperBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Wynik;
    }
}

