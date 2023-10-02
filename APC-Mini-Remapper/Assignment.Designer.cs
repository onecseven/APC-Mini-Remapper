namespace APC_Mini_Remapper
{
    partial class AssignHotkey
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            keySelectionGroup = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mod1 = new ComboBox();
            charKey = new ComboBox();
            mod2 = new ComboBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            keySelectionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "Actions";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(262, 361);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.AccessibleRole = AccessibleRole.None;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(keySelectionGroup);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(254, 333);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Button Presses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(227, 15);
            label1.TabIndex = 6;
            label1.Text = "Choose a button combination for this key";
            // 
            // keySelectionGroup
            // 
            keySelectionGroup.Controls.Add(label4);
            keySelectionGroup.Controls.Add(label3);
            keySelectionGroup.Controls.Add(label2);
            keySelectionGroup.Controls.Add(mod1);
            keySelectionGroup.Controls.Add(charKey);
            keySelectionGroup.Controls.Add(mod2);
            keySelectionGroup.Location = new Point(6, 32);
            keySelectionGroup.Name = "keySelectionGroup";
            keySelectionGroup.Size = new Size(233, 226);
            keySelectionGroup.TabIndex = 7;
            keySelectionGroup.TabStop = false;
            keySelectionGroup.Text = "Key Selection";
            keySelectionGroup.Enter += keySelectionGroup_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 34);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 6;
            label4.Text = "Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 94);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Modifier (optional)";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 151);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 4;
            label2.Text = "Modifier (optional)";
            // 
            // mod1
            // 
            mod1.AllowDrop = true;
            mod1.DropDownStyle = ComboBoxStyle.DropDownList;
            mod1.FormattingEnabled = true;
            mod1.Location = new Point(6, 169);
            mod1.Name = "mod1";
            mod1.Size = new Size(221, 23);
            mod1.TabIndex = 0;
            // 
            // charKey
            // 
            charKey.DropDownStyle = ComboBoxStyle.DropDownList;
            charKey.FormattingEnabled = true;
            charKey.Location = new Point(7, 52);
            charKey.Name = "charKey";
            charKey.Size = new Size(221, 23);
            charKey.TabIndex = 2;
            // 
            // mod2
            // 
            mod2.DropDownStyle = ComboBoxStyle.DropDownList;
            mod2.FormattingEnabled = true;
            mod2.Location = new Point(7, 112);
            mod2.Name = "mod2";
            mod2.Size = new Size(221, 23);
            mod2.TabIndex = 3;
            //mod2.SelectedIndexChanged += this.mod2_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(254, 333);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "LEDs";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(254, 333);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Events";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(127, 269);
            button1.Name = "button1";
            button1.Size = new Size(104, 24);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AssignHotkey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 331);
            Controls.Add(tabControl1);
            Name = "AssignHotkey";
            Text = "Button Settings";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            keySelectionGroup.ResumeLayout(false);
            keySelectionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private GroupBox keySelectionGroup;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox mod1;
        private ComboBox charKey;
        private ComboBox mod2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
    }
}