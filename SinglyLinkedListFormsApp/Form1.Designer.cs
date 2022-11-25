namespace SinglyLinkedListFormsApp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noTextBar = new System.Windows.Forms.TextBox();
            this.surNameTextBar = new System.Windows.Forms.TextBox();
            this.nameTextBar = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.RichTextBox();
            this.ListB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // noTextBar
            // 
            this.noTextBar.Location = new System.Drawing.Point(162, 173);
            this.noTextBar.Name = "noTextBar";
            this.noTextBar.Size = new System.Drawing.Size(107, 22);
            this.noTextBar.TabIndex = 16;
            // 
            // surNameTextBar
            // 
            this.surNameTextBar.Location = new System.Drawing.Point(162, 112);
            this.surNameTextBar.Name = "surNameTextBar";
            this.surNameTextBar.Size = new System.Drawing.Size(107, 22);
            this.surNameTextBar.TabIndex = 15;
            // 
            // nameTextBar
            // 
            this.nameTextBar.Location = new System.Drawing.Point(162, 56);
            this.nameTextBar.Name = "nameTextBar";
            this.nameTextBar.Size = new System.Drawing.Size(107, 22);
            this.nameTextBar.TabIndex = 14;
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(235, 307);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(346, 88);
            this.List.TabIndex = 13;
            this.List.Text = "";
            // 
            // ListB
            // 
            this.ListB.Location = new System.Drawing.Point(373, 253);
            this.ListB.Name = "ListB";
            this.ListB.Size = new System.Drawing.Size(82, 23);
            this.ListB.TabIndex = 12;
            this.ListB.Text = "SHOW";
            this.ListB.UseVisualStyleBackColor = true;
            this.ListB.Click += new System.EventHandler(this.Show);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 71);
            this.button2.TabIndex = 11;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 71);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noTextBar);
            this.Controls.Add(this.surNameTextBar);
            this.Controls.Add(this.nameTextBar);
            this.Controls.Add(this.List);
            this.Controls.Add(this.ListB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noTextBar;
        private System.Windows.Forms.TextBox surNameTextBar;
        private System.Windows.Forms.TextBox nameTextBar;
        private System.Windows.Forms.RichTextBox List;
        private System.Windows.Forms.Button ListB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

