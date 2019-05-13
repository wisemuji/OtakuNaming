using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        string MonName;
        string DayName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void showResult_Click(object sender, EventArgs e)
        {
            if (this.rbMon1.Checked)
            {
                MonName = "달";
            }
            else if (this.rbMon2.Checked)
            {
                MonName = "사랑";
            }
            else if (this.rbMon3.Checked)
            {
                MonName = "하늘";
            }
            else if (this.rbMon4.Checked)
            {
                MonName = "물";
            }
            else if (this.rbMon5.Checked)
            {
                MonName = "꽃";
            }
            else if (this.rbMon6.Checked)
            {
                MonName = "우주";
            }
            else if (this.rbMon7.Checked)
            {
                MonName = "태양";
            }
            else if (this.rbMon8.Checked)
            {
                MonName = "별";
            }
            else if (this.rbMon9.Checked)
            {
                MonName = "숲";
            }
            else if (this.rbMon10.Checked)
            {
                MonName = "그림자";
            }
            else if (this.rbMon11.Checked)
            {
                MonName = "천국";
            }
            else if (this.rbMon12.Checked)
            {
                MonName = "눈";
            }

            if (this.rbDay1.Checked)
            {
                this.DayName = "파편";
            }
            else if (this.rbDay2.Checked)
            {
                this.DayName = "천사";
            }
            else if (this.rbDay3.Checked)
            {
                this.DayName = "눈물";
            }
            else if (this.rbDay4.Checked)
            {
                this.DayName = "증거";
            }
            else if (this.rbDay5.Checked)
            {
                this.DayName = "꿈";
            }
            else if (this.rbDay6.Checked)
            {
                this.DayName = "마음";
            }
            else if (this.rbDay7.Checked)
            {
                this.DayName = "물방울";
            }
            else if (this.rbDay8.Checked)
            {
                this.DayName = "요정";
            }
            else if (this.rbDay9.Checked)
            {
                this.DayName = "음악";
            }
            else if (this.rbDay10.Checked)
            {
                this.DayName = "빛";
            }
            else if (this.rbDay11.Checked)
            {
                this.DayName = "상어";
            }
            else if (this.rbDay12.Checked)
            {
                this.DayName = "결정";
            }
            else if (this.rbDay13.Checked)
            {
                this.DayName = "속삭임";
            }
            else if (this.rbDay14.Checked)
            {
                this.DayName = "신탁";
            }
            else if (this.rbDay15.Checked)
            {
                this.DayName = "주문";
            }
            else if (this.rbDay16.Checked)
            {
                this.DayName = "사기꾼";
            }
            else if (this.rbDay17.Checked)
            {
                this.DayName = "기도";
            }
            else if (this.rbDay18.Checked)
            {
                this.DayName = "고양이";
            }
            else if (this.rbDay19.Checked)
            {
                this.DayName = "안내자";
            }
            else if (this.rbDay20.Checked)
            {
                this.DayName = "파곰";
            }
            else if (this.rbDay21.Checked)
            {
                this.DayName = "보호자";
            }
            else if (this.rbDay22.Checked)
            {
                this.DayName = "마법";
            }
            else if (this.rbDay23.Checked)
            {
                this.DayName = "보물";
            }
            else if (this.rbDay24.Checked)
            {
                this.DayName = "영혼";
            }
            else if (this.rbDay25.Checked)
            {
                this.DayName = "여괴";
            }
            else if (this.rbDay26.Checked)
            {
                this.DayName = "여우";
            }
            else if (this.rbDay27.Checked)
            {
                this.DayName = "늑대";
            }
            else if (this.rbDay28.Checked)
            {
                this.DayName = "날개";
            }
            else if (this.rbDay29.Checked)
            {
                this.DayName = "서눔ㄹ";
            }
            else if (this.rbDay30.Checked)
            {
                this.DayName = "괴도";
            }
            else if (this.rbDay31.Checked)
            {
                this.DayName = "지배자";
            }

            if (this.DayName == null || this.DayName == "")
            {
                MessageBox.Show(
                    "태어난 날짜를 선택해 주세요", "신탁",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((
                    this.rbMon4.Checked ||
                    this.rbMon6.Checked ||
                    this.rbMon8.Checked ||
                    this.rbMon10.Checked ||
                    this.rbMon12.Checked)
                     &&
                     (this.rbDay31.Checked))
                {
                    MessageBox.Show(
                   "해당 날짜에 태어난사람은 없습니다!", "신탁",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "당신의 이름은\n["
                    + this.MonName + "의 " + this.DayName
                    + "] 입니다!!", "신탁",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void month2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
