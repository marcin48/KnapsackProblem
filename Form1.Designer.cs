namespace WinFormsApp1
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
            solve_btn = new Button();
            Seed = new TextBox();
            item_number = new TextBox();
            Capacity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            instance_box = new TextBox();
            result_box = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // solve_btn
            // 
            solve_btn.Location = new Point(83, 504);
            solve_btn.Margin = new Padding(4);
            solve_btn.Name = "solve_btn";
            solve_btn.Size = new Size(172, 57);
            solve_btn.TabIndex = 0;
            solve_btn.Text = "SOLVE";
            solve_btn.UseVisualStyleBackColor = true;
            solve_btn.Click += solve_btn_Click;
            // 
            // Seed
            // 
            Seed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Seed.Location = new Point(85, 95);
            Seed.Margin = new Padding(4);
            Seed.Multiline = true;
            Seed.Name = "Seed";
            Seed.Size = new Size(170, 46);
            Seed.TabIndex = 2;
            // 
            // item_number
            // 
            item_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            item_number.Location = new Point(85, 210);
            item_number.Margin = new Padding(4);
            item_number.Multiline = true;
            item_number.Name = "item_number";
            item_number.Size = new Size(170, 36);
            item_number.TabIndex = 3;
            // 
            // Capacity
            // 
            Capacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Capacity.Location = new Point(85, 308);
            Capacity.Margin = new Padding(4);
            Capacity.Multiline = true;
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(170, 36);
            Capacity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 5;
            label1.Text = "Seed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 6;
            label2.Text = "Number of items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 276);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 7;
            label3.Text = "Capacity";
            // 
            // instance_box
            // 
            instance_box.Location = new Point(364, 95);
            instance_box.Multiline = true;
            instance_box.Name = "instance_box";
            instance_box.ReadOnly = true;
            instance_box.ScrollBars = ScrollBars.Vertical;
            instance_box.Size = new Size(635, 306);
            instance_box.TabIndex = 10;
            // 
            // result_box
            // 
            result_box.Location = new Point(364, 467);
            result_box.Multiline = true;
            result_box.Name = "result_box";
            result_box.ReadOnly = true;
            result_box.Size = new Size(635, 187);
            result_box.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(916, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 12;
            label4.Text = "Instance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(935, 436);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 13;
            label5.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1092, 687);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(result_box);
            Controls.Add(instance_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Capacity);
            Controls.Add(item_number);
            Controls.Add(Seed);
            Controls.Add(solve_btn);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button solve_btn;
        private TextBox Seed;
        private TextBox item_number;
        private TextBox Capacity;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox instance_box;
        private TextBox result_box;
        private Label label4;
        private Label label5;
    }
}
