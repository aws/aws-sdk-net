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

using System;
using System.IO;
using System.Threading.Tasks;
using Amazon.Util;
using Amazon.WorkDocs.Model;
using System.Collections.Generic;

namespace Amazon.WorkDocs.Utils
{
    /// <summary>
    /// Implementation of IContentManager interface.
    /// </summary>
    public class ContentManager : IContentManager, IDisposable
    {
        private readonly IAmazonWorkDocs client;
        private readonly String authenticationToken;
        private readonly AWSHttpClient httpClient;
        private bool disposed = false;

        /// <summary>
        /// Initializes ContentManager object.
        /// </summary>
        /// <param name="param">Paramteres.</param>
        public ContentManager(ContentManagerParams param)
        {
            client = param.WorkDocsClient;
            authenticationToken = param.AuthenticationToken;
            httpClient = new AWSHttpClient();
        }

        /// <summary>
        /// Gets document stream of latest version of given document ID.
        /// If version ID is null, it retrieves latest version of requested document ID.
        /// </summary>
        /// <param name="getDocumentStreamRequest">Request parameters.</param>
        /// <returns>Response for stream of latest version of requested document.</returns>
        public async Task<GetDocumentStreamResponse> GetDocumentStreamAsync(GetDocumentStreamRequest getDocumentStreamRequest)
        {
            String versionId = getDocumentStreamRequest.VersionId;
            if (versionId == null)
            {
                GetDocumentRequest getDocumentRequest = new GetDocumentRequest()
                {
                    DocumentId = getDocumentStreamRequest.DocumentId,
                    AuthenticationToken = authenticationToken
                };

                GetDocumentResponse response = await client.GetDocumentAsync(getDocumentRequest).ConfigureAwait(false);
                versionId = response.Metadata.LatestVersionMetadata.Id;
            }

            Stream documentVersionStream = await GetDocumentVersionStreamAsync(getDocumentStreamRequest.DocumentId, versionId).ConfigureAwait(false);
            GetDocumentStreamResponse getDocumentStreamResponse = new GetDocumentStreamResponse(getDocumentStreamRequest)
            {
                Stream = documentVersionStream
            };

            return getDocumentStreamResponse;
        }

        private async Task<Stream> GetDocumentVersionStreamAsync(String documentId, String versionId)
        {
            GetDocumentVersionRequest getDocumentVersionRequest = new GetDocumentVersionRequest()
            {
                DocumentId = documentId,
                VersionId = versionId,
                Fields = "SOURCE",
                AuthenticationToken = authenticationToken
            };

            GetDocumentVersionResponse response = await client.GetDocumentVersionAsync(getDocumentVersionRequest).ConfigureAwait(false);
            String downloadUrl = response.Metadata.Source[DocumentSourceType.ORIGINAL.Value];

            return await httpClient.GetStreamAsync(downloadUrl).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads stream to given folder and document name.
        /// </summary>
        /// <param name="uploadDocumentStreamRequest">Request parameters.</param>
        /// <returns>Response for document details.</returns>
        public async Task<UploadDocumentStreamResponse> UploadDocumentStreamAsync(UploadDocumentStreamRequest uploadDocumentStreamRequest)
        {
            InitiateDocumentVersionUploadRequest initiateDocumentVersionUploadRequest = new InitiateDocumentVersionUploadRequest()
            {
                ParentFolderId = uploadDocumentStreamRequest.ParentFolderId,
                Name = uploadDocumentStreamRequest.DocumentName,
                ContentType = uploadDocumentStreamRequest.ContentType,
                ContentCreatedTimestamp = uploadDocumentStreamRequest.ContentCreatedTimestamp,
                ContentModifiedTimestamp = uploadDocumentStreamRequest.ContentModifiedTimestamp,
                DocumentSizeInBytes = uploadDocumentStreamRequest.DocumentSizeInBytes,
                Id = uploadDocumentStreamRequest.DocumentId,
                AuthenticationToken = authenticationToken
            };

            InitiateDocumentVersionUploadResponse response = await client.InitiateDocumentVersionUploadAsync(initiateDocumentVersionUploadRequest).ConfigureAwait(false);
            UploadMetadata uploadMetadata = response.UploadMetadata;
            String documentId = response.Metadata.Id;
            String versionId = response.Metadata.LatestVersionMetadata.Id;
            String uploadUrl = uploadMetadata.UploadUrl;

            AWSStreamContent content = new AWSStreamContent(uploadDocumentStreamRequest.Stream);
            try
            {
                IDictionary<string, string> requestHeaders = new Dictionary<string, string>();
                requestHeaders.Add("x-amz-server-side-encryption", "AES256");

                content.RemoveHttpContentHeader("Content-Type");
                content.AddHttpContentHeader("Content-Type", uploadDocumentStreamRequest.ContentType);

                await httpClient.PutRequestUriAsync(uploadUrl, content, requestHeaders).ConfigureAwait(false);
                var task = CompleteUpload(documentId, versionId);

                UploadDocumentStreamResponse uploadDocumentStreamResponse = new UploadDocumentStreamResponse(uploadDocumentStreamRequest)
                {
                    DocumentId = task.Result,
                    VersionId = versionId
                };

                return uploadDocumentStreamResponse;
            }
            finally
            {
                content.Dispose();
            }
        }

        private async Task<String> CompleteUpload(String documentId, String versionId)
        {
            UpdateDocumentVersionRequest updateDocumentVersionRequest = new UpdateDocumentVersionRequest()
            {
                DocumentId = documentId,
                VersionId = versionId,
                VersionStatus = DocumentVersionStatus.ACTIVE,
                AuthenticationToken = authenticationToken
            };

            await client.UpdateDocumentVersionAsync(updateDocumentVersionRequest).ConfigureAwait(false);
            return documentId;
        }

        /// <summary>
        /// Disposes ContentManager resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    httpClient.Dispose();
                }

                disposed = true;
            }
        }

        /// <summary>
        /// Finalizer to dispose of the ContentManager
        /// </summary>
        ~ContentManager()
        {
            Dispose(false);
        }
    }
}
