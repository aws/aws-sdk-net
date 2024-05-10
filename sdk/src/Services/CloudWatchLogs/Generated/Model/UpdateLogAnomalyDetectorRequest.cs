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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLogAnomalyDetector operation.
    /// Updates an existing log anomaly detector.
    /// </summary>
    public partial class UpdateLogAnomalyDetectorRequest : AmazonCloudWatchLogsRequest
    {
        private string _anomalyDetectorArn;
        private long? _anomalyVisibilityTime;
        private bool? _enabled;
        private EvaluationFrequency _evaluationFrequency;
        private string _filterPattern;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the anomaly detector that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property AnomalyVisibilityTime. 
        /// <para>
        /// The number of days to use as the life cycle of anomalies. After this time, anomalies
        /// are automatically baselined and the anomaly detector model will treat new occurrences
        /// of similar event as normal. Therefore, if you do not correct the cause of an anomaly
        /// during this time, it will be considered normal going forward and will not be detected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=90)]
        public long? AnomalyVisibilityTime
        {
            get { return this._anomalyVisibilityTime; }
            set { this._anomalyVisibilityTime = value; }
        }

        // Check to see if AnomalyVisibilityTime property is set
        internal bool IsSetAnomalyVisibilityTime()
        {
            return this._anomalyVisibilityTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Use this parameter to pause or restart the anomaly detector. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationFrequency. 
        /// <para>
        /// Specifies how often the anomaly detector runs and look for anomalies. Set this value
        /// according to the frequency that the log group receives new logs. For example, if the
        /// log group receives new log events every 10 minutes, then setting <c>evaluationFrequency</c>
        /// to <c>FIFTEEN_MIN</c> might be appropriate.
        /// </para>
        /// </summary>
        public EvaluationFrequency EvaluationFrequency
        {
            get { return this._evaluationFrequency; }
            set { this._evaluationFrequency = value; }
        }

        // Check to see if EvaluationFrequency property is set
        internal bool IsSetEvaluationFrequency()
        {
            return this._evaluationFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property FilterPattern.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

    }
}