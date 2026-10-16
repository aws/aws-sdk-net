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

namespace Amazon.WorkDocs.Utils
{
    /// <summary>
    /// Response properties for UploadDocumentStream operation.
    /// </summary>
    public class UploadDocumentStreamResponse
    {
        /// <summary>
        /// The ID of the parent folder.
        /// </summary>
        public String ParentFolderId { get; }

        /// <summary>
        /// The name of the document.
        /// </summary>
        public String DocumentName { get; }

        /// <summary>
        /// The content type of the document.
        /// </summary>
        public String ContentType { get; }

        /// <summary>
        /// The timestamp when the content of the document was originally created.
        /// </summary>
        public DateTime ContentCreatedTimestamp { get; }

        /// <summary>
        /// The timestamp when the content of the document was modified.
        /// </summary>
        public DateTime ContentModifiedTimestamp { get; }

        /// <summary>
        /// The size of the document, in bytes.
        /// </summary>
        public long DocumentSizeInBytes { get; }

        /// <summary>
        /// Steam of the document content.
        /// </summary>
        public Stream Stream { get; }

        /// <summary>
        /// The ID of the document.
        /// </summary>
        public String DocumentId { get; internal set; }

        /// <summary>
        /// The version ID of the document.
        /// </summary>
        public String VersionId { get; internal set; }

        internal UploadDocumentStreamResponse(UploadDocumentStreamRequest request)
        {
            ParentFolderId = request.ParentFolderId;
            DocumentName = request.DocumentName;
            ContentType = request.ContentType;
            ContentCreatedTimestamp = request.ContentCreatedTimestamp;
            ContentModifiedTimestamp = request.ContentModifiedTimestamp;
            DocumentSizeInBytes = request.DocumentSizeInBytes;
            Stream = request.Stream;
            DocumentId = request.DocumentId;
        }
    }
}
