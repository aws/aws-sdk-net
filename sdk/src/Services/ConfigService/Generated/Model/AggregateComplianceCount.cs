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
    /// Returns the number of compliant and noncompliant rules for one or more accounts and
    /// regions in an aggregator.
    /// </summary>
    public partial class AggregateComplianceCount
    {
        private ComplianceSummary _complianceSummary;
        private string _groupName;

        /// <summary>
        /// Gets and sets the property ComplianceSummary. 
        /// <para>
        /// The number of compliant and noncompliant Config rules.
        /// </para>
        /// </summary>
        public ComplianceSummary ComplianceSummary
        {
            get { return this._complianceSummary; }
            set { this._complianceSummary = value; }
        }

        // Check to see if ComplianceSummary property is set
        internal bool IsSetComplianceSummary()
        {
            return this._complianceSummary != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The 12-digit account ID or region based on the GroupByKey value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

    }
}