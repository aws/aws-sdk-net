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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetDocumentContent operation.
    /// </summary>
    public partial class GetDocumentContentResponse : AmazonWebServiceResponse
    {
        private long? _documentContentLength;
        private string _mimeType;
        private string _presignedUrl;

        /// <summary>
        /// Gets and sets the property DocumentContentLength. 
        /// <para>
        /// The size of the document content in bytes available at the pre-signed URL.
        /// </para>
        /// </summary>
        public long? DocumentContentLength
        {
            get { return this._documentContentLength; }
            set { this._documentContentLength = value; }
        }

        // Check to see if DocumentContentLength property is set
        internal bool IsSetDocumentContentLength()
        {
            return this._documentContentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the document content. For <c>RAW</c> format, this is the original
        /// file type (for example, <c>application/pdf</c>). For <c>EXTRACTED</c> format, this
        /// is always <c>application/json</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MimeType
        {
            get { return this._mimeType; }
            set { this._mimeType = value; }
        }

        // Check to see if MimeType property is set
        internal bool IsSetMimeType()
        {
            return this._mimeType != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// A pre-signed URL for downloading the document content. The URL expires after 5 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string PresignedUrl
        {
            get { return this._presignedUrl; }
            set { this._presignedUrl = value; }
        }

        // Check to see if PresignedUrl property is set
        internal bool IsSetPresignedUrl()
        {
            return this._presignedUrl != null;
        }

    }
}