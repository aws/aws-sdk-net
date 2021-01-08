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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the ListRuleGroups operation.
    /// </summary>
    public partial class ListRuleGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RuleGroupMetadata> _ruleGroups = new List<RuleGroupMetadata>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you request a list of objects with a <code>MaxResults</code> setting, if the
        /// number of objects that are still available for retrieval exceeds the maximum you requested,
        /// Network Firewall returns a <code>NextToken</code> value in the response. To retrieve
        /// the next batch of objects, use the token returned from the prior request in your next
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroups. 
        /// <para>
        /// The rule group metadata objects that you've defined. Depending on your setting for
        /// max results and the number of rule groups, this might not be the full list. 
        /// </para>
        /// </summary>
        public List<RuleGroupMetadata> RuleGroups
        {
            get { return this._ruleGroups; }
            set { this._ruleGroups = value; }
        }

        // Check to see if RuleGroups property is set
        internal bool IsSetRuleGroups()
        {
            return this._ruleGroups != null && this._ruleGroups.Count > 0; 
        }

    }
}