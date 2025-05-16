namespace RestarauntReservation.UserControls
{
    partial class PersonalUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            labelTable = new Label();
            guna2CircleButtonCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            labelCount = new Label();
            labelTime = new Label();
            labelDate = new Label();
            SuspendLayout();
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.Font = new Font("Segoe UI", 10.2F);
            labelTable.ForeColor = SystemColors.Control;
            labelTable.Location = new Point(14, 16);
            labelTable.Name = "labelTable";
            labelTable.Size = new Size(49, 23);
            labelTable.TabIndex = 9;
            labelTable.Text = "Table";
            // 
            // guna2CircleButtonCancel
            // 
            guna2CircleButtonCancel.Cursor = Cursors.Hand;
            guna2CircleButtonCancel.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButtonCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButtonCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButtonCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButtonCancel.FillColor = Color.Firebrick;
            guna2CircleButtonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2CircleButtonCancel.ForeColor = Color.White;
            guna2CircleButtonCancel.Location = new Point(711, 16);
            guna2CircleButtonCancel.Name = "guna2CircleButtonCancel";
            guna2CircleButtonCancel.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButtonCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButtonCancel.Size = new Size(116, 90);
            guna2CircleButtonCancel.TabIndex = 8;
            guna2CircleButtonCancel.Text = "Отменить";
            guna2CircleButtonCancel.Click += guna2CircleButtonCancel_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 10.2F);
            labelCount.ForeColor = SystemColors.Control;
            labelCount.Location = new Point(158, 16);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(61, 23);
            labelCount.TabIndex = 10;
            labelCount.Text = "Guests";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 10.2F);
            labelTime.ForeColor = SystemColors.Control;
            labelTime.Location = new Point(16, 83);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(47, 23);
            labelTime.TabIndex = 12;
            labelTime.Text = "Time";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 10.2F);
            labelDate.ForeColor = SystemColors.Control;
            labelDate.Location = new Point(172, 83);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(46, 23);
            labelDate.TabIndex = 13;
            labelDate.Text = "Date";
            // 
            // PersonalUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(labelDate);
            Controls.Add(labelTime);
            Controls.Add(labelCount);
            Controls.Add(labelTable);
            Controls.Add(guna2CircleButtonCancel);
            ForeColor = SystemColors.Control;
            Name = "PersonalUserControl";
            Size = new Size(848, 123);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTable;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButtonCancel;
        private Label labelCount;
        private Label labelTime;
        private Label labelDate;
    }
}
