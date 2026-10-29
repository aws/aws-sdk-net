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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// This is the response object from the DescribeAttachmentUploadStatus operation.
    /// </summary>
    public partial class DescribeAttachmentUploadStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file being uploaded, including the file extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property UploadProgress. 
        /// <para>
        /// The progress of the multipart upload, including the total number of parts and the
        /// number of parts that have been successfully uploaded.
        /// </para>
        /// </summary>
        public UploadProgress UploadProgress { get; set; }

        /// <summary>
        /// Checks to see if the UploadProgress property is set.
        /// </summary>
        internal bool IsSetUploadProgress() => this.UploadProgress != null;

        /// <summary>
        /// Gets and sets the property UploadStatus. 
        /// <para>
        /// The current status of the multipart upload. Valid values: <c>attachment-ready</c>,
        /// <c>attachment-not-ready</c>, and <c>failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UploadStatus UploadStatus { get; set; }

        /// <summary>
        /// Checks to see if the UploadStatus property is set.
        /// </summary>
        internal bool IsSetUploadStatus() => this.UploadStatus != null;
    }
}
