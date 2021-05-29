
namespace РеализацияКлассаАвтомобиля
{
	partial class Form1
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonStart = new System.Windows.Forms.Button();
			this.textBoxSpeed = new System.Windows.Forms.TextBox();
			this.labelType = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button0 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.buttonStart.FlatAppearance.BorderSize = 3;
			this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStart.Location = new System.Drawing.Point(272, 12);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(219, 69);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Ключ зажигания\r\n(v)";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			this.buttonStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.buttonStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			// 
			// textBoxSpeed
			// 
			this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSpeed.Location = new System.Drawing.Point(227, 106);
			this.textBoxSpeed.Name = "textBoxSpeed";
			this.textBoxSpeed.ReadOnly = true;
			this.textBoxSpeed.Size = new System.Drawing.Size(297, 45);
			this.textBoxSpeed.TabIndex = 50;
			this.textBoxSpeed.TabStop = false;
			this.textBoxSpeed.Text = "0";
			this.textBoxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.textBoxSpeed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelType.Location = new System.Drawing.Point(179, 116);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(27, 29);
			this.labelType.TabIndex = 51;
			this.labelType.Text = "1";
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.White;
			this.progressBar1.Location = new System.Drawing.Point(140, 166);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(481, 43);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 52;
			// 
			// button0
			// 
			this.button0.BackColor = System.Drawing.Color.Beige;
			this.button0.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.Location = new System.Drawing.Point(45, 234);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(169, 110);
			this.button0.TabIndex = 53;
			this.button0.Text = "Сцепление\r\n(с)";
			this.button0.UseVisualStyleBackColor = false;
			this.button0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.button0.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Orchid;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(227, 234);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(228, 141);
			this.button1.TabIndex = 53;
			this.button1.Text = "Тормоз\r\n(s)";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Aqua;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(461, 234);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 204);
			this.button2.TabIndex = 53;
			this.button2.Text = "Газ\r\n(w)";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(670, 106);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(52, 89);
			this.button3.TabIndex = 54;
			this.button3.Text = "+\r\n(e)";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(670, 222);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(52, 93);
			this.button4.TabIndex = 54;
			this.button4.Text = "↓\r\n(q)";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.button4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			// 
			// timer1
			// 
			this.timer1.Interval = 2400;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 250;
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(530, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 29);
			this.label1.TabIndex = 51;
			this.label1.Text = "км/ч";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(364, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 29);
			this.label2.TabIndex = 51;
			this.label2.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.textBoxSpeed);
			this.Controls.Add(this.buttonStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Автомобиль";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.TextBox textBoxSpeed;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

