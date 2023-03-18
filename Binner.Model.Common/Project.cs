﻿using System.ComponentModel.DataAnnotations;
using AnySerializer;

namespace Binner.Model.Common
{
    /// <summary>
    /// A user defined project
    /// </summary>
    public class Project : IEntity, IEquatable<Project>
    {
        /// <summary>
        /// Primary key
        /// </summary>
        [Key]
        public long ProjectId { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Project description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Project location
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// Project color
        /// </summary>
        public int Color { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime DateCreatedUtc { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Optional user id to associate
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Custom notes for the project (BOM)
        /// </summary>
        [PropertyVersion("BinnerDbV4")]
        public string? Notes { get; set; }

        /// <summary>
        /// Modification date
        /// </summary>
        [PropertyVersion("BinnerDbV4")]
        public DateTime DateModifiedUtc { get; set; } = DateTime.UtcNow;

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Project project)
                return Equals(project);
            return false;
        }

        public bool Equals(Project? other)
        {
            return other != null && ProjectId == other.ProjectId && UserId == other.UserId;
        }

        public override int GetHashCode()
        {
#if (NET462 || NET471)
            return ProjectId.GetHashCode() ^ (UserId?.GetHashCode() ?? 0);
#else
            return HashCode.Combine(ProjectId, UserId);
#endif

        }

        public override string ToString()
        {
            return $"{ProjectId}: {Name}";
        }
    }
}
