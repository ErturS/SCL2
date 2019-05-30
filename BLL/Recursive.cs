namespace BLL
{
    public class Recursive
    {
        private bool[,] binaryArray;
        private int[,] labels;
        private int L, width = 0, height = 0;

        public Recursive(bool[,] binaryArray)
        {
            this.binaryArray = binaryArray;
            width = binaryArray.GetLength(0);
            height = binaryArray.GetLength(1);
            labels = new int[width, height];
        }

        public int[,] GetLabels()
        {
            Labeling();
            return labels;
        }

        private void Labeling()
        {
            L = 1;

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    if (Fill(x, y))
                        L++;
                }
        }

        private bool Fill(int x, int y)
        {
            if ((labels[x, y] == 0) && binaryArray[x, y])
            {
                labels[x, y] = L;

                if (x > 0)
                    Fill(x - 1, y);
                if (x < width - 1)
                    Fill(x + 1, y);
                if (y > 0)
                    Fill(x, y - 1);
                if (y < height - 1)
                    Fill(x, y + 1);
                return true;
            }
            return false;
        }
    }
}
