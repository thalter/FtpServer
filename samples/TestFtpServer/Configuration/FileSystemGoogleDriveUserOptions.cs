// <copyright file="FileSystemGoogleDriveUserOptions.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using JetBrains.Annotations;

namespace TestFtpServer.Configuration
{
    /// <summary>
    /// Options for a Google Drive for a user.
    /// </summary>
    public class FileSystemGoogleDriveUserOptions
    {
        /// <summary>
        /// Gets or sets the path to the client secrets file.
        /// </summary>
        [CanBeNull]
        public string ClientSecrets { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        [CanBeNull]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Google Drive access token should be refreshed.
        /// </summary>
        public bool RefreshToken { get; set; }
    }
}
