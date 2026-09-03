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
    /// Container for the parameters to the DescribeAttachmentUploadStatus operation.
    /// Returns the current status, file name, and progress of a multipart attachment upload
    /// that was started with <a>GetAttachmentUploadLinks</a>. Use this operation to track
    /// where an upload is in the workflow. While parts are still being uploaded and reported
    /// through <a>CompleteAttachmentUpload</a>, the <c>uploadStatus</c> is <c>attachment-not-ready</c>
    /// and <c>uploadProgress</c> reports the total number of parts and how many have been
    /// completed so far. After every part has been reported and the service finishes processing
    /// the upload asynchronously, the <c>uploadStatus</c> becomes <c>attachment-ready</c>
    /// and the <c>uploadId</c> can be attached to a case through <a>CreateCase</a> or <a>AddCommunicationToCase</a>.
    /// 
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
    public partial class DescribeAttachmentUploadStatusRequest : AmazonAWSSupportRequest
    {
        private bool? _dryRun;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually returning upload status.
        /// When set to <c>true</c>, the request is validated but no status is returned, and the
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
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The unique identifier for the upload. The <c>uploadId</c> is returned by <a>GetAttachmentUploadLinks</a>
        /// when you initiate the upload.
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