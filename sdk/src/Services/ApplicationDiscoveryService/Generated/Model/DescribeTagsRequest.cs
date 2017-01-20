/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTags operation.
    /// Retrieves a list of configuration items that are tagged with a specific tag. Or retrieves
    /// a list of all tags assigned to a specific configuration item.
    /// </summary>
    public partial class DescribeTagsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<TagFilter> _filters = new List<TagFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// You can filter the list using a <i>key</i>-<i>value</i> format. You can separate these
        /// items by using logical operators. Allowed filters include <code>tagKey</code>, <code>tagValue</code>,
        /// and <code>configurationId</code>. 
        /// </para>
        ///  
        /// <para>
        /// For a complete list of filter options and guidance about using them with this action,
        /// see <a href="http://docs.aws.amazon.com/application-discovery/latest/APIReference/managing-agents.html">Managing
        /// AWS Application Discovery Service Agents and the AWS Application Discovery Connector
        /// </a>.
        /// </para>
        /// </summary>
        public List<TagFilter> Filters
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
        /// The total number of items to return in a single page of output. The maximum value
        /// is 100.
        /// </para>
        /// </summary>
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
        /// A token to start the list. Use this token to get the next set of results.
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

    }
}