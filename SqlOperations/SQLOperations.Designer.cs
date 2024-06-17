namespace SqlOperations
{
    partial class SQLOperations
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
            buttonSearch = new Button();
            buttonView = new Button();
            buttonprocedure = new Button();
            table1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)table1).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(53, 51);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonsearch_Click;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(202, 51);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(94, 29);
            buttonView.TabIndex = 1;
            buttonView.Text = "view";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += this.buttonview_Click;
            // 
            // buttonprocedure
            // 
            buttonprocedure.Location = new Point(337, 51);
            buttonprocedure.Name = "buttonprocedure";
            buttonprocedure.Size = new Size(94, 29);
            buttonprocedure.TabIndex = 2;
            buttonprocedure.Text = "procedure";
            buttonprocedure.UseVisualStyleBackColor = true;
            buttonprocedure.Click += this.buttonprocedure_Click;
            // 
            // table1
            // 
            table1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table1.Location = new Point(12, 199);
            table1.Name = "table1";
            table1.RowHeadersWidth = 51;
            table1.Size = new Size(550, 239);
            table1.TabIndex = 3;
            // 
            // SQLOperations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(table1);
            Controls.Add(buttonprocedure);
            Controls.Add(buttonView);
            Controls.Add(buttonSearch);
            Name = "SQLOperations";
            Text = "SQLOperations";
            ((System.ComponentModel.ISupportInitialize)table1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSearch;
        private Button buttonView;
        private Button buttonprocedure;
        private DataGridView table1;
    }
}
