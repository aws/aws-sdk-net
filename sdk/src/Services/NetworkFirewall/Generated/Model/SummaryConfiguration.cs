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
    /// A complex type that specifies which Suricata rule metadata fields to use when displaying
    /// threat information. Contains:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>RuleOptions</c> - The Suricata rule options fields to extract and display
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// These settings affect how threat information appears in both the console and API responses.
    /// Summaries are available for rule groups you manage and for active threat defense Amazon
    /// Web Services managed rule groups.
    /// </para>
    /// </summary>
    public partial class SummaryConfiguration
    {
        private List<string> _ruleOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property RuleOptions. 
        /// <para>
        /// Specifies the selected rule options returned by <a>DescribeRuleGroupSummary</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RuleOptions
        {
            get { return this._ruleOptions; }
            set { this._ruleOptions = value; }
        }

        // Check to see if RuleOptions property is set
        internal bool IsSetRuleOptions()
        {
            return this._ruleOptions != null && (this._ruleOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}