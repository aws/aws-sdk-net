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
    /// Contains information about one anomaly detector in the account.
    /// </summary>
    public partial class AnomalyDetector
    {
        private string _anomalyDetectorArn;
        private AnomalyDetectorStatus _anomalyDetectorStatus;
        private long? _anomalyVisibilityTime;
        private long? _creationTimeStamp;
        private string _detectorName;
        private EvaluationFrequency _evaluationFrequency;
        private string _filterPattern;
        private string _kmsKeyId;
        private long? _lastModifiedTimeStamp;
        private List<string> _logGroupArnList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property AnomalyDetectorStatus. 
        /// <para>
        /// Specifies the current status of the anomaly detector. To pause an anomaly detector,
        /// use the <c>enabled</c> parameter in the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateLogAnomalyDetector.html">UpdateLogAnomalyDetector</a>
        /// operation.
        /// </para>
        /// </summary>
        public AnomalyDetectorStatus AnomalyDetectorStatus
        {
            get { return this._anomalyDetectorStatus; }
            set { this._anomalyDetectorStatus = value; }
        }

        // Check to see if AnomalyDetectorStatus property is set
        internal bool IsSetAnomalyDetectorStatus()
        {
            return this._anomalyDetectorStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyVisibilityTime. 
        /// <para>
        /// The number of days used as the life cycle of anomalies. After this time, anomalies
        /// are automatically baselined and the anomaly detector model will treat new occurrences
        /// of similar event as normal. 
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
        /// Gets and sets the property CreationTimeStamp. 
        /// <para>
        /// The date and time when this anomaly detector was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? CreationTimeStamp
        {
            get { return this._creationTimeStamp; }
            set { this._creationTimeStamp = value; }
        }

        // Check to see if CreationTimeStamp property is set
        internal bool IsSetCreationTimeStamp()
        {
            return this._creationTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorName. 
        /// <para>
        /// The name of the anomaly detector.
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
        /// Specifies how often the anomaly detector runs and look for anomalies.
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

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key assigned to this anomaly detector, if any.
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
        /// Gets and sets the property LastModifiedTimeStamp. 
        /// <para>
        /// The date and time when this anomaly detector was most recently modified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? LastModifiedTimeStamp
        {
            get { return this._lastModifiedTimeStamp; }
            set { this._lastModifiedTimeStamp = value; }
        }

        // Check to see if LastModifiedTimeStamp property is set
        internal bool IsSetLastModifiedTimeStamp()
        {
            return this._lastModifiedTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupArnList. 
        /// <para>
        /// A list of the ARNs of the log groups that this anomaly detector watches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

    }
}