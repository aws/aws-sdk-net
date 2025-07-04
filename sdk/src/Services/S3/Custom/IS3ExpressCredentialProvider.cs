/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.S3.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3
{

    /// <summary>
    /// Interface for S3Express credential provider.
    /// Used to provide credentials for requests that uses S3Express authentication.
    /// </summary>
    public interface IS3ExpressCredentialProvider : IDisposable
    {
        /// <summary>
        /// Resolves S3Express session credentials based on the bucket name.
        /// </summary>
        SessionCredentials ResolveSessionCredentials(string bucketName);

        /// <summary>
        /// Resolves S3Express session credentials based on the bucket name.
        /// </summary>
        Task<SessionCredentials> ResolveSessionCredentialsAsync(string bucketName, CancellationToken cancellationToken = default);
    }
}