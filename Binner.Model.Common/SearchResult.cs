﻿namespace Binner.Model.Common
{
    /// <summary>
    /// A ranked search result
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SearchResult<T>
    {
        /// <summary>
        /// The search result entry
        /// </summary>
        public T Result { get; }

        /// <summary>
        /// The rank of the result
        /// </summary>
        public int Rank { get; }

        public SearchResult(T result, int rank)
        {
            Result = result;
            Rank = rank;
        }
    }
}
