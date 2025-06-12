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
    /// Container for the parameters to the CreateLogAnomalyDetector operation.
    /// Creates an <i>anomaly detector</i> that regularly scans one or more log groups and
    /// look for patterns and anomalies in the logs.
    /// 
    ///  
    /// <para>
    /// An anomaly detector can help surface issues by automatically discovering anomalies
    /// in your log event traffic. An anomaly detector uses machine learning algorithms to
    /// scan log events and find <i>patterns</i>. A pattern is a shared text structure that
    /// recurs among your log fields. Patterns provide a useful tool for analyzing large sets
    /// of logs because a large number of log events can often be compressed into a few patterns.
    /// </para>
    ///  
    /// <para>
    /// The anomaly detector uses pattern recognition to find <c>anomalies</c>, which are
    /// unusual log events. It uses the <c>evaluationFrequency</c> to compare current log
    /// events and patterns with trained baselines. 
    /// </para>
    ///  
    /// <para>
    /// Fields within a pattern are called <i>tokens</i>. Fields that vary within a pattern,
    /// such as a request ID or timestamp, are referred to as <i>dynamic tokens</i> and represented
    /// by <c>&lt;*&gt;</c>. 
    /// </para>
    ///  
    /// <para>
    /// The following is an example of a pattern:
    /// </para>
    ///  
    /// <para>
    ///  <c>[INFO] Request time: &lt;*&gt; ms</c> 
    /// </para>
    ///  
    /// <para>
    /// This pattern represents log events like <c>[INFO] Request time: 327 ms</c> and other
    /// similar log events that differ only by the number, in this csse 327. When the pattern
    /// is displayed, the different numbers are replaced by <c>&lt;*&gt;</c> 
    /// </para>
    ///  <note> 
    /// <para>
    /// Any parts of log events that are masked as sensitive data are not scanned for anomalies.
    /// For more information about masking sensitive data, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Help
    /// protect sensitive log data with masking</a>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateLogAnomalyDetectorRequest : AmazonCloudWatchLogsRequest
    {
        private long? _anomalyVisibilityTime;
        private string _detectorName;
        private EvaluationFrequency _evaluationFrequency;
        private string _filterPattern;
        private string _kmsKeyId;
        private List<string> _logGroupArnList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AnomalyVisibilityTime. 
        /// <para>
        /// The number of days to have visibility on an anomaly. After this time period has elapsed
        /// for an anomaly, it will be automatically baselined and the anomaly detector will treat
        /// new occurrences of a similar anomaly as normal. Therefore, if you do not correct the
        /// cause of an anomaly during the time period specified in <c>anomalyVisibilityTime</c>,
        /// it will be considered normal going forward and will not be detected as an anomaly.
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
        /// Gets and sets the property DetectorName. 
        /// <para>
        /// A name for this anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DetectorName
        {
            get { return this._detectorName; }
            set { this._detectorName = value; }
        }

        // Check to see if DetectorName property is set
        internal bool IsSetDetectorName()
        {
            return this._detectorName != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFrequency. 
        /// <para>
        /// Specifies how often the anomaly detector is to run and look for anomalies. Set this
        /// value according to the frequency that the log group receives new logs. For example,
        /// if the log group receives new log events every 10 minutes, then 15 minutes might be
        /// a good setting for <c>evaluationFrequency</c> .
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
        /// <para>
        /// You can use this parameter to limit the anomaly detection model to examine only log
        /// events that match the pattern you specify here. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">Filter
        /// and Pattern Syntax</a>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Optionally assigns a KMS key to secure this anomaly detector and its findings. If
        /// a key is assigned, the anomalies found and the model used by this detector are encrypted
        /// at rest with the key. If a key is assigned to an anomaly detector, a user must have
        /// permissions for both this key and for the anomaly detector to retrieve information
        /// about the anomalies that it finds.
        /// </para>
        ///  
        /// <para>
        ///  Make sure the value provided is a valid KMS key ARN. For more information about using
        /// a KMS key and to see the required IAM policy, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/LogsAnomalyDetection-KMS.html">Use
        /// a KMS key with an anomaly detector</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupArnList. 
        /// <para>
        /// An array containing the ARN of the log group that this anomaly detector will watch.
        /// You can specify only one log group ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> LogGroupArnList
        {
            get { return this._logGroupArnList; }
            set { this._logGroupArnList = value; }
        }

        // Check to see if LogGroupArnList property is set
        internal bool IsSetLogGroupArnList()
        {
            return this._logGroupArnList != null && (this._logGroupArnList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of key-value pairs to associate with the resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> 
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