
namespace sorter
{
    partial class SortingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BogoSortRadioButton = new System.Windows.Forms.RadioButton();
            this.InsertSortRadioButton = new System.Windows.Forms.RadioButton();
            this.ShakerSortRadioButton = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.FileInputRadioButton = new System.Windows.Forms.RadioButton();
            this.RandomInputRadioButton = new System.Windows.Forms.RadioButton();
            this.HandleInputRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.AscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.start_sort_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VerticalLine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.BogoSortRadioButton);
            this.groupBox1.Controls.Add(this.InsertSortRadioButton);
            this.groupBox1.Controls.Add(this.ShakerSortRadioButton);
            this.groupBox1.Controls.Add(this.bubbleSortRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(20, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(269, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритм";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(191, 44);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // BogoSortRadioButton
            // 
            this.BogoSortRadioButton.AutoSize = true;
            this.BogoSortRadioButton.Location = new System.Drawing.Point(5, 102);
            this.BogoSortRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BogoSortRadioButton.Name = "BogoSortRadioButton";
            this.BogoSortRadioButton.Size = new System.Drawing.Size(70, 24);
            this.BogoSortRadioButton.TabIndex = 2;
            this.BogoSortRadioButton.TabStop = true;
            this.BogoSortRadioButton.Text = "Бого";
            this.BogoSortRadioButton.UseVisualStyleBackColor = true;
            this.BogoSortRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // InsertSortRadioButton
            // 
            this.InsertSortRadioButton.AutoSize = true;
            this.InsertSortRadioButton.Location = new System.Drawing.Point(5, 75);
            this.InsertSortRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertSortRadioButton.Name = "InsertSortRadioButton";
            this.InsertSortRadioButton.Size = new System.Drawing.Size(100, 24);
            this.InsertSortRadioButton.TabIndex = 2;
            this.InsertSortRadioButton.TabStop = true;
            this.InsertSortRadioButton.Text = "Вставка";
            this.InsertSortRadioButton.UseVisualStyleBackColor = true;
            this.InsertSortRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ShakerSortRadioButton
            // 
            this.ShakerSortRadioButton.AutoSize = true;
            this.ShakerSortRadioButton.Location = new System.Drawing.Point(5, 48);
            this.ShakerSortRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShakerSortRadioButton.Name = "ShakerSortRadioButton";
            this.ShakerSortRadioButton.Size = new System.Drawing.Size(93, 24);
            this.ShakerSortRadioButton.TabIndex = 2;
            this.ShakerSortRadioButton.TabStop = true;
            this.ShakerSortRadioButton.Text = "Шейкер";
            this.ShakerSortRadioButton.UseVisualStyleBackColor = true;
            this.ShakerSortRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // bubbleSortRadioButton
            // 
            this.bubbleSortRadioButton.AutoSize = true;
            this.bubbleSortRadioButton.Location = new System.Drawing.Point(5, 21);
            this.bubbleSortRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bubbleSortRadioButton.Name = "bubbleSortRadioButton";
            this.bubbleSortRadioButton.Size = new System.Drawing.Size(101, 24);
            this.bubbleSortRadioButton.TabIndex = 1;
            this.bubbleSortRadioButton.TabStop = true;
            this.bubbleSortRadioButton.Text = "Пузырек";
            this.bubbleSortRadioButton.UseVisualStyleBackColor = true;
            this.bubbleSortRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.FileInputRadioButton);
            this.groupBox2.Controls.Add(this.RandomInputRadioButton);
            this.groupBox2.Controls.Add(this.HandleInputRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(20, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(269, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Метод ввода";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(147, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ввод";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FileInputRadioButton
            // 
            this.FileInputRadioButton.AutoSize = true;
            this.FileInputRadioButton.Location = new System.Drawing.Point(5, 75);
            this.FileInputRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileInputRadioButton.Name = "FileInputRadioButton";
            this.FileInputRadioButton.Size = new System.Drawing.Size(76, 24);
            this.FileInputRadioButton.TabIndex = 2;
            this.FileInputRadioButton.TabStop = true;
            this.FileInputRadioButton.Text = "Файл";
            this.FileInputRadioButton.UseVisualStyleBackColor = true;
            // 
            // RandomInputRadioButton
            // 
            this.RandomInputRadioButton.AutoSize = true;
            this.RandomInputRadioButton.Location = new System.Drawing.Point(5, 48);
            this.RandomInputRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomInputRadioButton.Name = "RandomInputRadioButton";
            this.RandomInputRadioButton.Size = new System.Drawing.Size(122, 24);
            this.RandomInputRadioButton.TabIndex = 2;
            this.RandomInputRadioButton.TabStop = true;
            this.RandomInputRadioButton.Text = "Случайный";
            this.RandomInputRadioButton.UseVisualStyleBackColor = true;
            // 
            // HandleInputRadioButton
            // 
            this.HandleInputRadioButton.AutoSize = true;
            this.HandleInputRadioButton.Location = new System.Drawing.Point(5, 21);
            this.HandleInputRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HandleInputRadioButton.Name = "HandleInputRadioButton";
            this.HandleInputRadioButton.Size = new System.Drawing.Size(89, 24);
            this.HandleInputRadioButton.TabIndex = 1;
            this.HandleInputRadioButton.TabStop = true;
            this.HandleInputRadioButton.Text = "Ручной";
            this.HandleInputRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.DescendingRadioButton);
            this.groupBox3.Controls.Add(this.AscendingRadioButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(20, 234);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(269, 84);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Направление";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(191, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // DescendingRadioButton
            // 
            this.DescendingRadioButton.AutoSize = true;
            this.DescendingRadioButton.Location = new System.Drawing.Point(5, 48);
            this.DescendingRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescendingRadioButton.Name = "DescendingRadioButton";
            this.DescendingRadioButton.Size = new System.Drawing.Size(113, 24);
            this.DescendingRadioButton.TabIndex = 2;
            this.DescendingRadioButton.TabStop = true;
            this.DescendingRadioButton.Text = "Убывание";
            this.DescendingRadioButton.UseVisualStyleBackColor = true;
            this.DescendingRadioButton.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // AscendingRadioButton
            // 
            this.AscendingRadioButton.AutoSize = true;
            this.AscendingRadioButton.Location = new System.Drawing.Point(5, 21);
            this.AscendingRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AscendingRadioButton.Name = "AscendingRadioButton";
            this.AscendingRadioButton.Size = new System.Drawing.Size(140, 24);
            this.AscendingRadioButton.TabIndex = 1;
            this.AscendingRadioButton.TabStop = true;
            this.AscendingRadioButton.Text = "Возрастание";
            this.AscendingRadioButton.UseVisualStyleBackColor = true;
            this.AscendingRadioButton.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // start_sort_button
            // 
            this.start_sort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_sort_button.Location = new System.Drawing.Point(20, 432);
            this.start_sort_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_sort_button.Name = "start_sort_button";
            this.start_sort_button.Size = new System.Drawing.Size(147, 36);
            this.start_sort_button.TabIndex = 3;
            this.start_sort_button.Text = "Сортировка";
            this.start_sort_button.UseVisualStyleBackColor = true;
            this.start_sort_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(20, 473);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1084, 107);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1031, 432);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(400, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Алгоритмы сортировки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Параметры:";
            // 
            // VerticalLine
            // 
            this.VerticalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VerticalLine.Location = new System.Drawing.Point(296, 57);
            this.VerticalLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(4, 370);
            this.VerticalLine.TabIndex = 9;
            this.VerticalLine.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1088, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(307, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 359);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(20, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 593);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VerticalLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.start_sort_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SortingForm";
            this.Text = "Сортировка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BogoSortRadioButton;
        private System.Windows.Forms.RadioButton InsertSortRadioButton;
        private System.Windows.Forms.RadioButton ShakerSortRadioButton;
        private System.Windows.Forms.RadioButton bubbleSortRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FileInputRadioButton;
        private System.Windows.Forms.RadioButton RandomInputRadioButton;
        private System.Windows.Forms.RadioButton HandleInputRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton DescendingRadioButton;
        private System.Windows.Forms.RadioButton AscendingRadioButton;
        private System.Windows.Forms.Button start_sort_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VerticalLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}

