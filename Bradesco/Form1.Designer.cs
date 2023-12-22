namespace Bradesco
{
  partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(71, 134);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(326, 23);
            this.txtInput.TabIndex = 0;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(186, 191);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(80, 30);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validar";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(186, 93);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(80, 15);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Digite o valor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 330);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Exercise01";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox txtInput;
    private Button btnValidate;
    private Label lblText;
  }
}
