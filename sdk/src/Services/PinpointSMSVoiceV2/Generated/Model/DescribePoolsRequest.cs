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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePools operation.
    /// Retrieves the specified pools or all pools associated with your Amazon Web Services
    /// account.
    /// 
    ///  
    /// <para>
    /// If you specify pool IDs, the output includes information for only the specified pools.
    /// If you specify filters, the output includes information for only those pools that
    /// meet the filter criteria. If you don't specify pool IDs or filters, the output includes
    /// information for all pools.
    /// </para>
    ///  
    /// <para>
    /// If you specify a pool ID that isn't valid, an Error is returned.
    /// </para>
    ///  
    /// <para>
    /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
    /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class DescribePoolsRequest : AmazonPinpointSMSVoiceV2Request
    {
        private List<PoolFilter> _filters = new List<PoolFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _poolIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of PoolFilter objects to filter the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<PoolFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// Gets and sets the property PoolIds. 
        /// <para>
        /// The unique identifier of pools to find. This is an array of strings that can be either
        /// the PoolId or PoolArn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> PoolIds
        {
            get { return this._poolIds; }
            set { this._poolIds = value; }
        }

        // Check to see if PoolIds property is set
        internal bool IsSetPoolIds()
        {
            return this._poolIds != null && this._poolIds.Count > 0; 
        }

    }
}