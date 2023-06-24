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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Contains information on a metric attribution. A metric attribution creates reports
    /// on the data that you import into Amazon Personalize. Depending on how you import the
    /// data, you can view reports in Amazon CloudWatch or Amazon S3. For more information,
    /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
    /// impact of recommendations</a>.
    /// </summary>
    public partial class MetricAttribution
    {
        private DateTime? _creationDateTime;
        private string _datasetGroupArn;
        private string _failureReason;
        private DateTime? _lastUpdatedDateTime;
        private string _metricAttributionArn;
        private MetricAttributionOutput _metricsOutputConfig;
        private string _name;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The metric attribution's creation date time.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The metric attribution's dataset group Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The metric attribution's failure reason.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The metric attribution's last updated date time.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime.GetValueOrDefault(); }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricAttributionArn. 
        /// <para>
        /// The metric attribution's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MetricAttributionArn
        {
            get { return this._metricAttributionArn; }
            set { this._metricAttributionArn = value; }
        }

        // Check to see if MetricAttributionArn property is set
        internal bool IsSetMetricAttributionArn()
        {
            return this._metricAttributionArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsOutputConfig. 
        /// <para>
        /// The metric attribution's output configuration.
        /// </para>
        /// </summary>
        public MetricAttributionOutput MetricsOutputConfig
        {
            get { return this._metricsOutputConfig; }
            set { this._metricsOutputConfig = value; }
        }

        // Check to see if MetricsOutputConfig property is set
        internal bool IsSetMetricsOutputConfig()
        {
            return this._metricsOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The metric attribution's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The metric attribution's status.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}