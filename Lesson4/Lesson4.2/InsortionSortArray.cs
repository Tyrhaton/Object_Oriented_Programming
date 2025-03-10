using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2
{
    internal class InsortionSortArray
    {
        int[] row;
        public int[] Row { get { return row; } }

        public InsortionSortArray(int[] Row)
        {
            row = Row;
        }

        public InsortionSortArray InsertionSort()
        {
            int position = 1;
            while (position < row.Length)
            {
                int newPosition = position;
                while(newPosition > 0 && row[newPosition - 1] > row[newPosition])
                {
                    //swap
                    int temp = row[newPosition - 1];
                    row[newPosition -1] = row[newPosition];
                    row[newPosition] = temp;
                    newPosition--;
                }
                position++;
            }
            return this;
        }
        public InsortionSortArray Print()
        {
            for (int i = 0; i < row.Length; i++)
            {
                Console.Write("[+] "+row[i]+" ");
            }
            Console.WriteLine();
            return this;
        }
        public InsortionSortArray InsertionSortWithPrint()
        {
            int position = 1;
            while (position < row.Length)
            {
                int newPosition = position;
                while (newPosition > 0 && row[newPosition - 1] > row[newPosition])
                {
                    //swap
                    int temp = row[newPosition - 1];
                    row[newPosition - 1] = row[newPosition];
                    row[newPosition] = temp;
                    newPosition--;
                }
                position++;
                Print();
            }
            return this;
        }
    }
}
