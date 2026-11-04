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
    /// Container for the parameters to the DeleteAnomalyDetector operation. Deletes the specified
    /// anomaly detection model from your account. For more information about how to delete
    /// an anomaly detection model, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Create_Anomaly_Detection_Alarm.html#Delete_Anomaly_Detection_Model">Deleting
    /// an anomaly detection model</a> in the <i>CloudWatch User Guide</i>.
    /// </summary>
    public partial class DeleteAnomalyDetectorRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property AnomalyDetectorId. 
        /// <para>
        /// Specifies the unique identifier of the anomaly detector to delete. If you specify
        /// this parameter, you do not need to specify a metric to identify the detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AnomalyDetectorId { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyDetectorId property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorId() => this.AnomalyDetectorId != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The metric dimensions associated with the anomaly detection model to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Min = 0, Max = 30)]
        public List<Dimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public MetricMathAnomalyDetector MetricMathAnomalyDetector { get; set; }

        /// <summary>
        /// Checks to see if the MetricMathAnomalyDetector property is set.
        /// </summary>
        internal bool IsSetMetricMathAnomalyDetector() => this.MetricMathAnomalyDetector != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric name associated with the anomaly detection model to delete.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace associated with the anomaly detection model to delete.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

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
        public SingleMetricAnomalyDetector SingleMetricAnomalyDetector { get; set; }

        /// <summary>
        /// Checks to see if the SingleMetricAnomalyDetector property is set.
        /// </summary>
        internal bool IsSetSingleMetricAnomalyDetector() => this.SingleMetricAnomalyDetector != null;

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic associated with the anomaly detection model to delete.
        /// </para>
        /// </summary>
        [Obsolete("Use SingleMetricAnomalyDetector.")]
        [AWSProperty(Min = 0, Max = 50)]
        public string Stat { get; set; }

        /// <summary>
        /// Checks to see if the Stat property is set.
        /// </summary>
        internal bool IsSetStat() => this.Stat != null;
    }
}
