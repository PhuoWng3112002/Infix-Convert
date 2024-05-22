
namespace InfixConverter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTitile = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.tCtrl = new System.Windows.Forms.TabControl();
            this.tPgStack = new System.Windows.Forms.TabPage();
            this.lvDescription = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPostfix = new InfixConverter.Custom.VBTextbox();
            this.tbResult = new InfixConverter.Custom.VBTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new InfixConverter.Custom.VBButton();
            this.btnRead = new InfixConverter.Custom.VBButton();
            this.btnSave = new InfixConverter.Custom.VBButton();
            this.btnStepForward = new InfixConverter.Custom.VBButton();
            this.btnReset = new InfixConverter.Custom.VBButton();
            this.btnStart = new InfixConverter.Custom.VBButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlStack = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInfix = new System.Windows.Forms.FlowLayoutPanel();
            this.tPgTree = new System.Windows.Forms.TabPage();
            this.panelTree1 = new InfixConverter.PanelTree();
            this.tbPostfixTree = new InfixConverter.Custom.VBTextbox();
            this.tbResultTree = new InfixConverter.Custom.VBTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculateTree = new InfixConverter.Custom.VBButton();
            this.btnReadTree = new InfixConverter.Custom.VBButton();
            this.btnSaveTree = new InfixConverter.Custom.VBButton();
            this.btnStepForwardTree = new InfixConverter.Custom.VBButton();
            this.btnResetTree = new InfixConverter.Custom.VBButton();
            this.btnStartTree = new InfixConverter.Custom.VBButton();
            this.vbTextbox2 = new InfixConverter.Custom.VBTextbox();
            this.tPgA = new System.Windows.Forms.TabPage();
            this.tPgAuthor = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbInput = new InfixConverter.Custom.VBTextbox();
            this.tCtrl.SuspendLayout();
            this.tPgStack.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tPgTree.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitile
            // 
            this.lbTitile.AutoSize = true;
            this.lbTitile.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitile.Location = new System.Drawing.Point(210, 9);
            this.lbTitile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(582, 29);
            this.lbTitile.TabIndex = 0;
            this.lbTitile.Text = "BIẾN ĐỔI BIỂU THỨC TRUNG TỐ SANG HẬU TỐ";
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(20, 62);
            this.lbInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(150, 21);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Biểu thức trung tố:";
            // 
            // tCtrl
            // 
            this.tCtrl.Controls.Add(this.tPgStack);
            this.tCtrl.Controls.Add(this.tPgTree);
            this.tCtrl.Controls.Add(this.tPgA);
            this.tCtrl.Controls.Add(this.tPgAuthor);
            this.tCtrl.Location = new System.Drawing.Point(10, 103);
            this.tCtrl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tCtrl.Name = "tCtrl";
            this.tCtrl.SelectedIndex = 0;
            this.tCtrl.Size = new System.Drawing.Size(880, 553);
            this.tCtrl.TabIndex = 3;
            // 
            // tPgStack
            // 
            this.tPgStack.Controls.Add(this.lvDescription);
            this.tPgStack.Controls.Add(this.tbPostfix);
            this.tPgStack.Controls.Add(this.tbResult);
            this.tPgStack.Controls.Add(this.label8);
            this.tPgStack.Controls.Add(this.label9);
            this.tPgStack.Controls.Add(this.groupBox2);
            this.tPgStack.Controls.Add(this.panel2);
            this.tPgStack.Location = new System.Drawing.Point(4, 30);
            this.tPgStack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgStack.Name = "tPgStack";
            this.tPgStack.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgStack.Size = new System.Drawing.Size(872, 519);
            this.tPgStack.TabIndex = 0;
            this.tPgStack.Text = "Biến đổi biểu thức bằng Stack";
            this.tPgStack.UseVisualStyleBackColor = true;
            // 
            // lvDescription
            // 
            this.lvDescription.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDescription.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvDescription.GridLines = true;
            this.lvDescription.HideSelection = false;
            this.lvDescription.Location = new System.Drawing.Point(35, 262);
            this.lvDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvDescription.Name = "lvDescription";
            this.lvDescription.Size = new System.Drawing.Size(632, 186);
            this.lvDescription.TabIndex = 10;
            this.lvDescription.UseCompatibleStateImageBehavior = false;
            this.lvDescription.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Token";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Stack";
            this.columnHeader6.Width = 91;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Output";
            this.columnHeader7.Width = 121;
            // 
            // tbPostfix
            // 
            this.tbPostfix.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPostfix.Location = new System.Drawing.Point(150, 161);
            this.tbPostfix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPostfix.Multiline = true;
            this.tbPostfix.Name = "tbPostfix";
            this.tbPostfix.ReadOnly = true;
            this.tbPostfix.Size = new System.Drawing.Size(482, 35);
            this.tbPostfix.TabIndex = 15;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbResult.Location = new System.Drawing.Point(150, 200);
            this.tbResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(482, 35);
            this.tbResult.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Result";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Final Postfix";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnStepForward);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(682, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(173, 479);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCalculate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCalculate.BorderRadius = 5;
            this.btnCalculate.BorderSize = 0;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(24, 303);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Tính biểu thức";
            this.btnCalculate.TextColor = System.Drawing.Color.White;
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnRead.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnRead.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRead.BorderRadius = 5;
            this.btnRead.BorderSize = 0;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(24, 253);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(128, 35);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Đọc file";
            this.btnRead.TextColor = System.Drawing.Color.White;
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.BackgroundColor = System.Drawing.Color.Silver;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(24, 202);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu file";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStepForward
            // 
            this.btnStepForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnStepForward.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnStepForward.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStepForward.BorderRadius = 5;
            this.btnStepForward.BorderSize = 0;
            this.btnStepForward.FlatAppearance.BorderSize = 0;
            this.btnStepForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepForward.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStepForward.ForeColor = System.Drawing.Color.White;
            this.btnStepForward.Location = new System.Drawing.Point(24, 152);
            this.btnStepForward.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStepForward.Name = "btnStepForward";
            this.btnStepForward.Size = new System.Drawing.Size(128, 35);
            this.btnStepForward.TabIndex = 2;
            this.btnStepForward.Text = "Từng bước";
            this.btnStepForward.TextColor = System.Drawing.Color.White;
            this.btnStepForward.UseVisualStyleBackColor = false;
            this.btnStepForward.Click += new System.EventHandler(this.btnStepForward_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 5;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(24, 101);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnStart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStart.BorderRadius = 5;
            this.btnStart.BorderSize = 0;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(24, 52);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pnlStack);
            this.panel2.Controls.Add(this.pnlOutput);
            this.panel2.Controls.Add(this.pnlInfix);
            this.panel2.Location = new System.Drawing.Point(35, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 148);
            this.panel2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Output";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Stack";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Infix";
            // 
            // pnlStack
            // 
            this.pnlStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStack.Location = new System.Drawing.Point(80, 53);
            this.pnlStack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlStack.Name = "pnlStack";
            this.pnlStack.Size = new System.Drawing.Size(520, 31);
            this.pnlStack.TabIndex = 1;
            // 
            // pnlOutput
            // 
            this.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutput.Location = new System.Drawing.Point(80, 102);
            this.pnlOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(517, 31);
            this.pnlOutput.TabIndex = 1;
            // 
            // pnlInfix
            // 
            this.pnlInfix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfix.Location = new System.Drawing.Point(80, 4);
            this.pnlInfix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlInfix.Name = "pnlInfix";
            this.pnlInfix.Size = new System.Drawing.Size(520, 31);
            this.pnlInfix.TabIndex = 3;
            // 
            // tPgTree
            // 
            this.tPgTree.Controls.Add(this.panelTree1);
            this.tPgTree.Controls.Add(this.tbPostfixTree);
            this.tPgTree.Controls.Add(this.tbResultTree);
            this.tPgTree.Controls.Add(this.label2);
            this.tPgTree.Controls.Add(this.label4);
            this.tPgTree.Controls.Add(this.groupBox1);
            this.tPgTree.Controls.Add(this.vbTextbox2);
            this.tPgTree.Location = new System.Drawing.Point(4, 30);
            this.tPgTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgTree.Name = "tPgTree";
            this.tPgTree.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgTree.Size = new System.Drawing.Size(872, 519);
            this.tPgTree.TabIndex = 1;
            this.tPgTree.Text = "Biến đổi biểu thức bằng Tree";
            this.tPgTree.UseVisualStyleBackColor = true;
            // 
            // panelTree1
            // 
            this.panelTree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTree1.Location = new System.Drawing.Point(37, 21);
            this.panelTree1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTree1.Name = "panelTree1";
            this.panelTree1.Size = new System.Drawing.Size(599, 340);
            this.panelTree1.TabIndex = 21;
            this.panelTree1.Load += new System.EventHandler(this.panelTree1_Load);
            // 
            // tbPostfixTree
            // 
            this.tbPostfixTree.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPostfixTree.Location = new System.Drawing.Point(137, 410);
            this.tbPostfixTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPostfixTree.Multiline = true;
            this.tbPostfixTree.Name = "tbPostfixTree";
            this.tbPostfixTree.ReadOnly = true;
            this.tbPostfixTree.Size = new System.Drawing.Size(482, 35);
            this.tbPostfixTree.TabIndex = 20;
            // 
            // tbResultTree
            // 
            this.tbResultTree.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbResultTree.Location = new System.Drawing.Point(137, 449);
            this.tbResultTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbResultTree.Multiline = true;
            this.tbResultTree.Name = "tbResultTree";
            this.tbResultTree.ReadOnly = true;
            this.tbResultTree.Size = new System.Drawing.Size(482, 35);
            this.tbResultTree.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 452);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Final Postfix";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculateTree);
            this.groupBox1.Controls.Add(this.btnReadTree);
            this.groupBox1.Controls.Add(this.btnSaveTree);
            this.groupBox1.Controls.Add(this.btnStepForwardTree);
            this.groupBox1.Controls.Add(this.btnResetTree);
            this.groupBox1.Controls.Add(this.btnStartTree);
            this.groupBox1.Location = new System.Drawing.Point(682, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(173, 479);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // btnCalculateTree
            // 
            this.btnCalculateTree.BackColor = System.Drawing.Color.Silver;
            this.btnCalculateTree.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCalculateTree.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCalculateTree.BorderRadius = 5;
            this.btnCalculateTree.BorderSize = 0;
            this.btnCalculateTree.FlatAppearance.BorderSize = 0;
            this.btnCalculateTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateTree.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTree.ForeColor = System.Drawing.Color.Black;
            this.btnCalculateTree.Location = new System.Drawing.Point(24, 303);
            this.btnCalculateTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalculateTree.Name = "btnCalculateTree";
            this.btnCalculateTree.Size = new System.Drawing.Size(128, 35);
            this.btnCalculateTree.TabIndex = 5;
            this.btnCalculateTree.Text = "Tính biểu thức";
            this.btnCalculateTree.TextColor = System.Drawing.Color.Black;
            this.btnCalculateTree.UseVisualStyleBackColor = false;
            // 
            // btnReadTree
            // 
            this.btnReadTree.BackColor = System.Drawing.Color.Silver;
            this.btnReadTree.BackgroundColor = System.Drawing.Color.Silver;
            this.btnReadTree.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReadTree.BorderRadius = 5;
            this.btnReadTree.BorderSize = 0;
            this.btnReadTree.FlatAppearance.BorderSize = 0;
            this.btnReadTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadTree.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadTree.ForeColor = System.Drawing.Color.Black;
            this.btnReadTree.Location = new System.Drawing.Point(24, 253);
            this.btnReadTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReadTree.Name = "btnReadTree";
            this.btnReadTree.Size = new System.Drawing.Size(128, 35);
            this.btnReadTree.TabIndex = 4;
            this.btnReadTree.Text = "Đọc file";
            this.btnReadTree.TextColor = System.Drawing.Color.Black;
            this.btnReadTree.UseVisualStyleBackColor = false;
            // 
            // btnSaveTree
            // 
            this.btnSaveTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnSaveTree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnSaveTree.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaveTree.BorderRadius = 5;
            this.btnSaveTree.BorderSize = 0;
            this.btnSaveTree.FlatAppearance.BorderSize = 0;
            this.btnSaveTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTree.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTree.ForeColor = System.Drawing.Color.White;
            this.btnSaveTree.Location = new System.Drawing.Point(24, 202);
            this.btnSaveTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveTree.Name = "btnSaveTree";
            this.btnSaveTree.Size = new System.Drawing.Size(128, 35);
            this.btnSaveTree.TabIndex = 3;
            this.btnSaveTree.Text = "Lưu file";
            this.btnSaveTree.TextColor = System.Drawing.Color.White;
            this.btnSaveTree.UseVisualStyleBackColor = false;
            // 
            // btnStepForwardTree
            // 
            this.btnStepForwardTree.BackColor = System.Drawing.Color.Silver;
            this.btnStepForwardTree.BackgroundColor = System.Drawing.Color.Silver;
            this.btnStepForwardTree.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStepForwardTree.BorderRadius = 5;
            this.btnStepForwardTree.BorderSize = 0;
            this.btnStepForwardTree.FlatAppearance.BorderSize = 0;
            this.btnStepForwardTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepForwardTree.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStepForwardTree.ForeColor = System.Drawing.Color.Black;
            this.btnStepForwardTree.Location = new System.Drawing.Point(24, 152);
            this.btnStepForwardTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStepForwardTree.Name = "btnStepForwardTree";
            this.btnStepForwardTree.Size = new System.Drawing.Size(128, 35);
            this.btnStepForwardTree.TabIndex = 2;
            this.btnStepForwardTree.Text = "Từng bước";
            this.btnStepForwardTree.TextColor = System.Drawing.Color.Black;
            this.btnStepForwardTree.UseVisualStyleBackColor = false;
            // 
            // btnResetTree
            // 
            this.btnResetTree.BackColor = System.Drawing.Color.Silver;
            this.btnResetTree.BackgroundColor = System.Drawing.Color.Silver;
            this.btnResetTree.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResetTree.BorderRadius = 5;
            this.btnResetTree.BorderSize = 0;
            this.btnResetTree.FlatAppearance.BorderSize = 0;
            this.btnResetTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTree.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTree.ForeColor = System.Drawing.Color.Black;
            this.btnResetTree.Location = new System.Drawing.Point(24, 101);
            this.btnResetTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetTree.Name = "btnResetTree";
            this.btnResetTree.Size = new System.Drawing.Size(128, 35);
            this.btnResetTree.TabIndex = 1;
            this.btnResetTree.Text = "Làm mới";
            this.btnResetTree.TextColor = System.Drawing.Color.Black;
            this.btnResetTree.UseVisualStyleBackColor = false;
            // 
            // btnStartTree
            // 
            this.btnStartTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnStartTree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(169)))), ((int)(((byte)(249)))));
            this.btnStartTree.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStartTree.BorderRadius = 5;
            this.btnStartTree.BorderSize = 0;
            this.btnStartTree.FlatAppearance.BorderSize = 0;
            this.btnStartTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTree.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTree.ForeColor = System.Drawing.Color.White;
            this.btnStartTree.Location = new System.Drawing.Point(23, 52);
            this.btnStartTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStartTree.Name = "btnStartTree";
            this.btnStartTree.Size = new System.Drawing.Size(128, 35);
            this.btnStartTree.TabIndex = 0;
            this.btnStartTree.Text = "Bắt đầu";
            this.btnStartTree.TextColor = System.Drawing.Color.White;
            this.btnStartTree.UseVisualStyleBackColor = false;
            this.btnStartTree.Click += new System.EventHandler(this.btnStartTree_Click);
            // 
            // vbTextbox2
            // 
            this.vbTextbox2.Location = new System.Drawing.Point(170, 252);
            this.vbTextbox2.Name = "vbTextbox2";
            this.vbTextbox2.Size = new System.Drawing.Size(100, 28);
            this.vbTextbox2.TabIndex = 16;
            // 
            // tPgA
            // 
            this.tPgA.Location = new System.Drawing.Point(4, 30);
            this.tPgA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgA.Name = "tPgA";
            this.tPgA.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgA.Size = new System.Drawing.Size(872, 519);
            this.tPgA.TabIndex = 2;
            this.tPgA.Text = "Thuật toán";
            this.tPgA.UseVisualStyleBackColor = true;
            // 
            // tPgAuthor
            // 
            this.tPgAuthor.Location = new System.Drawing.Point(4, 30);
            this.tPgAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgAuthor.Name = "tPgAuthor";
            this.tPgAuthor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tPgAuthor.Size = new System.Drawing.Size(872, 519);
            this.tPgAuthor.TabIndex = 3;
            this.tPgAuthor.Text = "Thông tin tác giả";
            this.tPgAuthor.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbInput
            // 
            this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInput.Location = new System.Drawing.Point(174, 48);
            this.tbInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(627, 35);
            this.tbInput.TabIndex = 5;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(900, 667);
            this.Controls.Add(this.tCtrl);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.lbTitile);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Infix Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tCtrl.ResumeLayout(false);
            this.tPgStack.ResumeLayout(false);
            this.tPgStack.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tPgTree.ResumeLayout(false);
            this.tPgTree.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitile;
        private System.Windows.Forms.Label lbInput;
        private Custom.VBTextbox tbInput;
        private System.Windows.Forms.TabControl tCtrl;
        private System.Windows.Forms.TabPage tPgStack;
        private System.Windows.Forms.ListView lvDescription;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private Custom.VBTextbox tbPostfix;
        private Custom.VBTextbox tbResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private Custom.VBButton btnReset;
        private Custom.VBButton btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel pnlStack;
        private System.Windows.Forms.FlowLayoutPanel pnlOutput;
        private System.Windows.Forms.FlowLayoutPanel pnlInfix;
        private System.Windows.Forms.TabPage tPgTree;
        private System.Windows.Forms.TabPage tPgA;
        private System.Windows.Forms.TabPage tPgAuthor;
        private Custom.VBButton btnCalculate;
        private Custom.VBButton btnRead;
        private Custom.VBButton btnSave;
        private Custom.VBButton btnStepForward;
        private System.Windows.Forms.GroupBox groupBox1;
        private Custom.VBButton btnCalculateTree;
        private Custom.VBButton btnReadTree;
        private Custom.VBButton btnSaveTree;
        private Custom.VBButton btnStepForwardTree;
        private Custom.VBButton btnResetTree;
        private Custom.VBButton btnStartTree;
        private Custom.VBTextbox vbTextbox2;
        private Custom.VBTextbox tbPostfixTree;
        private Custom.VBTextbox tbResultTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private PanelTree panelTree1;
        private System.Windows.Forms.Timer timer1;
    }
}

