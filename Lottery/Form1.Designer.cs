using System.Windows.Forms;
namespace LotteryArchive
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
            txtLotteryName = new Label();
            textBox1 = new TextBox();
            numTicketLength = new Label();
            numericUpDown1 = new NumericUpDown();
            numPrizeFund = new Label();
            numericUpDown2 = new NumericUpDown();
            numParticipants = new Label();
            numericUpDown3 = new NumericUpDown();
            btnStartLottery = new Button();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // txtLotteryName
            // 
            txtLotteryName.AutoSize = true;
            txtLotteryName.Location = new Point(206, 19);
            txtLotteryName.Name = "txtLotteryName";
            txtLotteryName.Size = new Size(141, 20);
            txtLotteryName.TabIndex = 0;
            txtLotteryName.Text = "Название лотереи:";
            txtLotteryName.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numTicketLength
            // 
            numTicketLength.AutoSize = true;
            numTicketLength.Location = new Point(203, 53);
            numTicketLength.Name = "numTicketLength";
            numTicketLength.Size = new Size(170, 20);
            numTicketLength.TabIndex = 2;
            numTicketLength.Text = "Длина номера билета: ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(379, 51);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numPrizeFund
            // 
            numPrizeFund.AutoSize = true;
            numPrizeFund.Location = new Point(204, 90);
            numPrizeFund.Name = "numPrizeFund";
            numPrizeFund.Size = new Size(127, 20);
            numPrizeFund.TabIndex = 4;
            numPrizeFund.Text = "Призовой фонд: ";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(337, 92);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numParticipants
            // 
            numParticipants.AutoSize = true;
            numParticipants.Location = new Point(207, 131);
            numParticipants.Name = "numParticipants";
            numParticipants.Size = new Size(179, 20);
            numParticipants.TabIndex = 6;
            numParticipants.Text = "Количество участников: ";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(392, 133);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 7;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnStartLottery
            // 
            btnStartLottery.Location = new Point(337, 220);
            btnStartLottery.Name = "btnStartLottery";
            btnStartLottery.Size = new Size(94, 94);
            btnStartLottery.TabIndex = 8;
            btnStartLottery.Text = "Создать и провести лотерею";
            btnStartLottery.UseVisualStyleBackColor = true;
            btnStartLottery.Click += btnStartLottery_Click;

            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(301, 379);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(177, 20);
            lblResult.TabIndex = 9;
            lblResult.Text = "Для вывода победителя";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnStartLottery);
            Controls.Add(numericUpDown3);
            Controls.Add(numParticipants);
            Controls.Add(numericUpDown2);
            Controls.Add(numPrizeFund);
            Controls.Add(numericUpDown1);
            Controls.Add(numTicketLength);
            Controls.Add(textBox1);
            Controls.Add(txtLotteryName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtLotteryName;
        private TextBox textBox1;
        private Label numTicketLength;
        private NumericUpDown numericUpDown1;
        private Label numPrizeFund;
        private NumericUpDown numericUpDown2;
        private Label numParticipants;
        private NumericUpDown numericUpDown3;
        private Button btnStartLottery;
        private Label lblResult;
    }
}
