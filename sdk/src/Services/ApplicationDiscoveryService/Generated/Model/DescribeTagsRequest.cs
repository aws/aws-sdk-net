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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTags operation.
    /// Retrieves a list of configuration items that have tags as specified by the key-value
    /// pairs, name and value, passed to the optional parameter <c>filters</c>.
    /// 
    ///  
    /// <para>
    /// There are three valid tag filter names:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// tagKey
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// tagValue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// configurationId
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Also, all configuration items associated with your user that have tags can be listed
    /// if you call <c>DescribeTags</c> as is without passing any parameters.
    /// </para>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<TagFilter> _filters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// You can filter the list using a <i>key</i>-<i>value</i> format. You can separate these
        /// items by using logical operators. Allowed filters include <c>tagKey</c>, <c>tagValue</c>,
        /// and <c>configurationId</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagFilter> Filters
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
        /// The total number of items to return in a single page of output. The maximum value
        /// is 100.
        /// </para>
        /// </summary>
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