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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetDocumentContent operation.
    /// </summary>
    public partial class GetDocumentContentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the document content. When outputFormat is RAW, this corresponds
        /// to the original document's MIME type (e.g., application/pdf, text/plain, application/vnd.openxmlformats-officedocument.wordprocessingml.document).
        /// When outputFormat is EXTRACTED, the MIME type is always application/json.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string MimeType { get; set; }

        /// <summary>
        /// Checks to see if the MimeType property is set.
        /// </summary>
        internal bool IsSetMimeType() => this.MimeType != null;

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// A pre-signed URL that provides temporary access to download the document content directly
        /// from Amazon Q Business. The URL expires after 5 minutes for security purposes. This
        /// URL is generated only after successful ACL validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PresignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrl property is set.
        /// </summary>
        internal bool IsSetPresignedUrl() => this.PresignedUrl != null;
    }
}
