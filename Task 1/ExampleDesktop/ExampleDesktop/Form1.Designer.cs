namespace ExampleDesktop
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Button greetButton;
        private System.Windows.Forms.Label greetingLabel;

        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.greetButton = new System.Windows.Forms.Button();
            this.greetingLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(300, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 0;

            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(300, 150);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 20);
            this.ageTextBox.TabIndex = 1;

            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(300, 200);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 2;

            // 
            // greetButton
            // 
            this.greetButton.Location = new System.Drawing.Point(350, 250);
            this.greetButton.Name = "greetButton";
            this.greetButton.Size = new System.Drawing.Size(100, 23);
            this.greetButton.TabIndex = 3;
            this.greetButton.Text = "Submit";
            this.greetButton.UseVisualStyleBackColor = true;
            this.greetButton.Click += new System.EventHandler(this.greetButton_Click);

            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(300, 300);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(0, 13);
            this.greetingLabel.TabIndex = 4;

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.greetButton);
            this.Controls.Add(this.greetingLabel);
            this.Name = "Form1";
            this.Text = "User Information";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
