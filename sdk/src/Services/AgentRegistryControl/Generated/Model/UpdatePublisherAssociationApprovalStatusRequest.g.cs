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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePublisherAssociationApprovalStatus operation.
    /// Record the curator's decision (APPROVED or REJECTED) on a registry record's publisher
    /// association. A successful call returns an empty response. Repeating the decision the
    /// association already holds changes nothing; the same approvalStatus with a different
    /// approvalStatusReason updates the reason. If the caller has no publisher association
    /// for the registry record, the request fails with AccessDeniedException. A ConflictException
    /// (HTTP 409) means the association is not in a state that accepts the decision (e.g.
    /// not PENDING_APPROVAL/APPROVED/REJECTED) or it changed while the request was being
    /// applied; read it again before deciding whether to resubmit.
    /// </summary>
    public partial class UpdatePublisherAssociationApprovalStatusRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalStatus.
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationApprovalStatus ApprovalStatus { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalStatus property is set.
        /// </summary>
        internal bool IsSetApprovalStatus() => this.ApprovalStatus != null;

        /// <summary>
        /// Gets and sets the property ApprovalStatusReason. The curator's reason for the decision;
        /// may be empty.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string ApprovalStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalStatusReason property is set.
        /// </summary>
        internal bool IsSetApprovalStatusReason() => this.ApprovalStatusReason != null;

        /// <summary>
        /// Gets and sets the property RecordArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RecordArn { get; set; }

        /// <summary>
        /// Checks to see if the RecordArn property is set.
        /// </summary>
        internal bool IsSetRecordArn() => this.RecordArn != null;
    }
}
