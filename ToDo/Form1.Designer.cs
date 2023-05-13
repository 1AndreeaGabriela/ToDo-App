namespace ToDo
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
            fisierToolStripMenuItem = new ToolStripMenuItem();
            nouToolStripMenuItem = new ToolStripMenuItem();
            deschidereToolStripMenuItem = new ToolStripMenuItem();
            salvareToolStripMenuItem = new ToolStripMenuItem();
            salvareCaToolStripMenuItem = new ToolStripMenuItem();
            iesireToolStripMenuItem = new ToolStripMenuItem();
            editareToolStripMenuItem = new ToolStripMenuItem();
            adaugareSarcinaToolStripMenuItem = new ToolStripMenuItem();
            EditatiSarcinaToolStripMenuItem = new ToolStripMenuItem();
            stergetiSarcinaToolStripMenuItem = new ToolStripMenuItem();
            ajutorToolStripMenuItem = new ToolStripMenuItem();
            despreToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            prioritate = new ComboBox();
            date = new DateTimePicker();
            descriere = new TextBox();
            nume = new TextBox();
            taskList = new ListBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(180, 129, 200);
            menuStrip1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, editareToolStripMenuItem, ajutorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouToolStripMenuItem, deschidereToolStripMenuItem, salvareToolStripMenuItem, salvareCaToolStripMenuItem, iesireToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(62, 24);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // nouToolStripMenuItem
            // 
            nouToolStripMenuItem.Name = "nouToolStripMenuItem";
            nouToolStripMenuItem.Size = new Size(172, 26);
            nouToolStripMenuItem.Text = "Nou";
            nouToolStripMenuItem.Click += nouToolStripMenuItem_Click;
            // 
            // deschidereToolStripMenuItem
            // 
            deschidereToolStripMenuItem.Name = "deschidereToolStripMenuItem";
            deschidereToolStripMenuItem.Size = new Size(172, 26);
            deschidereToolStripMenuItem.Text = "Deschidere";
            deschidereToolStripMenuItem.Click += deschidereToolStripMenuItem_Click;
            // 
            // salvareToolStripMenuItem
            // 
            salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            salvareToolStripMenuItem.Size = new Size(172, 26);
            salvareToolStripMenuItem.Text = "Salvare";
            salvareToolStripMenuItem.Click += SalvareToolStripMenuItem_Click;
            // 
            // salvareCaToolStripMenuItem
            // 
            salvareCaToolStripMenuItem.Name = "salvareCaToolStripMenuItem";
            salvareCaToolStripMenuItem.Size = new Size(172, 26);
            salvareCaToolStripMenuItem.Text = "Salvare ca";
            salvareCaToolStripMenuItem.Click += salvareCaToolStripMenuItem_Click;
            // 
            // iesireToolStripMenuItem
            // 
            iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            iesireToolStripMenuItem.Size = new Size(172, 26);
            iesireToolStripMenuItem.Text = "Iesire";
            iesireToolStripMenuItem.Click += iesireToolStripMenuItem_Click;
            // 
            // editareToolStripMenuItem
            // 
            editareToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugareSarcinaToolStripMenuItem, EditatiSarcinaToolStripMenuItem, stergetiSarcinaToolStripMenuItem });
            editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            editareToolStripMenuItem.Size = new Size(74, 24);
            editareToolStripMenuItem.Text = "Editare";
            // 
            // adaugareSarcinaToolStripMenuItem
            // 
            adaugareSarcinaToolStripMenuItem.Name = "adaugareSarcinaToolStripMenuItem";
            adaugareSarcinaToolStripMenuItem.Size = new Size(210, 26);
            adaugareSarcinaToolStripMenuItem.Text = "Adaugati sarcina";
            adaugareSarcinaToolStripMenuItem.Click += adaugareSarcinaToolStripMenuItem_Click;
            // 
            // EditatiSarcinaToolStripMenuItem
            // 
            EditatiSarcinaToolStripMenuItem.Name = "EditatiSarcinaToolStripMenuItem";
            EditatiSarcinaToolStripMenuItem.Size = new Size(210, 26);
            EditatiSarcinaToolStripMenuItem.Text = "Editati sarcina";
            EditatiSarcinaToolStripMenuItem.Click += EditatiSarcinaToolStripMenuItem_Click;
            // 
            // stergetiSarcinaToolStripMenuItem
            // 
            stergetiSarcinaToolStripMenuItem.Name = "stergetiSarcinaToolStripMenuItem";
            stergetiSarcinaToolStripMenuItem.Size = new Size(210, 26);
            stergetiSarcinaToolStripMenuItem.Text = "Stergeti sarcina";
            stergetiSarcinaToolStripMenuItem.Click += stergetiSarcinaToolStripMenuItem_Click;
            // 
            // ajutorToolStripMenuItem
            // 
            ajutorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despreToolStripMenuItem });
            ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            ajutorToolStripMenuItem.Size = new Size(69, 24);
            ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // despreToolStripMenuItem
            // 
            despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            despreToolStripMenuItem.Size = new Size(143, 26);
            despreToolStripMenuItem.Text = "Despre";
            despreToolStripMenuItem.Click += despreToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(prioritate);
            groupBox1.Controls.Add(date);
            groupBox1.Controls.Add(descriere);
            groupBox1.Controls.Add(nume);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(371, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 383);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sarcini";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Location = new Point(291, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 37);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Stergeti";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Location = new Point(291, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 9;
            btnSave.Text = "Salvati";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 273);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 8;
            label4.Text = "Nivel de prioritate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 192);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 7;
            label3.Text = "Data Scadentei";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Descriere";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 42);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 5;
            label1.Text = "Nume Sarcina";
            // 
            // prioritate
            // 
            prioritate.FormattingEnabled = true;
            prioritate.Items.AddRange(new object[] { "Urgent", "Important", "Urgent dar nu important", "Important dar nu urgent" });
            prioritate.Location = new Point(0, 296);
            prioritate.Name = "prioritate";
            prioritate.Size = new Size(258, 28);
            prioritate.TabIndex = 4;
            // 
            // date
            // 
            date.Location = new Point(0, 215);
            date.Name = "date";
            date.Size = new Size(258, 28);
            date.TabIndex = 3;
            // 
            // descriere
            // 
            descriere.Location = new Point(0, 131);
            descriere.Multiline = true;
            descriere.Name = "descriere";
            descriere.Size = new Size(258, 34);
            descriere.TabIndex = 1;
            // 
            // nume
            // 
            nume.BackColor = SystemColors.ControlLightLight;
            nume.Location = new Point(0, 65);
            nume.Name = "nume";
            nume.Size = new Size(258, 28);
            nume.TabIndex = 0;
            // 
            // taskList
            // 
            taskList.BackColor = Color.Thistle;
            taskList.FormattingEnabled = true;
            taskList.ItemHeight = 20;
            taskList.Location = new Point(12, 54);
            taskList.Name = "taskList";
            taskList.Size = new Size(353, 384);
            taskList.TabIndex = 3;
            taskList.SelectedIndexChanged += selected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(taskList);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ToDoApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem editareToolStripMenuItem;
        private ToolStripMenuItem ajutorToolStripMenuItem;
        private ToolStripMenuItem nouToolStripMenuItem;
        private ToolStripMenuItem deschidereToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem salvareCaToolStripMenuItem;
        private ToolStripMenuItem iesireToolStripMenuItem;
        private ToolStripMenuItem adaugareSarcinaToolStripMenuItem;
        private ToolStripMenuItem EditatiSarcinaToolStripMenuItem;
        private ToolStripMenuItem stergetiSarcinaToolStripMenuItem;
        private ToolStripMenuItem despreToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox prioritate;
        private DateTimePicker date;
        private TextBox descriere;
        private TextBox nume;
        private ListBox taskList;
    }
}