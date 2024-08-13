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
    /// Feedback for an anomalous metric.
    /// </summary>
    public partial class AnomalyGroupTimeSeriesFeedback
    {
        private string _anomalyGroupId;
        private bool? _isAnomaly;
        private string _timeSeriesId;

        /// <summary>
        /// Gets and sets the property AnomalyGroupId. 
        /// <para>
        /// The ID of the anomaly group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// Gets and sets the property IsAnomaly. 
        /// <para>
        /// Feedback on whether the metric is a legitimate anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsAnomaly
        {
            get { return this._isAnomaly; }
            set { this._isAnomaly = value; }
        }

        // Check to see if IsAnomaly property is set
        internal bool IsSetIsAnomaly()
        {
            return this._isAnomaly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The ID of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=520)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

    }
}