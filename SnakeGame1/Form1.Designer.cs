namespace SnakeGame1
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
            menuStrip1 = new MenuStrip();
            новаяИграToolStripMenuItem = new ToolStripMenuItem();
            уровеньСложностиToolStripMenuItem = new ToolStripMenuItem();
            легкийToolStripMenuItem = new ToolStripMenuItem();
            нормальныйToolStripMenuItem = new ToolStripMenuItem();
            сложныйToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { новаяИграToolStripMenuItem, выйтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            новаяИграToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { уровеньСложностиToolStripMenuItem });
            новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            новаяИграToolStripMenuItem.Size = new Size(81, 20);
            новаяИграToolStripMenuItem.Text = "Новая игра";
            // 
            // уровеньСложностиToolStripMenuItem
            // 
            уровеньСложностиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { легкийToolStripMenuItem, нормальныйToolStripMenuItem, сложныйToolStripMenuItem });
            уровеньСложностиToolStripMenuItem.Name = "уровеньСложностиToolStripMenuItem";
            уровеньСложностиToolStripMenuItem.Size = new Size(184, 22);
            уровеньСложностиToolStripMenuItem.Text = "Уровень сложности";
            // 
            // легкийToolStripMenuItem
            // 
            легкийToolStripMenuItem.Name = "легкийToolStripMenuItem";
            легкийToolStripMenuItem.Size = new Size(180, 22);
            легкийToolStripMenuItem.Text = "Легкий";
            легкийToolStripMenuItem.Click += легкийToolStripMenuItem_Click;
            // 
            // нормальныйToolStripMenuItem
            // 
            нормальныйToolStripMenuItem.Name = "нормальныйToolStripMenuItem";
            нормальныйToolStripMenuItem.Size = new Size(180, 22);
            нормальныйToolStripMenuItem.Text = "Нормальный";
            нормальныйToolStripMenuItem.Click += нормальныйToolStripMenuItem_Click;
            // 
            // сложныйToolStripMenuItem
            // 
            сложныйToolStripMenuItem.Name = "сложныйToolStripMenuItem";
            сложныйToolStripMenuItem.Size = new Size(180, 22);
            сложныйToolStripMenuItem.Text = "Сложный";
            сложныйToolStripMenuItem.Click += сложныйToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(54, 20);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 861);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 900);
            MinimizeBox = false;
            MinimumSize = new Size(1000, 900);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem новаяИграToolStripMenuItem;
        private ToolStripMenuItem уровеньСложностиToolStripMenuItem;
        private ToolStripMenuItem легкийToolStripMenuItem;
        private ToolStripMenuItem нормальныйToolStripMenuItem;
        private ToolStripMenuItem сложныйToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
    }
}