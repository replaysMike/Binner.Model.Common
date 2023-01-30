using System.Linq.Expressions;

namespace Binner.Model.Common
{
    /// <summary>
    /// A part storage provider
    /// </summary>
    public interface IStorageProvider : IDisposable
    {
        /// <summary>
        /// Get an instance of the entire database
        /// </summary>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<IBinnerDb> GetDatabaseAsync(IUserContext userContext);

        /// <summary>
        /// Get an oAuth Credential
        /// </summary>
        /// <param name="providerName">The provider name to fetch</param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<OAuthCredential> GetOAuthCredentialAsync(string providerName, IUserContext userContext);

        /// <summary>
        /// Save an oAuth Credential
        /// </summary>
        /// <param name="credential"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<OAuthCredential> SaveOAuthCredentialAsync(OAuthCredential credential, IUserContext userContext);

        /// <summary>
        /// Remove an oAuth Credential
        /// </summary>
        /// <param name="providerName">The provider name to fetch</param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task RemoveOAuthCredentialAsync(string providerName, IUserContext userContext);

        /// <summary>
        /// Add a new part
        /// </summary>
        /// <param name="part"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Part> AddPartAsync(Part part, IUserContext userContext);

        /// <summary>
        /// Update an existing part
        /// </summary>
        /// <param name="part"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Part> UpdatePartAsync(Part part, IUserContext userContext);

        /// <summary>
        /// Get a part by its internal id
        /// </summary>
        /// <param name="partId"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Part> GetPartAsync(long partId, IUserContext userContext);

        /// <summary>
        /// Get a part by part number
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Part> GetPartAsync(string partNumber, IUserContext userContext);

        /// <summary>
        /// Get all parts
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<PaginatedResponse<Part>> GetPartsAsync(PaginatedRequest request, IUserContext userContext);

        /// <summary>
        /// Get all parts
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<ICollection<Part>> GetPartsAsync(Expression<Func<Part, bool>> predicate, IUserContext userContext);

        /// <summary>
        /// Find a part that matches any keyword
        /// </summary>
        /// <param name="keywords">Space seperated keywords</param>
        /// <param name="userContext">The user performing the operation</param>

        /// <returns></returns>
        Task<ICollection<SearchResult<Part>>> FindPartsAsync(string keywords, IUserContext userContext);

        /// <summary>
        /// Delete an existing part
        /// </summary>
        /// <param name="part"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<bool> DeletePartAsync(Part part, IUserContext userContext);

        /// <summary>
        /// Get a partType object, or create it if it doesn't exist
        /// </summary>
        /// <param name="partType"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<PartType> GetOrCreatePartTypeAsync(PartType partType, IUserContext userContext);

        /// <summary>
        /// Get an existing part type
        /// </summary>
        /// <param name="partTypeId"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<PartType> GetPartTypeAsync(long partTypeId, IUserContext userContext);

        /// <summary>
        /// Update an existing part type
        /// </summary>
        /// <param name="partType"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<PartType> UpdatePartTypeAsync(PartType partType, IUserContext userContext);

        /// <summary>
        /// Delete an existing partType
        /// </summary>
        /// <param name="partType"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<bool> DeletePartTypeAsync(PartType partType, IUserContext userContext);

        /// <summary>
        /// Get all of the part types
        /// </summary>
        /// <param name="userContext"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<ICollection<PartType>> GetPartTypesAsync(IUserContext userContext);

        /// <summary>
        /// Create a new user defined project
        /// </summary>
        /// <param name="project"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Project> AddProjectAsync(Project project, IUserContext userContext);

        /// <summary>
        /// Get an existing user defined project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Project> GetProjectAsync(long projectId, IUserContext userContext);

        /// <summary>
        /// Get an existing user defined project
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Project> GetProjectAsync(string projectName, IUserContext userContext);

        /// <summary>
        /// Get an existing user defined project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<ICollection<Project>> GetProjectsAsync(PaginatedRequest request, IUserContext userContext);

        /// <summary>
        /// Update an existing user defined project
        /// </summary>
        /// <param name="project"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<Project> UpdateProjectAsync(Project project, IUserContext userContext);

        /// <summary>
        /// Update an existing user defined project
        /// </summary>
        /// <param name="project"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<bool> DeleteProjectAsync(Project project, IUserContext userContext);

        /// <summary>
        /// Get total parts count including quantities
        /// </summary>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<long> GetPartsCountAsync(IUserContext userContext);

        /// <summary>
        /// Get total number of unique parts
        /// </summary>
        /// <param name="userContext"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<long> GetUniquePartsCountAsync(IUserContext userContext);

        /// <summary>
        /// Get financial value/cost of all parts
        /// </summary>
        /// <param name="userContext"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<decimal> GetPartsValueAsync(IUserContext userContext);

        /// <summary>
        /// Get low stock
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<PaginatedResponse<Part>> GetLowStockAsync(PaginatedRequest request, IUserContext userContext);

        /// <summary>
        /// Create a new user uploaded file
        /// </summary>
        /// <param name="storedFile"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<StoredFile> AddStoredFileAsync(StoredFile storedFile, IUserContext userContext);

        /// <summary>
        /// Get an existing user uploaded file
        /// </summary>
        /// <param name="storedFileId"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<StoredFile> GetStoredFileAsync(long storedFileId, IUserContext userContext);

        /// <summary>
        /// Get an existing user uploaded file
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<StoredFile> GetStoredFileAsync(string filename, IUserContext userContext);

        /// <summary>
        /// Get existing user uploaded files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<ICollection<StoredFile>> GetStoredFilesAsync(long partId, StoredFileType? fileType, IUserContext userContext);

        /// <summary>
        /// Get existing user uploaded files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userContext">The user performing the operation</param>
        /// <returns></returns>
        Task<ICollection<StoredFile>> GetStoredFilesAsync(PaginatedRequest request, IUserContext userContext);
    }
}
