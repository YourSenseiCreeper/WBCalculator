namespace WBCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.AutoSize = true;
            this.layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layout.ColumnCount = 5;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.Controls.Add(this.divide, 4, 3);
            this.layout.Controls.Add(this.clear, 4, 1);
            this.layout.Controls.Add(this.multiply, 4, 2);
            this.layout.Controls.Add(this.comma, 2, 4);
            this.layout.Controls.Add(this.plus, 3, 2);
            this.layout.Controls.Add(this.number0, 1, 4);
            this.layout.Controls.Add(this.plusminus, 0, 4);
            this.layout.Controls.Add(this.number1, 0, 1);
            this.layout.Controls.Add(this.calculate, 3, 4);
            this.layout.Controls.Add(this.number8, 1, 3);
            this.layout.Controls.Add(this.number9, 2, 3);
            this.layout.Controls.Add(this.minus, 3, 3);
            this.layout.Controls.Add(this.number7, 0, 3);
            this.layout.Controls.Add(this.number3, 2, 1);
            this.layout.Controls.Add(this.number4, 0, 2);
            this.layout.Controls.Add(this.number2, 1, 1);
            this.layout.Controls.Add(this.number6, 2, 2);
            this.layout.Controls.Add(this.number5, 1, 2);
            this.layout.Controls.Add(this.back, 3, 1);
            this.layout.Controls.Add(this.screen, 0, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 5;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.Size = new System.Drawing.Size(233, 278);
            this.layout.TabIndex = 0;
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divide.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divide.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.divide.Location = new System.Drawing.Point(184, 165);
            this.divide.Margin = new System.Windows.Forms.Padding(0);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(49, 55);
            this.divide.TabIndex = 19;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clear.Location = new System.Drawing.Point(184, 55);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(49, 55);
            this.clear.TabIndex = 18;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiply.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiply.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.multiply.Location = new System.Drawing.Point(184, 110);
            this.multiply.Margin = new System.Windows.Forms.Padding(0);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(49, 55);
            this.multiply.TabIndex = 17;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // comma
            // 
            this.comma.AutoSize = true;
            this.comma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comma.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.comma.Location = new System.Drawing.Point(92, 220);
            this.comma.Margin = new System.Windows.Forms.Padding(0);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(46, 58);
            this.comma.TabIndex = 16;
            this.comma.Text = ".";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.plus.Location = new System.Drawing.Point(138, 110);
            this.plus.Margin = new System.Windows.Forms.Padding(0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 55);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // number0
            // 
            this.number0.AutoSize = true;
            this.number0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number0.Font = new System.Drawing.Font("Arial", 14.25F);
            this.number0.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number0.Location = new System.Drawing.Point(46, 220);
            this.number0.Margin = new System.Windows.Forms.Padding(0);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(46, 58);
            this.number0.TabIndex = 13;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // plusminus
            // 
            this.plusminus.AutoSize = true;
            this.plusminus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusminus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusminus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.plusminus.Location = new System.Drawing.Point(0, 220);
            this.plusminus.Margin = new System.Windows.Forms.Padding(0);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(46, 58);
            this.plusminus.TabIndex = 12;
            this.plusminus.Text = "±";
            this.plusminus.UseVisualStyleBackColor = true;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number1.Location = new System.Drawing.Point(0, 55);
            this.number1.Margin = new System.Windows.Forms.Padding(0);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(46, 55);
            this.number1.TabIndex = 11;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // calculate
            // 
            this.calculate.AutoSize = true;
            this.calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculate.Font = new System.Drawing.Font("Arial", 14.25F);
            this.calculate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.calculate.Location = new System.Drawing.Point(138, 220);
            this.calculate.Margin = new System.Windows.Forms.Padding(0);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(46, 58);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // number8
            // 
            this.number8.AutoSize = true;
            this.number8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number8.Font = new System.Drawing.Font("Arial", 14.25F);
            this.number8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number8.Location = new System.Drawing.Point(46, 165);
            this.number8.Margin = new System.Windows.Forms.Padding(0);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(46, 55);
            this.number8.TabIndex = 9;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.AutoSize = true;
            this.number9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number9.Font = new System.Drawing.Font("Arial", 14.25F);
            this.number9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number9.Location = new System.Drawing.Point(92, 165);
            this.number9.Margin = new System.Windows.Forms.Padding(0);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(46, 55);
            this.number9.TabIndex = 8;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.minus.Location = new System.Drawing.Point(138, 165);
            this.minus.Margin = new System.Windows.Forms.Padding(0);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 55);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // number7
            // 
            this.number7.AutoSize = true;
            this.number7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.number7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number7.Location = new System.Drawing.Point(0, 165);
            this.number7.Margin = new System.Windows.Forms.Padding(0);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(46, 55);
            this.number7.TabIndex = 6;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number3
            // 
            this.number3.AutoSize = true;
            this.number3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number3.Location = new System.Drawing.Point(92, 55);
            this.number3.Margin = new System.Windows.Forms.Padding(0);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(46, 55);
            this.number3.TabIndex = 5;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.AutoSize = true;
            this.number4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number4.Location = new System.Drawing.Point(0, 110);
            this.number4.Margin = new System.Windows.Forms.Padding(0);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(46, 55);
            this.number4.TabIndex = 4;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number2.Location = new System.Drawing.Point(46, 55);
            this.number2.Margin = new System.Windows.Forms.Padding(0);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(46, 55);
            this.number2.TabIndex = 3;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number6
            // 
            this.number6.AutoSize = true;
            this.number6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.number6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number6.Location = new System.Drawing.Point(92, 110);
            this.number6.Margin = new System.Windows.Forms.Padding(0);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(46, 55);
            this.number6.TabIndex = 2;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number5
            // 
            this.number5.AutoSize = true;
            this.number5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.number5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number5.Location = new System.Drawing.Point(46, 110);
            this.number5.Margin = new System.Windows.Forms.Padding(0);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(46, 55);
            this.number5.TabIndex = 1;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.back.Location = new System.Drawing.Point(138, 55);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 55);
            this.back.TabIndex = 0;
            this.back.Text = "⬅";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // screen
            // 
            this.layout.SetColumnSpan(this.screen, 5);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.screen.Location = new System.Drawing.Point(5, 5);
            this.screen.Margin = new System.Windows.Forms.Padding(5);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(223, 39);
            this.screen.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 278);
            this.Controls.Add(this.layout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multiply;
    }
}

