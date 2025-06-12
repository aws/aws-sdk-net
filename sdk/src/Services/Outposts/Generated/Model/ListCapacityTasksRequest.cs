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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListCapacityTasks operation.
    /// Lists the capacity tasks for your Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// Use filters to return specific results. If you specify multiple filters, the results
    /// include only the resources that match all of the specified filters. For a filter where
    /// you can specify multiple values, the results include items that match any of the values
    /// that you specify for the filter.
    /// </para>
    /// </summary>
    public partial class ListCapacityTasksRequest : AmazonOutpostsRequest
    {
        private List<string> _capacityTaskStatusFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _outpostIdentifierFilter;

        /// <summary>
        /// Gets and sets the property CapacityTaskStatusFilter. 
        /// <para>
        /// A list of statuses. For example, <c>REQUESTED</c> or <c>WAITING_FOR_EVACUATION</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityTaskStatusFilter
        {
            get { return this._capacityTaskStatusFilter; }
            set { this._capacityTaskStatusFilter = value; }
        }

        // Check to see if CapacityTaskStatusFilter property is set
        internal bool IsSetCapacityTaskStatusFilter()
        {
            return this._capacityTaskStatusFilter != null && (this._capacityTaskStatusFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property OutpostIdentifierFilter. 
        /// <para>
        /// Filters the results by an Outpost ID or an Outpost ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public string OutpostIdentifierFilter
        {
            get { return this._outpostIdentifierFilter; }
            set { this._outpostIdentifierFilter = value; }
        }

        // Check to see if OutpostIdentifierFilter property is set
        internal bool IsSetOutpostIdentifierFilter()
        {
            return this._outpostIdentifierFilter != null;
        }

    }
}