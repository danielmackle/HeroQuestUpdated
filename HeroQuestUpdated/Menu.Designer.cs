namespace HeroQuestUpdated
{
    partial class Menu
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
            pnlMainMenu = new Panel();
            btnMainMenu = new Button();
            pnlMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainMenu
            // 
            pnlMainMenu.Controls.Add(btnMainMenu);
            pnlMainMenu.Location = new Point(-2, -2);
            pnlMainMenu.Name = "pnlMainMenu";
            pnlMainMenu.Size = new Size(801, 457);
            pnlMainMenu.TabIndex = 0;
            pnlMainMenu.Visible = false;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(301, 209);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(194, 105);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "Enter";
            btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMainMenu);
            Name = "Menu";
            Text = "HeroQuest";
            pnlMainMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainMenu;
        private Button btnMainMenu;
    }
}
