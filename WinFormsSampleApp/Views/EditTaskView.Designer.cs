namespace WinFormsSampleApp.Views
{
    partial class EditTaskView
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
            this._messageInput = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._buttonLayout = new System.Windows.Forms.TableLayoutPanel();
            this._cancelButton = new System.Windows.Forms.Button();
            this._buttonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // _messageInput
            // 
            this._messageInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this._messageInput.Location = new System.Drawing.Point(0, 0);
            this._messageInput.Multiline = true;
            this._messageInput.Name = "_messageInput";
            this._messageInput.PlaceholderText = "Enter your message here...";
            this._messageInput.Size = new System.Drawing.Size(150, 119);
            this._messageInput.TabIndex = 0;
            // 
            // _okButton
            // 
            this._okButton.AutoSize = true;
            this._okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._okButton.Enabled = false;
            this._okButton.Location = new System.Drawing.Point(3, 3);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(69, 25);
            this._okButton.TabIndex = 1;
            this._okButton.Text = "Ok";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _buttonLayout
            // 
            this._buttonLayout.AutoSize = true;
            this._buttonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonLayout.ColumnCount = 2;
            this._buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttonLayout.Controls.Add(this._okButton, 0, 0);
            this._buttonLayout.Controls.Add(this._cancelButton, 1, 0);
            this._buttonLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this._buttonLayout.Location = new System.Drawing.Point(0, 119);
            this._buttonLayout.Name = "_buttonLayout";
            this._buttonLayout.RowCount = 1;
            this._buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttonLayout.Size = new System.Drawing.Size(150, 31);
            this._buttonLayout.TabIndex = 2;
            // 
            // _cancelButton
            // 
            this._cancelButton.AutoSize = true;
            this._cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cancelButton.Location = new System.Drawing.Point(78, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(69, 25);
            this._cancelButton.TabIndex = 2;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._messageInput);
            this.Controls.Add(this._buttonLayout);
            this.Name = "EditTaskView";
            this._buttonLayout.ResumeLayout(false);
            this._buttonLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _messageInput;
        private Button _okButton;
        private TableLayoutPanel _buttonLayout;
        private Button _cancelButton;
    }
}
