using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace tibia_info
{
    public partial class index : Form
    {
        private bool event_loop = false;
        private bool _dragging;
        private Point _offset;

        private string name_class = "TibiaClient";

        IntPtr window;
        IntPtr handle;

        public index()
        {
            InitializeComponent();
            loadInfos();
        }

        private void loadInfos()
        {
            
            window = dllImport.FindWindow(name_class, null);
            if(window == IntPtr.Zero)
            {
                MessageBox.Show("Desculpe mas não foi possivel localizar a janela do tibia.", "Tibia Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CloseWindow();
                return;
            }

            int processId = 0;
            dllImport.GetWindowThreadProcessId(window, out processId);
            if (processId <= 0) 
            {
                MessageBox.Show("Falha ao obter o ID do processo.", "Tibia Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CloseWindow();
                return;
            }

            handle = dllImport.OpenProcess(0x0010, true, processId); // 0x0010 = processRead
            if(handle == IntPtr.Zero)
            {
                MessageBox.Show("Falha ao abrir o processo.", "Tibia Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CloseWindow();
                return;
            }

            event_loop = true;

            Thread thread = new Thread(StartLoop);
            thread.Start();
        }

        private void StartLoop()
        {
            address ad = new address();

            int byte_read;
            while (event_loop)
            {
                ad.Read(handle, ad.health, ad.health_value, 2, out byte_read);
                ad.Read(handle, ad.mana, ad.mana_value, 2, out byte_read);
                ad.Read(handle, ad.level, ad.level_value, 4, out byte_read);

                healthLabelValue.Text = BitConverter.ToUInt16(ad.health_value, 0).ToString();
                manaLabelValue.Text = BitConverter.ToUInt16(ad.mana_value, 0).ToString();
                levelLabelValue.Text = BitConverter.ToUInt16(ad.level_value, 0).ToString();
            }
        }

        private void CloseWindow()
        {
            event_loop = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _dragging = true;
            _offset = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - _offset.X,
                                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHome_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _dragging = true;
            _offset = e.Location;
        }

        private void labelHome_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - _offset.X,
                                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void labelHome_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _dragging = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _dragging = true;
            _offset = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - _offset.X,
                                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _dragging = false;
        }
    }
}
