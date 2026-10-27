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
    /// The configuration specifies details about how the anomaly detection model is to be
    /// trained, including time ranges to exclude from use for training the model and the
    /// time zone to use for the metric.
    /// </summary>
    public partial class AnomalyDetectorConfiguration
    {
        private AnomalyDetectorAdaptationSpeed _adaptationSpeed;
        private List<Range> _excludedTimeRanges = AWSConfigs.InitializeCollections ? new List<Range>() : null;
        private string _metricTimezone;
        private AnomalyDetectorOutlierFilteringStrength _outlierFilteringStrength;

        /// <summary>
        /// Gets and sets the property AdaptationSpeed. 
        /// <para>
        /// The speed at which the anomaly detection model adapts to sustained changes in the
        /// metric's baseline. Faster adaptation lets the model track shifting workloads sooner,
        /// but increases the chance that the model treats a real, lasting change as normal.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAST</c> - The model adapts quickly to sustained changes in the baseline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NORMAL</c> - The model adapts at a moderate pace. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SLOW</c> - The model adapts slowly, reducing the risk of treating a real change
        /// as normal.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnomalyDetectorAdaptationSpeed AdaptationSpeed
        {
            get { return this._adaptationSpeed; }
            set { this._adaptationSpeed = value; }
        }

        // Check to see if AdaptationSpeed property is set
        internal bool IsSetAdaptationSpeed()
        {
            return this._adaptationSpeed != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedTimeRanges. 
        /// <para>
        /// An array of time ranges to exclude from use when the anomaly detection model is trained.
        /// Use this to make sure that events that could cause unusual values for the metric,
        /// such as deployments, aren't used when CloudWatch creates the model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> ExcludedTimeRanges
        {
            get { return this._excludedTimeRanges; }
            set { this._excludedTimeRanges = value; }
        }

        // Check to see if ExcludedTimeRanges property is set
        internal bool IsSetExcludedTimeRanges()
        {
            return this._excludedTimeRanges != null && (this._excludedTimeRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricTimezone. 
        /// <para>
        /// The time zone to use for the metric. This is useful to enable the model to automatically
        /// account for daylight savings time changes if the metric is sensitive to such time
        /// changes.
        /// </para>
        ///  
        /// <para>
        /// To specify a time zone, use the name of the time zone as specified in the standard
        /// tz database. For more information, see <a href="https://en.wikipedia.org/wiki/Tz_database">tz
        /// database</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string MetricTimezone
        {
            get { return this._metricTimezone; }
            set { this._metricTimezone = value; }
        }

        // Check to see if MetricTimezone property is set
        internal bool IsSetMetricTimezone()
        {
            return this._metricTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property OutlierFilteringStrength. 
        /// <para>
        /// The aggressiveness with which CloudWatch filters outliers from the metric data that
        /// the anomaly detection model uses. Stronger filtering excludes more extreme values,
        /// which can produce a tighter band of expected values but may also suppress legitimate
        /// spikes.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MINIMAL</c> - Excludes only the most extreme outliers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODERATE</c> - Excludes a moderate range of outliers. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STRICT</c> - Excludes a wider range of outliers, which can suppress legitimate
        /// spikes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnomalyDetectorOutlierFilteringStrength OutlierFilteringStrength
        {
            get { return this._outlierFilteringStrength; }
            set { this._outlierFilteringStrength = value; }
        }

        // Check to see if OutlierFilteringStrength property is set
        internal bool IsSetOutlierFilteringStrength()
        {
            return this._outlierFilteringStrength != null;
        }

    }
}