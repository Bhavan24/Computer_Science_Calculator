using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Hex2Binary(String hex)
        {
            int decimal_value = Convert.ToInt32(hex, 16);
            string Base = Convert.ToString(decimal_value, 2);
            return Base;
        }
        private string Hex2Decimal(String hex)
        {
            int decimal_value = Convert.ToInt32(hex, 16);
            string d = Convert.ToString(decimal_value);
            return d;
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                int binaryNumber = int.Parse(txt2.Text);
                int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
                txt10.Text = Convert.ToString(decimalValue);
                int number = int.Parse(txt10.Text);
                string Base = Convert.ToString(number, 2);
                txt2.Text = Base;
                string Base1 = Convert.ToString(number, 8);
                txt8.Text = Base1;
                string Base2 = Convert.ToString(number, 16);
                txt16.Text = Base2.ToUpper();
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                int octnum = 0, r = 0;
                int i = 0;
                double decnum = 0;
                octnum = int.Parse(txt8.Text);
                while (octnum != 0)
                {
                    r = octnum % 10;
                    decnum = decnum + (r * Math.Pow(8, i++));
                    octnum = octnum / 10;
                }
                txt10.Text = decnum.ToString();
                int number = int.Parse(txt10.Text);
                string Base = Convert.ToString(number, 2);
                txt2.Text = Base;
                string Base2 = Convert.ToString(number, 16);
                txt16.Text = Base2.ToUpper();
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txt10.Text);
                string Base1 = Convert.ToString(number, 8);
                txt8.Text = Base1;
                string Base2 = Convert.ToString(number, 16);
                txt16.Text = Base2.ToUpper();
                string Base = Convert.ToString(number, 2);
                if (number < 0)
                {
                    int len = Base.Length - 8;
                    txt2.Text = Base.Substring(len);
                }
                else
                {
                    txt2.Text = Base;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            try
            {
                string hex_value = txt16.Text;
                int int_value = Convert.ToInt32(hex_value, 16);
                txt10.Text = Convert.ToString(int_value);
                int number = int.Parse(txt10.Text);
                string Base = Convert.ToString(number, 2);
                txt2.Text = Base;
                string Base2 = Convert.ToString(number, 8);
                txt8.Text = Base2;
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt2.Clear();
            txt8.Clear();
            txt10.Clear();
            txt16.Clear();
            txt2.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int binary_Number_1 = int.Parse(txtadd1.Text);
                int decimal_Value_1 = Convert.ToInt32(binary_Number_1.ToString(), 2);
                int binary_Number_2 = int.Parse(txtadd2.Text);
                int decimal_Value_2 = Convert.ToInt32(binary_Number_2.ToString(), 2);
                int decimalValue = decimal_Value_1 + decimal_Value_2;
                string Base = Convert.ToString(decimalValue, 2);
                txtaddans.Text = Base;
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                int binary_Number_1 = int.Parse(txtsub1.Text);
                int decimal_Value_1 = Convert.ToInt32(binary_Number_1.ToString(), 2);
                int binary_Number_2 = int.Parse(txtsub2.Text);
                int decimal_Value_2 = Convert.ToInt32(binary_Number_2.ToString(), 2);
                int decimalValue = decimal_Value_1 - decimal_Value_2;
                string Base = Convert.ToString(decimalValue, 2);
                txtsubans.Text = Base;
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                int binary_Number_1 = int.Parse(txtM1.Text);
                int decimal_Value_1 = Convert.ToInt32(binary_Number_1.ToString(), 2);
                int binary_Number_2 = int.Parse(txtM2.Text);
                int decimal_Value_2 = Convert.ToInt32(binary_Number_2.ToString(), 2);
                int decimalValue = decimal_Value_1 * decimal_Value_2;
                string Base = Convert.ToString(decimalValue, 2);
                txtMans.Text = Base;
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int binary_Number_1 = int.Parse(txtD1.Text);
                int decimal_Value_1 = Convert.ToInt32(binary_Number_1.ToString(), 2);
                int binary_Number_2 = int.Parse(txtD2.Text);
                int decimal_Value_2 = Convert.ToInt32(binary_Number_2.ToString(), 2);
                double decimalValue = decimal_Value_1 / decimal_Value_2;
                int decimalValuex = Convert.ToInt32(decimalValue);
                string Base = Convert.ToString(decimalValuex, 2);
                txtDans.Text = Base;
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static String decimalToBinary(double num, int k_prec)
        {
            String binary = "";
            int Integral = (int)num;
            double fractional = num - Integral;
            while (Integral > 0)
            {
                int rem = Integral % 2;
                binary += ((char)(rem + '0'));
                Integral /= 2;
            }
            binary = reverse(binary);
            binary += ('.');
            while (k_prec-- > 0)
            {
                fractional *= 2;
                int fract_bit = (int)fractional;
                if (fract_bit == 1)
                {
                    fractional -= fract_bit;
                    binary += (char)(1 + '0');
                }
                else
                {
                    binary += (char)(0 + '0');
                }
            }
            return binary;
        }

        static String reverse(String input)
        {
            char[] temparray = input.ToCharArray();
            int left, right = 0;
            right = temparray.Length - 1;
            for (left = 0; left < right; left++, right--)
            {
                char temp = temparray[left];
                temparray[left] = temparray[right];
                temparray[right] = temp;
            }
            return String.Join("", temparray);
        }

        private void btnIEEE_Click(object sender, EventArgs e)
        {
            try
            {
                int k = 10;
                double n = Convert.ToDouble(txtnum.Text);
                txtans.Text = decimalToBinary(n, k);

                string s = txtSign.Text;
                if (s == "+" || s == "")
                {
                    t1.Text = "0";
                }
                if (s == "-")
                {
                    t1.Text = "1";
                }

                String numz = txtans.Text;
                int num1 = numz.IndexOf(".");
                numz = numz.Replace(".", "");
                String new_num = numz.Insert(1, ".");
                txtNormal.Text = new_num;
                int num2 = new_num.IndexOf(".");
                int i = num1 - num2;
                txtExp.Text = Convert.ToString(i);

                txtExp.Text = Convert.ToString(i);
                txtMantissa.Text = txtNormal.Text;

                int exp = i + 127;
                string Base_x = Convert.ToString(exp, 2);
                txtExpBin.Text = Base_x;

                String man = txtMantissa.Text;
                man = man.Remove(0, 2);
                txtManBits.Text = man;

                String exp_array = txtExpBin.Text;
                char[] char_array = exp_array.ToCharArray();
                t2.Text = Convert.ToString(char_array[0]);
                t3.Text = Convert.ToString(char_array[1]);
                t4.Text = Convert.ToString(char_array[2]);
                t5.Text = Convert.ToString(char_array[3]);
                t6.Text = Convert.ToString(char_array[4]);
                t7.Text = Convert.ToString(char_array[5]);
                t8.Text = Convert.ToString(char_array[6]);
                t9.Text = Convert.ToString(char_array[7]);

                String exp_array_1 = txtManBits.Text;
                char[] char_array_1 = exp_array_1.ToCharArray();
                t10.Text = Convert.ToString(char_array_1[0]);
                t11.Text = Convert.ToString(char_array_1[1]);
                t12.Text = Convert.ToString(char_array_1[2]);
                t13.Text = Convert.ToString(char_array_1[3]);
                t14.Text = Convert.ToString(char_array_1[4]);
                t15.Text = Convert.ToString(char_array_1[5]);
                t16.Text = Convert.ToString(char_array_1[6]);
                t17.Text = Convert.ToString(char_array_1[7]);
                t18.Text = Convert.ToString(char_array_1[8]);
                t19.Text = Convert.ToString(char_array_1[9]);
                t20.Text = Convert.ToString(char_array_1[10]);

                t21.Text = "0";
                t22.Text = "0";
                t23.Text = "0";
                t24.Text = "0";
                t25.Text = "0";
                t26.Text = "0";
                t27.Text = "0";
                t28.Text = "0";
                t29.Text = "0";
                t30.Text = "0";
                t31.Text = "0";
                t32.Text = "0";

                String hex_1, hex_2, hex_3, hex_4, hex_5, hex_6, hex_7, hex_8;
                hex_1 = (t1.Text) + (t2.Text) + (t3.Text) + (t4.Text);
                hex_2 = (t5.Text) + (t6.Text) + (t7.Text) + (t8.Text);
                hex_3 = (t9.Text) + (t10.Text) + (t11.Text) + (t12.Text);
                hex_4 = (t13.Text) + (t14.Text) + (t15.Text) + (t16.Text);
                hex_5 = (t17.Text) + (t18.Text) + (t19.Text) + (t20.Text);
                hex_6 = (t21.Text) + (t22.Text) + (t23.Text) + (t24.Text);
                hex_7 = (t25.Text) + (t26.Text) + (t27.Text) + (t28.Text);
                hex_8 = (t29.Text) + (t30.Text) + (t31.Text) + (t32.Text);

                int binaryNumber = int.Parse(hex_1);
                int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
                string Base2 = Convert.ToString(decimalValue, 16);
                h1.Text = Base2.ToUpper();

                int binaryNumber1 = int.Parse(hex_2);
                int decimalValue1 = Convert.ToInt32(binaryNumber1.ToString(), 2);
                string Base21 = Convert.ToString(decimalValue1, 16);
                h2.Text = Base21.ToUpper();

                int binaryNumber2 = int.Parse(hex_3);
                int decimalValue2 = Convert.ToInt32(binaryNumber2.ToString(), 2);
                string Base22 = Convert.ToString(decimalValue2, 16);
                h3.Text = Base22.ToUpper();

                int binaryNumber3 = int.Parse(hex_4);
                int decimalValue3 = Convert.ToInt32(binaryNumber3.ToString(), 2);
                string Base23 = Convert.ToString(decimalValue3, 16);
                h4.Text = Base23.ToUpper();

                int binaryNumber4 = int.Parse(hex_5);
                int decimalValue4 = Convert.ToInt32(binaryNumber4.ToString(), 2);
                string Base24 = Convert.ToString(decimalValue4, 16);
                h5.Text = Base24.ToUpper();

                int binaryNumber5 = int.Parse(hex_6);
                int decimalValue5 = Convert.ToInt32(binaryNumber5.ToString(), 2);
                string Base25 = Convert.ToString(decimalValue5, 16);
                h6.Text = Base25.ToUpper();

                int binaryNumber6 = int.Parse(hex_7);
                int decimalValue6 = Convert.ToInt32(binaryNumber6.ToString(), 2);
                string Base26 = Convert.ToString(decimalValue6, 16);
                h7.Text = Base26.ToUpper();

                int binaryNumber7 = int.Parse(hex_8);
                int decimalValue7 = Convert.ToInt32(binaryNumber7.ToString(), 2);
                string Base27 = Convert.ToString(decimalValue7, 16);
                h8.Text = Base27.ToUpper();
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnResetMBR_Click(object sender, EventArgs e)
        {
            p1.Clear();
            p2.Clear();
            p3.Clear();
            p4.Clear();
            p5.Clear();
            p6.Clear();
            p7.Clear();
            p8.Clear();
            p9.Clear();
            p10.Clear();
            p11.Clear();
            p12.Clear();
            p13.Clear();
            p14.Clear();
            p15.Clear();
            p16.Clear();
        }

        private void btnMBR_Click(object sender, EventArgs e)
        {
            try
            {
                //Bootable flag
                bf1.Text = p1.Text;
                bf2.Text = bf1.Text;
                if (p1.Text == "00")
                {
                    bf3.Text = "Non Bootable";
                }
                else
                {
                    bf3.Text = "Bootable";
                }

                //STARTING CHS ADDRESS
                String chs_LE = p2.Text + " " + p3.Text + " " + p4.Text;
                schs1.Text = chs_LE;
                String chs_BE = p4.Text + " " + p3.Text + " " + p2.Text;
                schs2.Text = chs_BE;
                chs_BE = chs_BE.Replace(" ", "");
                int int_value_1 = Convert.ToInt32(chs_BE, 16);
                schs3.Text = Convert.ToString(int_value_1);

                //PARTIOTION TYPE
                pt1.Text = p5.Text;
                pt2.Text = pt1.Text;
                String type = p5.Text;

                if (type == "00")
                {
                    pt3.Text = "Empty";
                }
                else if (type == "01")
                {
                    pt3.Text = "FAT12";
                }
                else if (type == "04")
                {
                    pt3.Text = "FAT 16, 16 - 32 MB";
                }
                else if (type == "06")
                {
                    pt3.Text = "FAT 16, 32 MB – 2GB";
                }
                else if (type == "07")
                {
                    pt3.Text = "NTFS";
                }
                else if ((type == "0b") || (type == "0B"))
                {
                    pt3.Text = "FAT32";
                }
                else if ((type == "0c") || (type == "0C"))
                {
                    pt3.Text = "FAT32";
                }
                else if (type == "82")
                {
                    pt3.Text = "Solaris x86";
                }
                else if (type == "83")
                {
                    pt3.Text = "Linux";
                }
                else if ((type == "a5") || (type == "A5"))
                {
                    pt3.Text = "FreeBSD";
                }
                else if ((type == "a6") || (type == "A6"))
                {
                    pt3.Text = "OpenBSD";
                }
                else if ((type == "a8") || (type == "A8"))
                {
                    pt3.Text = "Mac OSX";
                }
                else
                {
                    pt3.Text = "NO";
                }

                //ENDING CHS ASSRESS
                String echs_LE = p6.Text + " " + p7.Text + " " + p8.Text;
                echs1.Text = echs_LE;
                String echs_BE = p8.Text + " " + p7.Text + " " + p6.Text;
                echs2.Text = echs_BE;
                echs_BE = echs_BE.Replace(" ", "");
                int int_value_2 = Convert.ToInt32(echs_BE, 16);
                echs3.Text = Convert.ToString(int_value_2);

                //STARTING LBA ADDRESS
                String lba_LE = p9.Text + " " + p10.Text + " " + p11.Text + " " + p12.Text;
                lba1.Text = lba_LE;
                String lba_BE = p12.Text + " " + p11.Text + " " + p10.Text + " " + p9.Text;
                lba2.Text = lba_BE;
                lba_BE = lba_BE.Replace(" ", "");
                int int_value_3 = Convert.ToInt32(lba_BE, 16);
                lba3.Text = Convert.ToString(int_value_3);

                //SIZE IN SECTORS
                String sec_LE = p13.Text + " " + p14.Text + " " + p15.Text + " " + p16.Text;
                sec1.Text = sec_LE;
                String sec_BE = p16.Text + " " + p15.Text + " " + p14.Text + " " + p13.Text;
                sec2.Text = sec_BE;
                sec_BE = sec_BE.Replace(" ", "");
                int int_value_4 = Convert.ToInt32(sec_BE, 16);
                sec3.Text = Convert.ToString(int_value_4);


                //kb and mb
                int size = Convert.ToInt32(sec3.Text);
                double size_1 = size / 2;
                secKB.Text = Convert.ToString(size_1);
                double size_2 = size_1 / 1024;
                secMB.Text = Convert.ToString(size_2);
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter Valid Input", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnresetiee_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtans.Clear();
            h1.Clear();
            h2.Clear();
            h3.Clear();
            h4.Clear();
            h5.Clear();
            h6.Clear();
            h7.Clear();
            h8.Clear();
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t7.Clear();
            t8.Clear();
            t9.Clear();
            t10.Clear();
            t11.Clear();
            t12.Clear();
            t13.Clear();
            t14.Clear();
            t15.Clear();
            t16.Clear();
            t17.Clear();
            t18.Clear();
            t19.Clear();
            t20.Clear();
            t21.Clear();
            t22.Clear();
            t23.Clear();
            t24.Clear();
            t25.Clear();
            t26.Clear();
            t27.Clear();
            t28.Clear();
            t29.Clear();
            t30.Clear();
            t31.Clear();
            t32.Clear();
            txtSign.Clear();
            txtNormal.Clear();
            txtManBits.Clear();
            txtExpBin.Clear();
            txtMantissa.Clear();
            txtExp.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int binaryNumber = int.Parse(txtaddans.Text);
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            addDEC.Text = Convert.ToString(decimalValue);
            int number = int.Parse(addDEC.Text);
            string Base1 = Convert.ToString(number, 8);
            addOCT.Text = Base1;
            string Base2 = Convert.ToString(number, 16);
            addHEX.Text = Base2.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int binaryNumber = int.Parse(txtsubans.Text);
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            subDEC.Text = Convert.ToString(decimalValue);
            int number = int.Parse(subDEC.Text);
            string Base1 = Convert.ToString(number, 8);
            subOCT.Text = Base1;
            string Base2 = Convert.ToString(number, 16);
            subHEX.Text = Base2.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int binaryNumber = int.Parse(txtMans.Text);
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            mulDEC.Text = Convert.ToString(decimalValue);
            int number = int.Parse(mulDEC.Text);
            string Base1 = Convert.ToString(number, 8);
            mulOCT.Text = Base1;
            string Base2 = Convert.ToString(number, 16);
            mulHEX.Text = Base2.ToUpper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int binaryNumber = int.Parse(txtDans.Text);
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            divDEC.Text = Convert.ToString(decimalValue);
            int number = int.Parse(mulDEC.Text);
            string Base1 = Convert.ToString(number, 8);
            divOCT.Text = Base1;
            string Base2 = Convert.ToString(number, 16);
            divHEX.Text = Base2.ToUpper();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double total = num1 + num2;
            txtFINAL.Text = Convert.ToString(total);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double total = num1 - num2;
            txtFINAL.Text = Convert.ToString(total);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double total = num1 * num2;
            txtFINAL.Text = Convert.ToString(total);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double total = num1 / num2;
            txtFINAL.Text = Convert.ToString(total);
        }


        private void btnAND_Click(object sender, EventArgs e)
        {
            l1.Text = "0";
            l2.Text = "0";
            l3.Text = "0";
            l4.Text = "0";
            l5.Text = "0";
            l6.Text = "0";
            l7.Text = "0";
            l8.Text = "0";

            if (j1.Text == "1" && k1.Text == "1")
            {
                l1.Text = "1";
            }

            if (j1.Text == "1" && k1.Text == "1")
            {
                l1.Text = "1";
            }

            if (j2.Text == "1" && k2.Text == "1")
            {
                l2.Text = "1";
            }

            if (j3.Text == "1" && k3.Text == "1")
            {
                l3.Text = "1";
            }

            if (j4.Text == "1" && k4.Text == "1")
            {
                l4.Text = "1";
            }

            if (j5.Text == "1" && k5.Text == "1")
            {
                l5.Text = "1";
            }

            if (j6.Text == "1" && k6.Text == "1")
            {
                l6.Text = "1";
            }

            if (j7.Text == "1" && k7.Text == "1")
            {
                l7.Text = "1";
            }

            if (j8.Text == "1" && k8.Text == "1")
            {
                l8.Text = "1";
            }


        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            l1.Text = "1";
            l2.Text = "1";
            l3.Text = "1";
            l4.Text = "1";
            l5.Text = "1";
            l6.Text = "1";
            l7.Text = "1";
            l8.Text = "1";

            if (j1.Text == "0" && k1.Text == "0")
            {
                l1.Text = "0";
            }

            if (j1.Text == "0" && k1.Text == "0")
            {
                l1.Text = "0";
            }

            if (j2.Text == "0" && k2.Text == "0")
            {
                l2.Text = "0";
            }

            if (j3.Text == "0" && k3.Text == "0")
            {
                l3.Text = "0";
            }

            if (j4.Text == "0" && k4.Text == "0")
            {
                l4.Text = "0";
            }

            if (j5.Text == "0" && k5.Text == "0")
            {
                l5.Text = "0";
            }

            if (j6.Text == "0" && k6.Text == "0")
            {
                l6.Text = "0";
            }

            if (j7.Text == "0" && k7.Text == "0")
            {
                l7.Text = "0";
            }

            if (j8.Text == "0" && k8.Text == "0")
            {
                l8.Text = "0";
            }
        }

        private void btnNOT_Click(object sender, EventArgs e)
        {
            l1.Text = "1";
            l2.Text = "1";
            l3.Text = "1";
            l4.Text = "1";
            l5.Text = "1";
            l6.Text = "1";
            l7.Text = "1";
            l8.Text = "1";
            k1.Text = "-";
            k2.Text = "-";
            k3.Text = "-";
            k4.Text = "-";
            k5.Text = "-";
            k6.Text = "-";
            k7.Text = "-";
            k8.Text = "-";

            if (j1.Text == "1")
            {
                l1.Text = "0";
            }
            if (j2.Text == "1")
            {
                l2.Text = "0";
            }
            if (j3.Text == "1")
            {
                l3.Text = "0";
            }
            if (j4.Text == "1")
            {
                l4.Text = "0";
            }
            if (j5.Text == "1")
            {
                l5.Text = "0";
            }
            if (j6.Text == "1")
            {
                l6.Text = "0";
            }
            if (j7.Text == "1")
            {
                l7.Text = "0";
            }
            if (j8.Text == "1")
            {
                l8.Text = "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String x = l1.Text + l2.Text + l3.Text + l4.Text + l5.Text + l6.Text + l7.Text + l8.Text;
            int binaryNumber = int.Parse(x);
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            opDEC.Text = Convert.ToString(decimalValue);
            int number = int.Parse(opDEC.Text);
            string Base1 = Convert.ToString(number, 8);
            opOCT.Text = Base1;
            string Base2 = Convert.ToString(number, 16);
            opHEX.Text = Base2.ToUpper();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            j1.Clear();
            j2.Clear();
            j3.Clear();
            j4.Clear();
            j5.Clear();
            j6.Clear();
            j7.Clear();
            j8.Clear();
            k1.Clear();
            k2.Clear();
            k3.Clear();
            k4.Clear();
            k5.Clear();
            k6.Clear();
            k7.Clear();
            k8.Clear();
            l1.Clear();
            l2.Clear();
            l3.Clear();
            l4.Clear();
            l5.Clear();
            l6.Clear();
            l7.Clear();
            l8.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            j1.Clear();
            j2.Clear();
            j3.Clear();
            j4.Clear();
            j5.Clear();
            j6.Clear();
            j7.Clear();
            j8.Clear();
            k1.Clear();
            k2.Clear();
            k3.Clear();
            k4.Clear();
            k5.Clear();
            k6.Clear();
            k7.Clear();
            k8.Clear();
            l1.Clear();
            l2.Clear();
            l3.Clear();
            l4.Clear();
            l5.Clear();
            l6.Clear();
            l7.Clear();
            l8.Clear();
            txtnum.Clear();
            txtans.Clear();
            h1.Clear();
            h2.Clear();
            h3.Clear();
            h4.Clear();
            h5.Clear();
            h6.Clear();
            h7.Clear();
            h8.Clear();
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t7.Clear();
            t8.Clear();
            t9.Clear();
            t10.Clear();
            t11.Clear();
            t12.Clear();
            t13.Clear();
            t14.Clear();
            t15.Clear();
            t16.Clear();
            t17.Clear();
            t18.Clear();
            t19.Clear();
            t20.Clear();
            t21.Clear();
            t22.Clear();
            t23.Clear();
            t24.Clear();
            t25.Clear();
            t26.Clear();
            t27.Clear();
            t28.Clear();
            t29.Clear();
            t30.Clear();
            t31.Clear();
            t32.Clear();
            txtSign.Clear();
            txtNormal.Clear();
            txtManBits.Clear();
            txtExpBin.Clear();
            txtMantissa.Clear();
            txtExp.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string x1 = hexfull(ir1.Text);
                string x2 = hexfull(ir2.Text);
                string x3 = hexfull(ir3.Text);
                string x4 = hexfull(ir4.Text);
                string x5 = hexfull(ir5.Text);
                string x6 = hexfull(ir6.Text);
                string x7 = hexfull(ir7.Text);
                string x8 = hexfull(ir8.Text);


                char[] char_array_0 = x1.ToCharArray();
                a1.Text = Convert.ToString(char_array_0[0]);
                a2.Text = Convert.ToString(char_array_0[1]);
                a3.Text = Convert.ToString(char_array_0[2]);
                a4.Text = Convert.ToString(char_array_0[3]);


                char[] char_array_1 = x2.ToCharArray();
                a5.Text = Convert.ToString(char_array_1[0]);
                a6.Text = Convert.ToString(char_array_1[1]);
                a7.Text = Convert.ToString(char_array_1[2]);
                a8.Text = Convert.ToString(char_array_1[3]);


                char[] char_array_2 = x3.ToCharArray();
                a9.Text = Convert.ToString(char_array_2[0]);
                a10.Text = Convert.ToString(char_array_2[1]);
                a11.Text = Convert.ToString(char_array_2[2]);
                a12.Text = Convert.ToString(char_array_2[3]);


                char[] char_array_3 = x4.ToCharArray();
                a13.Text = Convert.ToString(char_array_3[0]);
                a14.Text = Convert.ToString(char_array_3[1]);
                a15.Text = Convert.ToString(char_array_3[2]);
                a16.Text = Convert.ToString(char_array_3[3]);


                char[] char_array_4 = x5.ToCharArray();
                a17.Text = Convert.ToString(char_array_4[0]);
                a18.Text = Convert.ToString(char_array_4[1]);
                a19.Text = Convert.ToString(char_array_4[2]);
                a20.Text = Convert.ToString(char_array_4[3]);


                char[] char_array_5 = x6.ToCharArray();
                a21.Text = Convert.ToString(char_array_5[0]);
                a22.Text = Convert.ToString(char_array_5[1]);
                a23.Text = Convert.ToString(char_array_5[2]);
                a24.Text = Convert.ToString(char_array_5[3]);


                char[] char_array_6 = x7.ToCharArray();
                a25.Text = Convert.ToString(char_array_6[0]);
                a26.Text = Convert.ToString(char_array_6[1]);
                a27.Text = Convert.ToString(char_array_6[2]);
                a28.Text = Convert.ToString(char_array_6[3]);


                char[] char_array_7 = x8.ToCharArray();
                a29.Text = Convert.ToString(char_array_7[0]);
                a30.Text = Convert.ToString(char_array_7[1]);
                a31.Text = Convert.ToString(char_array_7[2]);
                a32.Text = Convert.ToString(char_array_7[3]);


                string exp = a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + a8.Text + a9.Text;
                int binaryNumber = int.Parse(exp);
                int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
                int exponent_value = decimalValue - 127;
                irexp.Text = Convert.ToString(exponent_value);

                string mantissa = a10.Text + a11.Text + a12.Text + a13.Text + a14.Text + a15.Text + a16.Text + a17.Text + a18.Text + a19.Text + a20.Text + a21.Text + a22.Text + a23.Text + a24.Text + a25.Text + a26.Text + a27.Text + a28.Text + a29.Text + a30.Text + a31.Text + a32.Text;
                mantissa = mantissa.Insert(0, "1");
                mantissa = mantissa.Insert(1, ".");
                irnornum.Text = mantissa;

                string mantissa_new = mantissa.Replace(".", "");
                irbin.Text = mantissa_new.Insert(exponent_value + 1, ".");

                if (a1.Text == "0")
                {
                    irsign.Text = "+";
                }
                if (a1.Text == "1")
                {
                    irsign.Text = "-";
                }

                string n = irbin.Text;
                irdec.Text = Convert.ToString(binaryToDecimal(n, n.Length));


                string sign = irsign.Text;
                double final_num = Convert.ToDouble(irdec.Text);
                string final = Convert.ToString(Math.Round(final_num, 2));
                txtend.Text = sign + final;
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter Valid Input", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static double binaryToDecimal(string binary, int len)
        {

            int point = binary.IndexOf('.');
            if (point == -1)
                point = len;

            double intDecimal = 0,
                   fracDecimal = 0,
                   twos = 1;
            for (int i = point - 1; i >= 0; i--)
            {
                intDecimal += (binary[i] - '0') * twos;
                twos *= 2;
            }
            twos = 2;
            for (int i = point + 1; i < len; i++)
            {
                fracDecimal += (binary[i] - '0') / twos;
                twos *= 2.0;
            }
            return intDecimal + fracDecimal;

        }
        public String hexfull(String hexbin)
        {
            string bin = hextobin(hexbin);
            if (bin == "0")
            {
                bin = "0000";
            }
            if (bin == "1")
            {
                bin = "0001";
            }
            if (bin == "10")
            {
                bin = "0010";
            }
            if (bin == "11")
            {
                bin = "0011";
            }
            if (bin.Length < 4)
            {
                bin = bin.Insert(0, "0");
            }
            if (bin.Length < 3)
            {
                bin = bin.Insert(1, "0");
            }
            if (bin.Length < 2)
            {
                bin = bin.Insert(2, "0");
            }

            return bin;

        }
        public String hextobin(string hex_value)
        {
            int int_value = Convert.ToInt32(hex_value, 16);
            string Base = Convert.ToString(int_value, 2);
            return Base;

        }
        public int bintodec(string binvalue)
        {
            int binaryNumber = int.Parse(binvalue);
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            return decimalValue;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ir1.Clear();
            ir2.Clear();
            ir3.Clear();
            ir4.Clear();
            ir5.Clear();
            ir6.Clear();
            ir7.Clear();
            ir8.Clear();
            a1.Clear();
            a2.Clear();
            a3.Clear();
            a4.Clear();
            a5.Clear();
            a6.Clear();
            a7.Clear();
            a8.Clear();
            a9.Clear();
            a10.Clear();
            a11.Clear();
            a12.Clear();
            a13.Clear();
            a14.Clear();
            a15.Clear();
            a16.Clear();
            a17.Clear();
            a18.Clear();
            a19.Clear();
            a20.Clear();
            a21.Clear();
            a22.Clear();
            a23.Clear();
            a24.Clear();
            a25.Clear();
            a26.Clear();
            a27.Clear();
            a28.Clear();
            a29.Clear();
            a30.Clear();
            a31.Clear();
            a32.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtFINAL.Clear();
            txtbitnum.Clear();
            txtbitanswer.Clear();
            bit2.Clear();
            bit16.Clear();
            txtBIT.Clear();
            txtNIB.Clear();
            txtBYTE.Clear();
            txtKB.Clear();
            txtMB.Clear();
            txtGB.Clear();
            txth.Clear();
            txtw.Clear();
            txti.Clear();
            txtansrgb.Clear();
            txtArray.Clear();
            txtReqMemory.Clear();
            txtMemAns.Clear();


        }


        private void asciibtn_Click(object sender, EventArgs e)
        {
            try
            {
                string asciitext = txtascii.Text;
                txtbinascii.Text = ascii(asciitext);
                asciihex.Text = AsciiToHex(asciitext);
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private static string ascii(string x)
        {
            string converted = string.Empty;
            byte[] byteArray = Encoding.ASCII.GetBytes(x);

            for (int i = 0; i < byteArray.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    converted += (byteArray[i] & 0x80) > 0 ? "1" : "0";
                    byteArray[i] <<= 1;
                }
                converted += " ";
            }
            return converted;
        }

        public static string AsciiToHex(string str)
        {
            char[] array = str.ToCharArray();
            string final = "";
            foreach (var i in array)
            {
                string hex = String.Format("{0:X}", Convert.ToInt32(i));
                final += hex.Insert(0, "0X") + " ";
            }
            final = final.TrimEnd();
            final = final.Replace("0X", "");
            return final;
        }

        public static string BinaryToASCII(string bin)
        {
            string ascii = string.Empty;

            for (int i = 0; i < bin.Length; i += 8)
            {
                ascii += (char)BinaryToDecimal(bin.Substring(i, 8));
            }

            return ascii;
        }
        private static int BinaryToDecimal(string bin)
        {
            int binLength = bin.Length;
            double dec = 0;

            for (int i = 0; i < binLength; ++i)
            {
                dec += ((byte)bin[i] - 48) * Math.Pow(2, ((binLength - i) - 1));
            }

            return (int)dec;
        }

        private void buttonbin_Click(object sender, EventArgs e)
        {
            try
            {
                string bintext = txtbinascii.Text;
                bintext = bintext.Replace(" ", "");
                txtascii.Text = BinaryToASCII(bintext);
                asciihex.Text = AsciiToHex(txtascii.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static string HexadecimalToASCII(string hex)
        {
            string ascii = string.Empty;

            for (int i = 0; i < hex.Length; i += 2)
            {
                ascii += (char)HexadecimalToDecimal(hex.Substring(i, 2));
            }

            return ascii;
        }

        private static int HexadecimalToDecimal(string hex)
        {
            hex = hex.ToUpper();

            int hexLength = hex.Length;
            double dec = 0;

            for (int i = 0; i < hexLength; ++i)
            {
                byte b = (byte)hex[i];

                if (b >= 48 && b <= 57)
                    b -= 48;
                else if (b >= 65 && b <= 70)
                    b -= 55;

                dec += b * Math.Pow(16, ((hexLength - i) - 1));
            }

            return (int)dec;
        }

        private void buttonhex_Click(object sender, EventArgs e)
        {
            try
            {
                string hextext = asciihex.Text;
                hextext = hextext.Replace(" ", "");
                txtascii.Text = HexadecimalToASCII(hextext);
                txtbinascii.Text = ascii(txtascii.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("Please Enter a Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtascii.Clear();
            txtbinascii.Clear();
            asciihex.Clear();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtbitnum.Text);
            double value = (Math.Pow(2, number) - 1);
            txtbitanswer.Text = Convert.ToString(value);

            string Base = Convert.ToString((int)value, 2);
            bit2.Text = Base;
            string Base2 = Convert.ToString((int)value, 16);
            bit16.Text = Base2.ToUpper();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double total = Math.Pow(num1, num2);
            txtFINAL.Text = Convert.ToString(total);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double BIT, NIBBLE, BYTE, KB, MB, GB;

            if (txtBIT.Text.Equals("") && txtBYTE.Text.Equals("") && txtNIB.Text.Equals("") && txtKB.Text.Equals("") && txtMB.Text.Equals("") && txtGB.Text.Equals(""))
            {
                MessageBox.Show("Enter a number");
            }
            else if (txtBYTE.Text.Equals("") && txtNIB.Text.Equals("") && txtKB.Text.Equals("") && txtMB.Text.Equals("") && txtGB.Text.Equals(""))
            {
                BIT = Convert.ToDouble(txtBIT.Text);

                NIBBLE = BIT / 4;
                BYTE = BIT / 8;
                KB = BYTE / 1024;
                MB = KB / 1024;
                GB = MB / 1024;

                txtNIB.Text = Convert.ToString(NIBBLE);
                txtBYTE.Text = Convert.ToString(BYTE);
                txtKB.Text = Convert.ToString(KB);
                txtMB.Text = Convert.ToString(MB);
                txtGB.Text = Convert.ToString(GB);
            }
            else if (txtBIT.Text.Equals("") && txtBYTE.Text.Equals("") && txtKB.Text.Equals("") && txtMB.Text.Equals("") && txtGB.Text.Equals(""))
            {
                NIBBLE = Convert.ToDouble(txtNIB.Text);

                BIT = NIBBLE * 4;
                BYTE = BIT / 8;
                KB = BYTE / 1024;
                MB = KB / 1024;
                GB = MB / 1024;

                txtBIT.Text = Convert.ToString(BIT);
                txtBYTE.Text = Convert.ToString(BYTE);
                txtKB.Text = Convert.ToString(KB);
                txtMB.Text = Convert.ToString(MB);
                txtGB.Text = Convert.ToString(GB);
            }
            else if (txtBIT.Text.Equals("") && txtNIB.Text.Equals("") && txtKB.Text.Equals("") && txtMB.Text.Equals("") && txtGB.Text.Equals(""))
            {
                BYTE = Convert.ToDouble(txtBYTE.Text);

                BIT = BYTE * 8;
                NIBBLE = BIT / 4;
                KB = BYTE / 1024;
                MB = KB / 1024;
                GB = MB / 1024;

                txtBIT.Text = Convert.ToString(BIT);
                txtBYTE.Text = Convert.ToString(BYTE);
                txtKB.Text = Convert.ToString(KB);
                txtMB.Text = Convert.ToString(MB);
                txtGB.Text = Convert.ToString(GB);
                txtNIB.Text = Convert.ToString(NIBBLE);
            }
            else if (txtBIT.Text.Equals("") && txtBYTE.Text.Equals("") && txtNIB.Text.Equals("") && txtMB.Text.Equals("") && txtGB.Text.Equals(""))
            {
                KB = Convert.ToDouble(txtKB.Text);


                BYTE = KB * 1024;
                BIT = BYTE * 8;
                NIBBLE = BIT / 4;
                MB = KB / 1024;
                GB = MB / 1024;

                txtBIT.Text = Convert.ToString(BIT);
                txtBYTE.Text = Convert.ToString(BYTE);
                txtMB.Text = Convert.ToString(MB);
                txtGB.Text = Convert.ToString(GB);
                txtNIB.Text = Convert.ToString(NIBBLE);
            }
            else if (txtBIT.Text.Equals("") && txtBYTE.Text.Equals("") && txtKB.Text.Equals("") && txtNIB.Text.Equals("") && txtGB.Text.Equals(""))
            {
                MB = Convert.ToDouble(txtMB.Text);

                KB = MB * 1024;
                BYTE = KB * 1024;
                BIT = BYTE * 8;
                NIBBLE = BIT / 4;
                GB = MB / 1024;

                txtBIT.Text = Convert.ToString(BIT);
                txtBYTE.Text = Convert.ToString(BYTE);
                txtKB.Text = Convert.ToString(KB);
                txtGB.Text = Convert.ToString(GB);
                txtNIB.Text = Convert.ToString(NIBBLE);
            }
            else if (txtBIT.Text.Equals("") && txtBYTE.Text.Equals("") && txtKB.Text.Equals("") && txtMB.Text.Equals("") && txtNIB.Text.Equals(""))
            {
                GB = Convert.ToDouble(txtGB.Text);

                MB = GB * 1024;
                KB = MB * 1024;
                BYTE = KB * 1024;
                BIT = BYTE * 8;
                NIBBLE = BIT / 4;

                txtBIT.Text = Convert.ToString(BIT);
                txtBYTE.Text = Convert.ToString(BYTE);
                txtKB.Text = Convert.ToString(KB);
                txtMB.Text = Convert.ToString(MB);
                txtNIB.Text = Convert.ToString(NIBBLE);
            }
            else
            {
                txtBIT.Clear();
                txtNIB.Clear();
                txtBYTE.Clear();
                txtKB.Clear();
                txtMB.Clear();
                txtGB.Clear();
                txtMB.Focus();
            }

        }

        private void btnrgb_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(txth.Text);
            int width = Convert.ToInt32(txtw.Text);
            int images = Convert.ToInt32(txti.Text);
            int z = 1024 * 1024;
            float answer = (height * width * 3 * images) / (z);
            txtansrgb.Text = Convert.ToString(answer);
        }

        private void btnbest_Click(object sender, EventArgs e)
        {
            string[] arr;
            string memory_list = txtArray.Text;
            arr = memory_list.Split(' ');
            Array.Sort(arr);
            int a = Convert.ToInt32(txtReqMemory.Text);

            foreach (string value in arr)
            {
                if (a <= Convert.ToInt32(value))
                {
                    txtMemAns.Text = value;
                    break;
                }
            }

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            string[] arr;
            string memory_list = txtArray.Text;
            arr = memory_list.Split(' ');
            int a = Convert.ToInt32(txtReqMemory.Text);

            foreach (string value in arr)
            {
                if (a <= Convert.ToInt32(value))
                {
                    txtMemAns.Text = value;
                    break;
                }
            }
        }

        private void btnWorst_Click(object sender, EventArgs e)
        {
            string[] arr;
            string memory_list = txtArray.Text;
            arr = memory_list.Split(' ');
            int[] myInts = Array.ConvertAll(arr, s => int.Parse(s));
            int a = Convert.ToInt32(txtReqMemory.Text);

            foreach (int value in myInts)
            {
                if (value >= myInts.Max())
                {
                    txtMemAns.Text = Convert.ToString(value);
                    break;
                }
            }
        }

        private string hexToDec(String hex)
        {
            int decimal_value = Convert.ToInt32(hex, 16);
            string d = Convert.ToString(decimal_value);
            return d;
        }

        private void btnPBS_Click(object sender, EventArgs e)
        {
            string[] arr;
            string pbs = txtPBS.Text;
            arr = pbs.Split(' ');

            string oem_name = arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8] + arr[9] + arr[10];
            string bytes_per_sector = arr[12] + arr[11];
            string sector_per_cluster = arr[13];
            string size_in_secto_RA = arr[15] + arr[14];
            string nof = arr[16];
            string max_nof_rd = arr[18] + arr[17];
            string nos = arr[20] + arr[19];
            string media_type = arr[21];
            string size_of_each_fat = arr[23] + arr[22];
            string sectors_per_track = arr[25] + arr[24];
            string number_of_heads = arr[27] + arr[26];
            string sectors_before_partition = arr[31] + arr[30] + arr[29] + arr[28];
            string sectors_in_partition = arr[35] + arr[34] + arr[33] + arr[32];

            if (media_type == "F8")
            {
                txtMediaType.Text = "fixed disk";
            }
            else
            {
                txtMediaType.Text = "Removable disk";
            }

            long sbp = Convert.ToInt64(hexToDec(sectors_before_partition));
            long sbpFull = sbp * 512;

            txtoem.Text = HexadecimalToASCII(oem_name);
            txtBPS.Text = hexToDec(bytes_per_sector);
            txtSPC.Text = hexToDec(sector_per_cluster);
            txtSRA.Text = hexToDec(size_in_secto_RA);
            txtNOF.Text = hexToDec(nof);
            txtMaxNOF.Text = hexToDec(max_nof_rd);
            txtSec16.Text = hexToDec(nos);
            txtSfat.Text = hexToDec(size_of_each_fat);
            txtSPT.Text = hexToDec(sectors_per_track);
            txtNOH.Text = hexToDec(number_of_heads);
            txtsbp.Text = hexToDec(sectors_before_partition) + "  " + Convert.ToString(sbpFull);
            txtSec32.Text = hexToDec(sectors_in_partition);

            long firstFat = sbp + Convert.ToInt64(txtSRA.Text);
            long SecondFat = firstFat + Convert.ToInt64(txtSfat.Text);
            long rootDir = SecondFat + Convert.ToInt64(txtSfat.Text);

            txtFirstFat.Text = Convert.ToString(firstFat);
            txtSecondFat.Text = Convert.ToString(SecondFat);
            txtRootDir.Text = Convert.ToString(rootDir);
        }

        private string eight_bit_binary(int[] list)
        {
            string y = "";
            for (int i = 0; i < list.Length; i++)
            {
                string x = Convert.ToString(list[i], 2);
                if (x.Length < 8)
                {
                    string zeros = String.Concat(Enumerable.Repeat("0", (8 - x.Length)));
                    x = zeros + x;
                }
                y = y + x;
            }
            return y;
        }

        private string bin2dec(string value)
        {
            string result = "";
            for (int i = 0; i < 32; i += 8)
            {
                string newValue = value.Substring(i, 8);
                int dec = Convert.ToInt32(newValue, 2);
                result += dec.ToString();
                result += ".";
            }
            return result;
        }

        private void subnet(int x, int y)
        {
            int num = 0;
            int num1 = 0;
            if (x < 127)
            {
                num = y - 8;
            }
            else if (x < 192)
            {
                num = y - 16;
            }
            else if (x < 224)
            {
                num = y - 24;
            }
            else
            {
                num = 0;
            }

            double subnet = Math.Pow(2, num);
            num1 = 32 - y;
            double host_subnet = (Math.Pow(2, num1)) - 2;
            txtMaxSubnet.Text = Convert.ToString(subnet);
            txtMaxHostSubnet.Text = Convert.ToString(host_subnet);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text;
            string[] ip_array = ip.Split('.');
            int[] ip_list = Array.ConvertAll(ip_array, s => int.Parse(s));

            int nmask_number = 0;
            if (txtNOnmask.Text.Equals(""))
            {
                string nmask = txtnmask.Text;
                string[] nmask_array = nmask.Split('.');
                int[] nmask_list = Array.ConvertAll(nmask_array, s => int.Parse(s));
                string network_mask_binary = eight_bit_binary(nmask_list);
                nmask_number = network_mask_binary.IndexOf("0");
            }
            else
            {
                nmask_number = Convert.ToInt32(txtNOnmask.Text);
            }

            string ip_in_binary = eight_bit_binary(ip_list);
            string change = ip_in_binary.Substring(nmask_number);
            string unchanged = ip_in_binary.Substring(0, nmask_number);
            string new1 = String.Concat(Enumerable.Repeat("0", change.Length));
            string new2 = String.Concat(Enumerable.Repeat("1", change.Length));
            string new3 = String.Concat(Enumerable.Repeat("0", (change.Length - 1))) + "1";
            string new4 = String.Concat(Enumerable.Repeat("1", (change.Length - 1))) + "0";
            string network_address = unchanged + new1;
            string broadcast_address = unchanged + new2;
            string first_valid_host_ip = unchanged + new3;
            string last_valid_host_ip = unchanged + new4;
            txtNA.Text = bin2dec(network_address);
            txtBA.Text = bin2dec(broadcast_address);
            txtFirstIP.Text = bin2dec(first_valid_host_ip);
            txtLastIP.Text = bin2dec(last_valid_host_ip);
            subnet(ip_list[0], nmask_number);
        }
    }
}
