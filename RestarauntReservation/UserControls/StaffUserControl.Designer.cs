namespace RestarauntReservation.UserControls
{
    partial class StaffUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            labelName = new Label();
            labelNumber = new Label();
            guna2CircleButtonEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButtonCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            labelTable = new Label();
            labelCount = new Label();
            labelTime = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10.2F);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(16, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Segoe UI", 10.2F);
            labelNumber.ForeColor = SystemColors.Control;
            labelNumber.Location = new Point(16, 85);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(124, 23);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "Phone number";
            // 
            // guna2CircleButtonEdit
            // 
            guna2CircleButtonEdit.Cursor = Cursors.Hand;
            guna2CircleButtonEdit.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButtonEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButtonEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButtonEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButtonEdit.FillColor = Color.Firebrick;
            guna2CircleButtonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2CircleButtonEdit.ForeColor = Color.White;
            guna2CircleButtonEdit.Location = new Point(696, 18);
            guna2CircleButtonEdit.Name = "guna2CircleButtonEdit";
            guna2CircleButtonEdit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButtonEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButtonEdit.Size = new Size(140, 90);
            guna2CircleButtonEdit.TabIndex = 2;
            guna2CircleButtonEdit.Text = "Редактировать";
            guna2CircleButtonEdit.Click += guna2CircleButtonEdit_Click;
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
            guna2CircleButtonCancel.Location = new Point(560, 18);
            guna2CircleButtonCancel.Name = "guna2CircleButtonCancel";
            guna2CircleButtonCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButtonCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButtonCancel.Size = new Size(116, 90);
            guna2CircleButtonCancel.TabIndex = 3;
            guna2CircleButtonCancel.Text = "Отменить";
            guna2CircleButtonCancel.Click += guna2CircleButtonCancel_Click;
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.Font = new Font("Segoe UI", 10.2F);
            labelTable.ForeColor = SystemColors.Control;
            labelTable.Location = new Point(176, 18);
            labelTable.Name = "labelTable";
            labelTable.Size = new Size(49, 23);
            labelTable.TabIndex = 4;
            labelTable.Text = "Table";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 10.2F);
            labelCount.ForeColor = SystemColors.Control;
            labelCount.Location = new Point(357, 18);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(61, 23);
            labelCount.TabIndex = 5;
            labelCount.Text = "Guests";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 10.2F);
            labelTime.ForeColor = SystemColors.Control;
            labelTime.Location = new Point(357, 85);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(47, 23);
            labelTime.TabIndex = 12;
            labelTime.Text = "Time";
            // 
            // StaffUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(labelTime);
            Controls.Add(labelCount);
            Controls.Add(labelTable);
            Controls.Add(guna2CircleButtonCancel);
            Controls.Add(guna2CircleButtonEdit);
            Controls.Add(labelNumber);
            Controls.Add(labelName);
            Name = "StaffUserControl";
            Size = new Size(848, 123);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelNumber;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButtonEdit;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButtonCancel;
        private Label labelTable;
        private Label labelCount;
        private Label labelTime;
    }
}
