
namespace CK2_Extended_Millennia
{
    partial class FileConfig
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
            this.GroupBoxDefineDates = new System.Windows.Forms.GroupBox();
            this.ModNameTextBox = new System.Windows.Forms.TextBox();
            this.ModNameLabel = new System.Windows.Forms.Label();
            this.DefineDatesSaveButton = new System.Windows.Forms.Button();
            this.GameModPathTextBox = new System.Windows.Forms.TextBox();
            this.BuildModPathTextBox = new System.Windows.Forms.TextBox();
            this.GameModLabel = new System.Windows.Forms.Label();
            this.BuildModPathLabel = new System.Windows.Forms.Label();
            this.GamePathLabel = new System.Windows.Forms.Label();
            this.GamePathTextBox = new System.Windows.Forms.TextBox();
            this.GroupBoxDefineDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxDefineDates
            // 
            this.GroupBoxDefineDates.Controls.Add(this.ModNameTextBox);
            this.GroupBoxDefineDates.Controls.Add(this.ModNameLabel);
            this.GroupBoxDefineDates.Controls.Add(this.DefineDatesSaveButton);
            this.GroupBoxDefineDates.Controls.Add(this.GameModPathTextBox);
            this.GroupBoxDefineDates.Controls.Add(this.BuildModPathTextBox);
            this.GroupBoxDefineDates.Controls.Add(this.GameModLabel);
            this.GroupBoxDefineDates.Controls.Add(this.BuildModPathLabel);
            this.GroupBoxDefineDates.Controls.Add(this.GamePathLabel);
            this.GroupBoxDefineDates.Controls.Add(this.GamePathTextBox);
            this.GroupBoxDefineDates.Location = new System.Drawing.Point(74, 54);
            this.GroupBoxDefineDates.Name = "GroupBoxDefineDates";
            this.GroupBoxDefineDates.Size = new System.Drawing.Size(312, 327);
            this.GroupBoxDefineDates.TabIndex = 2;
            this.GroupBoxDefineDates.TabStop = false;
            this.GroupBoxDefineDates.Enter += new System.EventHandler(this.GroupBoxDefineDates_Enter);
            // 
            // ModNameTextBox
            // 
            this.ModNameTextBox.Location = new System.Drawing.Point(114, 188);
            this.ModNameTextBox.Name = "ModNameTextBox";
            this.ModNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.ModNameTextBox.TabIndex = 8;
            // 
            // ModNameLabel
            // 
            this.ModNameLabel.AutoSize = true;
            this.ModNameLabel.Location = new System.Drawing.Point(21, 191);
            this.ModNameLabel.Name = "ModNameLabel";
            this.ModNameLabel.Size = new System.Drawing.Size(59, 13);
            this.ModNameLabel.TabIndex = 7;
            this.ModNameLabel.Text = "Mod Name";
            // 
            // DefineDatesSaveButton
            // 
            this.DefineDatesSaveButton.Location = new System.Drawing.Point(77, 234);
            this.DefineDatesSaveButton.Name = "DefineDatesSaveButton";
            this.DefineDatesSaveButton.Size = new System.Drawing.Size(150, 37);
            this.DefineDatesSaveButton.TabIndex = 6;
            this.DefineDatesSaveButton.Text = "Guardar Cambiios";
            this.DefineDatesSaveButton.UseVisualStyleBackColor = true;
            // 
            // GameModPathTextBox
            // 
            this.GameModPathTextBox.Location = new System.Drawing.Point(114, 142);
            this.GameModPathTextBox.Name = "GameModPathTextBox";
            this.GameModPathTextBox.Size = new System.Drawing.Size(135, 20);
            this.GameModPathTextBox.TabIndex = 5;
            // 
            // BuildModPathTextBox
            // 
            this.BuildModPathTextBox.Location = new System.Drawing.Point(114, 87);
            this.BuildModPathTextBox.Name = "BuildModPathTextBox";
            this.BuildModPathTextBox.Size = new System.Drawing.Size(135, 20);
            this.BuildModPathTextBox.TabIndex = 4;
            // 
            // GameModLabel
            // 
            this.GameModLabel.AutoSize = true;
            this.GameModLabel.Location = new System.Drawing.Point(21, 142);
            this.GameModLabel.Name = "GameModLabel";
            this.GameModLabel.Size = new System.Drawing.Size(84, 13);
            this.GameModLabel.TabIndex = 3;
            this.GameModLabel.Text = "Game Mod Path";
            // 
            // BuildModPathLabel
            // 
            this.BuildModPathLabel.AutoSize = true;
            this.BuildModPathLabel.Location = new System.Drawing.Point(21, 87);
            this.BuildModPathLabel.Name = "BuildModPathLabel";
            this.BuildModPathLabel.Size = new System.Drawing.Size(79, 13);
            this.BuildModPathLabel.TabIndex = 2;
            this.BuildModPathLabel.Text = "Build Mod Path";
            // 
            // GamePathLabel
            // 
            this.GamePathLabel.AutoSize = true;
            this.GamePathLabel.Location = new System.Drawing.Point(21, 38);
            this.GamePathLabel.Name = "GamePathLabel";
            this.GamePathLabel.Size = new System.Drawing.Size(60, 13);
            this.GamePathLabel.TabIndex = 1;
            this.GamePathLabel.Text = "Game Path";
            // 
            // GamePathTextBox
            // 
            this.GamePathTextBox.Location = new System.Drawing.Point(114, 38);
            this.GamePathTextBox.Name = "GamePathTextBox";
            this.GamePathTextBox.Size = new System.Drawing.Size(135, 20);
            this.GamePathTextBox.TabIndex = 0;
            // 
            // FileConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.GroupBoxDefineDates);
            this.Name = "FileConfig";
            this.Text = "File / Config";
            this.Load += new System.EventHandler(this.FileConfig_Load);
            this.GroupBoxDefineDates.ResumeLayout(false);
            this.GroupBoxDefineDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBoxDefineDates;
        internal System.Windows.Forms.TextBox ModNameTextBox;
        internal System.Windows.Forms.Label ModNameLabel;
        internal System.Windows.Forms.Button DefineDatesSaveButton;
        internal System.Windows.Forms.TextBox GameModPathTextBox;
        internal System.Windows.Forms.TextBox BuildModPathTextBox;
        internal System.Windows.Forms.Label GameModLabel;
        internal System.Windows.Forms.Label BuildModPathLabel;
        internal System.Windows.Forms.Label GamePathLabel;
        internal System.Windows.Forms.TextBox GamePathTextBox;
    }
}