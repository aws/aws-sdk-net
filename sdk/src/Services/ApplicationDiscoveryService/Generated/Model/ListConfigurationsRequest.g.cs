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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListConfigurations operation. Retrieves a list
    /// of configuration items as specified by the value passed to the required parameter
    /// <c>configurationType</c>. Optional filtering may be applied to refine search results.
    /// </summary>
    public partial class ListConfigurationsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// A valid configuration identified by Application Discovery Service. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationItemType ConfigurationType { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationType property is set.
        /// </summary>
        internal bool IsSetConfigurationType() => this.ConfigurationType != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of items to return. The maximum value is 100.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to retrieve the next set of results. For example, if a previous call to ListConfigurations
        /// returned 100 items, but you set <c>ListConfigurationsRequest$maxResults</c> to 10,
        /// you received a set of 10 results along with a token. Use that token in this query
        /// to get the next set of 10.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Certain filter criteria return output that can be sorted in ascending or descending
        /// order. For a list of output characteristics for each filter, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-api-queries.html#ListConfigurations">Using
        /// the ListConfigurations Action</a> in the <i>Amazon Web Services Application Discovery
        /// Service User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OrderByElement> OrderBy { get; set; } = AWSConfigs.InitializeCollections ? new List<OrderByElement>() : null;

        /// <summary>
        /// Checks to see if the OrderBy property is set.
        /// </summary>
        internal bool IsSetOrderBy() => this.OrderBy != null && (this.OrderBy.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
