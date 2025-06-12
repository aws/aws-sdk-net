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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Details about Performance Insights metrics.
    /// 
    ///  
    /// <para>
    /// Amazon RDS Performance Insights enables you to monitor and explore different dimensions
    /// of database load based on data captured from a running DB instance. DB load is measured
    /// as average active sessions. Performance Insights provides the data to API consumers
    /// as a two-dimensional time-series dataset. The time dimension provides DB load data
    /// for each time point in the queried time range. Each time point decomposes overall
    /// load in relation to the requested dimensions, measured at that time point. Examples
    /// include SQL, Wait event, User, and Host. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To learn more about Performance Insights and Amazon Aurora DB instances, go to the
    /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_PerfInsights.html">
    /// Amazon Aurora User Guide</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To learn more about Performance Insights and Amazon RDS DB instances, go to the <a
    /// href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">
    /// Amazon RDS User Guide</a>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PerformanceInsightsMetricsDetail
    {
        private string _metricDisplayName;
        private PerformanceInsightsMetricQuery _metricQuery;
        private List<PerformanceInsightsReferenceData> _referenceData = AWSConfigs.InitializeCollections ? new List<PerformanceInsightsReferenceData>() : null;
        private List<PerformanceInsightsStat> _statsAtAnomaly = AWSConfigs.InitializeCollections ? new List<PerformanceInsightsStat>() : null;
        private List<PerformanceInsightsStat> _statsAtBaseline = AWSConfigs.InitializeCollections ? new List<PerformanceInsightsStat>() : null;
        private string _unit;

        /// <summary>
        /// Gets and sets the property MetricDisplayName. 
        /// <para>
        /// The name used for a specific Performance Insights metric.
        /// </para>
        /// </summary>
        public string MetricDisplayName
        {
            get { return this._metricDisplayName; }
            set { this._metricDisplayName = value; }
        }

        // Check to see if MetricDisplayName property is set
        internal bool IsSetMetricDisplayName()
        {
            return this._metricDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricQuery. 
        /// <para>
        /// A single query to be processed for the metric. For more information, see <c> <a href="https://docs.aws.amazon.com/devops-guru/latest/APIReference/API_PerformanceInsightsMetricQuery.html">PerformanceInsightsMetricQuery</a>
        /// </c>.
        /// </para>
        /// </summary>
        public PerformanceInsightsMetricQuery MetricQuery
        {
            get { return this._metricQuery; }
            set { this._metricQuery = value; }
        }

        // Check to see if MetricQuery property is set
        internal bool IsSetMetricQuery()
        {
            return this._metricQuery != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceData. 
        /// <para>
        ///  For more information, see <c> <a href="https://docs.aws.amazon.com/devops-guru/latest/APIReference/API_PerformanceInsightsReferenceData.html">PerformanceInsightsReferenceData</a>
        /// </c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PerformanceInsightsReferenceData> ReferenceData
        {
            get { return this._referenceData; }
            set { this._referenceData = value; }
        }

        // Check to see if ReferenceData property is set
        internal bool IsSetReferenceData()
        {
            return this._referenceData != null && (this._referenceData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatsAtAnomaly. 
        /// <para>
        /// The metric statistics during the anomalous period detected by DevOps Guru;
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PerformanceInsightsStat> StatsAtAnomaly
        {
            get { return this._statsAtAnomaly; }
            set { this._statsAtAnomaly = value; }
        }

        // Check to see if StatsAtAnomaly property is set
        internal bool IsSetStatsAtAnomaly()
        {
            return this._statsAtAnomaly != null && (this._statsAtAnomaly.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatsAtBaseline. 
        /// <para>
        /// Typical metric statistics that are not considered anomalous. When DevOps Guru analyzes
        /// metrics, it compares them to <c>StatsAtBaseline</c> to help determine if they are
        /// anomalous.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PerformanceInsightsStat> StatsAtBaseline
        {
            get { return this._statsAtBaseline; }
            set { this._statsAtBaseline = value; }
        }

        // Check to see if StatsAtBaseline property is set
        internal bool IsSetStatsAtBaseline()
        {
            return this._statsAtBaseline != null && (this._statsAtBaseline.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measure for a metric. For example, a session or a process.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}