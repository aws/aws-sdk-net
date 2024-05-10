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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
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
namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Metadata that is associated with a code review. This applies to both pull request
    /// and repository analysis code reviews.
    /// </summary>
    public partial class RequestMetadata
    {
        private EventInfo _eventInfo;
        private string _requester;
        private string _requestId;
        private VendorName _vendorName;

        /// <summary>
        /// Gets and sets the property EventInfo. 
        /// <para>
        /// Information about the event associated with a code review.
        /// </para>
        /// </summary>
        public EventInfo EventInfo
        {
            get { return this._eventInfo; }
            set { this._eventInfo = value; }
        }

        // Check to see if EventInfo property is set
        internal bool IsSetEventInfo()
        {
            return this._eventInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Requester. 
        /// <para>
        /// An identifier, such as a name or account ID, that is associated with the requester.
        /// The <c>Requester</c> is used to capture the <c>author/actor</c> name of the event
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Requester
        {
            get { return this._requester; }
            set { this._requester = value; }
        }

        // Check to see if Requester property is set
        internal bool IsSetRequester()
        {
            return this._requester != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The ID of the request. This is required for a pull request code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the repository vendor used to upload code to an S3 bucket for a CI/CD
        /// code review. For example, if code and artifacts are uploaded to an S3 bucket for a
        /// CI/CD code review by GitHub scripts from a GitHub repository, then the repository
        /// association's <c>ProviderType</c> is <c>S3Bucket</c> and the CI/CD repository vendor
        /// name is GitHub. For more information, see the definition for <c>ProviderType</c> in
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">RepositoryAssociation</a>.
        /// </para>
        /// </summary>
        public VendorName VendorName
        {
            get { return this._vendorName; }
            set { this._vendorName = value; }
        }

        // Check to see if VendorName property is set
        internal bool IsSetVendorName()
        {
            return this._vendorName != null;
        }

    }
}