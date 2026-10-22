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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateMemberToJob operation. Assigns a job
    /// membership level to a member
    /// </summary>
    public partial class AssociateMemberToJobRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the job to associate with the member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterRegion. 
        /// <para>
        /// The Region of the IAM Identity Center instance. If not provided, the service defaults
        /// to the Region of the farm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string IdentityCenterRegion { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterRegion property is set.
        /// </summary>
        internal bool IsSetIdentityCenterRegion() => this.IdentityCenterRegion != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The member's identity store ID to associate with the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID to associate with the member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property MembershipLevel. 
        /// <para>
        /// The principal's membership level for the associated job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MembershipLevel MembershipLevel { get; set; }

        /// <summary>
        /// Checks to see if the MembershipLevel property is set.
        /// </summary>
        internal bool IsSetMembershipLevel() => this.MembershipLevel != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The member's principal ID to associate with the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 47)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The member's principal type to associate with the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID to associate to the member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;
    }
}
