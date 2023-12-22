namespace Bradesco
{
  partial class Form2
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
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblText = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.dtpBirthDate.Location = new System.Drawing.Point(103, 147);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(265, 23);
            this.dtpBirthDate.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(123, 114);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(205, 15);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Insira data, mês e ano de nascimento:";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(195, 187);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validar";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 330);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.dtpBirthDate);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DateTimePicker dtpBirthDate;
    private Label lblText;
    private Button btnValidate;
  }
}
