
namespace clack
{
    partial class Clack
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
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.fileButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.filePanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArea
            // 
            this.textArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.ForeColor = System.Drawing.SystemColors.Window;
            this.textArea.Location = new System.Drawing.Point(0, 21);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(1264, 660);
            this.textArea.TabIndex = 0;
            this.textArea.Text = "";
            this.textArea.Click += new System.EventHandler(this.textArea_Click);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.topPanel.Controls.Add(this.fileButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1264, 20);
            this.topPanel.TabIndex = 1;
            // 
            // fileButton
            // 
            this.fileButton.BackColor = System.Drawing.Color.Transparent;
            this.fileButton.FlatAppearance.BorderSize = 0;
            this.fileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.ForeColor = System.Drawing.Color.White;
            this.fileButton.Location = new System.Drawing.Point(0, 0);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(75, 20);
            this.fileButton.TabIndex = 2;
            this.fileButton.Text = "File";
            this.fileButton.UseVisualStyleBackColor = false;
            this.fileButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.openButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(0, 0);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(0, 45);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveAsButton.FlatAppearance.BorderSize = 0;
            this.saveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAsButton.ForeColor = System.Drawing.Color.White;
            this.saveAsButton.Location = new System.Drawing.Point(0, 23);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 1;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = false;
            this.saveAsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filePanel
            // 
            this.filePanel.BackColor = System.Drawing.Color.DarkGray;
            this.filePanel.Controls.Add(this.saveButton);
            this.filePanel.Controls.Add(this.openButton);
            this.filePanel.Controls.Add(this.saveAsButton);
            this.filePanel.Location = new System.Drawing.Point(0, 21);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(75, 68);
            this.filePanel.TabIndex = 3;
            this.filePanel.Visible = false;
            // 
            // Clack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.filePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.textArea);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Clack";
            this.Text = "Clack";
            this.Load += new System.EventHandler(this.Clack_Load);
            this.topPanel.ResumeLayout(false);
            this.filePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Panel filePanel;
    }
}

