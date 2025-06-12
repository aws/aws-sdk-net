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
    /// An anomaly detection model associated with a particular CloudWatch metric, statistic,
    /// or metric math expression. You can use the model to display a band of expected, normal
    /// values when the metric is graphed.
    /// 
    ///  
    /// <para>
    /// If you have enabled unified cross-account observability, and this account is a monitoring
    /// account, the metric can be in the same account or a source account.
    /// </para>
    /// </summary>
    public partial class AnomalyDetector
    {
        private AnomalyDetectorConfiguration _configuration;
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private MetricCharacteristics _metricCharacteristics;
        private MetricMathAnomalyDetector _metricMathAnomalyDetector;
        private string _metricName;
        private string _awsNamespace;
        private SingleMetricAnomalyDetector _singleMetricAnomalyDetector;
        private string _stat;
        private AnomalyDetectorStateValue _stateValue;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration specifies details about how the anomaly detection model is to be
        /// trained, including time ranges to exclude from use for training the model, and the
        /// time zone to use for the metric.
        /// </para>
        /// </summary>
        public AnomalyDetectorConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The metric dimensions associated with the anomaly detection model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.Dimensions property.")]
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
        /// Gets and sets the property MetricCharacteristics. 
        /// <para>
        /// This object includes parameters that you can use to provide information about your
        /// metric to CloudWatch to help it build more accurate anomaly detection models. Currently,
        /// it includes the <c>PeriodicSpikes</c> parameter.
        /// </para>
        /// </summary>
        public MetricCharacteristics MetricCharacteristics
        {
            get { return this._metricCharacteristics; }
            set { this._metricCharacteristics = value; }
        }

        // Check to see if MetricCharacteristics property is set
        internal bool IsSetMetricCharacteristics()
        {
            return this._metricCharacteristics != null;
        }

        /// <summary>
        /// Gets and sets the property MetricMathAnomalyDetector. 
        /// <para>
        /// The CloudWatch metric math expression for this anomaly detector.
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
        /// The name of the metric associated with the anomaly detection model.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.MetricName property.")]
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
        /// The namespace of the metric associated with the anomaly detection model.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.Namespace property.")]
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
        /// The CloudWatch metric and statistic for this anomaly detector.
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
        /// The statistic associated with the anomaly detection model.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.Stat property.")]
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

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        /// The current status of the anomaly detector's training.
        /// </para>
        /// </summary>
        public AnomalyDetectorStateValue StateValue
        {
            get { return this._stateValue; }
            set { this._stateValue = value; }
        }

        // Check to see if StateValue property is set
        internal bool IsSetStateValue()
        {
            return this._stateValue != null;
        }

    }
}