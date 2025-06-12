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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Aggregated statistics for a group of anomalous metrics.
    /// </summary>
    public partial class AnomalyGroupStatistics
    {
        private string _evaluationStartDate;
        private List<ItemizedMetricStats> _itemizedMetricStatsList = AWSConfigs.InitializeCollections ? new List<ItemizedMetricStats>() : null;
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property EvaluationStartDate. 
        /// <para>
        /// The start of the time range that was searched.
        /// </para>
        /// </summary>
        [AWSProperty(Max=60)]
        public string EvaluationStartDate
        {
            get { return this._evaluationStartDate; }
            set { this._evaluationStartDate = value; }
        }

        // Check to see if EvaluationStartDate property is set
        internal bool IsSetEvaluationStartDate()
        {
            return this._evaluationStartDate != null;
        }

        /// <summary>
        /// Gets and sets the property ItemizedMetricStatsList. 
        /// <para>
        /// Statistics for individual metrics within the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ItemizedMetricStats> ItemizedMetricStatsList
        {
            get { return this._itemizedMetricStatsList; }
            set { this._itemizedMetricStatsList = value; }
        }

        // Check to see if ItemizedMetricStatsList property is set
        internal bool IsSetItemizedMetricStatsList()
        {
            return this._itemizedMetricStatsList != null && (this._itemizedMetricStatsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The number of groups found.
        /// </para>
        /// </summary>
        public int? TotalCount
        {
            get { return this._totalCount; }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}