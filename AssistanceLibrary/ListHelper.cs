using System.Collections.Generic;

namespace AssistanceLibrary
{
    public class ListHelper<T>
    {
        public static List<T> TakeElement(List<T> mainArrayElements, int startIndex, int endIndex)
        {
            List<T> newList = new();
            for (int i = startIndex; i < endIndex; i++)
                newList.Add(mainArrayElements[i]);
            return newList;
        }

        public static List<T> TakeElement(List<T> mainArrayElements, params int[] elementsIndex)
        {
            List<T> newList = new();
            for (int i = 0; i < elementsIndex.Length; i++)
                newList.Add(mainArrayElements[elementsIndex[i]]);
            return newList;
        }

        public static List<T> Append(List<T> mainArrayElements, int indexElement, T element)
        {
            List<T> newArray = new();
            for (int i = 0; i < indexElement; i++)
                newArray.Add(mainArrayElements[i]);
            newArray.Add(element);
            for (int i = indexElement; i < mainArrayElements.Count; i++)
                newArray.Add(mainArrayElements[i]);
            return newArray;
        }
    }
}
