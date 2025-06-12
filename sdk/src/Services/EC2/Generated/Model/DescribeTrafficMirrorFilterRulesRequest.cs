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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrafficMirrorFilterRules operation.
    /// Describe traffic mirror filters that determine the traffic that is mirrored.
    /// </summary>
    public partial class DescribeTrafficMirrorFilterRulesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _trafficMirrorFilterId;
        private List<string> _trafficMirrorFilterRuleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Traffic mirror filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>traffic-mirror-filter-rule-id</c>: The ID of the Traffic Mirror rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>traffic-mirror-filter-id</c>: The ID of the filter that this rule is associated
        /// with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule-number</c>: The number of the Traffic Mirror rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule-action</c>: The action taken on the filtered traffic. Possible actions are
        /// <c>accept</c> and <c>reject</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>traffic-direction</c>: The traffic direction. Possible directions are <c>ingress</c>
        /// and <c>egress</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>protocol</c>: The protocol, for example UDP, assigned to the Traffic Mirror rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-cidr-block</c>: The source CIDR block assigned to the Traffic Mirror rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>destination-cidr-block</c>: The destination CIDR block assigned to the Traffic
        /// Mirror rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>description</c>: The description of the Traffic Mirror rule.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <c>nextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// Traffic filter ID.
        /// </para>
        /// </summary>
        public string TrafficMirrorFilterId
        {
            get { return this._trafficMirrorFilterId; }
            set { this._trafficMirrorFilterId = value; }
        }

        // Check to see if TrafficMirrorFilterId property is set
        internal bool IsSetTrafficMirrorFilterId()
        {
            return this._trafficMirrorFilterId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterRuleIds. 
        /// <para>
        /// Traffic filter rule IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TrafficMirrorFilterRuleIds
        {
            get { return this._trafficMirrorFilterRuleIds; }
            set { this._trafficMirrorFilterRuleIds = value; }
        }

        // Check to see if TrafficMirrorFilterRuleIds property is set
        internal bool IsSetTrafficMirrorFilterRuleIds()
        {
            return this._trafficMirrorFilterRuleIds != null && (this._trafficMirrorFilterRuleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}