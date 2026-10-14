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
    /// Container for the parameters to the GetComplianceDetail operation. Returns detailed
    /// compliance information about the specified member account. Details include resources
    /// that are in and out of compliance with the specified policy. <para> The reasons for
    /// resources being considered compliant depend on the Firewall Manager policy type. </para>
    /// </summary>
    public partial class GetComplianceDetailRequest : AmazonFMSRequest
    {
        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The Amazon Web Services account that owns the resources that you want to get the details
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string MemberAccount { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccount property is set.
        /// </summary>
        internal bool IsSetMemberAccount() => this.MemberAccount != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the policy that you want to get the details for. <c>PolicyId</c> is returned
        /// by <c>PutPolicy</c> and by <c>ListPolicies</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;
    }
}
