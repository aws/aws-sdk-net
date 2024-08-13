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
    /// This is the response object from the DescribeAnomalyDetector operation.
    /// </summary>
    public partial class DescribeAnomalyDetectorResponse : AmazonWebServiceResponse
    {
        private string _anomalyDetectorArn;
        private AnomalyDetectorConfigSummary _anomalyDetectorConfig;
        private string _anomalyDetectorDescription;
        private string _anomalyDetectorName;
        private DateTime? _creationTime;
        private string _failureReason;
        private AnomalyDetectorFailureType _failureType;
        private string _kmsKeyArn;
        private DateTime? _lastModificationTime;
        private AnomalyDetectorStatus _status;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the detector.
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
        /// Gets and sets the property AnomalyDetectorConfig. 
        /// <para>
        /// Contains information about the detector's configuration.
        /// </para>
        /// </summary>
        public AnomalyDetectorConfigSummary AnomalyDetectorConfig
        {
            get { return this._anomalyDetectorConfig; }
            set { this._anomalyDetectorConfig = value; }
        }

        // Check to see if AnomalyDetectorConfig property is set
        internal bool IsSetAnomalyDetectorConfig()
        {
            return this._anomalyDetectorConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorDescription. 
        /// <para>
        /// A description of the detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AnomalyDetectorDescription
        {
            get { return this._anomalyDetectorDescription; }
            set { this._anomalyDetectorDescription = value; }
        }

        // Check to see if AnomalyDetectorDescription property is set
        internal bool IsSetAnomalyDetectorDescription()
        {
            return this._anomalyDetectorDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorName. 
        /// <para>
        /// The name of the detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string AnomalyDetectorName
        {
            get { return this._anomalyDetectorName; }
            set { this._anomalyDetectorName = value; }
        }

        // Check to see if AnomalyDetectorName property is set
        internal bool IsSetAnomalyDetectorName()
        {
            return this._anomalyDetectorName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the detector was created.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the detector failed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property FailureType. 
        /// <para>
        /// The process that caused the detector to fail.
        /// </para>
        /// </summary>
        public AnomalyDetectorFailureType FailureType
        {
            get { return this._failureType; }
            set { this._failureType = value; }
        }

        // Check to see if FailureType property is set
        internal bool IsSetFailureType()
        {
            return this._failureType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key to use to encrypt your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time at which the detector was last modified.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the detector.
        /// </para>
        /// </summary>
        public AnomalyDetectorStatus Status
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