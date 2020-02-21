using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpWorld.FormComponents
{
    class HealthBar : ProgressBar
    {
        private Brush _brush;
        public HealthBar(Brush brush)
        {
            _brush = brush;
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                result.ExStyle |= 0x02000000; // WS_EX_COMPOSITED 
                return result;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(_brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
