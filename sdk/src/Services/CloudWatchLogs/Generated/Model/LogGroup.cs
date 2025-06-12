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
    /// Represents a log group.
    /// </summary>
    public partial class LogGroup
    {
        private string _arn;
        private DateTime? _creationTime;
        private DataProtectionStatus _dataProtectionStatus;
        private List<string> _inheritedProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _kmsKeyId;
        private string _logGroupArn;
        private LogGroupClass _logGroupClass;
        private string _logGroupName;
        private int? _metricFilterCount;
        private int? _retentionInDays;
        private long? _storedBytes;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log group. This version of the ARN includes
        /// a trailing <c>:*</c> after the log group name. 
        /// </para>
        ///  
        /// <para>
        /// Use this version to refer to the ARN in IAM policies when specifying permissions for
        /// most API actions. The exception is when specifying permissions for <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_TagResource.html">TagResource</a>,
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UntagResource.html">UntagResource</a>,
        /// and <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>.
        /// The permissions for those three actions require the ARN version that doesn't include
        /// a trailing <c>:*</c>.
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
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
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
        /// Gets and sets the property InheritedProperties. 
        /// <para>
        /// Displays all the properties that this log group has inherited from account-level settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InheritedProperties
        {
            get { return this._inheritedProperties; }
            set { this._inheritedProperties = value; }
        }

        // Check to see if InheritedProperties property is set
        internal bool IsSetInheritedProperties()
        {
            return this._inheritedProperties != null && (this._inheritedProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log group. This version of the ARN doesn't include
        /// a trailing <c>:*</c> after the log group name. 
        /// </para>
        ///  
        /// <para>
        /// Use this version to refer to the ARN in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In the <c>logGroupIdentifier</c> input field in many CloudWatch Logs APIs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the <c>resourceArn</c> field in tagging APIs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In IAM policies, when specifying permissions for <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_TagResource.html">TagResource</a>,
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UntagResource.html">UntagResource</a>,
        /// and <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string LogGroupArn
        {
            get { return this._logGroupArn; }
            set { this._logGroupArn = value; }
        }

        // Check to see if LogGroupArn property is set
        internal bool IsSetLogGroupArn()
        {
            return this._logGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupClass. 
        /// <para>
        /// This specifies the log group class for this log group. There are three classes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>Standard</c> log class supports all CloudWatch Logs features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Infrequent Access</c> log class supports a subset of CloudWatch Logs features
        /// and incurs lower costs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>Delivery</c> log class only for delivering Lambda logs to store in Amazon
        /// S3 or Amazon Data Firehose. Log events in log groups in the Delivery class are kept
        /// in CloudWatch Logs for only one day. This log class doesn't offer rich CloudWatch
        /// Logs capabilities such as CloudWatch Logs Insights queries.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details about the features supported by the Standard and Infrequent Access classes,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch_Logs_Log_Classes.html">Log
        /// classes</a> 
        /// </para>
        /// </summary>
        public LogGroupClass LogGroupClass
        {
            get { return this._logGroupClass; }
            set { this._logGroupClass = value; }
        }

        // Check to see if LogGroupClass property is set
        internal bool IsSetLogGroupClass()
        {
            return this._logGroupClass != null;
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
        public int? MetricFilterCount
        {
            get { return this._metricFilterCount; }
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
        public long? StoredBytes
        {
            get { return this._storedBytes; }
            set { this._storedBytes = value; }
        }

        // Check to see if StoredBytes property is set
        internal bool IsSetStoredBytes()
        {
            return this._storedBytes.HasValue; 
        }

    }
}