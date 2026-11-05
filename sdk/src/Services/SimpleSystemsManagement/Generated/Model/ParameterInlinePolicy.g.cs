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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more policies assigned to a parameter.
    /// </summary>
    public partial class ParameterInlinePolicy
    {
        /// <summary>
        /// Gets and sets the property PolicyStatus. 
        /// <para>
        /// The status of the policy. Policies report the following statuses: Pending (the policy
        /// hasn't been enforced or applied yet), Finished (the policy was applied), Failed (the
        /// policy wasn't applied), or InProgress (the policy is being applied now). 
        /// </para>
        /// </summary>
        public string PolicyStatus { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStatus property is set.
        /// </summary>
        internal bool IsSetPolicyStatus() => this.PolicyStatus != null;

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The JSON text of the policy.
        /// </para>
        /// </summary>
        public string PolicyText { get; set; }

        /// <summary>
        /// Checks to see if the PolicyText property is set.
        /// </summary>
        internal bool IsSetPolicyText() => this.PolicyText != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy. Parameter Store, a tool in Amazon Web Services Systems Manager,
        /// supports the following policy types: Expiration, ExpirationNotification, and NoChangeNotification.
        /// 
        /// </para>
        /// </summary>
        public string PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;
    }
}
