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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// This is the response object from the GetAttachment operation.
    /// </summary>
    public partial class GetAttachmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttachmentSizeInBytes. 
        /// <para>
        /// The size of the attachment in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? AttachmentSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentSizeInBytes property is set.
        /// </summary>
        internal bool IsSetAttachmentSizeInBytes() => this.AttachmentSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// This is the pre-signed URL that can be used for uploading the file to Amazon S3 when
        /// used in response to <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_StartAttachmentUpload.html">StartAttachmentUpload</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property UrlExpiry. 
        /// <para>
        /// The expiration time of the URL in ISO timestamp. It's specified in ISO 8601 format:
        /// yyyy-MM-ddThh:mm:ss.SSSZ. For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        public string UrlExpiry { get; set; }

        /// <summary>
        /// Checks to see if the UrlExpiry property is set.
        /// </summary>
        internal bool IsSetUrlExpiry() => this.UrlExpiry != null;
    }
}
