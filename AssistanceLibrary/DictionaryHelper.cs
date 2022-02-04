using System.Collections.Generic;

namespace AssistanceLibrary
{
    public class DictionaryHelper<K, V>
    {
        public static Dictionary<K, V> CreateDictionary(K[] key, V[] value)
        {
            Dictionary<K, V> newDictionary = new();
            for (int i = 0; i < key.Length; i++)
                newDictionary.Add(key[i], value[i]);
            return newDictionary;
        }

        public static Dictionary<K, V> AddToDictionary(Dictionary<K, V> mainDictionary, K[] key, V[] value)
        {
            for (int i = 0; i < key.Length; i++)
                mainDictionary.Add(key[i], value[i]);
            return mainDictionary;
        }

        public static Dictionary<K,V> AddToDictionary(Dictionary<K, V> mainDictionary, Dictionary<K,V> secondDictionary)
        {
            foreach (var item in secondDictionary)
                mainDictionary.Add(item.Key, item.Value);
            return mainDictionary;
        }
    }
}
