using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfixConverter
{
    public partial class Form1 : Form
    {

        Image _stack = Properties.Resources.stack;//
        Image _input = Properties.Resources.input;//

        bool _isInProcess = false;//

        Control _preCtl, _nextCtl;//


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelTree1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartTree_Click(object sender, EventArgs e)
        {
            

        }
        public void btnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("123");
            if (String.IsNullOrEmpty(tbInput.Text.Trim()))
            {
                MessageBox.Show("Không được để trống!!!");
                return;
            }
            if (!timer1.Enabled)
                //Điều khiển hẹn giờ:true=kích hoạt, false=dừng hoạt động
                //Khởi tạo = false
            {
                if (!_isInProcess)
                {

                    string infix = tbInput.Text;
                    //Format biểu thức đầu vào
                    infix = FormatExpression(infix);

                    //phân tách một biểu thức trung tố (infix) thành các token (đơn vị cơ bản) bằng cách sử dụng dấu cách làm ký tự phân tách.
                    IEnumerable<string> tokens;
                    tokens = infix.Split(' ');

                    foreach (string s in tokens)
                    {
                        Label lbl = new Label();
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Text = s;
                        lbl.BackgroundImageLayout = ImageLayout.Stretch;
                        lbl.BackgroundImage = Properties.Resources.input;

                        lbl.Width = 30;
                        lbl.Height = 30;

                        //Controls: chứa danh sách các đối tượng điều khiển con nằm trong Panel
                        pnlInfix.Controls.Add(lbl);
                    }
                    lvDescription.Items.Clear();
                    tbPostfix.Clear();
                }
                btnStart.Text = "Tạm dừng";

                //Interval:khoảng thời gian (tính bằng mili giây) giữa các lần kích hoạt của Timer. Khi Timer được kích hoạt, nó sẽ chờ đợi một khoảng thời gian (được định nghĩa bởi Interval) trước khi thực hiện hành động.
                timer1.Interval = 300;
            }
            else
            {
                if (_isInProcess)
                    btnStart.Text = "Tiếp tục";
                else
                    btnStart.Text = "Bắt đầu";
            }
            _isInProcess = true;
            timer1.Enabled = !timer1.Enabled;

            ///////////////////////////
            ///
            //string str = FormatExpression(tbInput.Text);
            //tbInput.Text = str.Replace(" ", "");

            //if (tCtrl.SelectedIndex == 0)
            //    btnStart_Click(null, null);
            //Console.WriteLine(Infix2Prefix(tbInput.Text));

            //try
            //{
            //    if (_isInfix2Prefix)
            //        tbResult.Text = EvaluatePrefix(Infix2Prefix(tbInput.Text)).ToString();
            //    else
            //        tbResult.Text = EvaluatePostfix(Infix2Postfix(tbInput.Text)).ToString();
            //}
            //catch (Exception ex)
            //{
            //    tbResult.Text = ex.Message;
            //}
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!_isInProcess)
                return;
            tbInput.Clear();
            tbPostfix.Clear();
            tbResult.Clear();
            tbInput.Controls.Clear();
            pnlInfix.Controls.Clear();
            pnlOutput.Controls.Clear();
            pnlStack.Controls.Clear();
            lvDescription.Clear();

            btnStart.Text = "Bắt đầu";
            _isInProcess = false;
            Refresh();
            //btnSave.Enabled = true;
           // btnSave.BackgroundColor = Color.FromArgb(0,117, 169, 249);

            
        }

        
        public static string Infix2Postfix(string infix)
        {
            infix = FormatExpression(infix);

            string[] tokens = infix.Split(' ').ToArray();

            return ProcessConvert(tokens);
        }

        // Chuyển đổi một biểu thức trung tố (infix) thành biểu thức hậu tố (postfix) bằng cách sử dụng thuật toán Shunting Yard. 
        private static string ProcessConvert(string[] tokens)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];
                if (IsOperator(token))
                {
                    if ((i == 0) || (i > 0 && (IsOperator(tokens[i - 1]) || tokens[i - 1] == "(")))
                    {
                        if (token == "-")
                        {
                            result.Append(token + tokens[i + 1]).Append(" ");
                            i++;
                        }
                        
                    }
                    else
                    {
                        while (stack.Count > 0 && GetPriority(token) <= GetPriority(stack.Peek()))
                            result.Append(stack.Pop()).Append(" ");
                        stack.Push(token);
                    }
                }

                else if (token == "(")
                    stack.Push(token);
                else if (token == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        result.Append(x).Append(" ");
                        x = stack.Pop();
                    }
                }
                else
                {
                    result.Append(token).Append(" ");
                }
            }

            while (stack.Count > 0)
                result.Append(stack.Pop()).Append(" ");

            return result.ToString();
        }



        //tính toán giá trị của một biểu thức hậu tố (postfix expression)
        private static double EvaluatePostfix(IEnumerable<string> tokens)
        {
            //input: tokens
            //stack: lưu trữ giá trị tạm thời trong qt tính toán
            Stack<double> stack = new Stack<double>();

            foreach (string s in tokens)
            {
                if (IsOperator(s))
                {
                    double x = stack.Pop();

                  
                        double y = stack.Pop();

                    //Nếu token là một toán tử, hàm thực hiện phép tính tương ứng (cộng, trừ, nhân, chia, phần dư) giữa hai giá trị được lấy từ stack.
                    switch (s)
                        {
                            case "+": y += x; break;
                            case "-": y -= x; break;
                            case "*": y *= x; break;
                            case "/": y /= x; break;
                            case "%": y %= x; break;
                            default:
                                throw new Exception("Invalid operator");
                        }

                        stack.Push(y);
                    
                }
                else  
                //Nếu token không phải là toán tử, nó được chuyển thành số và đẩy vào stack.
                {
                    stack.Push(double.Parse(s));
                }

            }
            return stack.Pop();
        }



        //xử lý biểu thức hậu tố (postfix expression)
        private void ProcessPostfix(Control ctl)
        {
            //Đầu vào: Hàm nhận một đối tượng Control (ctl) làm đối số.
            if (IsOperator(ctl.Text))
            {
                //Nếu mã thông báo hiện tại (ctl.Text) là một toán tử, hàm kiểm tra xem điều khiển trước đó (_preCtl) cũng có phải là toán tử không.
                if (_preCtl != null && IsOperator(_preCtl.Text))
                {
                    //Nếu có, và toán tử hiện tại là “-”, nó sẽ nối nó với văn bản của điều khiển tiếp theo (_nextCtl.Text) và đưa ra kết quả.
                    if (ctl.Text == "-")
                    {
                        _nextCtl.Text = ctl.Text + _nextCtl.Text;
                        Output(_nextCtl);
                    }
                    
                }
                //Ngược lại, nó xử lý ưu tiên của toán tử và đẩy nó vào ngăn xếp
                else
                {
                    while (pnlStack.Controls.Count > 0 &&
                        GetPriority(ctl.Text) <= GetPriority(PeekStack().Text))
                        Output(PopStack());
                    PushStack(ctl);
                }
            }

            else if (ctl.Text == "(")
                PushStack(ctl);
            else if (ctl.Text == ")")
            {
                Control x = PopStack();
                while (x.Text != "(")
                {
                    Output(x);
                    x = PopStack();
                }
            }
            else //ko phải toán hạng==> đưa ra output
            {
                Output(ctl);
            }

        }

        //Xét độ ưu tiên toán tử
        public static int GetPriority(string op)
        {
           
            if (op == "*" || op == "/" || op == "%" || op == "^")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }

        
        //Là toán tử
        public static bool IsOperator(string str)
        {
            return Regex.Match(str, @"^(\+|\-|\*|\/|\%|\^|)$").Success;
        }

        //trả về phần tử ở đỉnh của stack mà không loại bỏ nó khỏi stack.
        Control PeekStack()
        {
            //Truy cập vào danh sách các controls trong pnlStack.
            //Lấy phần tử cuối cùng(đỉnh của stack) bằng cách sử dụng chỉ số pnlStack.Controls.Count - 1.
            return pnlStack.Controls[pnlStack.Controls.Count - 1];
        }

        //trả về phần tử ở đỉnh của stack và loại bỏ nó khỏi stack.
        Control PopStack()
        {
            Control ctl = pnlStack.Controls[pnlStack.Controls.Count - 1];
            pnlStack.Controls.Remove(ctl);

            return ctl;
        }


        //Hàm này thêm một control (ctl) vào stack được hiển thị trên giao diện (pnlStack).
        void PushStack(Control ctl)
        {
            //để thêm ctl vào danh sách các controls trong pnlStack
            pnlStack.Controls.Add(ctl);

            //Nếu pnlStack đã chứa ít nhất 2 controls, hàm sẽ đặt hình nền cho control ngay trước ctl bằng _input
            if (pnlStack.Controls.Count > 1)
                pnlStack.Controls[pnlStack.Controls.Count - 2].BackgroundImage = _input;
        }

        //thêm một control (ctl) vào stack khác (pnlOutput)
        void Output(Control ctl)
        {
            pnlOutput.Controls.Add(ctl);

            if (pnlOutput.Controls.Count > 1)
                pnlOutput.Controls[pnlOutput.Controls.Count - 2].BackgroundImage = _input;
        }

        void AddToListView(Control ctl)
        {
            string s = String.Empty;
            if (ctl != null)
                s = ctl.Text;
            ListViewItem item = lvDescription.Items.Add(s);
            StringBuilder str = new StringBuilder();

            // stack
            foreach (Control c in pnlStack.Controls)
                str.Append(c.Text).Append(" ");

            s = str.ToString().Trim();
            if (s == String.Empty)
                s = "{Empty}";

            item.SubItems.Add(s);

            // output
            str = new StringBuilder();
            foreach (Control c in pnlOutput.Controls)
                str.Append(c.Text).Append(" ");

            s = str.ToString().Trim();
            if (s == String.Empty)
                s = "{Empty}";
            item.SubItems.Add(s);

            if (lvDescription.Items.Count > 1)
                lvDescription.Items[lvDescription.Items.Count - 2].Selected = false;

            item.Selected = true;

            lvDescription.TopItem = item;
        }

        //timer1_Tick được gọi mỗi khi một khoảng thời gian đã định trước trôi qua
        private void timer1_Tick(object sender, EventArgs e)
        {
            StepForward();
        }


        private void btnStepForward_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                btnStart_Click(null, null);
                btnStart.Text = "Resume";
                timer1.Stop();
                StepForward();
            }
        }

        private void StepForward()
        {
            try
            {
                if (pnlInfix.Controls.Count > 0)
                {
                    Control ctl = pnlInfix.Controls[0];
                    ctl.BackgroundImage = _stack;

                    pnlInfix.Controls.Remove(ctl);

                    if (pnlInfix.Controls.Count > 0)
                        _nextCtl = pnlInfix.Controls[0];

                    ProcessPostfix(ctl);

                    AddToListView(ctl);

                    _preCtl = ctl;
                }
                else if (pnlStack.Controls.Count > 0)
                {
                    Control ctl = PopStack();
                    Output(ctl);

                    // last 
                    if (pnlInfix.Controls.Count == 0 && pnlStack.Controls.Count == 0)
                        AddToListView(null);
                }
                else if (pnlOutput.Controls.Count > 0) // final expression
                {
                    int index = 0;
                    //if (_isInfix2Prefix)
                       // index = pnlOutput.Controls.Count - 1;

                    if (pnlOutput.Controls.Count > 1)
                        pnlOutput.Controls[pnlOutput.Controls.Count - 1].BackgroundImage = _stack;

                    Control ctl = pnlOutput.Controls[index];

                    tbPostfix.Text += ctl.Text + " ";
                    pnlOutput.Controls.Remove(ctl);

                    ctl.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt"; // Thay đổi filter để chỉ hiển thị các file có đuôi .txt

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Nếu tệp không tồn tại, tạo mới và ghi dữ liệu vào
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("infix").Append(tbInput.Text).AppendLine("");
                stringBuilder.Append("postfix").Append(tbPostfix.Text).AppendLine("");
                stringBuilder.AppendLine(tbResult.Text);

                stringBuilder.Append("Token").Append("Stack").Append("Output").AppendLine("");
                

                foreach (ListViewItem item in lvDescription.Items)
                {
                    stringBuilder.Append(item.Text).Append(item.SubItems[1].Text).Append(item.SubItems[2].Text).AppendLine("");
                    
                }
                try
                {
                    StreamWriter writer = new StreamWriter(dlg.FileName);

                    writer.Write(stringBuilder.ToString());
                    //writer.Flush();
                    writer.Close();
                    writer.Dispose();

                    if (DialogResult.Yes ==
                        MessageBox.Show(
                        @"Lưu file thành công", "Lưu file",
                                      MessageBoxButtons.OK, MessageBoxIcon.Question))
                    {

                        Process.Start(dlg.FileName);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void btnRead_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        // Insert code to read the stream here.
                        string file = File.ReadAllText(openFileDialog1.FileName);
                        int startInfix = file.IndexOf("infix");
                        int endPostfix = file.IndexOf("postfix", startInfix);
                        string extractedData = file.Substring(startInfix+5, endPostfix - startInfix-5);
                        tbInput.Text = extractedData; // Display the text in your TextBox
                        btnStart_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tbResult.Text = EvaluatePostfix(Infix2Postfix(tbInput.Text)).ToString();
        }


        //chuyển đổi biểu thức postfix thành mảng các phần tử và sau đó đánh giá kết quả của biểu thức đó
        private object EvaluatePostfix(string v)
        {
            return EvaluatePostfix(v.Trim().Split(' '));
        }

        public static string FormatExpression(string expression)
        {
            //Loại bỏ khoảng trắng+ biến thành chữ thường
            expression = expression.ToLower().Replace(" ", "");

            //tìm và thay thế bất kỳ chuỗi nào chứa 3 hoặc nhiều ký tự toán học liên tiếp (ví dụ: “+++”, “—”, “^^^”) bằng ký tự đầu tiên của chuỗi đó.
            expression = Regex.Replace(expression, @"(\+|\-|\*|\/|\%|\^){3,}", match => match.Value[0].ToString());

            //tìm và thay thế bất kỳ cặp ký tự toán học liên tiếp (ví dụ: “±”, “*/”, “^%”) bằng ký tự đầu tiên của cặp đó
            expression = Regex.Replace(expression, @"(\+|\-|\*|\/|\%|\^)(\+|\*|\/|\%|\^)", match =>
                match.Value[0].ToString()
            );

            //thay thế tất cả các ký tự toán học (+, -, *, /, %, ^, ), (, ) trong biểu thức bằng một khoảng trắng trước và sau ký tự đó.
            expression = Regex.Replace(expression, @"\+|\-|\*|\/|\%|\^|\)|\(", match =>
                String.Format(" {0} ", match.Value)
            );

            //Loại bỏ khoảng trắng thừa
            expression = expression.Replace("  ", " ");

            //Loại khoảng trắng đầu & cuối biểu thức
            expression = expression.Trim();

            return expression;
        }
    }
}
