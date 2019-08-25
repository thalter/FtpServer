// <copyright file="CreateEncryptedStreamDelegate.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System.IO;
using System.Threading.Tasks;

using FubarDev.FtpServer.Features;

namespace FubarDev.FtpServer
{
    /// <summary>
    /// A delegate that's used to create an encrypted stream (<see cref="ISecureConnectionFeature.CreateEncryptedStream"/>).
    /// </summary>
    /// <param name="unencryptedStream">The unencrypted stream.</param>
    /// <returns>The encrypted stream.</returns>
    public delegate Task<Stream> CreateEncryptedStreamDelegate(Stream unencryptedStream);
}
