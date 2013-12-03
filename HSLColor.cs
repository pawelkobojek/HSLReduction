using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3
{
    class HSLColor
    {
        const int HUE_COUNT = 8;
        const int SAT_COUNT = 8;
        const int LIGHT_COUNT = 8;

        public static double[] hueIntervals = new double[HUE_COUNT];
        public static double[] satIntervals = new double[SAT_COUNT];
        public static double[] lightIntervals = new double[LIGHT_COUNT];

        public double H { get; set; }
        public double S { get; set; }
        public double L { get; set; }

        static HSLColor()
        {
            double hueStep = 360.0 / (HUE_COUNT);
            double satStep = 100.0 / (SAT_COUNT - 1);
            double lightStep = 100.0 / (LIGHT_COUNT - 1);

            hueIntervals[0] = 0;
            for (int i = 1; i < hueIntervals.Length - 1; i++)
            {
                hueIntervals[i] = hueStep * i;
            }
            hueIntervals[hueIntervals.Length - 1] = 360.0;
            //hueIntervals[hueIntervals.Length - 1] = 0;

            satIntervals[0] = 0;
            for (int i = 1; i < satIntervals.Length - 1; i++)
            {
                satIntervals[i] = satStep * i;
            }
            satIntervals[satIntervals.Length - 1] = 100.0;

            lightIntervals[0] = 0;
            for (int i = 1; i < lightIntervals.Length - 1; i++)
            {
                lightIntervals[i] = lightStep * i;
            }
            lightIntervals[lightIntervals.Length - 1] = 100.0;
        }

        public HSLColor(double h, double s, double l)
        {
            H = h;
            S = s;
            L = l;
        }

        public Color getRGBColor()
        {
            /*   double r, g, b;
              if (S == 0)
              {
                  r = g = b = L; // achromatic
              }
              else
              {

              }

              double l = (double)L / 100;
              double s = (double)S / 100;
              double h = (double)H / 360.0;
              var q = l < 0.5 ? l * (1 + s) : l + s - l * s;
              var p = 2 * l - q;
              r = hue2rgb(p, q, h + (1.0 / 3.0), 0);
              g = hue2rgb(p, q, h, 0);
              b = hue2rgb(p, q, h - (1.0 / 3.0), 0);

              /////


              int adjR = (int)(255 * r);
              int adjG = (int)(255 * g);
              int adjB = (int)(255 * b);

              return Color.FromArgb(adjR, adjG, adjB);*/

            double c = (1 - Math.Abs(2 * L - 1)) * S;
            double h = (this.H / 60);
            double x = c * (1 - Math.Abs((h % 2) - 1));
            double m = L - 0.5 * c;

            double r, g, b;
            int ejcz = (int)h;

            switch (ejcz)
            {
                case 0:
                    r = c;
                    g = x;
                    b = 0;
                    break;
                case 1:
                    r = x;
                    g = c;
                    b = 0;
                    break;
                case 2:
                    r = 0;
                    g = c;
                    b = x;
                    break;
                case 3:
                    r = 0;
                    g = x;
                    b = c;
                    break;
                case 4:
                    r = x;
                    g = 0;
                    b = c;
                    break;
                case 5:
                    r = c;
                    g = 0;
                    b = x;
                    break;
                default:
                    r = g = b = 0.0;
                    break;
            }

            Color color;
            color = Color.FromArgb(
                ((int)((r + m) * 255)) % 256,
                ((int)((g + m) * 255)) % 256,
                ((int)((b + m) * 255)) % 256);

            return color;
        }

        private double hue2rgb(double p, double q, double t, double ad)
        {
            if (t < 0.0) t += 1;
            if (t > 1.0) t -= 1;
            if (t < 1.0 / 6.0) return p + (q - p) * 6.0 * t;
            if (t < 1.0 / 2.0) return q;
            if (t < 2.0 / 3.0) return p + (q - p) * (2.0 / 3.0 - t) * 6.0;
            return p;
        }

        public static HSLColor FromArgbColor(Color c)
        {
            //double r = (double)c.R / 255;
            //double g = (double)c.G / 255;
            //double b = (double)c.B / 255;

            //double h, s, l;

            //double Cmax = Math.Max(r, Math.Max(g, b));
            //double Cmin = Math.Min(r, Math.Min(g, b));

            //double d = Cmax - Cmin;

            //l = ((Cmax + Cmin) / 2 * 100);

            //if (d == 0)
            //{
            //    h = s = 0;
            //}
            //else
            //{
            //    h = ((Cmax == r ? ((g - b) / d) + (g < b ? 6 : 0) : Cmax == g ? ((b - r) / d) + 2 : ((r - g) / d) + 4) * 60);

            //    //_s = (int)(d / (1 - Math.Abs(2 * _l - 1)) * 100);
            //    s = ((l > 50 ? d / (2 - Cmax - Cmin) : d / (Cmax + Cmin)) * 100);
            //}

            double h = c.GetHue();
            double s = c.GetSaturation();
            double l = c.GetBrightness();
            return new HSLColor(h, s, l);
        }

        private double hue2rgb(double p, double q, double t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < (double)1 / 6) return p + (q - p) * 6 * t;
            if (t < (double)1 / 2) return q;
            if (t < (double)2 / 3) return p + (q - p) * ((double)2 / 3 - t) * 6;
            return p;
        }

        public void Reduce(bool reduceH, bool reduceS, bool reduceL)
        {
            if (reduceH)
            {
                double closestValue = 0;
                foreach (var value in hueIntervals)
                {
                    if (Math.Abs(value - H) < Math.Abs(value - closestValue))
                        closestValue = value;
                }

                H = (int)closestValue;
            }

            if (reduceS)
            {
                double closestValue = 0;
                foreach (var value in satIntervals)
                {
                    if (Math.Abs(value - S) < Math.Abs(value - closestValue))
                        closestValue = value;
                }
                S = (int)closestValue;
            }

            if (reduceL)
            {
                double closestValue = 0;
                foreach (var value in lightIntervals)
                {
                    if (Math.Abs(value - L) < Math.Abs(value - closestValue))
                        closestValue = value;
                }
                L = (int)closestValue;
            }
        }
    }
}
