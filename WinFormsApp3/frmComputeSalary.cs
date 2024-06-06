using EmployeeApplication;

namespace WinFormsApp3
{
    public partial class frmComputeSalary : Form
    {
        string fname, lname, dep, jobtitle;
        double rateperhour;
        int totalhoursworked;
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(55, 67);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F);
            textBox1.Location = new Point(55, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 33);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F);
            textBox2.Location = new Point(270, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 33);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(270, 67);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Last name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F);
            textBox3.Location = new Point(270, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 33);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(270, 136);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 6;
            label3.Text = "Job title";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F);
            textBox4.Location = new Point(55, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 33);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(55, 136);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 4;
            label4.Text = "Department";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F);
            textBox5.Location = new Point(270, 276);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 33);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(270, 245);
            label5.Name = "label5";
            label5.Size = new Size(172, 25);
            label5.TabIndex = 10;
            label5.Text = "Total hours worked";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F);
            textBox6.Location = new Point(55, 276);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 33);
            textBox6.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(55, 245);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 8;
            label6.Text = "Rate per hour";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(136, 336);
            button1.Name = "button1";
            button1.Size = new Size(197, 43);
            button1.TabIndex = 12;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(23, 484);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 14;
            label7.Text = "Last name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(21, 440);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 13;
            label8.Text = "First name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.Location = new Point(167, 484);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 16;
            label9.Text = "Last name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F);
            label10.Location = new Point(165, 440);
            label10.Name = "label10";
            label10.Size = new Size(99, 25);
            label10.TabIndex = 15;
            label10.Text = "First name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F);
            label12.Location = new Point(23, 533);
            label12.Name = "label12";
            label12.Size = new Size(113, 25);
            label12.TabIndex = 17;
            label12.Text = "Basic salary:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F);
            label11.Location = new Point(165, 533);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 18;
            label11.Text = "Basic salary:";
            // 
            // frmComputeSalary
            // 
            ClientSize = new Size(530, 579);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmComputeSalary";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label11;
        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            lname = textBox2.Text;
            dep = textBox4.Text;
            jobtitle = textBox3.Text;
            rateperhour = Convert.ToDouble(textBox6.Text);
            totalhoursworked = Convert.ToInt32(textBox5.Text);

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(fname, lname, dep, jobtitle);
            partTimeEmployee.computeSalary(totalhoursworked, rateperhour);



            label10.Text = this.fname;
            label9.Text = this.lname;
            label11.Text = partTimeEmployee.getSalary().ToString();
        }
    }
}
