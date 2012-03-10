namespace RegExplore
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegEx = new System.Windows.Forms.TextBox();
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTemplates = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.labelMatchReplace = new System.Windows.Forms.Label();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMatchesCount = new System.Windows.Forms.Label();
            this.textBoxReplaceText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regular Expression";
            // 
            // textBoxRegEx
            // 
            this.textBoxRegEx.Location = new System.Drawing.Point(37, 49);
            this.textBoxRegEx.Multiline = true;
            this.textBoxRegEx.Name = "textBoxRegEx";
            this.textBoxRegEx.Size = new System.Drawing.Size(638, 20);
            this.textBoxRegEx.TabIndex = 1;
            // 
            // textBoxSample
            // 
            this.textBoxSample.Location = new System.Drawing.Point(37, 94);
            this.textBoxSample.Multiline = true;
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSample.Size = new System.Drawing.Size(638, 69);
            this.textBoxSample.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sample Text";
            // 
            // listBoxTemplates
            // 
            this.listBoxTemplates.DisplayMember = "value";
            this.listBoxTemplates.FormattingEnabled = true;
            this.listBoxTemplates.Location = new System.Drawing.Point(698, 49);
            this.listBoxTemplates.Name = "listBoxTemplates";
            this.listBoxTemplates.Size = new System.Drawing.Size(221, 420);
            this.listBoxTemplates.TabIndex = 4;
            this.listBoxTemplates.ValueMember = "key";
            this.listBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.listBoxTemplates_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Template";
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.Location = new System.Drawing.Point(37, 236);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(345, 186);
            this.listBoxMatches.TabIndex = 7;
            // 
            // labelMatchReplace
            // 
            this.labelMatchReplace.AutoSize = true;
            this.labelMatchReplace.Location = new System.Drawing.Point(34, 220);
            this.labelMatchReplace.Name = "labelMatchReplace";
            this.labelMatchReplace.Size = new System.Drawing.Size(48, 13);
            this.labelMatchReplace.TabIndex = 8;
            this.labelMatchReplace.Text = "Matches";
            // 
            // buttonMatch
            // 
            this.buttonMatch.Location = new System.Drawing.Point(600, 186);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(75, 23);
            this.buttonMatch.TabIndex = 9;
            this.buttonMatch.Text = "Match";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Matches";
            // 
            // labelMatchesCount
            // 
            this.labelMatchesCount.AutoSize = true;
            this.labelMatchesCount.Location = new System.Drawing.Point(473, 236);
            this.labelMatchesCount.Name = "labelMatchesCount";
            this.labelMatchesCount.Size = new System.Drawing.Size(13, 13);
            this.labelMatchesCount.TabIndex = 11;
            this.labelMatchesCount.Text = "0";
            // 
            // textBoxReplaceText
            // 
            this.textBoxReplaceText.Location = new System.Drawing.Point(37, 186);
            this.textBoxReplaceText.Multiline = true;
            this.textBoxReplaceText.Name = "textBoxReplaceText";
            this.textBoxReplaceText.Size = new System.Drawing.Size(449, 20);
            this.textBoxReplaceText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Replace Text";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(509, 186);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 14;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 514);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxReplaceText);
            this.Controls.Add(this.labelMatchesCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.labelMatchReplace);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBoxTemplates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSample);
            this.Controls.Add(this.textBoxRegEx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RegularExodus 360:  NET Framework Regular Expression Tester ";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegEx;
        private System.Windows.Forms.TextBox textBoxSample;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTemplates;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.Label labelMatchReplace;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMatchesCount;
        private System.Windows.Forms.TextBox textBoxReplaceText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

