
namespace Artemkin.HomeWork._23._11
{
    partial class Task1
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
            this.mainText = new System.Windows.Forms.Label();
            this.currentNumber = new System.Windows.Forms.Label();
            this.currentTry = new System.Windows.Forms.Label();
            this.plusOne = new System.Windows.Forms.Button();
            this.multiplyByTwo = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.discharge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainText.Location = new System.Drawing.Point(123, 48);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(310, 26);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "Вам нужно получить число --";
            // 
            // currentNumber
            // 
            this.currentNumber.AutoSize = true;
            this.currentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentNumber.Location = new System.Drawing.Point(49, 150);
            this.currentNumber.Name = "currentNumber";
            this.currentNumber.Size = new System.Drawing.Size(184, 26);
            this.currentNumber.TabIndex = 1;
            this.currentNumber.Text = "Текущее число 0";
            // 
            // currentTry
            // 
            this.currentTry.AutoSize = true;
            this.currentTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTry.Location = new System.Drawing.Point(49, 209);
            this.currentTry.Name = "currentTry";
            this.currentTry.Size = new System.Drawing.Size(251, 26);
            this.currentTry.TabIndex = 2;
            this.currentTry.Text = "Количество действий 0";
            // 
            // plusOne
            // 
            this.plusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusOne.Location = new System.Drawing.Point(431, 146);
            this.plusOne.Name = "plusOne";
            this.plusOne.Size = new System.Drawing.Size(75, 30);
            this.plusOne.TabIndex = 3;
            this.plusOne.Text = "+1";
            this.plusOne.UseVisualStyleBackColor = true;
            this.plusOne.Click += new System.EventHandler(this.plusOne_Click);
            // 
            // multiplyByTwo
            // 
            this.multiplyByTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyByTwo.Location = new System.Drawing.Point(431, 205);
            this.multiplyByTwo.Name = "multiplyByTwo";
            this.multiplyByTwo.Size = new System.Drawing.Size(75, 30);
            this.multiplyByTwo.TabIndex = 4;
            this.multiplyByTwo.Text = "x2";
            this.multiplyByTwo.UseVisualStyleBackColor = true;
            this.multiplyByTwo.Click += new System.EventHandler(this.multiplyByTwo_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(107, 352);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 40);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // discharge
            // 
            this.discharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discharge.Location = new System.Drawing.Point(327, 352);
            this.discharge.Name = "discharge";
            this.discharge.Size = new System.Drawing.Size(150, 40);
            this.discharge.TabIndex = 6;
            this.discharge.Text = "Сброс";
            this.discharge.UseVisualStyleBackColor = true;
            this.discharge.Click += new System.EventHandler(this.discharge_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.discharge);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.multiplyByTwo);
            this.Controls.Add(this.plusOne);
            this.Controls.Add(this.currentTry);
            this.Controls.Add(this.currentNumber);
            this.Controls.Add(this.mainText);
            this.Name = "Task1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Label currentNumber;
        private System.Windows.Forms.Label currentTry;
        private System.Windows.Forms.Button plusOne;
        private System.Windows.Forms.Button multiplyByTwo;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button discharge;
    }
}