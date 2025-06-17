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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A complex type containing summaries of security protections provided by a rule group.
    /// 
    ///  
    /// <para>
    /// Network Firewall extracts this information from selected fields in the rule group's
    /// Suricata rules, based on your <a>SummaryConfiguration</a> settings.
    /// </para>
    /// </summary>
    public partial class Summary
    {
        private List<RuleSummary> _ruleSummaries = AWSConfigs.InitializeCollections ? new List<RuleSummary>() : null;

        /// <summary>
        /// Gets and sets the property RuleSummaries. 
        /// <para>
        /// An array of <a>RuleSummary</a> objects containing individual rule details that had
        /// been configured by the rulegroup's SummaryConfiguration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleSummary> RuleSummaries
        {
            get { return this._ruleSummaries; }
            set { this._ruleSummaries = value; }
        }

        // Check to see if RuleSummaries property is set
        internal bool IsSetRuleSummaries()
        {
            return this._ruleSummaries != null && (this._ruleSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}