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
    /// Container for the parameters to the ListConfigurations operation.
    /// Retrieves a list of configuration items as specified by the value passed to the required
    /// parameter <c>configurationType</c>. Optional filtering may be applied to refine search
    /// results.
    /// </summary>
    public partial class ListConfigurationsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private ConfigurationItemType _configurationType;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<OrderByElement> _orderBy = AWSConfigs.InitializeCollections ? new List<OrderByElement>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// A valid configuration identified by Application Discovery Service. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationItemType ConfigurationType
        {
            get { return this._configurationType; }
            set { this._configurationType = value; }
        }

        // Check to see if ConfigurationType property is set
        internal bool IsSetConfigurationType()
        {
            return this._configurationType != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// You can filter the request using various logical operators and a <i>key</i>-<i>value</i>
        /// format. For example: 
        /// </para>
        ///  
        /// <para>
        ///  <c>{"key": "serverType", "value": "webServer"}</c> 
        /// </para>
        ///  
        /// <para>
        /// For a complete list of filter options and guidance about using them with this action,
        /// see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-api-queries.html#ListConfigurations">Using
        /// the ListConfigurations Action</a> in the <i>Amazon Web Services Application Discovery
        /// Service User Guide</i>.
        /// </para>
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
        /// The total number of items to return. The maximum value is 100.
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
        /// Token to retrieve the next set of results. For example, if a previous call to ListConfigurations
        /// returned 100 items, but you set <c>ListConfigurationsRequest$maxResults</c> to 10,
        /// you received a set of 10 results along with a token. Use that token in this query
        /// to get the next set of 10.
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
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Certain filter criteria return output that can be sorted in ascending or descending
        /// order. For a list of output characteristics for each filter, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-api-queries.html#ListConfigurations">Using
        /// the ListConfigurations Action</a> in the <i>Amazon Web Services Application Discovery
        /// Service User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OrderByElement> OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null && (this._orderBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}