namespace BLL
{
    
    public class KMeans
    {
        private double[,] brightArray;

        public KMeans(double[,] brightArray)
        {
            this.brightArray = brightArray;
        }

 
        public bool[,] GetBinaryArray()
        {
            double T1;
            double T = GetMidRangeBrightness();

            do
            {
                T1 = T;

                T = GetAverageBrightness(T);
            } while (T != T1);

            return SplitToBinary(T);
        }

       
        private double GetMidRangeBrightness()
        {
            double max, min;
            max = min = brightArray[0, 0];

            for (int i = 0; i < brightArray.GetLength(0); i++)
                for (int j = 0; j < brightArray.GetLength(1); j++)
                {
                    if (max < brightArray[i, j]) max = brightArray[i, j];
                    if (min > brightArray[i, j]) min = brightArray[i, j];
                }
            return (max + min) / 2;
        }

        
        private double GetAverageBrightness(double T)
        {
            double m1 = 0, m2 = 0;
            int m1Count = 0, m2Count = 0;

            for (int i = 0; i < brightArray.GetLength(0); i++)
                for (int j = 0; j < brightArray.GetLength(1); j++)
                    if (brightArray[i, j] > T)
                    {
                        m1 += brightArray[i, j];
                        m1Count++;
                    }
                    else
                    {
                        m2 += brightArray[i, j];
                        m2Count++;
                    }

            if (m1Count != 0) m1 = m1 / m1Count;
            if (m2Count != 0) m2 = m2 / m2Count;

            return (m1 + m2) / 2;
        }

        
        private bool[,] SplitToBinary(double T)
        {
            bool[,] binaryArray = new bool[brightArray.GetLength(0), brightArray.GetLength(1)];

            for (int i = 0; i < brightArray.GetLength(0); i++)
                for (int j = 0; j < brightArray.GetLength(1); j++)
                    binaryArray[i, j] = !(brightArray[i, j] > T);
            return binaryArray;
        }
    }
}