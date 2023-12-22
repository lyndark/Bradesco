namespace Bradesco
{
  partial class Form3
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(167, 103);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(121, 15);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Valor em CELSIUS (Tc)";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(112, 131);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(230, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(75, 178);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(141, 23);
            this.btnFahrenheit.TabIndex = 2;
            this.btnFahrenheit.Text = "FAHRENHEIT (Tf)";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnKelvin
            // 
            this.btnKelvin.Location = new System.Drawing.Point(235, 178);
            this.btnKelvin.Name = "btnKelvin";
            this.btnKelvin.Size = new System.Drawing.Size(141, 23);
            this.btnKelvin.TabIndex = 3;
            this.btnKelvin.Text = "KELVIN (Tk)";
            this.btnKelvin.UseVisualStyleBackColor = true;
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 330);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblText);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lblText;
    private TextBox txtInput;
    private Button btnFahrenheit;
    private Button btnKelvin;
  }
}