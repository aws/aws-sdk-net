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
    /// Request parameters for UploadDocumentStream operation.
    /// </summary>
    public class UploadDocumentStreamRequest
    {
        /// <summary>
        /// The ID of the parent folder.
        /// </summary>
        public String ParentFolderId { get; set; }

        /// <summary>
        /// The name of the document.
        /// </summary>
        public String DocumentName { get; set; }

        /// <summary>
        /// The content type of the document.
        /// </summary>
        public String ContentType { get; set; }

        /// <summary>
        /// The timestamp when the content of the document was originally created.
        /// </summary>
        public DateTime ContentCreatedTimestamp { get; set; }

        /// <summary>
        /// The timestamp when the content of the document was modified.
        /// </summary>
        public DateTime ContentModifiedTimestamp { get; set; }

        /// <summary>
        /// The size of the document, in bytes.
        /// </summary>
        public long DocumentSizeInBytes { get; set; }

        /// <summary>
        /// Steam of the document content.
        /// </summary>
        public Stream Stream { get; set; }

        /// <summary>
        /// The ID of the document.
        /// </summary>
        public String DocumentId { get; internal set; }

        /// <summary>
        /// Initializes a new instance of UploadDocumentStreamRequest object.
        /// </summary>
        public UploadDocumentStreamRequest()
        {
        }
    }
}
