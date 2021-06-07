using System.Collections.Generic;
using UnityEngine;

namespace NotTidduss.Core.Extensions
{
    public static class CollectionExtensions
    {
        public static List<T> ShuffleItems<T>(this List<T> originalItems)
        {
            List<T> shuffledItems = new List<T>();

            return Shuffle(originalItems, shuffledItems);
        }

        private static List<T> Shuffle<T>(List<T> originalItems, List<T> shuffledItems)
        {
            if (originalItems.Count == 0) return shuffledItems;

            int randomIndex = Random.Range(0, originalItems.Count);
            shuffledItems.Add(originalItems[randomIndex]);
            originalItems.RemoveAt(randomIndex);

            return Shuffle(originalItems, shuffledItems);
        }
    }
}
