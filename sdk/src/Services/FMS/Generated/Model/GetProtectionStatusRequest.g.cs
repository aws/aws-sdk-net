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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the GetProtectionStatus operation. If you created
    /// a Shield Advanced policy, returns policy-level attack summary information in the event
    /// of a potential DDoS attack. Other policy types are currently unsupported.
    /// </summary>
    public partial class GetProtectionStatusRequest : AmazonFMSRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period to query for the attacks. This is a <c>timestamp</c> type.
        /// The request syntax listing indicates a <c>number</c> type because the default used
        /// by Firewall Manager is Unix time in seconds. However, any valid <c>timestamp</c> format
        /// is allowed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the number of objects that you want Firewall Manager to return for this
        /// request. If you have more objects than the number that you specify for <c>MaxResults</c>,
        /// the response includes a <c>NextToken</c> value that you can use to get another batch
        /// of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MemberAccountId. 
        /// <para>
        /// The Amazon Web Services account that is in scope of the policy that you want to get
        /// the details for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string MemberAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccountId property is set.
        /// </summary>
        internal bool IsSetMemberAccountId() => this.MemberAccountId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <c>MaxResults</c> and you have more objects than the number
        /// that you specify for <c>MaxResults</c>, Firewall Manager returns a <c>NextToken</c>
        /// value in the response, which you can use to retrieve another group of objects. For
        /// the second and subsequent <c>GetProtectionStatus</c> requests, specify the value of
        /// <c>NextToken</c> from the previous response to get information about another batch
        /// of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the policy for which you want to get the attack information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period to query for the attacks. This is a <c>timestamp</c>
        /// type. The request syntax listing indicates a <c>number</c> type because the default
        /// used by Firewall Manager is Unix time in seconds. However, any valid <c>timestamp</c>
        /// format is allowed.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
