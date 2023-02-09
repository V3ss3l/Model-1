namespace Model_1
{
    partial class Form_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEndExpression = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrigExpression = new System.Windows.Forms.TextBox();
            this.buttonMastFunc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelEndExpression);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxOrigExpression);
            this.groupBox1.Controls.Add(this.buttonMastFunc);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 631);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Преобразование выражений к постфикскной форме";
            // 
            // labelEndExpression
            // 
            this.labelEndExpression.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEndExpression.Location = new System.Drawing.Point(11, 143);
            this.labelEndExpression.Name = "labelEndExpression";
            this.labelEndExpression.Size = new System.Drawing.Size(435, 23);
            this.labelEndExpression.TabIndex = 3;
            this.labelEndExpression.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходное выражение в инфиксной форме";
            // 
            // textBoxOrigExpression
            // 
            this.textBoxOrigExpression.Location = new System.Drawing.Point(11, 87);
            this.textBoxOrigExpression.Name = "textBoxOrigExpression";
            this.textBoxOrigExpression.Size = new System.Drawing.Size(435, 23);
            this.textBoxOrigExpression.TabIndex = 1;
            // 
            // buttonMastFunc
            // 
            this.buttonMastFunc.Location = new System.Drawing.Point(111, 22);
            this.buttonMastFunc.Name = "buttonMastFunc";
            this.buttonMastFunc.Size = new System.Drawing.Size(235, 31);
            this.buttonMastFunc.TabIndex = 0;
            this.buttonMastFunc.Text = "Задать выражение";
            this.buttonMastFunc.UseVisualStyleBackColor = true;
            this.buttonMastFunc.Click += new System.EventHandler(this.buttonMastFunc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результативное выражение";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(10, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(64, 275);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(80, 22);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 275);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(111, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(216, 315);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "СТЕК";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 693);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonMastFunc;
        private Label label1;
        private TextBox textBoxOrigExpression;
        private Label labelEndExpression;
        private GroupBox groupBox2;
        private ListView listView2;
        private ListView listView1;
        private Label label2;
    }
}