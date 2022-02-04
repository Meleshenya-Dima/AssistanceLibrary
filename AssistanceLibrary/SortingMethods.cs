using System;
using System.Linq;

namespace AssistanceLibrary
{
    public class SortingMethods<T> where T : IComparable<T>
    {
        public static T[] BubbleSort(T[] ArrayOfT)
        {
            T temp;
            for (int i = 0; i < ArrayOfT.Length; i++)
            {
                for (int j = i + 1; j < ArrayOfT.Length; j++)
                {
                    if (ArrayOfT[i].CompareTo(ArrayOfT[j]) > 0)
                    {
                        temp = ArrayOfT[i];
                        ArrayOfT[i] = ArrayOfT[j];
                        ArrayOfT[j] = temp;
                    }
                }
            }
            return ArrayOfT;
        }

        public static T[] HoareSort(T[] ArrayOfT, int startIndex, int endIndex)
        {
            if (endIndex == startIndex) return ArrayOfT;
            T pivot = ArrayOfT[endIndex];
            int storeIndex = startIndex;
            for (int i = startIndex; i <= endIndex - 1; i++)
                if (ArrayOfT[i].CompareTo(pivot) <= 0)
                {
                    T t = ArrayOfT[i];
                    ArrayOfT[i] = ArrayOfT[storeIndex];
                    ArrayOfT[storeIndex] = t;
                    storeIndex++;
                }
            T n = ArrayOfT[storeIndex];
            ArrayOfT[storeIndex] = ArrayOfT[endIndex];
            ArrayOfT[endIndex] = n;
            if (storeIndex > startIndex) return HoareSort(ArrayOfT, startIndex, storeIndex - 1);
            if (storeIndex < endIndex) return HoareSort(ArrayOfT, storeIndex + 1, endIndex);
            return ArrayOfT;
        }
    }
}
