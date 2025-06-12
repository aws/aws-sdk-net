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
    /// The analysis result for Network Firewall's stateless rule group analyzer. Every time
    /// you call <a>CreateRuleGroup</a>, <a>UpdateRuleGroup</a>, or <a>DescribeRuleGroup</a>
    /// on a stateless rule group, Network Firewall analyzes the stateless rule groups in
    /// your account and identifies the rules that might adversely effect your firewall's
    /// functionality. For example, if Network Firewall detects a rule that's routing traffic
    /// asymmetrically, which impacts the service's ability to properly process traffic, the
    /// service includes the rule in a list of analysis results.
    /// 
    ///  
    /// <para>
    /// The <c>AnalysisResult</c> data type is not related to traffic analysis reports you
    /// generate using <a>StartAnalysisReport</a>. For information on traffic analysis report
    /// results, see <a>AnalysisTypeReportResult</a>.
    /// </para>
    /// </summary>
    public partial class AnalysisResult
    {
        private string _analysisDetail;
        private List<string> _identifiedRuleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IdentifiedType _identifiedType;

        /// <summary>
        /// Gets and sets the property AnalysisDetail. 
        /// <para>
        /// Provides analysis details for the identified rule.
        /// </para>
        /// </summary>
        public string AnalysisDetail
        {
            get { return this._analysisDetail; }
            set { this._analysisDetail = value; }
        }

        // Check to see if AnalysisDetail property is set
        internal bool IsSetAnalysisDetail()
        {
            return this._analysisDetail != null;
        }

        /// <summary>
        /// Gets and sets the property IdentifiedRuleIds. 
        /// <para>
        /// The priority number of the stateless rules identified in the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IdentifiedRuleIds
        {
            get { return this._identifiedRuleIds; }
            set { this._identifiedRuleIds = value; }
        }

        // Check to see if IdentifiedRuleIds property is set
        internal bool IsSetIdentifiedRuleIds()
        {
            return this._identifiedRuleIds != null && (this._identifiedRuleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentifiedType. 
        /// <para>
        /// The types of rule configurations that Network Firewall analyzes your rule groups for.
        /// Network Firewall analyzes stateless rule groups for the following types of rule configurations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STATELESS_RULE_FORWARDING_ASYMMETRICALLY</c> 
        /// </para>
        ///  
        /// <para>
        /// Cause: One or more stateless rules with the action <c>pass</c> or <c>forward</c> are
        /// forwarding traffic asymmetrically. Specifically, the rule's set of source IP addresses
        /// or their associated port numbers, don't match the set of destination IP addresses
        /// or their associated port numbers.
        /// </para>
        ///  
        /// <para>
        /// To mitigate: Make sure that there's an existing return path. For example, if the rule
        /// allows traffic from source 10.1.0.0/24 to destination 20.1.0.0/24, you should allow
        /// return traffic from source 20.1.0.0/24 to destination 10.1.0.0/24.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STATELESS_RULE_CONTAINS_TCP_FLAGS</c> 
        /// </para>
        ///  
        /// <para>
        /// Cause: At least one stateless rule with the action <c>pass</c> or<c>forward</c> contains
        /// TCP flags that are inconsistent in the forward and return directions.
        /// </para>
        ///  
        /// <para>
        /// To mitigate: Prevent asymmetric routing issues caused by TCP flags by following these
        /// actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Remove unnecessary TCP flag inspections from the rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need to inspect TCP flags, check that the rules correctly account for changes
        /// in TCP flags throughout the TCP connection cycle, for example <c>SYN</c> and <c>ACK</c>
        /// flags used in a 3-way TCP handshake.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public IdentifiedType IdentifiedType
        {
            get { return this._identifiedType; }
            set { this._identifiedType = value; }
        }

        // Check to see if IdentifiedType property is set
        internal bool IsSetIdentifiedType()
        {
            return this._identifiedType != null;
        }

    }
}