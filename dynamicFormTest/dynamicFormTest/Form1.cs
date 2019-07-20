using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamicFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<T> GetAllControls<T>(Control top) where T : Control
        {
            List<T> buf = new List<T>();
            foreach (Control ctrl in top.Controls)
            {
                if (ctrl is T) buf.Add((T)ctrl);
                buf.AddRange(GetAllControls<T>(ctrl));
            }
            return buf;
        }


        bool panels_drag = false;
        int panels_default_x = 0;
        int panels_default_y = 0;
        Control selected_panel;
        int panel_num = 0;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                panels_default_x = e.X;
                panels_default_y = e.Y;
                panels_drag = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                selected_panel = ((Panel)sender);
                System.Drawing.Point p = System.Windows.Forms.Cursor.Position;
                this.contextMenuStrip1.Show(p);
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if(panels_drag)
            {
                Point loc = ((Panel)sender).Location;
                    ((Panel)sender).Location = new Point(((loc.X + e.X - panels_default_x) / 10) * 10, ((loc.Y + e.Y - panels_default_y) / 10) * 10);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            panels_drag = false;
        }


        private void AddPanelButton_Click(object sender, EventArgs e)
        {
            Panel pnl = new Panel();
            this.Controls.Add(pnl);
            pnl.Name = "panel_" + panel_num.ToString();
            pnl.Left = 10;
            pnl.Top = 10;
            pnl.Width = 50;
            pnl.Height = 200;
            pnl.BackColor = Color.Brown;
            pnl.MouseDown += new MouseEventHandler(Panel_MouseDown);
            pnl.MouseUp += new MouseEventHandler(Panel_MouseUp);
            pnl.MouseMove += new MouseEventHandler(Panel_MouseMove);
            panel_num++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Panel> panels = GetAllControls<Panel>(this);
            System.Console.WriteLine("panels : " + panels.Count().ToString());
            foreach (var ctl in panels)
            {
                System.Console.WriteLine("panels : " + ctl.Name);
                ctl.MouseDown += new MouseEventHandler(Panel_MouseDown);
                ctl.MouseUp += new MouseEventHandler(Panel_MouseUp);
                ctl.MouseMove += new MouseEventHandler(Panel_MouseMove);

            }
        }

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(selected_panel);
        }

        private void 細長ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected_panel.Size = new Size(50, 200);
        }

        private void 正方形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected_panel.Size = new Size(230, 200);
        }
    }
}
