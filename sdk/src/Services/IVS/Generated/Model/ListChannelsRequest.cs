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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannels operation.
    /// Gets summary information about all channels in your account, in the AWS region where
    /// the API request is processed. This list can be filtered to match a specified string.
    /// </summary>
    public partial class ListChannelsRequest : AmazonIVSRequest
    {
        private string _filterByName;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FilterByName. 
        /// <para>
        /// Filters the channel list to match the specified name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string FilterByName
        {
            get { return this._filterByName; }
            set { this._filterByName = value; }
        }

        // Check to see if FilterByName property is set
        internal bool IsSetFilterByName()
        {
            return this._filterByName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of channels to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The first channel to retrieve. This is used for pagination; see the <code>nextToken</code>
        /// response field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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

    }
}