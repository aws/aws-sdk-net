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
    /// Container for the parameters to the GetAttachmentUploadLinks operation.
    /// Returns one or more presigned upload URLs for uploading a large file attachment to
    /// a support case by using a multipart upload workflow. The maximum file size that you
    /// can upload with this workflow is 150 MB, and parts can be up to 100 MB each. Initiate
    /// a new upload by providing <c>fileName</c> and <c>fileSizeBytes</c>; the response returns
    /// a unique <c>uploadId</c>, the part size, the total number of parts, and a list of
    /// presigned upload URLs for the requested range of parts. A maximum of 10 upload URLs
    /// are returned per call. To retrieve more upload URLs for an upload that's already in
    /// progress, call <c>GetAttachmentUploadLinks</c> again with the existing <c>uploadId</c>
    /// and a new <c>uploadRange</c>.
    /// 
    ///  
    /// <para>
    /// Upload each part to its presigned URL by using HTTP <c>PUT</c> and capture the ETag
    /// from the response. After you upload all parts, call <a>CompleteAttachmentUpload</a>
    /// with the <c>uploadId</c> and the list of part indexes and ETags to finalize the upload.
    /// You can then attach the upload to a case by passing the <c>uploadId</c> in the <c>uploadIds</c>
    /// parameter of <a>CreateCase</a> or <a>AddCommunicationToCase</a>. To monitor progress
    /// before completion, call <a>DescribeAttachmentUploadStatus</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have an Amazon Web Services Business Support+, Amazon Web Services Enterprise
    /// Support, or Amazon Web Services Unified Operations plan to use the Amazon Web Services
    /// Support API. If you're in an Amazon Web Services Region that doesn't offer one of
    /// these Amazon Web Services Support plans, or if you haven't transitioned to one of
    /// these plans, you can use the Amazon Web Services Support API with a Business, Enterprise
    /// On-Ramp, or Enterprise Support plan.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// an Amazon Web Services Business Support+, Amazon Web Services Enterprise Support,
    /// or Amazon Web Services Unified Operations plan, the <c>SubscriptionRequiredException</c>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class GetAttachmentUploadLinksRequest : AmazonAWSSupportRequest
    {
        private bool? _dryRun;
        private string _fileName;
        private long? _fileSizeBytes;
        private string _uploadId;
        private UploadRange _uploadRange;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually generating upload URLs.
        /// When set to <c>true</c>, the request is validated but no URLs are returned, and the
        /// operation returns a <c>DryRunOperationException</c>. When omitted or set to <c>false</c>,
        /// the request runs normally.
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
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file to upload, including the file extension. This value is required
        /// when you initiate a new upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property FileSizeBytes. 
        /// <para>
        /// The total size of the file in bytes. The service uses this value to calculate the
        /// total number of parts and the size of each part. Required when you initiate a new
        /// upload (when <c>uploadId</c> isn't provided). Valid range: 1 to 157,286,400 bytes
        /// (approximately 150 MB).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=157286400)]
        public long? FileSizeBytes
        {
            get { return this._fileSizeBytes; }
            set { this._fileSizeBytes = value; }
        }

        // Check to see if FileSizeBytes property is set
        internal bool IsSetFileSizeBytes()
        {
            return this._fileSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The unique identifier of an in-progress multipart upload, returned by a previous call
        /// to <c>GetAttachmentUploadLinks</c>. Specify <c>uploadId</c> to retrieve additional
        /// presigned upload URLs for an upload that has already been initiated. Required when
        /// <c>fileSizeBytes</c> isn't provided. Length: 1 to 2,048 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property UploadRange. 
        /// <para>
        /// The range of part indexes for which to return presigned upload URLs. Use this parameter
        /// to page through the upload URLs for a large file across multiple calls. If you omit
        /// this parameter, the service determines the range to return.
        /// </para>
        /// </summary>
        public UploadRange UploadRange
        {
            get { return this._uploadRange; }
            set { this._uploadRange = value; }
        }

        // Check to see if UploadRange property is set
        internal bool IsSetUploadRange()
        {
            return this._uploadRange != null;
        }

    }
}