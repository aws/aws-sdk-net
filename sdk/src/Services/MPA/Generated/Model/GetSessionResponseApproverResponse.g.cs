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

namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for an approver response in an approval session.
    /// </summary>
    public partial class GetSessionResponseApproverResponse
    {
        /// <summary>
        /// Gets and sets the property ApproverId. 
        /// <para>
        /// ID for the approver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApproverId { get; set; }

        /// <summary>
        /// Checks to see if the ApproverId property is set.
        /// </summary>
        internal bool IsSetApproverId() => this.ApproverId != null;

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// ID for the identity source. The identity source manages the user authentication for
        /// approvers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityId property is set.
        /// </summary>
        internal bool IsSetIdentityId() => this.IdentityId != null;

        /// <summary>
        /// Gets and sets the property IdentitySourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the identity source. The identity source manages the
        /// user authentication for approvers.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string IdentitySourceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySourceArn property is set.
        /// </summary>
        internal bool IsSetIdentitySourceArn() => this.IdentitySourceArn != null;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// Response to the operation request.
        /// </para>
        /// </summary>
        public SessionResponse Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property ResponseTime. 
        /// <para>
        /// Timestamp when a approver responded to the operation request.
        /// </para>
        /// </summary>
        public DateTime? ResponseTime { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTime property is set.
        /// </summary>
        internal bool IsSetResponseTime() => this.ResponseTime.HasValue;
    }
}
