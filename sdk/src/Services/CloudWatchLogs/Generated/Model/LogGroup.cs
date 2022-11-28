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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a log group.
    /// </summary>
    public partial class LogGroup
    {
        private string _arn;
        private DateTime? _creationTime;
        private DataProtectionStatus _dataProtectionStatus;
        private string _kmsKeyId;
        private string _logGroupName;
        private int? _metricFilterCount;
        private int? _retentionInDays;
        private long? _storedBytes;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log group.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the log group, expressed as the number of milliseconds after
        /// Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataProtectionStatus. 
        /// <para>
        /// Displays whether this log group has a protection policy, or whether it had one in
        /// the past. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>.
        /// </para>
        /// </summary>
        public DataProtectionStatus DataProtectionStatus
        {
            get { return this._dataProtectionStatus; }
            set { this._dataProtectionStatus = value; }
        }

        // Check to see if DataProtectionStatus property is set
        internal bool IsSetDataProtectionStatus()
        {
            return this._dataProtectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to use when encrypting log data.
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
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricFilterCount. 
        /// <para>
        /// The number of metric filters.
        /// </para>
        /// </summary>
        public int MetricFilterCount
        {
            get { return this._metricFilterCount.GetValueOrDefault(); }
            set { this._metricFilterCount = value; }
        }

        // Check to see if MetricFilterCount property is set
        internal bool IsSetMetricFilterCount()
        {
            return this._metricFilterCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionInDays.
        /// </summary>
        public int? RetentionInDays
        {
            get { return this._retentionInDays; }
            set { this._retentionInDays = value; }
        }

        // Check to see if RetentionInDays property is set
        internal bool IsSetRetentionInDays()
        {
            return this._retentionInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StoredBytes. 
        /// <para>
        /// The number of bytes stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long StoredBytes
        {
            get { return this._storedBytes.GetValueOrDefault(); }
            set { this._storedBytes = value; }
        }

        // Check to see if StoredBytes property is set
        internal bool IsSetStoredBytes()
        {
            return this._storedBytes.HasValue; 
        }

    }
}