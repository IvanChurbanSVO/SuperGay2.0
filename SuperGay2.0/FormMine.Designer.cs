namespace SuperGay2._0
{
    partial class FormMine
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
            labelOre = new Label();
            buttonSell = new Button();
            buttonBuy = new Button();
            labelWorker = new Label();
            textBoxSellOre = new TextBox();
            SuspendLayout();
            // 
            // labelOre
            // 
            labelOre.AutoSize = true;
            labelOre.Font = new Font("Roblox 2017", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOre.Location = new Point(33, 23);
            labelOre.Name = "labelOre";
            labelOre.Size = new Size(116, 36);
            labelOre.TabIndex = 0;
            labelOre.Text = "Ore: ";
            // 
            // buttonSell
            // 
            buttonSell.Font = new Font("Roblox 2017", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSell.Location = new Point(356, 58);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(148, 104);
            buttonSell.TabIndex = 1;
            buttonSell.Text = "Sell";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("Roblox 2017", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuy.Location = new Point(33, 216);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(215, 106);
            buttonBuy.TabIndex = 2;
            buttonBuy.Text = "Buy 300$";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Font = new Font("Roblox 2017", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWorker.Location = new Point(33, 177);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(215, 36);
            labelWorker.TabIndex = 3;
            labelWorker.Text = "Worker: ";
            // 
            // textBoxSellOre
            // 
            textBoxSellOre.Font = new Font("Segoe UI", 24F);
            textBoxSellOre.Location = new Point(12, 82);
            textBoxSellOre.Name = "textBoxSellOre";
            textBoxSellOre.Size = new Size(326, 50);
            textBoxSellOre.TabIndex = 4;
            // 
            // FormMine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 354);
            Controls.Add(textBoxSellOre);
            Controls.Add(labelWorker);
            Controls.Add(buttonBuy);
            Controls.Add(buttonSell);
            Controls.Add(labelOre);
            Font = new Font("Segoe UI", 9F);
            Name = "FormMine";
            Text = "FormMine";
            Load += FormMine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOre;
        private Button buttonSell;
        private Button buttonBuy;
        private Label labelWorker;
        private TextBox textBoxSellOre;
    }
}