
namespace WindowsFormsBank
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAutification = new System.Windows.Forms.GroupBox();
            this.buttonAutification = new System.Windows.Forms.Button();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.TransferCard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.buttonTran = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonPut = new System.Windows.Forms.Button();
            this.textBoxOperations = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.groupBoxAutification.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAutification
            // 
            this.groupBoxAutification.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxAutification.Controls.Add(this.buttonAutification);
            this.groupBoxAutification.Controls.Add(this.textBoxPin);
            this.groupBoxAutification.Controls.Add(this.textBoxCardNum);
            this.groupBoxAutification.Controls.Add(this.label1);
            this.groupBoxAutification.Controls.Add(this.label2);
            this.groupBoxAutification.ForeColor = System.Drawing.Color.LightYellow;
            this.groupBoxAutification.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAutification.Name = "groupBoxAutification";
            this.groupBoxAutification.Size = new System.Drawing.Size(516, 441);
            this.groupBoxAutification.TabIndex = 1;
            this.groupBoxAutification.TabStop = false;
            // 
            // buttonAutification
            // 
            this.buttonAutification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAutification.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAutification.Location = new System.Drawing.Point(347, 365);
            this.buttonAutification.Name = "buttonAutification";
            this.buttonAutification.Size = new System.Drawing.Size(147, 48);
            this.buttonAutification.TabIndex = 5;
            this.buttonAutification.Text = "Увійти";
            this.buttonAutification.UseVisualStyleBackColor = true;
            this.buttonAutification.Click += new System.EventHandler(this.buttonAutification_Click);
            // 
            // textBoxPin
            // 
            this.textBoxPin.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin.Location = new System.Drawing.Point(72, 239);
            this.textBoxPin.Multiline = true;
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(374, 56);
            this.textBoxPin.TabIndex = 4;
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCardNum.Location = new System.Drawing.Point(72, 103);
            this.textBoxCardNum.Multiline = true;
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(374, 56);
            this.textBoxCardNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть номер картки:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(67, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть пароль:";
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.BackColor = System.Drawing.Color.Black;
            this.groupBoxOperations.Controls.Add(this.TransferCard);
            this.groupBoxOperations.Controls.Add(this.label4);
            this.groupBoxOperations.Controls.Add(this.textBoxCard);
            this.groupBoxOperations.Controls.Add(this.labelBalance);
            this.groupBoxOperations.Controls.Add(this.labelText);
            this.groupBoxOperations.Controls.Add(this.groupBoxButtons);
            this.groupBoxOperations.Controls.Add(this.textBoxOperations);
            this.groupBoxOperations.Controls.Add(this.buttonExit);
            this.groupBoxOperations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxOperations.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(533, 441);
            this.groupBoxOperations.TabIndex = 2;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Enter += new System.EventHandler(this.groupBoxOperations_Enter);
            // 
            // TransferCard
            // 
            this.TransferCard.Location = new System.Drawing.Point(344, 176);
            this.TransferCard.Name = "TransferCard";
            this.TransferCard.Size = new System.Drawing.Size(136, 39);
            this.TransferCard.TabIndex = 12;
            this.TransferCard.Text = "Перевести";
            this.TransferCard.UseVisualStyleBackColor = true;
            this.TransferCard.Click += new System.EventHandler(this.TransferCard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введіть номер картки:";
            // 
            // textBoxCard
            // 
            this.textBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCard.Location = new System.Drawing.Point(32, 122);
            this.textBoxCard.Multiline = true;
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.Size = new System.Drawing.Size(448, 42);
            this.textBoxCard.TabIndex = 10;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(380, 9);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 16);
            this.labelBalance.TabIndex = 9;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(29, 35);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(137, 20);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "Введіть суму:";
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.Color.Black;
            this.groupBoxButtons.Controls.Add(this.buttonTake);
            this.groupBoxButtons.Controls.Add(this.buttonTran);
            this.groupBoxButtons.Controls.Add(this.buttonInfo);
            this.groupBoxButtons.Controls.Add(this.buttonPut);
            this.groupBoxButtons.Controls.Add(this.checkBoxNotify);
            this.groupBoxButtons.Location = new System.Drawing.Point(32, 190);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(462, 210);
            this.groupBoxButtons.TabIndex = 3;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTake.Location = new System.Drawing.Point(247, 31);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(194, 63);
            this.buttonTake.TabIndex = 1;
            this.buttonTake.Text = "Зняти кошти";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // buttonTran
            // 
            this.buttonTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTran.Location = new System.Drawing.Point(22, 126);
            this.buttonTran.Name = "buttonTran";
            this.buttonTran.Size = new System.Drawing.Size(194, 63);
            this.buttonTran.TabIndex = 3;
            this.buttonTran.Text = "Перевести кошти";
            this.buttonTran.UseVisualStyleBackColor = true;
            this.buttonTran.Click += new System.EventHandler(this.buttonTran_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.Location = new System.Drawing.Point(22, 31);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(194, 63);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Переглянути інформацію";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonPut
            // 
            this.buttonPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPut.Location = new System.Drawing.Point(247, 126);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(194, 63);
            this.buttonPut.TabIndex = 2;
            this.buttonPut.Text = "Поповнити картку";
            this.buttonPut.UseVisualStyleBackColor = true;
            this.buttonPut.Click += new System.EventHandler(this.buttonPut_Click);
            // 
            // textBoxOperations
            // 
            this.textBoxOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOperations.Location = new System.Drawing.Point(32, 58);
            this.textBoxOperations.Multiline = true;
            this.textBoxOperations.Name = "textBoxOperations";
            this.textBoxOperations.Size = new System.Drawing.Size(448, 42);
            this.textBoxOperations.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(431, 408);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 26);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Вийти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxNotify.Location = new System.Drawing.Point(22, 172);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(18, 17);
            this.checkBoxNotify.TabIndex = 5;
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 465);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.groupBoxAutification);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 512);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONO24";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAutification.ResumeLayout(false);
            this.groupBoxAutification.PerformLayout();
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAutification;
        private System.Windows.Forms.Button buttonAutification;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.TextBox textBoxCardNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonTran;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.TextBox textBoxOperations;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TransferCard;
        private System.Windows.Forms.CheckBox checkBoxNotify;
    }
}

