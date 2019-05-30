using System;
using System.Collections;
using System.Drawing;

namespace BLL
{
    public class Processing
    {
        public Bitmap Recrecognize(Bitmap bitmap)
        {
            double[,] brightArray = GetBrightness(bitmap);
            bool[,] binaryArray = (new KMeans(brightArray)).GetBinaryArray();
            int[,] labels = (new Recursive(binaryArray)).GetLabels();

            ArrayList binaryCode = (new Recognize(labels)).GetBinaryCode();

            DrawBinCode(bitmap, binaryCode);

            return bitmap;
        }

        private double[,] GetBrightness(Bitmap bitmap)
        {
            double[,] brightArray = new double[bitmap.Width, bitmap.Height];

            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                    brightArray[i, j] = bitmap.GetPixel(i, j).GetBrightness();

            return brightArray;
        }

        private Bitmap DrawBinCode(Bitmap bitmap, ArrayList binaryCode)
        {
            Graphics g = Graphics.FromImage(bitmap);
            String drawString = "";
            foreach (Recognize.DigitStruct bin in binaryCode)
            {
                Pen blackPen = new Pen((bin.digit == 1) ? Color.Green : Color.Red, 1);
                Rectangle rect = new Rectangle(bin.x1, bin.y1, bin.x2 - bin.x1, bin.y2 - bin.y1);
                g.DrawRectangle(blackPen, rect);
                drawString += bin.digit;
            }


            drawString += ", " + Convert.ToInt32(drawString, 2);
            Font drawFont = new Font("Arial", bitmap.Height / 6);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            PointF drawPoint = new PointF((bitmap.Width / 2) - (drawString.Length / 2 - 1) * drawFont.Size, bitmap.Height - drawFont.GetHeight());

            g.DrawString(drawString, drawFont, drawBrush, drawPoint);

            return bitmap;
        }
    }
}
