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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetCapacityManagerMetricDimensions operation.
    /// Retrieves the available dimension values for capacity metrics within a specified
    /// time range. This is useful for discovering what accounts, regions, instance families,
    /// and other dimensions have data available for filtering and grouping.
    /// </summary>
    public partial class GetCapacityManagerMetricDimensionsRequest : AmazonEC2Request
    {
        private DateTime? _endTime;
        private List<CapacityManagerCondition> _filterBy = AWSConfigs.InitializeCollections ? new List<CapacityManagerCondition>() : null;
        private List<string> _groupBy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private List<string> _metricNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time for the dimension query, in ISO 8601 format. Only dimensions with data
        /// in this time range will be returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilterBy. 
        /// <para>
        ///  Conditions to filter which dimension values are returned. Each filter specifies a
        /// dimension, comparison operator, and values to match against. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<CapacityManagerCondition> FilterBy
        {
            get { return this._filterBy; }
            set { this._filterBy = value; }
        }

        // Check to see if FilterBy property is set
        internal bool IsSetFilterBy()
        {
            return this._filterBy != null && (this._filterBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        ///  The dimensions to group by when retrieving available dimension values. This determines
        /// which dimension combinations are returned. Required parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<string> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of dimension combinations to return. Valid range is 1 to 1000.
        /// Use with NextToken for pagination. 
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
        /// Gets and sets the property MetricNames. 
        /// <para>
        ///  The metric names to use as an additional filter when retrieving dimensions. Only
        /// dimensions that have data for these metrics will be returned. Required parameter with
        /// maximum size of 1 for v1. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=40)]
        public List<string> MetricNames
        {
            get { return this._metricNames; }
            set { this._metricNames = value; }
        }

        // Check to see if MetricNames property is set
        internal bool IsSetMetricNames()
        {
            return this._metricNames != null && (this._metricNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next page of results. Use this value in a subsequent call to retrieve
        /// additional dimension values. 
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
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time for the dimension query, in ISO 8601 format. Only dimensions with
        /// data in this time range will be returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}