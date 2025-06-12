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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAnomalyDetector operation.
    /// Deletes the specified anomaly detection model from your account. For more information
    /// about how to delete an anomaly detection model, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Create_Anomaly_Detection_Alarm.html#Delete_Anomaly_Detection_Model">Deleting
    /// an anomaly detection model</a> in the <i>CloudWatch User Guide</i>.
    /// </summary>
    public partial class DeleteAnomalyDetectorRequest : AmazonCloudWatchRequest
    {
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private MetricMathAnomalyDetector _metricMathAnomalyDetector;
        private string _metricName;
        private string _awsNamespace;
        private SingleMetricAnomalyDetector _singleMetricAnomalyDetector;
        private string _stat;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The metric dimensions associated with the anomaly detection model to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Max=30)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricMathAnomalyDetector. 
        /// <para>
        /// The metric math anomaly detector to be deleted.
        /// </para>
        ///  
        /// <para>
        /// When using <c>MetricMathAnomalyDetector</c>, you cannot include following parameters
        /// in the same operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Dimensions</c>,
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MetricName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Namespace</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stat</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// the <c>SingleMetricAnomalyDetector</c> parameters of <c>DeleteAnomalyDetectorInput</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instead, specify the metric math anomaly detector attributes as part of the <c>MetricMathAnomalyDetector</c>
        /// property.
        /// </para>
        /// </summary>
        public MetricMathAnomalyDetector MetricMathAnomalyDetector
        {
            get { return this._metricMathAnomalyDetector; }
            set { this._metricMathAnomalyDetector = value; }
        }

        // Check to see if MetricMathAnomalyDetector property is set
        internal bool IsSetMetricMathAnomalyDetector()
        {
            return this._metricMathAnomalyDetector != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric name associated with the anomaly detection model to delete.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace associated with the anomaly detection model to delete.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SingleMetricAnomalyDetector. 
        /// <para>
        /// A single metric anomaly detector to be deleted.
        /// </para>
        ///  
        /// <para>
        /// When using <c>SingleMetricAnomalyDetector</c>, you cannot include the following parameters
        /// in the same operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Dimensions</c>,
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MetricName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Namespace</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stat</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// the <c>MetricMathAnomalyDetector</c> parameters of <c>DeleteAnomalyDetectorInput</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instead, specify the single metric anomaly detector attributes as part of the <c>SingleMetricAnomalyDetector</c>
        /// property.
        /// </para>
        /// </summary>
        public SingleMetricAnomalyDetector SingleMetricAnomalyDetector
        {
            get { return this._singleMetricAnomalyDetector; }
            set { this._singleMetricAnomalyDetector = value; }
        }

        // Check to see if SingleMetricAnomalyDetector property is set
        internal bool IsSetSingleMetricAnomalyDetector()
        {
            return this._singleMetricAnomalyDetector != null;
        }

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic associated with the anomaly detection model to delete.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Max=50)]
        public string Stat
        {
            get { return this._stat; }
            set { this._stat = value; }
        }

        // Check to see if Stat property is set
        internal bool IsSetStat()
        {
            return this._stat != null;
        }

    }
}