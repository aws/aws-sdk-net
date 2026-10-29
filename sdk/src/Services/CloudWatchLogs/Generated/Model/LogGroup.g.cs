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
    /// Represents a log group.
    /// </summary>
    public partial class LogGroup
    {
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
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BearerTokenAuthenticationEnabled. 
        /// <para>
        /// Indicates whether bearer token authentication is enabled for this log group. When
        /// enabled, bearer token authentication is allowed on operations until it is explicitly
        /// disabled.
        /// </para>
        /// </summary>
        public bool? BearerTokenAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BearerTokenAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetBearerTokenAuthenticationEnabled() => this.BearerTokenAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the log group, expressed as the number of milliseconds after
        /// Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataProtectionStatus. 
        /// <para>
        /// Displays whether this log group has a protection policy, or whether it had one in
        /// the past. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>.
        /// </para>
        /// </summary>
        public DataProtectionStatus DataProtectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the DataProtectionStatus property is set.
        /// </summary>
        internal bool IsSetDataProtectionStatus() => this.DataProtectionStatus != null;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Indicates whether deletion protection is enabled for this log group. When enabled,
        /// deletion protection blocks all deletion operations until it is explicitly disabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InheritedProperties. 
        /// <para>
        /// Displays all the properties that this log group has inherited from account-level settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InheritedProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InheritedProperties property is set.
        /// </summary>
        internal bool IsSetInheritedProperties() => this.InheritedProperties != null && (this.InheritedProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to use when encrypting log data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

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
        public string LogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupArn property is set.
        /// </summary>
        internal bool IsSetLogGroupArn() => this.LogGroupArn != null;

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
        public LogGroupClass LogGroupClass { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupClass property is set.
        /// </summary>
        internal bool IsSetLogGroupClass() => this.LogGroupClass != null;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property MetricFilterCount. 
        /// <para>
        /// The number of metric filters.
        /// </para>
        /// </summary>
        public int? MetricFilterCount { get; set; }

        /// <summary>
        /// Checks to see if the MetricFilterCount property is set.
        /// </summary>
        internal bool IsSetMetricFilterCount() => this.MetricFilterCount.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionInDays.
        /// </summary>
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionInDays property is set.
        /// </summary>
        internal bool IsSetRetentionInDays() => this.RetentionInDays.HasValue;

        /// <summary>
        /// Gets and sets the property StoredBytes. 
        /// <para>
        /// The number of bytes stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? StoredBytes { get; set; }

        /// <summary>
        /// Checks to see if the StoredBytes property is set.
        /// </summary>
        internal bool IsSetStoredBytes() => this.StoredBytes.HasValue;
    }
}
