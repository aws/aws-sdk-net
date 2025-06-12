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
    /// Contains information about a dataset.
    /// </summary>
    public partial class MetricSetSummary
    {
        private string _anomalyDetectorArn;
        private DateTime? _creationTime;
        private DateTime? _lastModificationTime;
        private string _metricSetArn;
        private string _metricSetDescription;
        private string _metricSetName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the detector to which the dataset belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AnomalyDetectorArn
        {
            get { return this._anomalyDetectorArn; }
            set { this._anomalyDetectorArn = value; }
        }

        // Check to see if AnomalyDetectorArn property is set
        internal bool IsSetAnomalyDetectorArn()
        {
            return this._anomalyDetectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the dataset was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time at which the dataset was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricSetArn. 
        /// <para>
        /// The ARN of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MetricSetArn
        {
            get { return this._metricSetArn; }
            set { this._metricSetArn = value; }
        }

        // Check to see if MetricSetArn property is set
        internal bool IsSetMetricSetArn()
        {
            return this._metricSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSetDescription. 
        /// <para>
        /// The description of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MetricSetDescription
        {
            get { return this._metricSetDescription; }
            set { this._metricSetDescription = value; }
        }

        // Check to see if MetricSetDescription property is set
        internal bool IsSetMetricSetDescription()
        {
            return this._metricSetDescription != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string MetricSetName
        {
            get { return this._metricSetName; }
            set { this._metricSetName = value; }
        }

        // Check to see if MetricSetName property is set
        internal bool IsSetMetricSetName()
        {
            return this._metricSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The dataset's <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}