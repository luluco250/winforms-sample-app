namespace WinFormsSampleApp.Views
{
    partial class TaskListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLayout = new System.Windows.Forms.TableLayoutPanel();
            this._addButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this._taskList = new System.Windows.Forms.ListBox();
            this.buttonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLayout
            // 
            this.buttonLayout.AutoSize = true;
            this.buttonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLayout.ColumnCount = 2;
            this.buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayout.Controls.Add(this._addButton, 0, 0);
            this.buttonLayout.Controls.Add(this._removeButton, 0, 1);
            this.buttonLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.buttonLayout.Location = new System.Drawing.Point(0, 119);
            this.buttonLayout.Name = "buttonLayout";
            this.buttonLayout.RowCount = 1;
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayout.Size = new System.Drawing.Size(150, 31);
            this.buttonLayout.TabIndex = 1;
            // 
            // addButton
            // 
            this._addButton.AutoSize = true;
            this._addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addButton.Location = new System.Drawing.Point(3, 3);
            this._addButton.Name = "addButton";
            this._addButton.Size = new System.Drawing.Size(69, 25);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this._removeButton.AutoSize = true;
            this._removeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._removeButton.Enabled = false;
            this._removeButton.Location = new System.Drawing.Point(78, 3);
            this._removeButton.Name = "removeButton";
            this._removeButton.Size = new System.Drawing.Size(69, 25);
            this._removeButton.TabIndex = 1;
            this._removeButton.Text = "Remove";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // taskList
            // 
            this._taskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._taskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._taskList.FormattingEnabled = true;
            this._taskList.IntegralHeight = false;
            this._taskList.ItemHeight = 15;
            this._taskList.Location = new System.Drawing.Point(0, 0);
            this._taskList.Name = "taskList";
            this._taskList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._taskList.Size = new System.Drawing.Size(150, 119);
            this._taskList.TabIndex = 2;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._taskList);
            this.Controls.Add(this.buttonLayout);
            this.Name = "MainView";
            this.buttonLayout.ResumeLayout(false);
            this.buttonLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel buttonLayout;
        private Button _addButton;
        private Button _removeButton;
        private ListBox _taskList;
    }
}
