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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the ApproveAssignment operation. The <c>ApproveAssignment</c>
    /// operation approves the results of a completed assignment. <para> Approving an assignment
    /// initiates two payments from the Requester's Amazon.com account </para> <ul> <li> <para>
    /// The Worker who submitted the results is paid the reward specified in the HIT. </para>
    /// </li> <li> <para> Amazon Mechanical Turk fees are debited. </para> </li> </ul> <para>
    /// If the Requester's account does not have adequate funds for these payments, the call
    /// to ApproveAssignment returns an exception, and the approval is not processed. You
    /// can include an optional feedback message with the approval, which the Worker can see
    /// in the Status section of the web site. </para> <para> You can also call this operation
    /// for assignments that were previous rejected and approve them by explicitly overriding
    /// the previous rejection. This only works on rejected assignments that were submitted
    /// within the previous 30 days and only if the assignment's related HIT has not been
    /// deleted. </para>
    /// </summary>
    public partial class ApproveAssignmentRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        ///  The ID of the assignment. The assignment must correspond to a HIT created by the
        /// Requester. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AssignmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentId property is set.
        /// </summary>
        internal bool IsSetAssignmentId() => this.AssignmentId != null;

        /// <summary>
        /// Gets and sets the property OverrideRejection. 
        /// <para>
        ///  A flag indicating that an assignment should be approved even if it was previously
        /// rejected. Defaults to <c>False</c>. 
        /// </para>
        /// </summary>
        public bool? OverrideRejection { get; set; }

        /// <summary>
        /// Checks to see if the OverrideRejection property is set.
        /// </summary>
        internal bool IsSetOverrideRejection() => this.OverrideRejection.HasValue;

        /// <summary>
        /// Gets and sets the property RequesterFeedback. 
        /// <para>
        ///  A message for the Worker, which the Worker can see in the Status section of the web
        /// site. 
        /// </para>
        /// </summary>
        public string RequesterFeedback { get; set; }

        /// <summary>
        /// Checks to see if the RequesterFeedback property is set.
        /// </summary>
        internal bool IsSetRequesterFeedback() => this.RequesterFeedback != null;
    }
}
