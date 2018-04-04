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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Indicates whether an AWS resource or AWS Config rule is compliant and provides the
    /// number of contributors that affect the compliance.
    /// </summary>
    public partial class Compliance
    {
        private ComplianceContributorCount _complianceContributorCount;
        private ComplianceType _complianceType;

        /// <summary>
        /// Gets and sets the property ComplianceContributorCount. 
        /// <para>
        /// The number of AWS resources or AWS Config rules that cause a result of <code>NON_COMPLIANT</code>,
        /// up to a maximum number.
        /// </para>
        /// </summary>
        public ComplianceContributorCount ComplianceContributorCount
        {
            get { return this._complianceContributorCount; }
            set { this._complianceContributorCount = value; }
        }

        // Check to see if ComplianceContributorCount property is set
        internal bool IsSetComplianceContributorCount()
        {
            return this._complianceContributorCount != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Indicates whether an AWS resource or AWS Config rule is compliant.
        /// </para>
        ///  
        /// <para>
        /// A resource is compliant if it complies with all of the AWS Config rules that evaluate
        /// it. A resource is noncompliant if it does not comply with one or more of these rules.
        /// </para>
        ///  
        /// <para>
        /// A rule is compliant if all of the resources that the rule evaluates comply with it.
        /// A rule is noncompliant if any of these resources do not comply.
        /// </para>
        ///  
        /// <para>
        /// AWS Config returns the <code>INSUFFICIENT_DATA</code> value when no evaluation results
        /// are available for the AWS resource or AWS Config rule.
        /// </para>
        ///  
        /// <para>
        /// For the <code>Compliance</code> data type, AWS Config supports only <code>COMPLIANT</code>,
        /// <code>NON_COMPLIANT</code>, and <code>INSUFFICIENT_DATA</code> values. AWS Config
        /// does not support the <code>NOT_APPLICABLE</code> value for the <code>Compliance</code>
        /// data type.
        /// </para>
        /// </summary>
        public ComplianceType ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

    }
}