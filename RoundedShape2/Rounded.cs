using System.Drawing.Drawing2D;

namespace RoundedShape2
{
    //mengatur sudut components supaya lengkung
    public class Rounded
    {
        //control => jenis components yang akan dibuat lengkung
        //radius => besar kelengkungan yang diinginkan
        public static void SetRounded(Control control, int radius)
        {
            //AddArch mengatur kelengkungan untuk tiap sudut components
            if (control == null || radius <= 0) return;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            control.Region = new Region(path);
        }
    }
}