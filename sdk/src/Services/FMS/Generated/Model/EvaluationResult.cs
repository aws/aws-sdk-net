/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Describes the compliance status for the account. An account is considered non-compliant
    /// if it includes resources that are not protected by the specified policy.
    /// </summary>
    public partial class EvaluationResult
    {
        private PolicyComplianceStatusType _complianceStatus;
        private bool? _evaluationLimitExceeded;
        private long? _violatorCount;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Describes an AWS account's compliance with the AWS Firewall Manager policy.
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
        /// Indicates that over 100 resources are non-compliant with the AWS Firewall Manager
        /// policy.
        /// </para>
        /// </summary>
        public bool EvaluationLimitExceeded
        {
            get { return this._evaluationLimitExceeded.GetValueOrDefault(); }
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
        /// Number of resources that are non-compliant with the specified policy. A resource is
        /// considered non-compliant if it is not associated with the specified policy.
        /// </para>
        /// </summary>
        public long ViolatorCount
        {
            get { return this._violatorCount.GetValueOrDefault(); }
            set { this._violatorCount = value; }
        }

        // Check to see if ViolatorCount property is set
        internal bool IsSetViolatorCount()
        {
            return this._violatorCount.HasValue; 
        }

    }
}