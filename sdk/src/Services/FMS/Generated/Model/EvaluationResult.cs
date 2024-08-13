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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
        private PolicyComplianceStatusType _complianceStatus;
        private bool? _evaluationLimitExceeded;
        private long? _violatorCount;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Describes an Amazon Web Services account's compliance with the Firewall Manager policy.
        /// </para>
        /// </summary>
        public PolicyComplianceStatusType ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationLimitExceeded. 
        /// <para>
        /// Indicates that over 100 resources are noncompliant with the Firewall Manager policy.
        /// </para>
        /// </summary>
        public bool? EvaluationLimitExceeded
        {
            get { return this._evaluationLimitExceeded; }
            set { this._evaluationLimitExceeded = value; }
        }

        // Check to see if EvaluationLimitExceeded property is set
        internal bool IsSetEvaluationLimitExceeded()
        {
            return this._evaluationLimitExceeded.HasValue; 
        }

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
        [AWSProperty(Min=0)]
        public long? ViolatorCount
        {
            get { return this._violatorCount; }
            set { this._violatorCount = value; }
        }

        // Check to see if ViolatorCount property is set
        internal bool IsSetViolatorCount()
        {
            return this._violatorCount.HasValue; 
        }

    }
}