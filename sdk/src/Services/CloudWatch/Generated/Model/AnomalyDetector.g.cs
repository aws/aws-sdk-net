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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AnomalyDetectorId. 
        /// <para>
        /// The unique identifier of the anomaly detector.
        /// </para>
        ///  <note> 
        /// <para>
        /// The identifier does not restrict access to a specific anomaly detector in an IAM policy.
        /// Permissions for anomaly detector operations apply to all anomaly detectors in the
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AnomalyDetectorId { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyDetectorId property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorId() => this.AnomalyDetectorId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration specifies details about how the anomaly detection model is to be
        /// trained, including time ranges to exclude from use for training the model, and the
        /// time zone to use for the metric.
        /// </para>
        /// </summary>
        public AnomalyDetectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The metric dimensions associated with the anomaly detection model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.Dimensions property.")]
        [AWSProperty(Min = 0, Max = 30)]
        public List<Dimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricCharacteristics. 
        /// <para>
        /// This object includes parameters that you can use to provide information about your
        /// metric to CloudWatch to help it build more accurate anomaly detection models. Currently,
        /// it includes the <c>PeriodicSpikes</c> parameter.
        /// </para>
        /// </summary>
        public MetricCharacteristics MetricCharacteristics { get; set; }

        /// <summary>
        /// Checks to see if the MetricCharacteristics property is set.
        /// </summary>
        internal bool IsSetMetricCharacteristics() => this.MetricCharacteristics != null;

        /// <summary>
        /// Gets and sets the property MetricMathAnomalyDetector. 
        /// <para>
        /// The CloudWatch metric math expression for this anomaly detector.
        /// </para>
        /// </summary>
        public MetricMathAnomalyDetector MetricMathAnomalyDetector { get; set; }

        /// <summary>
        /// Checks to see if the MetricMathAnomalyDetector property is set.
        /// </summary>
        internal bool IsSetMetricMathAnomalyDetector() => this.MetricMathAnomalyDetector != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric associated with the anomaly detection model.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.MetricName property.")]
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric associated with the anomaly detection model.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.Namespace property.")]
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property SingleMetricAnomalyDetector. 
        /// <para>
        /// The CloudWatch metric and statistic for this anomaly detector.
        /// </para>
        /// </summary>
        public SingleMetricAnomalyDetector SingleMetricAnomalyDetector { get; set; }

        /// <summary>
        /// Checks to see if the SingleMetricAnomalyDetector property is set.
        /// </summary>
        internal bool IsSetSingleMetricAnomalyDetector() => this.SingleMetricAnomalyDetector != null;

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic associated with the anomaly detection model.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.Stat property.")]
        [AWSProperty(Min = 0, Max = 50)]
        public string Stat { get; set; }

        /// <summary>
        /// Checks to see if the Stat property is set.
        /// </summary>
        internal bool IsSetStat() => this.Stat != null;

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        /// The current status of the anomaly detector's training.
        /// </para>
        /// </summary>
        public AnomalyDetectorStateValue StateValue { get; set; }

        /// <summary>
        /// Checks to see if the StateValue property is set.
        /// </summary>
        internal bool IsSetStateValue() => this.StateValue != null;
    }
}
