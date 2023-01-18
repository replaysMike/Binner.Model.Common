namespace Binner.Model.Common
{
    /// <summary>
    /// Paginated data response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PaginatedResponse<T>
    {
        public int TotalPages { get; }
        public IEnumerable<T> Items { get; }

        public PaginatedResponse(int totalPages, IEnumerable<T> items)
        {
            TotalPages = totalPages;
            Items = items;
        }
    }
}
