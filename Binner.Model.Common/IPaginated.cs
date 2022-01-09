﻿using System.ComponentModel.DataAnnotations;

namespace Binner.Model.Common
{
    public interface IPaginated
    {
        /// <summary>
        /// Page Number
        /// </summary>
        [Range(1, 1000)]
        int Page { get; set; }

        /// <summary>
        /// Number of results to return
        /// </summary>
        [Range(1, 100)]
        int Results { get; set; }
    }
}
