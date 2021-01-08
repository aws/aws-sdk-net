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
    /// Response properties for GetDocumentStream operation.
    /// </summary>
    public class GetDocumentStreamResponse
    {
        /// <summary>
        /// The ID of the document.
        /// </summary>
        public String DocumentId { get; }

        /// <summary>
        /// The version ID of the document.
        /// </summary>
        public String VersionId { get; internal set; }

        /// <summary>
        /// Stream of the document content.
        /// </summary>
        public Stream Stream { get; internal set; }

        internal GetDocumentStreamResponse(GetDocumentStreamRequest request)
        {
            DocumentId = request.DocumentId;
        }
    }
}
