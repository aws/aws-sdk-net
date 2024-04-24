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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Indicates whether an Amazon Web Services resource or Config rule is compliant and
    /// provides the number of contributors that affect the compliance.
    /// </summary>
    public partial class Compliance
    {
        private ComplianceContributorCount _complianceContributorCount;
        private ComplianceType _complianceType;

        /// <summary>
        /// Gets and sets the property ComplianceContributorCount. 
        /// <para>
        /// The number of Amazon Web Services resources or Config rules that cause a result of
        /// <c>NON_COMPLIANT</c>, up to a maximum number.
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
        /// Indicates whether an Amazon Web Services resource or Config rule is compliant.
        /// </para>
        ///  
        /// <para>
        /// A resource is compliant if it complies with all of the Config rules that evaluate
        /// it. A resource is noncompliant if it does not comply with one or more of these rules.
        /// </para>
        ///  
        /// <para>
        /// A rule is compliant if all of the resources that the rule evaluates comply with it.
        /// A rule is noncompliant if any of these resources do not comply.
        /// </para>
        ///  
        /// <para>
        /// Config returns the <c>INSUFFICIENT_DATA</c> value when no evaluation results are available
        /// for the Amazon Web Services resource or Config rule.
        /// </para>
        ///  
        /// <para>
        /// For the <c>Compliance</c> data type, Config supports only <c>COMPLIANT</c>, <c>NON_COMPLIANT</c>,
        /// and <c>INSUFFICIENT_DATA</c> values. Config does not support the <c>NOT_APPLICABLE</c>
        /// value for the <c>Compliance</c> data type.
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