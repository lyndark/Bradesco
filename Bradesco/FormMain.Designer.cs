namespace Bradesco
{
  partial class FormMain
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
            this.btnExercise1 = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnExercise2 = new System.Windows.Forms.Button();
            this.btnExercise3 = new System.Windows.Forms.Button();
            this.btnExercise4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercise1
            // 
            this.btnExercise1.Location = new System.Drawing.Point(166, 94);
            this.btnExercise1.Name = "btnExercise1";
            this.btnExercise1.Size = new System.Drawing.Size(151, 23);
            this.btnExercise1.TabIndex = 0;
            this.btnExercise1.Text = "Exercicio 01";
            this.btnExercise1.UseVisualStyleBackColor = true;
            this.btnExercise1.Click += new System.EventHandler(this.btnExercise1_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(185, 50);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(110, 15);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Escolha o exercicio:";
            // 
            // btnExercise2
            // 
            this.btnExercise2.Location = new System.Drawing.Point(166, 135);
            this.btnExercise2.Name = "btnExercise2";
            this.btnExercise2.Size = new System.Drawing.Size(151, 23);
            this.btnExercise2.TabIndex = 2;
            this.btnExercise2.Text = "Exercicio 02";
            this.btnExercise2.UseVisualStyleBackColor = true;
            this.btnExercise2.Click += new System.EventHandler(this.btnExercise2_Click);
            // 
            // btnExercise3
            // 
            this.btnExercise3.Location = new System.Drawing.Point(166, 178);
            this.btnExercise3.Name = "btnExercise3";
            this.btnExercise3.Size = new System.Drawing.Size(151, 23);
            this.btnExercise3.TabIndex = 3;
            this.btnExercise3.Text = "Exercicio 03";
            this.btnExercise3.UseVisualStyleBackColor = true;
            this.btnExercise3.Click += new System.EventHandler(this.btnExercise3_Click);
            // 
            // btnExercise4
            // 
            this.btnExercise4.Location = new System.Drawing.Point(166, 220);
            this.btnExercise4.Name = "btnExercise4";
            this.btnExercise4.Size = new System.Drawing.Size(151, 23);
            this.btnExercise4.TabIndex = 4;
            this.btnExercise4.Text = "Exercicio 04";
            this.btnExercise4.UseVisualStyleBackColor = true;
            this.btnExercise4.Click += new System.EventHandler(this.btnExercise4_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 330);
            this.Controls.Add(this.btnExercise4);
            this.Controls.Add(this.btnExercise3);
            this.Controls.Add(this.btnExercise2);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnExercise1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnExercise1;
    private Label lblText;
    private Button btnExercise2;
    private Button btnExercise3;
    private Button btnExercise4;
  }
}
