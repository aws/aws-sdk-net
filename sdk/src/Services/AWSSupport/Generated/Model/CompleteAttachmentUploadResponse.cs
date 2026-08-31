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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// This is the response object from the CompleteAttachmentUpload operation.
    /// </summary>
    public partial class CompleteAttachmentUploadResponse : AmazonWebServiceResponse
    {
        private UploadStatus _uploadStatus;

        /// <summary>
        /// Gets and sets the property UploadStatus. 
        /// <para>
        /// The status of the multipart upload after the operation finalizes the attachment. Valid
        /// values: <c>attachment-ready</c>, <c>attachment-not-ready</c>, and <c>failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UploadStatus UploadStatus
        {
            get { return this._uploadStatus; }
            set { this._uploadStatus = value; }
        }

        // Check to see if UploadStatus property is set
        internal bool IsSetUploadStatus()
        {
            return this._uploadStatus != null;
        }

    }
}