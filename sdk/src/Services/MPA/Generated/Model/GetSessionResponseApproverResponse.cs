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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for an approver response in an approval session.
    /// </summary>
    public partial class GetSessionResponseApproverResponse
    {
        private string _approverId;
        private string _identityId;
        private string _identitySourceArn;
        private SessionResponse _response;
        private DateTime? _responseTime;

        /// <summary>
        /// Gets and sets the property ApproverId. 
        /// <para>
        /// ID for the approver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ApproverId
        {
            get { return this._approverId; }
            set { this._approverId = value; }
        }

        // Check to see if ApproverId property is set
        internal bool IsSetApproverId()
        {
            return this._approverId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// ID for the identity source. The identity source manages the user authentication for
        /// approvers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string IdentityId
        {
            get { return this._identityId; }
            set { this._identityId = value; }
        }

        // Check to see if IdentityId property is set
        internal bool IsSetIdentityId()
        {
            return this._identityId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentitySourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the identity source. The identity source manages the
        /// user authentication for approvers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string IdentitySourceArn
        {
            get { return this._identitySourceArn; }
            set { this._identitySourceArn = value; }
        }

        // Check to see if IdentitySourceArn property is set
        internal bool IsSetIdentitySourceArn()
        {
            return this._identitySourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// Response to the operation request.
        /// </para>
        /// </summary>
        public SessionResponse Response
        {
            get { return this._response; }
            set { this._response = value; }
        }

        // Check to see if Response property is set
        internal bool IsSetResponse()
        {
            return this._response != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseTime. 
        /// <para>
        /// Timestamp when a approver responded to the operation request.
        /// </para>
        /// </summary>
        public DateTime? ResponseTime
        {
            get { return this._responseTime; }
            set { this._responseTime = value; }
        }

        // Check to see if ResponseTime property is set
        internal bool IsSetResponseTime()
        {
            return this._responseTime.HasValue; 
        }

    }
}