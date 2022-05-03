namespace Tango_Inc.handover
{
    partial class TangoInc
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
            this.FindButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Initialise = new System.Windows.Forms.Button();
            this.ArrayBox = new System.Windows.Forms.ListBox();
            this.DeletButton = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.MidExtreme = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Range = new System.Windows.Forms.Button();
            this.SequentialSearch = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RangeBox = new System.Windows.Forms.TextBox();
            this.AverageBox = new System.Windows.Forms.TextBox();
            this.ModeBox = new System.Windows.Forms.TextBox();
            this.MidBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FindButton.Location = new System.Drawing.Point(165, 131);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(99, 23);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Search 1";
            this.ToolTip1.SetToolTip(this.FindButton, "Find a number in the using a binary search. (Must Sort)");
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InputBox.Location = new System.Drawing.Point(207, 208);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 26);
            this.InputBox.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.InputBox, "Use for Find, Add and sequential search. (displays selected items as well)");
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Location = new System.Drawing.Point(268, 179);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.ToolTip1.SetToolTip(this.AddButton, "Add/replace item to the list. (must delete a number and select 0)");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Initialise
            // 
            this.Initialise.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Initialise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Initialise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Initialise.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Initialise.Location = new System.Drawing.Point(12, 80);
            this.Initialise.Name = "Initialise";
            this.Initialise.Size = new System.Drawing.Size(139, 26);
            this.Initialise.TabIndex = 6;
            this.Initialise.Text = "Initialise";
            this.ToolTip1.SetToolTip(this.Initialise, "This button will display 24 numbers between 10-99 and ask if you want to sort the" +
        " data.");
            this.Initialise.UseVisualStyleBackColor = false;
            this.Initialise.Click += new System.EventHandler(this.Initilise_Click);
            // 
            // ArrayBox
            // 
            this.ArrayBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ArrayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ArrayBox.FormattingEnabled = true;
            this.ArrayBox.ItemHeight = 16;
            this.ArrayBox.Location = new System.Drawing.Point(12, 112);
            this.ArrayBox.Name = "ArrayBox";
            this.ArrayBox.Size = new System.Drawing.Size(139, 404);
            this.ArrayBox.TabIndex = 7;
            this.ToolTip1.SetToolTip(this.ArrayBox, "List box displays 24 random mutable numbers. (click initialise) (numbers can be s" +
        "orted)");
            this.ArrayBox.Click += new System.EventHandler(this.ArrayBox_Click);
            // 
            // DeletButton
            // 
            this.DeletButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeletButton.Location = new System.Drawing.Point(270, 131);
            this.DeletButton.Name = "DeletButton";
            this.DeletButton.Size = new System.Drawing.Size(99, 23);
            this.DeletButton.TabIndex = 8;
            this.DeletButton.Text = "Delete";
            this.ToolTip1.SetToolTip(this.DeletButton, "Delete selected item in list box.");
            this.DeletButton.UseVisualStyleBackColor = true;
            this.DeletButton.Click += new System.EventHandler(this.DeletButton_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BubbleSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BubbleSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubbleSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BubbleSort.Location = new System.Drawing.Point(198, 99);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(135, 26);
            this.BubbleSort.TabIndex = 10;
            this.BubbleSort.Text = "Sort";
            this.ToolTip1.SetToolTip(this.BubbleSort, "Sort the 24 numbers in the list box from smallest to largest.");
            this.BubbleSort.UseVisualStyleBackColor = false;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox1.Location = new System.Drawing.Point(175, 275);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(181, 32);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.Text = "Calculations";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.TextBox1, "sort before using");
            // 
            // MidExtreme
            // 
            this.MidExtreme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MidExtreme.Location = new System.Drawing.Point(175, 313);
            this.MidExtreme.Name = "MidExtreme";
            this.MidExtreme.Size = new System.Drawing.Size(101, 23);
            this.MidExtreme.TabIndex = 13;
            this.MidExtreme.Text = "Mid-Extreme";
            this.ToolTip1.SetToolTip(this.MidExtreme, "Finds mid-extreme of array. (must sort)");
            this.MidExtreme.UseVisualStyleBackColor = true;
            this.MidExtreme.Click += new System.EventHandler(this.Midextreme_Click);
            // 
            // Mode
            // 
            this.Mode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mode.Location = new System.Drawing.Point(175, 353);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(101, 23);
            this.Mode.TabIndex = 14;
            this.Mode.Text = "Mode";
            this.ToolTip1.SetToolTip(this.Mode, "Finds mode of array. (must sort)");
            this.Mode.UseVisualStyleBackColor = true;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // Average
            // 
            this.Average.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Average.Location = new System.Drawing.Point(175, 394);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(101, 23);
            this.Average.TabIndex = 15;
            this.Average.Text = "Average";
            this.ToolTip1.SetToolTip(this.Average, "Finds average of array. (must sort)");
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // Range
            // 
            this.Range.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Range.Location = new System.Drawing.Point(175, 433);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(101, 23);
            this.Range.TabIndex = 16;
            this.Range.Text = "Range";
            this.ToolTip1.SetToolTip(this.Range, "Finds Range of array. (must sort)");
            this.Range.UseVisualStyleBackColor = true;
            this.Range.Click += new System.EventHandler(this.Range_Click);
            // 
            // SequentialSearch
            // 
            this.SequentialSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SequentialSearch.Location = new System.Drawing.Point(165, 179);
            this.SequentialSearch.Name = "SequentialSearch";
            this.SequentialSearch.Size = new System.Drawing.Size(99, 23);
            this.SequentialSearch.TabIndex = 17;
            this.SequentialSearch.Text = "Search 2";
            this.ToolTip1.SetToolTip(this.SequentialSearch, "Search the data using a sequential search.");
            this.SequentialSearch.UseVisualStyleBackColor = true;
            this.SequentialSearch.Click += new System.EventHandler(this.SequentialSearch_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 531);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(379, 26);
            this.StatusStrip.TabIndex = 22;
            this.StatusStrip.Text = "StatusStrip";
            this.ToolTip1.SetToolTip(this.StatusStrip, "current program action status");
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(59, 21);
            this.StatusLabel.Text = "Status: ";
            // 
            // RangeBox
            // 
            this.RangeBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.RangeBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.RangeBox.Location = new System.Drawing.Point(282, 436);
            this.RangeBox.Name = "RangeBox";
            this.RangeBox.Size = new System.Drawing.Size(60, 20);
            this.RangeBox.TabIndex = 18;
            // 
            // AverageBox
            // 
            this.AverageBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.AverageBox.ForeColor = System.Drawing.SystemColors.Window;
            this.AverageBox.Location = new System.Drawing.Point(282, 397);
            this.AverageBox.Name = "AverageBox";
            this.AverageBox.Size = new System.Drawing.Size(60, 20);
            this.AverageBox.TabIndex = 19;
            // 
            // ModeBox
            // 
            this.ModeBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ModeBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ModeBox.Location = new System.Drawing.Point(282, 356);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(60, 20);
            this.ModeBox.TabIndex = 20;
            // 
            // MidBox
            // 
            this.MidBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MidBox.ForeColor = System.Drawing.SystemColors.Window;
            this.MidBox.Location = new System.Drawing.Point(282, 316);
            this.MidBox.Name = "MidBox";
            this.MidBox.Size = new System.Drawing.Size(60, 20);
            this.MidBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Astronomical Processing";
            // 
            // TangoInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(379, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MidBox);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.AverageBox);
            this.Controls.Add(this.RangeBox);
            this.Controls.Add(this.SequentialSearch);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.MidExtreme);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.DeletButton);
            this.Controls.Add(this.ArrayBox);
            this.Controls.Add(this.Initialise);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.FindButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "TangoInc";
            this.Text = "Tango Inc.";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Initialise;
        private System.Windows.Forms.ListBox ArrayBox;
        private System.Windows.Forms.Button DeletButton;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button MidExtreme;
        private System.Windows.Forms.Button Mode;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Range;
        private System.Windows.Forms.Button SequentialSearch;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.TextBox RangeBox;
        private System.Windows.Forms.TextBox AverageBox;
        private System.Windows.Forms.TextBox ModeBox;
        private System.Windows.Forms.TextBox MidBox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

