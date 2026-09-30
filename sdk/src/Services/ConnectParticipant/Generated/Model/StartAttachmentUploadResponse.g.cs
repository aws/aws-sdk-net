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
    /// This is the response object from the StartAttachmentUpload operation.
    /// </summary>
    public partial class StartAttachmentUploadResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// A unique identifier for the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property UploadMetadata. 
        /// <para>
        /// The headers to be provided while uploading the file to the URL.
        /// </para>
        /// </summary>
        public UploadMetadata UploadMetadata { get; set; }

        /// <summary>
        /// Checks to see if the UploadMetadata property is set.
        /// </summary>
        internal bool IsSetUploadMetadata() => this.UploadMetadata != null;
    }
}
