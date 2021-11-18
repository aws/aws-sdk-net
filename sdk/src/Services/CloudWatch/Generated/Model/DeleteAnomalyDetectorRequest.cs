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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAnomalyDetector operation.
    /// Deletes the specified anomaly detection model from your account.
    /// </summary>
    public partial class DeleteAnomalyDetectorRequest : AmazonCloudWatchRequest
    {
        private List<Dimension> _dimensions = new List<Dimension>();
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
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Max=10)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricMathAnomalyDetector. 
        /// <para>
        /// The metric math anomaly detector to be deleted.
        /// </para>
        ///  
        /// <para>
        /// When using <code>MetricMathAnomalyDetector</code>, you cannot include following parameters
        /// in the same operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Dimensions</code>,
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MetricName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Namespace</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Stat</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// the <code>SingleMetricAnomalyDetector</code> parameters of <code>DeleteAnomalyDetectorInput</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instead, specify the metric math anomaly detector attributes as part of the <code>MetricMathAnomalyDetector</code>
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
        /// When using <code>SingleMetricAnomalyDetector</code>, you cannot include the following
        /// parameters in the same operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Dimensions</code>,
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MetricName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Namespace</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Stat</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// the <code>MetricMathAnomalyDetector</code> parameters of <code>DeleteAnomalyDetectorInput</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instead, specify the single metric anomaly detector attributes as part of the <code>SingleMetricAnomalyDetector</code>
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