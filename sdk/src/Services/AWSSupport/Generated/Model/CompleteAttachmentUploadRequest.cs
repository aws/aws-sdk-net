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
    /// Container for the parameters to the CompleteAttachmentUpload operation.
    /// Completes an attachment upload that was started with <a>GetAttachmentUploadLinks</a>.
    /// After you upload a part of the file to its presigned Amazon S3 URL, call <c>CompleteAttachmentUpload</c>
    /// with the <c>partIndex</c> and <c>eTag</c> of that part. You can include one part per
    /// call, or multiple parts in a single call. After <c>CompleteAttachmentUpload</c> has
    /// been called for every part of the file, the service processes the upload asynchronously.
    /// The <c>attachment-ready</c> status might not be reflected immediately. Use <a>DescribeAttachmentUploadStatus</a>
    /// to poll for the <c>uploadStatus</c> to become <c>attachment-ready</c> before passing
    /// the <c>uploadId</c> to <a>CreateCase</a> or <a>AddCommunicationToCase</a>.
    /// </summary>
    public partial class CompleteAttachmentUploadRequest : AmazonAWSSupportRequest
    {
        private List<CompletedUpload> _completedUploads = AWSConfigs.InitializeCollections ? new List<CompletedUpload>() : null;
        private bool? _dryRun;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property CompletedUploads. 
        /// <para>
        /// The list of parts being reported as completed in this call. Each entry must contain
        /// the <c>partIndex</c> of an uploaded part and the <c>ETag</c> returned by Amazon S3
        /// when that part was uploaded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CompletedUpload> CompletedUploads
        {
            get { return this._completedUploads; }
            set { this._completedUploads = value; }
        }

        // Check to see if CompletedUploads property is set
        internal bool IsSetCompletedUploads()
        {
            return this._completedUploads != null && (this._completedUploads.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually completing the upload.
        /// When set to <c>true</c>, the request is validated but the upload isn't finalized,
        /// and the operation returns a <c>DryRunOperationException</c>. When omitted or set to
        /// <c>false</c>, the request runs normally.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The identifier associated with the upload to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}