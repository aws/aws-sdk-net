/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * http://aws.amazon.com/apache2.0
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
*/

using System.Threading.Tasks;

namespace Amazon.WorkDocs.Utils
{
    /// <summary>
    /// Interface for trasferring objects to and from WorkDocs.
    /// </summary>
    public interface IContentManager
    {
        /// <summary>
        /// Gets document stream of latest version of given document ID.
        /// If version ID is null, it retrieves latest version of requested document ID.
        /// </summary>
        /// <param name="getDocumentStreamRequest">Request parameters.</param>
        /// <returns>Response for stream of latest version of requested document.</returns>
        Task<GetDocumentStreamResponse> GetDocumentStreamAsync(GetDocumentStreamRequest getDocumentStreamRequest);

        /// <summary>
        /// Uploads stream to given folder and document name.
        /// </summary>
        /// <param name="uploadDocumentStreamRequest">Request parameters.</param>
        /// <returns>Result for document details.</returns>
        Task<UploadDocumentStreamResponse> UploadDocumentStreamAsync(UploadDocumentStreamRequest uploadDocumentStreamRequest);
    }
}
