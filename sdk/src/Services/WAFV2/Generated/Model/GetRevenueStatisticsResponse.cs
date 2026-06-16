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
    /// This is the response object from the GetRevenueStatistics operation.
    /// </summary>
    public partial class GetRevenueStatisticsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<RevenuePathStatistics> _revenuePathStatistics = AWSConfigs.InitializeCollections ? new List<RevenuePathStatistics>() : null;
        private List<SourceStatistics> _sourceStatistics = AWSConfigs.InitializeCollections ? new List<SourceStatistics>() : null;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you get a paginated response, this marker indicates that additional results are
        /// available.
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
        /// Gets and sets the property RevenuePathStatistics. 
        /// <para>
        /// Statistics for top revenue paths. Populated when <c>StatisticType</c> is <c>TOP_PATHS_BY_REVENUE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RevenuePathStatistics> RevenuePathStatistics
        {
            get { return this._revenuePathStatistics; }
            set { this._revenuePathStatistics = value; }
        }

        // Check to see if RevenuePathStatistics property is set
        internal bool IsSetRevenuePathStatistics()
        {
            return this._revenuePathStatistics != null && (this._revenuePathStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceStatistics. 
        /// <para>
        /// Statistics for top revenue sources (AI bots). Populated when <c>StatisticType</c>
        /// is <c>TOP_SOURCES_BY_REVENUE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceStatistics> SourceStatistics
        {
            get { return this._sourceStatistics; }
            set { this._sourceStatistics = value; }
        }

        // Check to see if SourceStatistics property is set
        internal bool IsSetSourceStatistics()
        {
            return this._sourceStatistics != null && (this._sourceStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}