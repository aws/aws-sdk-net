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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the GetTopPathStatisticsByTraffic operation.
    /// </summary>
    public partial class GetTopPathStatisticsByTrafficResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<PathStatistics> _pathStatistics = AWSConfigs.InitializeCollections ? new List<PathStatistics>() : null;
        private List<PathStatistics> _topCategories = AWSConfigs.InitializeCollections ? new List<PathStatistics>() : null;
        private long? _totalRequestCount;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <c>Limit</c> setting, if the number of objects
        /// that are still available for retrieval exceeds the limit, WAF returns a <c>NextMarker</c>
        /// value in the response. To retrieve the next batch of objects, provide the marker from
        /// the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property PathStatistics. 
        /// <para>
        /// The list of path statistics, ordered by request count. Each entry includes the path,
        /// request count, percentage of total traffic, and the top bots accessing that path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PathStatistics> PathStatistics
        {
            get { return this._pathStatistics; }
            set { this._pathStatistics = value; }
        }

        // Check to see if PathStatistics property is set
        internal bool IsSetPathStatistics()
        {
            return this._pathStatistics != null && (this._pathStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopCategories. 
        /// <para>
        /// Category-level aggregations for visualizing bot category to path relationships. This
        /// field is only populated when no bot filters are applied to the request. Each entry
        /// includes the bot category and the paths accessed by bots in that category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PathStatistics> TopCategories
        {
            get { return this._topCategories; }
            set { this._topCategories = value; }
        }

        // Check to see if TopCategories property is set
        internal bool IsSetTopCategories()
        {
            return this._topCategories != null && (this._topCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalRequestCount. 
        /// <para>
        /// The total number of requests that match the query criteria within the specified time
        /// window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? TotalRequestCount
        {
            get { return this._totalRequestCount; }
            set { this._totalRequestCount = value; }
        }

        // Check to see if TotalRequestCount property is set
        internal bool IsSetTotalRequestCount()
        {
            return this._totalRequestCount.HasValue; 
        }

    }
}