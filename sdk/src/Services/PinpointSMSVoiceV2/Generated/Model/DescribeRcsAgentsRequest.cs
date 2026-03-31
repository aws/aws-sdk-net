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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRcsAgents operation.
    /// Retrieves the specified RCS agents or all RCS agents associated with your Amazon Web
    /// Services account.
    /// 
    ///  
    /// <para>
    /// If you specify RCS agent IDs, the output includes information for only the specified
    /// RCS agents. If you specify filters, the output includes information for only those
    /// RCS agents that meet the filter criteria. If you don't specify RCS agent IDs or filters,
    /// the output includes information for all RCS agents.
    /// </para>
    /// </summary>
    public partial class DescribeRcsAgentsRequest : AmazonPinpointSMSVoiceV2Request
    {
        private List<RcsAgentFilter> _filters = AWSConfigs.InitializeCollections ? new List<RcsAgentFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private Owner _owner;
        private List<string> _rcsAgentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of RcsAgentFilter objects to filter the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<RcsAgentFilter> Filters
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
        /// The maximum number of results to return per each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token to be used for the next set of paginated results. You don't need to supply
        /// a value for this field in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// Use <c>SELF</c> to filter the list of RCS agents to ones your account owns or use
        /// <c>SHARED</c> to filter on RCS agents shared with your account. The <c>Owner</c> and
        /// <c>RcsAgentIds</c> parameters can't be used at the same time.
        /// </para>
        /// </summary>
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RcsAgentIds. 
        /// <para>
        /// An array of unique identifiers for the RCS agents. This is an array of strings that
        /// can be either the RcsAgentId or RcsAgentArn.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> RcsAgentIds
        {
            get { return this._rcsAgentIds; }
            set { this._rcsAgentIds = value; }
        }

        // Check to see if RcsAgentIds property is set
        internal bool IsSetRcsAgentIds()
        {
            return this._rcsAgentIds != null && (this._rcsAgentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}