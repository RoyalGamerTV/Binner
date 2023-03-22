﻿using System.Collections.Generic;

namespace Binner.Common.Integrations.Models
{
    public interface IApiResponse
    {
        /// <summary>
        /// Response from Api
        /// </summary>
        object? Response { get; set; }

        /// <summary>
        /// Name of api
        /// </summary>
        string ApiName { get; set; }

        /// <summary>
        /// Requires authentication to continue
        /// </summary>
        bool RequiresAuthentication { get; set; }

        /// <summary>
        /// A redirect Url location if requires authentication
        /// </summary>
        string? RedirectUrl { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        IEnumerable<string> Errors { get; set; }

        /// <summary>
        /// Warnings
        /// </summary>
        IEnumerable<string> Warnings { get; set; }
    }
}
