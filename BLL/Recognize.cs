using System.Collections;
namespace BLL
{
    public class Recognize
    {
        private int[] square;
        private int[,] labels;
        private int L;

        public Recognize(int[,] labels)
        {
            this.labels = labels;
            L = FindL();
            square = new int[L];
        }

        private int FindL()
        {
            int L = 0;
            for (int i = 0; i < labels.GetLength(0); i++)
                for (int j = 0; j < labels.GetLength(1); j++)
                    if (L < labels[i, j])
                        L = labels[i, j];
            return L;
        }

        private void FindSquare()
        {
            for (int x = 0; x < labels.GetLength(0); x++)
                for (int y = 0; y < labels.GetLength(1); y++)
                    if (labels[x, y] != 0)
                        square[labels[x, y] - 1]++;
        }

        private int GetGetMidRangeSquare()
        {
            int min, max;
            max = min = square[0];
            for (int i = 0; i < square.Length; i++)
            {
                if (max < square[i]) max = square[i];
                if (min > square[i]) min = square[i];
            }
            return (max + min) / 2;
        }

        private Coords GetCoords(int L)
        {
            Coords coords = new Coords();
            coords.x1 = coords.y1 = int.MaxValue;
            coords.x2 = coords.y2 = 0;

            for (int x = 0; x < labels.GetLength(0); x++)
                for (int y = 0; y < labels.GetLength(1); y++)
                    if (labels[x, y] == L)
                    {
                        if (coords.x1 > x) coords.x1 = x;
                        if (coords.y1 > y) coords.y1 = y;
                        if (coords.x2 < x) coords.x2 = x;
                        if (coords.y2 < y) coords.y2 = y;
                    }
            coords.x1 -= 3;
            coords.x2 += 3;
            coords.y1 -= 3;
            coords.y2 += 3;
            return coords;
        }

        public ArrayList GetBinaryCode()
        {
            FindSquare();
            int midRangeSquare = GetGetMidRangeSquare();
            ArrayList binaryCode = new ArrayList();

            DigitStruct ds = new DigitStruct();

            for (int i = 0; i < square.Length; i++)
            {
                Coords coords = GetCoords(i + 1);
                ds.x1 = coords.x1;
                ds.x2 = coords.x2;
                ds.y1 = coords.y1;
                ds.y2 = coords.y2;
                ds.digit = (square[i] < midRangeSquare) ? 1 : 0;

                binaryCode.Add(ds);
            }
            return binaryCode;
        }

        private struct Coords
        {
            public int x1, x2, y1, y2;
        }
        public struct DigitStruct
        {
            public int x1, x2, y1, y2;
            public int digit;
        }
    }
}
