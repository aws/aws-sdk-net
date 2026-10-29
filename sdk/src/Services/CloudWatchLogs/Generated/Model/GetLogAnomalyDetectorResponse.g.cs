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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the GetLogAnomalyDetector operation.
    /// </summary>
    public partial class GetLogAnomalyDetectorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnomalyDetectorStatus. 
        /// <para>
        /// Specifies whether the anomaly detector is currently active. To change its status,
        /// use the <c>enabled</c> parameter in the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateLogAnomalyDetector.html">UpdateLogAnomalyDetector</a>
        /// operation.
        /// </para>
        /// </summary>
        public AnomalyDetectorStatus AnomalyDetectorStatus { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyDetectorStatus property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorStatus() => this.AnomalyDetectorStatus != null;

        /// <summary>
        /// Gets and sets the property AnomalyVisibilityTime. 
        /// <para>
        /// The number of days used as the life cycle of anomalies. After this time, anomalies
        /// are automatically baselined and the anomaly detector model will treat new occurrences
        /// of similar event as normal. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 90)]
        public long? AnomalyVisibilityTime { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyVisibilityTime property is set.
        /// </summary>
        internal bool IsSetAnomalyVisibilityTime() => this.AnomalyVisibilityTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeStamp. 
        /// <para>
        /// The date and time when this anomaly detector was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? CreationTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreationTimeStamp() => this.CreationTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property DetectorName. 
        /// <para>
        /// The name of the log anomaly detector
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string DetectorName { get; set; }

        /// <summary>
        /// Checks to see if the DetectorName property is set.
        /// </summary>
        internal bool IsSetDetectorName() => this.DetectorName != null;

        /// <summary>
        /// Gets and sets the property EvaluationFrequency. 
        /// <para>
        /// Specifies how often the anomaly detector runs and look for anomalies. Set this value
        /// according to the frequency that the log group receives new logs. For example, if the
        /// log group receives new log events every 10 minutes, then setting <c>evaluationFrequency</c>
        /// to <c>FIFTEEN_MIN</c> might be appropriate.
        /// </para>
        /// </summary>
        public EvaluationFrequency EvaluationFrequency { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFrequency property is set.
        /// </summary>
        internal bool IsSetEvaluationFrequency() => this.EvaluationFrequency != null;

        /// <summary>
        /// Gets and sets the property FilterPattern.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// Checks to see if the FilterPattern property is set.
        /// </summary>
        internal bool IsSetFilterPattern() => this.FilterPattern != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key assigned to this anomaly detector, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeStamp. 
        /// <para>
        /// The date and time when this anomaly detector was most recently modified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastModifiedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeStamp() => this.LastModifiedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupArnList. 
        /// <para>
        /// An array of structures, where each structure contains the ARN of a log group associated
        /// with this anomaly detector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogGroupArnList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogGroupArnList property is set.
        /// </summary>
        internal bool IsSetLogGroupArnList() => this.LogGroupArnList != null && (this.LogGroupArnList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
