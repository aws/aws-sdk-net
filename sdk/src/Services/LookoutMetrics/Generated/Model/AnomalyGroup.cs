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
    /// A group of anomalous metrics
    /// </summary>
    public partial class AnomalyGroup
    {
        private string _anomalyGroupId;
        private double? _anomalyGroupScore;
        private string _endTime;
        private List<MetricLevelImpact> _metricLevelImpactList = AWSConfigs.InitializeCollections ? new List<MetricLevelImpact>() : null;
        private string _primaryMetricName;
        private string _startTime;

        /// <summary>
        /// Gets and sets the property AnomalyGroupId. 
        /// <para>
        /// The ID of the anomaly group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string AnomalyGroupId
        {
            get { return this._anomalyGroupId; }
            set { this._anomalyGroupId = value; }
        }

        // Check to see if AnomalyGroupId property is set
        internal bool IsSetAnomalyGroupId()
        {
            return this._anomalyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyGroupScore. 
        /// <para>
        /// The severity score of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? AnomalyGroupScore
        {
            get { return this._anomalyGroupScore; }
            set { this._anomalyGroupScore = value; }
        }

        // Check to see if AnomalyGroupScore property is set
        internal bool IsSetAnomalyGroupScore()
        {
            return this._anomalyGroupScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=60)]
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property MetricLevelImpactList. 
        /// <para>
        /// A list of measures affected by the anomaly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricLevelImpact> MetricLevelImpactList
        {
            get { return this._metricLevelImpactList; }
            set { this._metricLevelImpactList = value; }
        }

        // Check to see if MetricLevelImpactList property is set
        internal bool IsSetMetricLevelImpactList()
        {
            return this._metricLevelImpactList != null && (this._metricLevelImpactList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrimaryMetricName. 
        /// <para>
        /// The name of the primary affected measure for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string PrimaryMetricName
        {
            get { return this._primaryMetricName; }
            set { this._primaryMetricName = value; }
        }

        // Check to see if PrimaryMetricName property is set
        internal bool IsSetPrimaryMetricName()
        {
            return this._primaryMetricName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=60)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}