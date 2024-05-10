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
    /// Provides the number of compliant and noncompliant rules within a conformance pack.
    /// Also provides the compliance status of the conformance pack and the total rule count
    /// which includes compliant rules, noncompliant rules, and rules that cannot be evaluated
    /// due to insufficient data.
    /// 
    ///  
    /// <para>
    /// A conformance pack is compliant if all of the rules in a conformance packs are compliant.
    /// It is noncompliant if any of the rules are not compliant. The compliance status of
    /// a conformance pack is INSUFFICIENT_DATA only if all rules within a conformance pack
    /// cannot be evaluated due to insufficient data. If some of the rules in a conformance
    /// pack are compliant but the compliance status of other rules in that same conformance
    /// pack is INSUFFICIENT_DATA, the conformance pack shows compliant.
    /// </para>
    /// </summary>
    public partial class AggregateConformancePackCompliance
    {
        private ConformancePackComplianceType _complianceType;
        private int? _compliantRuleCount;
        private int? _nonCompliantRuleCount;
        private int? _totalRuleCount;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance status of the conformance pack.
        /// </para>
        /// </summary>
        public ConformancePackComplianceType ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property CompliantRuleCount. 
        /// <para>
        /// The number of compliant Config Rules.
        /// </para>
        /// </summary>
        public int? CompliantRuleCount
        {
            get { return this._compliantRuleCount; }
            set { this._compliantRuleCount = value; }
        }

        // Check to see if CompliantRuleCount property is set
        internal bool IsSetCompliantRuleCount()
        {
            return this._compliantRuleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantRuleCount. 
        /// <para>
        /// The number of noncompliant Config Rules.
        /// </para>
        /// </summary>
        public int? NonCompliantRuleCount
        {
            get { return this._nonCompliantRuleCount; }
            set { this._nonCompliantRuleCount = value; }
        }

        // Check to see if NonCompliantRuleCount property is set
        internal bool IsSetNonCompliantRuleCount()
        {
            return this._nonCompliantRuleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRuleCount. 
        /// <para>
        /// Total number of compliant rules, noncompliant rules, and the rules that do not have
        /// any applicable resources to evaluate upon resulting in insufficient data.
        /// </para>
        /// </summary>
        public int? TotalRuleCount
        {
            get { return this._totalRuleCount; }
            set { this._totalRuleCount = value; }
        }

        // Check to see if TotalRuleCount property is set
        internal bool IsSetTotalRuleCount()
        {
            return this._totalRuleCount.HasValue; 
        }

    }
}