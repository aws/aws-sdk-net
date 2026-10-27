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
    /// Describes the compliance status for the account. An account is considered noncompliant
    /// if it includes resources that are not protected by the specified policy or that don't
    /// comply with the policy.
    /// </summary>
    public partial class EvaluationResult
    {
        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Describes an Amazon Web Services account's compliance with the Firewall Manager policy.
        /// </para>
        /// </summary>
        public PolicyComplianceStatusType ComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceStatus property is set.
        /// </summary>
        internal bool IsSetComplianceStatus() => this.ComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property EvaluationLimitExceeded. 
        /// <para>
        /// Indicates that over 100 resources are noncompliant with the Firewall Manager policy.
        /// </para>
        /// </summary>
        public bool? EvaluationLimitExceeded { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationLimitExceeded property is set.
        /// </summary>
        internal bool IsSetEvaluationLimitExceeded() => this.EvaluationLimitExceeded.HasValue;

        /// <summary>
        /// Gets and sets the property ViolatorCount. 
        /// <para>
        /// The number of resources that are noncompliant with the specified policy. For WAF and
        /// Shield Advanced policies, a resource is considered noncompliant if it is not associated
        /// with the policy. For security group policies, a resource is considered noncompliant
        /// if it doesn't comply with the rules of the policy and remediation is disabled or not
        /// possible.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ViolatorCount { get; set; }

        /// <summary>
        /// Checks to see if the ViolatorCount property is set.
        /// </summary>
        internal bool IsSetViolatorCount() => this.ViolatorCount.HasValue;
    }
}
