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
    /// This structure represents one anomaly that has been found by a logs anomaly detector.
    /// 
    ///  
    /// <para>
    /// For more information about patterns and anomalies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateLogAnomalyDetector.html">CreateLogAnomalyDetector</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class Anomaly
    {
        private bool? _active;
        private string _anomalyDetectorArn;
        private string _anomalyId;
        private string _description;
        private long? _firstSeen;
        private Dictionary<string, long> _histogram = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;
        private bool? _isPatternLevelSuppression;
        private long? _lastSeen;
        private List<string> _logGroupArnList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<LogEvent> _logSamples = AWSConfigs.InitializeCollections ? new List<LogEvent>() : null;
        private string _patternId;
        private string _patternRegex;
        private string _patternString;
        private List<PatternToken> _patternTokens = AWSConfigs.InitializeCollections ? new List<PatternToken>() : null;
        private string _priority;
        private State _state;
        private bool? _suppressed;
        private long? _suppressedDate;
        private long? _suppressedUntil;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Specifies whether this anomaly is still ongoing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the anomaly detector that identified this anomaly.
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
        /// Gets and sets the property AnomalyId. 
        /// <para>
        /// The unique ID that CloudWatch Logs assigned to this anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AnomalyId
        {
            get { return this._anomalyId; }
            set { this._anomalyId = value; }
        }

        // Check to see if AnomalyId property is set
        internal bool IsSetAnomalyId()
        {
            return this._anomalyId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the anomaly. This description is generated by CloudWatch
        /// Logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FirstSeen. 
        /// <para>
        /// The date and time when the anomaly detector first saw this anomaly. It is specified
        /// as epoch time, which is the number of seconds since <c>January 1, 1970, 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? FirstSeen
        {
            get { return this._firstSeen; }
            set { this._firstSeen = value; }
        }

        // Check to see if FirstSeen property is set
        internal bool IsSetFirstSeen()
        {
            return this._firstSeen.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Histogram. 
        /// <para>
        /// A map showing times when the anomaly detector ran, and the number of occurrences of
        /// this anomaly that were detected at each of those runs. The times are specified in
        /// epoch time, which is the number of seconds since <c>January 1, 1970, 00:00:00 UTC</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, long> Histogram
        {
            get { return this._histogram; }
            set { this._histogram = value; }
        }

        // Check to see if Histogram property is set
        internal bool IsSetHistogram()
        {
            return this._histogram != null && (this._histogram.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsPatternLevelSuppression. 
        /// <para>
        /// If this anomaly is suppressed, this field is <c>true</c> if the suppression is because
        /// the pattern is suppressed. If <c>false</c>, then only this particular anomaly is suppressed.
        /// </para>
        /// </summary>
        public bool? IsPatternLevelSuppression
        {
            get { return this._isPatternLevelSuppression; }
            set { this._isPatternLevelSuppression = value; }
        }

        // Check to see if IsPatternLevelSuppression property is set
        internal bool IsSetIsPatternLevelSuppression()
        {
            return this._isPatternLevelSuppression.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSeen. 
        /// <para>
        /// The date and time when the anomaly detector most recently saw this anomaly. It is
        /// specified as epoch time, which is the number of seconds since <c>January 1, 1970,
        /// 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? LastSeen
        {
            get { return this._lastSeen; }
            set { this._lastSeen = value; }
        }

        // Check to see if LastSeen property is set
        internal bool IsSetLastSeen()
        {
            return this._lastSeen.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupArnList. 
        /// <para>
        /// An array of ARNS of the log groups that contained log events considered to be part
        /// of this anomaly.
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
        /// Gets and sets the property LogSamples. 
        /// <para>
        /// An array of sample log event messages that are considered to be part of this anomaly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LogEvent> LogSamples
        {
            get { return this._logSamples; }
            set { this._logSamples = value; }
        }

        // Check to see if LogSamples property is set
        internal bool IsSetLogSamples()
        {
            return this._logSamples != null && (this._logSamples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PatternId. 
        /// <para>
        /// The ID of the pattern used to help identify this anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string PatternId
        {
            get { return this._patternId; }
            set { this._patternId = value; }
        }

        // Check to see if PatternId property is set
        internal bool IsSetPatternId()
        {
            return this._patternId != null;
        }

        /// <summary>
        /// Gets and sets the property PatternRegex. 
        /// <para>
        /// The pattern used to help identify this anomaly, in regular expression format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PatternRegex
        {
            get { return this._patternRegex; }
            set { this._patternRegex = value; }
        }

        // Check to see if PatternRegex property is set
        internal bool IsSetPatternRegex()
        {
            return this._patternRegex != null;
        }

        /// <summary>
        /// Gets and sets the property PatternString. 
        /// <para>
        /// The pattern used to help identify this anomaly, in string format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string PatternString
        {
            get { return this._patternString; }
            set { this._patternString = value; }
        }

        // Check to see if PatternString property is set
        internal bool IsSetPatternString()
        {
            return this._patternString != null;
        }

        /// <summary>
        /// Gets and sets the property PatternTokens. 
        /// <para>
        /// An array of structures where each structure contains information about one token that
        /// makes up the pattern.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PatternToken> PatternTokens
        {
            get { return this._patternTokens; }
            set { this._patternTokens = value; }
        }

        // Check to see if PatternTokens property is set
        internal bool IsSetPatternTokens()
        {
            return this._patternTokens != null && (this._patternTokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of this anomaly, as determined by CloudWatch Logs. Priority is
        /// computed based on log severity labels such as <c>FATAL</c> and <c>ERROR</c> and the
        /// amount of deviation from the baseline. Possible values are <c>HIGH</c>, <c>MEDIUM</c>,
        /// and <c>LOW</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates the current state of this anomaly. If it is still being treated as an anomaly,
        /// the value is <c>Active</c>. If you have suppressed this anomaly by using the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateAnomaly.html">UpdateAnomaly</a>
        /// operation, the value is <c>Suppressed</c>. If this behavior is now considered to be
        /// normal, the value is <c>Baseline</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Suppressed. 
        /// <para>
        /// Indicates whether this anomaly is currently suppressed. To suppress an anomaly, use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateAnomaly.html">UpdateAnomaly</a>.
        /// </para>
        /// </summary>
        public bool? Suppressed
        {
            get { return this._suppressed; }
            set { this._suppressed = value; }
        }

        // Check to see if Suppressed property is set
        internal bool IsSetSuppressed()
        {
            return this._suppressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuppressedDate. 
        /// <para>
        /// If the anomaly is suppressed, this indicates when it was suppressed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? SuppressedDate
        {
            get { return this._suppressedDate; }
            set { this._suppressedDate = value; }
        }

        // Check to see if SuppressedDate property is set
        internal bool IsSetSuppressedDate()
        {
            return this._suppressedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuppressedUntil. 
        /// <para>
        /// If the anomaly is suppressed, this indicates when the suppression will end. If this
        /// value is <c>0</c>, the anomaly was suppressed with no expiration, with the <c>INFINITE</c>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? SuppressedUntil
        {
            get { return this._suppressedUntil; }
            set { this._suppressedUntil = value; }
        }

        // Check to see if SuppressedUntil property is set
        internal bool IsSetSuppressedUntil()
        {
            return this._suppressedUntil.HasValue; 
        }

    }
}