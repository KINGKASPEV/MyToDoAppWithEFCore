namespace MyToDoApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Task = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            UpdatedAt = new DataGridViewTextBoxColumn();
            IsCompleted = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            button8 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Task, Description, CreatedAt, UpdatedAt, IsCompleted });
            dataGridView1.Location = new Point(0, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1824, 712);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Task
            // 
            Task.DataPropertyName = "Task";
            Task.HeaderText = "Task";
            Task.MinimumWidth = 8;
            Task.Name = "Task";
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            // 
            // CreatedAt
            // 
            CreatedAt.HeaderText = "DateCreated";
            CreatedAt.MinimumWidth = 8;
            CreatedAt.Name = "CreatedAt";
            // 
            // UpdatedAt
            // 
            UpdatedAt.HeaderText = "DateUpdated";
            UpdatedAt.MinimumWidth = 8;
            UpdatedAt.Name = "UpdatedAt";
            // 
            // IsCompleted
            // 
            IsCompleted.DataPropertyName = "IsCompleted";
            IsCompleted.HeaderText = "Completed";
            IsCompleted.MinimumWidth = 8;
            IsCompleted.Name = "IsCompleted";
            IsCompleted.Resizable = DataGridViewTriState.True;
            IsCompleted.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(215, 257);
            button1.Name = "button1";
            button1.Size = new Size(222, 64);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Deletebutton_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(16, 257);
            button2.Name = "button2";
            button2.Size = new Size(190, 64);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Addbutton_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(446, 257);
            button3.Name = "button3";
            button3.Size = new Size(215, 64);
            button3.TabIndex = 3;
            button3.Text = "DeletAll";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteAllbutton_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(672, 257);
            button4.Name = "button4";
            button4.Size = new Size(225, 64);
            button4.TabIndex = 4;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Updatebutton_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(912, 257);
            button5.Name = "button5";
            button5.Size = new Size(240, 64);
            button5.TabIndex = 5;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Editbutton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(563, 12);
            button7.Name = "button7";
            button7.Size = new Size(165, 34);
            button7.TabIndex = 7;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(511, 31);
            textBox1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.HotTrack;
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1824, 60);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(527, 9);
            label1.Name = "label1";
            label1.Size = new Size(781, 45);
            label1.TabIndex = 10;
            label1.Text = "Welcome aboard! Get organized with YourTaskList.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(16, 187);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1799, 57);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 38);
            label2.TabIndex = 12;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 137);
            label3.Name = "label3";
            label3.Size = new Size(158, 38);
            label3.TabIndex = 13;
            label3.Text = "Description";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1476, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(339, 31);
            dateTimePicker1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1355, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(457, 31);
            textBox2.TabIndex = 16;
            textBox2.KeyUp += SearchTextBox_KeyUp;
            // 
            // button8
            // 
            button8.Location = new Point(1274, 271);
            button8.Name = "button8";
            button8.Size = new Size(75, 37);
            button8.TabIndex = 18;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Searchbutton_Click;
            // 
            // timer1
            // 
            timer1.Tick += Mytimer_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1824, 1050);
            Controls.Add(button8);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ToDo App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button button8;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn UpdatedAt;
        private DataGridViewCheckBoxColumn IsCompleted;
    }
}