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
    /// Container for the parameters to the GetAttachmentDownloadLink operation.
    /// Returns a presigned download URL for an attachment that is associated with a case
    /// communication. The download link works for an attachment of any size, including attachments
    /// added through <c>AddAttachmentsToSet</c> and attachments uploaded through <a>GetAttachmentUploadLinks</a>.
    /// The download URL is time-limited and expires at the date and time indicated in the
    /// <c>downloadUrl</c> response field. Download the attachment from the URL before it
    /// expires.
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
    public partial class GetAttachmentDownloadLinkRequest : AmazonAWSSupportRequest
    {
        private string _attachmentId;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The unique identifier of the attachment for which to retrieve a download link. Attachment
        /// IDs are returned in the <c>AttachmentDetails</c> objects in the <c>attachments</c>
        /// field of a <a>Communication</a> returned by <a>DescribeCommunications</a> or <a>DescribeCases</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually returning a download link.
        /// When set to <c>true</c>, the request is validated but no URL is returned, and the
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

    }
}