using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab6
{
    public partial class Form1 : Form
    {
        int fyear;
        int[] arr_values;
        // title variables
        string T_text;
        Font T_font;
        string T_fontstring;
        int T_fontsize;
        Color T_color;
        Brush T_brush;
       // Point T_stpt;
        StringFormat T_format;
        // table variables
        Pen rect_pen;
        Color rect_color;
        int rect_stptx;
        int rect_stpty;
        int rect_width;
        int rect_length;
        // cells string variables
        string C_text;
        Font C_font;
        Color C_textcolor;
        StringFormat C_Format;
        Brush C_brush;
        // chart lines variables
        Pen l_pen;
       // Brush l_brush;
        Color l_color;
        Point l_stpt;
        Point l_endpth;
        Point l_endptv;
        //labels variables
        Font label_font;
        string label_text;
        Brush label_brush;
        Color label_tcolor;
        int label_x;
        int label_y;
       // Point l_orgin;
        int chart_width;
        int chart_length;
        // bar chart variables
        Brush BC_brush;
        HatchStyle BC_style;
        float BC_width;
        float BC_length;
        Color BC_color;
        float BC_x;
         float BC_y;
        //line chart variables
        Pen LC_pen;
       Color LC_color;
        float LC_pt1_x;
        float LC_pt1_y;
        float LC_pt2_x;
        float LC_pt2_y;
       

        





        public Form1()
        {
            InitializeComponent();
            fyear = 1988;
            arr_values= new int[] { 150, 170, 180, 175, 200, 250, 210, 240, 280, 140 };

            //
            T_fontstring = "Times New Roman";
            T_fontsize = 16;
            T_text = "ABC Company";

            T_color = Color.Black;
            
            T_format = new StringFormat();
            T_format.Alignment = StringAlignment.Center;
            //
            rect_color = Color.DarkKhaki;
            rect_pen = new Pen(rect_color);
            // rect_stpoint = new Point(ClientSize.Width -60, ClientSize - 20);
            rect_stptx = this.Width;
            rect_stpty = 80;
            rect_length = 550 ;
            rect_width = 500;
            //
            C_font = new Font("Times New Roman", 14);
            C_textcolor = Color.Aqua;
            C_brush = new SolidBrush(C_textcolor);
            C_Format = new StringFormat();
            C_Format.Alignment = StringAlignment.Center;
            C_Format.LineAlignment = StringAlignment.Center;
            // 
            l_color = Color.Ivory;
           // l_brush = new SolidBrush(l_color);
            l_pen = new Pen(l_color, 3.5f);
            l_stpt = new Point(40, 650);
            l_pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            l_endpth = new Point(640, 650 );
            l_endptv = new Point(40, 80);
            chart_width = 600;
            chart_length  = 560;
            //
            label_font = new Font("Times New Roman", 8);
            label_tcolor = Color.DarkGoldenrod;
           label_brush = new SolidBrush(label_tcolor);

            //
            BC_color = Color.DarkRed;
            BC_style = HatchStyle.BackwardDiagonal;
            BC_brush = new HatchBrush(BC_style, BC_color);
            
            BC_width = 20;
            //
            LC_color = Color.DeepSkyBlue;
            LC_pen = new Pen(Color.Blue,3.5f);
            //
            this.toolStripMenuItem1.Text = BC_color.ToString();
            this.toolStripMenuItem1.Checked = checked(true);
            this.toolStripMenuItem2.Text=BC_style.ToString();
            this.toolStripMenuItem2.Checked= checked(true);

            









        }
        protected override void OnPaint(PaintEventArgs e)
        {
         this.WindowState = FormWindowState.Maximized;
         //   drawtitle("ABC Company", 30);
            drawtitle();
            drawrect();

            drawtablecell("YEARS", rect_stptx, rect_stpty + ((rect_length / 11) * 0), rect_length / 11, rect_width / 2);
            drawtablecell("REVenue", rect_stptx + (rect_width / 2), rect_stpty + ((rect_length / 11) * 0), rect_length / 11, rect_width / 2);
            for (int i = 1; i < 11; i++)

            {
                drawtablecell((fyear+i-1).ToString(),rect_stptx,rect_stpty+((rect_length/11)*i),rect_length/11,rect_width/2);
                drawtablecell((arr_values[i-1]).ToString(),rect_stptx+(rect_width / 2),rect_stpty + ((rect_length / 11) * i),rect_length / 11,rect_width / 2);
            }
            drawlineschart(l_endpth);
            drawlineschart(l_endptv);
            for(int i = 0; i < 10; i++) {
               drawbarchart((70+(i* chart_width / 10)), (l_stpt.Y - (chart_length / 28) * (arr_values[i ]/10.0f)), (chart_length / 28) * (arr_values[i ] / 10.0f));
                drawlineschartla((fyear + i).ToString(), (65 + (i * chart_width / 10)), l_stpt.Y + 10);
            }
            for(int i=0;i<= 28;i++)
            {
                drawlineschartla((i*10).ToString(),10, l_stpt.Y -((chart_length/28)*i)-10);

               // drawlineschartla((i*10)).ToString(),10,l_stpt.Y - (chart_length / 28*i));
            }
            for (int i=0;i<9;i++)
           {
                drawlinechart(80 + (i * chart_width / 10), l_stpt.Y - (chart_length / 28) * (arr_values[i] / 10.0f), (80 + ((i + 1) * chart_width / 10)), l_stpt.Y - (chart_length / 28) * (arr_values[i+1] / 10.0f));
            }
            

        }
        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
          //  base.OnResize(e);
        }
        public void drawtitle()
        {
            // T_stpt = new Point(ClientSize.Width / 2, yco);
            T_brush = new SolidBrush(T_color);

            
            string T_text1 = " ANNUAL REVUNUE";
            T_font = new Font(T_fontstring, T_fontsize, FontStyle.Underline);
            Graphics g = this.CreateGraphics();
            Rectangle r1 = new Rectangle(0, 30, this.Width, 40);
            g.DrawString(T_text, T_font, T_brush,r1, T_format);
            Rectangle r2 = new Rectangle(0, 60, this.Width, 40);
            g.DrawString(T_text1, T_font, T_brush, r2, T_format);

            // g.DrawString(T_text, T_font, T_brush, T_stpt);
        }
        public void drawrect()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(rect_pen, rect_stptx, rect_stpty,rect_width,rect_length);
        }
        public void drawtablecell(string text, int x, int y, int length, int width)
        {
            Graphics g = this.CreateGraphics();
           // g.DrawRectangle(rect_pen, x, y, width, length);
            Rectangle rect1 = new Rectangle(x, y, width, length);
           C_text = text;
            
            g.DrawRectangle( rect_pen,rect1);
           g.DrawString(C_text, C_font, C_brush, rect1, C_Format);
            
        }
        public void drawlineschartla(string text, int x, int y)
        {
            Graphics g = this.CreateGraphics();
            label_text = text;
            label_x = x;
            label_y = y;

            g.DrawString(label_text, label_font, label_brush, label_x, label_y);
        }
        public void drawlineschart(Point l_endline)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(l_pen, l_stpt, l_endline);
          //  l_stpt = n
            

        }
        public void drawbarchart(float st_x,float st_y, float length)
        {
            Graphics g = this.CreateGraphics();
            BC_x = st_x;
            
            BC_length = length;
            BC_y = st_y;
            g.FillRectangle(BC_brush, BC_x, BC_y, BC_width, BC_length);
            

        }
        public void drawlinechart(float x1 ,float y1 , float x2 , float y2)
        {
            Graphics g = this.CreateGraphics();
            // LC_pt1=new Point()
            // LC_pt1 = new Point(x1,y1);
            //  LC_pt2 = new Point(x2, y2);
            LC_pt1_x = x1;
            LC_pt1_y = y1;
            LC_pt2_x = x2;
            LC_pt2_y = y2;

            g.DrawLine(LC_pen,LC_pt1_x, LC_pt1_y, LC_pt2_x, LC_pt2_y);

         //   g.DrawLine(,LC_pt1,LC_pt2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 18:
                    l_color = Color.Red;
                    //MessageBox.Show("red");
                    break;
                case 2:
                    l_color = Color.Blue;
                    break;
                case 7:
                    l_color = Color.Green;
                    break;
            }
            l_pen.Color = l_color;
            this.Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left && e.X>=l_stpt.X && e.Y <=l_stpt.Y && e.X<=l_endpth.X && e.Y>=l_endptv.Y)
            //{
            //    int year = (e.X - l_stpt.X) / 60 + fyear;
            //    float rev = (l_stpt.Y-e.Y)/2;
            //    MessageBox.Show($" year : {year} revunue : {(int)rev} ");
            //    this.Invalidate();
            //}else if (e.Button == MouseButtons.Right && e.X >= l_stpt.X && e.Y <= l_stpt.Y && e.X <= l_endpth.X && e.Y >= l_endptv.Y)
            //{
               
            //    this.ContextMenuStrip = this.contextMenuStrip1;

            //}else if(e.Button == MouseButtons.Right)
            //{
            //    this.ContextMenuStrip = this.contextMenuStrip2;

            //}
                    }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in colorToolStripMenuItem.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in colorToolStripMenuItem3.DropDownItems)
            {
                i.Checked = false;
            }
            LC_color = Color.Red;
            LC_pen.Color = LC_color;
            l_color = Color.Red;
            l_pen.Color = l_color;
            rEDToolStripMenuItem.Checked = checked(true) ;
            redToolStripMenuItem3.Checked = checked(true);
            this.Invalidate();

        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in colorToolStripMenuItem.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in colorToolStripMenuItem3.DropDownItems)
            {
                i.Checked = false;
            }
            LC_color = Color.Green;
            LC_pen.Color = LC_color;
            l_color = Color.Green;
            l_pen.Color = l_color;
           gREENToolStripMenuItem .Checked = checked(true);
            greenToolStripMenuItem3.Checked = checked(true);

            this.Invalidate();
        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in colorToolStripMenuItem.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in colorToolStripMenuItem3.DropDownItems)
            {
                i.Checked = false;
            }
            LC_color = Color.Blue;
            LC_pen.Color = LC_color;
            l_color = Color.Blue;
            l_pen.Color = l_color;
            bLUEToolStripMenuItem.Checked = checked(true);
            blueToolStripMenuItem3.Checked = checked(true);
            this.Invalidate();
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in styleToolStripMenuItem.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in styleToolStripMenuItem3.DropDownItems)
            {
                i.Checked = false;
            }
            l_pen.DashStyle = DashStyle.Solid;
            LC_pen.DashStyle = DashStyle.Dash;
            solidToolStripMenuItem.Checked = checked(true);
            solidToolStripMenuItem1.Checked = checked(true);

            this.Invalidate();
           
        }

        private void dashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in styleToolStripMenuItem.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in styleToolStripMenuItem3.DropDownItems)
            {
                i.Checked = false;
            }
            l_pen.DashStyle = DashStyle.Dash;
            LC_pen.DashStyle = DashStyle.Dash;
            dashedToolStripMenuItem.Checked = checked(true);
            dashedToolStripMenuItem1.Checked = checked(true);
            this.Invalidate();

        }

        private void dottedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in styleToolStripMenuItem.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in styleToolStripMenuItem3.DropDownItems)
            {
                i.Checked = false;
            }
            l_pen.DashStyle = DashStyle.Dot;
            LC_pen.DashStyle = DashStyle.Dot;
            dottedToolStripMenuItem.Checked = checked(true);
            dottedToolStripMenuItem1.Checked = checked(true);
            this.Invalidate();

        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in colorToolStripMenuItem1.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in colorToolStripMenuItem2.DropDownItems)
            {
                i.Checked = false;
            }
            BC_color = Color.Red;
            BC_brush = new HatchBrush(BC_style, BC_color);
            redToolStripMenuItem1.Checked = checked(true);
            redToolStripMenuItem2.Checked = checked(true);
            this.Invalidate();
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in colorToolStripMenuItem1.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in colorToolStripMenuItem2.DropDownItems)
            {
                i.Checked = false;
            }

            BC_color = Color.Green;
            BC_brush = new HatchBrush(BC_style, BC_color);
            greenToolStripMenuItem1.Checked = checked(true);
            greenToolStripMenuItem2.Checked = checked(true);
            this.Invalidate();
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in colorToolStripMenuItem1.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in colorToolStripMenuItem2.DropDownItems)
            {
                i.Checked = false;
            }
            BC_color = Color.Blue;
            BC_brush = new HatchBrush(BC_style, BC_color);
            blueToolStripMenuItem1.Checked = checked(true);
            blueToolStripMenuItem2.Checked = checked(true);
            this.Invalidate();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in styleToolStripMenuItem1.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in styleToolStripMenuItem2.DropDownItems)
            {
                i.Checked = false;
            }
            BC_style = HatchStyle.BackwardDiagonal;
            BC_brush = new HatchBrush(BC_style, BC_color);
            rightToolStripMenuItem.Checked = checked(true);
            rightToolStripMenuItem1.Checked = checked(true);
            this.Invalidate();

        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in styleToolStripMenuItem1.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in styleToolStripMenuItem2.DropDownItems)
            {
                i.Checked = false;
            }
            BC_style = HatchStyle.ForwardDiagonal;
            BC_brush = new HatchBrush(BC_style, BC_color);
            leftToolStripMenuItem.Checked = checked(true);
            leftToolStripMenuItem1.Checked = checked(true);
            this.Invalidate();
        }

        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_style = HatchStyle.Cross;
            foreach(ToolStripMenuItem i in styleToolStripMenuItem1.DropDownItems )
            {
                i.Checked = false; 
            }
            foreach (ToolStripMenuItem i in styleToolStripMenuItem2.DropDownItems)
            {
                i.Checked = false;
            }

            crossToolStripMenuItem.Checked = checked(true);
            crossToolStripMenuItem1.Checked = checked(true);
            BC_brush = new HatchBrush(BC_style, BC_color);
            this.Invalidate();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in styleToolStripMenuItem1.DropDownItems)
            {
                i.Checked = false;
            }
            foreach (ToolStripMenuItem i in styleToolStripMenuItem2.DropDownItems)
            {
                i.Checked = false;
            }
            BC_style = HatchStyle.BackwardDiagonal;
            BC_brush = new HatchBrush(BC_style, BC_color);
            rightToolStripMenuItem.Checked = checked(true);
            rightToolStripMenuItem1.Checked = checked(true);
            this.Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.X >= l_stpt.X && e.Y <= l_stpt.Y && e.X <= l_endpth.X && e.Y >= l_endptv.Y)
            {
                int year = (e.X - l_stpt.X) / 60 + fyear;
                float rev = (l_stpt.Y - e.Y) / 2;
                MessageBox.Show($" year : {year} revunue : {(int)rev} ");
                this.Invalidate();
            }
            else if (e.Button == MouseButtons.Right && e.X >= l_stpt.X && e.Y <= l_stpt.Y && e.X <= l_endpth.X && e.Y >= l_endptv.Y)
            {

                this.ContextMenuStrip = this.contextMenuStrip1;

            }
            else if (e.Button == MouseButtons.Right)
            {
                this.ContextMenuStrip = this.contextMenuStrip2;

            }
        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogbox obj = new dialogbox();
            
            DialogResult dlgbres;
           obj.Ntext = T_text;
            obj.fontchanger=T_fontstring;
          obj.fontsizer=T_fontsize;



            obj.Ncolor = T_color;
            dlgbres = obj.ShowDialog();
            if (dlgbres == DialogResult.OK) {
                T_text = obj.Ntext;
                T_color = obj.Ncolor;
                T_fontstring = obj.fontchanger;
                T_fontsize = obj.fontsizer;
               
                Invalidate();
            }
        }
    }
}
