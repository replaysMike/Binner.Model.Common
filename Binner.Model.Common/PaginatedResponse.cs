namespace Binner.Model.Common
{
    /// <summary>
    /// Paginated data response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PaginatedResponse<T>
    {
        /// <summary>
        /// The total number of items available
        /// </summary>
        public int TotalItems { get; }
        
        /// <summary>
        /// The page of items requested
        /// </summary>
        public IEnumerable<T> Items { get; }

        public PaginatedResponse(int totalPages, IEnumerable<T> items)
        {
            TotalItems = totalPages;
            Items = items;
        }
    }
}
