using System.Collections.Generic;

namespace AssistanceLibrary
{
    public class ArrayHelper<T>
    {
        public static T[] Append(T[] arrayElements, T element)
        {
            T[] newArrayElement = new T[arrayElements.Length + 1];
            for (int i = 0; i < arrayElements.Length; i++)
                newArrayElement[i] = arrayElements[i];
            newArrayElement[^1] = element;
            return newArrayElement;
        }

        public static T[] Append(T[] mainArrayElements, T[] addedArrayElements)
        {
            int indexElement = 0;
            T[] newArrayElement = new T[mainArrayElements.Length + addedArrayElements.Length];
            for (int i = 0; i < mainArrayElements.Length; i++)
                newArrayElement[i] = mainArrayElements[i];
            for (int i = mainArrayElements.Length; i < newArrayElement.Length; i++)
                newArrayElement[i] = addedArrayElements[indexElement++];
            return newArrayElement;
        }

        public static T[] Append(T[] mainArrayElements, int indexElement, T element)
        {
            T[] newArray = new T[mainArrayElements.Length + 1];
            for (int i = 0; i < indexElement; i++)
                newArray[i] = mainArrayElements[i];
            newArray[indexElement] = element;
            int index = indexElement + 1;
            for (int i = indexElement; i < mainArrayElements.Length; i++)
            {
                newArray[index] = mainArrayElements[i];
                index++;
            }
            return newArray;
        }

        public static T[] TakeElements(T[] mainArrayElements, int startIndex, int endIndex)
        {
            int count = 0;
            T[] newArray = new T[endIndex - startIndex];
            for (int i = startIndex; i < endIndex; i++)
                newArray[count++] = mainArrayElements[i];
            return newArray;
        }

        public static T[] TakeElements(T[] mainArrayElements, params int[] indexElement)
        {
            T[] newArray = new T[indexElement.Length];
            for (int i = 0; i < indexElement.Length; i++)
                newArray[i] = mainArrayElements[indexElement[i]];
            return newArray;
        }
    }
}
