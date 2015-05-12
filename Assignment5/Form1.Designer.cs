namespace Quiz
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
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.ques = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsvalue = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.GroupBox();
            this.Instructions = new System.Windows.Forms.Button();
            this.explain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.startagain = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Enabled = false;
            this.option1.Location = new System.Drawing.Point(35, 29);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(62, 17);
            this.option1.TabIndex = 0;
            this.option1.TabStop = true;
            this.option1.Text = "Option1";
            this.option1.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Enabled = false;
            this.option2.Location = new System.Drawing.Point(35, 52);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(62, 17);
            this.option2.TabIndex = 1;
            this.option2.TabStop = true;
            this.option2.Text = "Option2";
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Enabled = false;
            this.option3.Location = new System.Drawing.Point(35, 75);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(62, 17);
            this.option3.TabIndex = 2;
            this.option3.TabStop = true;
            this.option3.Text = "Option3";
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Enabled = false;
            this.option4.Location = new System.Drawing.Point(35, 98);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(62, 17);
            this.option4.TabIndex = 3;
            this.option4.TabStop = true;
            this.option4.Text = "Option4";
            this.option4.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Enabled = false;
            this.Submit.Location = new System.Drawing.Point(97, 278);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(50, 98);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(78, 17);
            this.question.TabIndex = 5;
            this.question.Text = "Question:";
            // 
            // ques
            // 
            this.ques.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ques.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ques.Location = new System.Drawing.Point(135, 98);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(426, 37);
            this.ques.TabIndex = 6;
            this.ques.Text = "Question";
            // 
            // Go
            // 
            this.Go.Enabled = false;
            this.Go.Location = new System.Drawing.Point(343, 36);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 7;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Points:";
            // 
            // pointsvalue
            // 
            this.pointsvalue.AutoSize = true;
            this.pointsvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsvalue.Location = new System.Drawing.Point(374, 295);
            this.pointsvalue.Name = "pointsvalue";
            this.pointsvalue.Size = new System.Drawing.Size(19, 20);
            this.pointsvalue.TabIndex = 9;
            this.pointsvalue.Text = "0";
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(222, 278);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // options
            // 
            this.options.Controls.Add(this.option4);
            this.options.Controls.Add(this.option3);
            this.options.Controls.Add(this.option2);
            this.options.Controls.Add(this.option1);
            this.options.Location = new System.Drawing.Point(97, 132);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(200, 130);
            this.options.TabIndex = 11;
            this.options.TabStop = false;
            this.options.Text = "Options:";
            // 
            // Instructions
            // 
            this.Instructions.Location = new System.Drawing.Point(455, 278);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(75, 23);
            this.Instructions.TabIndex = 12;
            this.Instructions.Text = "Instructions";
            this.Instructions.UseVisualStyleBackColor = true;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // explain
            // 
            this.explain.Cursor = System.Windows.Forms.Cursors.Default;
            this.explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explain.Location = new System.Drawing.Point(322, 158);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(208, 86);
            this.explain.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select a category:";
            // 
            // dropdown
            // 
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Items.AddRange(new object[] {
            "US States and Capitals",
            "Science",
            "Movies"});
            this.dropdown.Location = new System.Drawing.Point(149, 36);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(188, 21);
            this.dropdown.TabIndex = 15;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.dropdown_SelectedIndexChanged);
            // 
            // startagain
            // 
            this.startagain.Location = new System.Drawing.Point(424, 36);
            this.startagain.Name = "startagain";
            this.startagain.Size = new System.Drawing.Size(75, 23);
            this.startagain.TabIndex = 16;
            this.startagain.Text = "New Quiz";
            this.startagain.UseVisualStyleBackColor = true;
            this.startagain.Click += new System.EventHandler(this.startagain_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(50, 323);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 17;
            this.error.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(424, 66);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Exit Quiz";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 361);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.error);
            this.Controls.Add(this.startagain);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.options);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.pointsvalue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.question);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take a Quiz!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label ques;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pointsvalue;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.Button Instructions;
        private System.Windows.Forms.Label explain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Button startagain;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button Exit;
    }
}

