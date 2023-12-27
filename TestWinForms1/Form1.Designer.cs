namespace TestWinForms1
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
            button1 = new Button();
            temp = new Label();
            descriptio = new Label();
            windSpeed = new Label();
            CityTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(268, 255);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 0;
            button1.Text = "Вывести информацию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // temp
            // 
            temp.Location = new Point(267, 99);
            temp.Name = "temp";
            temp.Size = new Size(277, 25);
            temp.TabIndex = 1;
            temp.Click += label1_Click;
            // 
            // descriptio
            // 
            descriptio.Location = new Point(268, 145);
            descriptio.Name = "descriptio";
            descriptio.Size = new Size(277, 25);
            descriptio.TabIndex = 2;
            descriptio.Click += label2_Click;
            // 
            // windSpeed
            // 
            windSpeed.Location = new Point(268, 195);
            windSpeed.Name = "windSpeed";
            windSpeed.Size = new Size(277, 25);
            windSpeed.TabIndex = 3;
            windSpeed.Click += label3_Click;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(268, 55);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 55);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "Введите город:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CityTextBox);
            Controls.Add(windSpeed);
            Controls.Add(descriptio);
            Controls.Add(temp);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label temp;
        private Label descriptio;
        private Label windSpeed;
        private TextBox CityTextBox;
        private Label label1;
    }
}
