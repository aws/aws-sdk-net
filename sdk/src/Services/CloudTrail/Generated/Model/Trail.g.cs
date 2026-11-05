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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// The settings for a trail.
    /// </summary>
    public partial class Trail
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// Specifies an Amazon Resource Name (ARN), a unique identifier that represents the log
        /// group to which CloudTrail logs will be delivered.
        /// </para>
        /// </summary>
        public string CloudWatchLogsLogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsLogGroupArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsLogGroupArn() => this.CloudWatchLogsLogGroupArn != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        /// Specifies the role for the CloudWatch Logs endpoint to assume to write to a user's
        /// log group.
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsRoleArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsRoleArn() => this.CloudWatchLogsRoleArn != null;

        /// <summary>
        /// Gets and sets the property HasCustomEventSelectors. 
        /// <para>
        /// Specifies if the trail has custom event selectors.
        /// </para>
        /// </summary>
        public bool? HasCustomEventSelectors { get; set; }

        /// <summary>
        /// Checks to see if the HasCustomEventSelectors property is set.
        /// </summary>
        internal bool IsSetHasCustomEventSelectors() => this.HasCustomEventSelectors.HasValue;

        /// <summary>
        /// Gets and sets the property HasInsightSelectors. 
        /// <para>
        /// Specifies whether a trail has insight types specified in an <c>InsightSelector</c>
        /// list.
        /// </para>
        /// </summary>
        public bool? HasInsightSelectors { get; set; }

        /// <summary>
        /// Checks to see if the HasInsightSelectors property is set.
        /// </summary>
        internal bool IsSetHasInsightSelectors() => this.HasInsightSelectors.HasValue;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The Region in which the trail was created.
        /// </para>
        /// </summary>
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property IncludeGlobalServiceEvents. 
        /// <para>
        /// Set to <b>True</b> to include Amazon Web Services API calls from Amazon Web Services
        /// global services such as IAM. Otherwise, <b>False</b>. Setting this value to <c>true</c>
        /// only delivers global service events to the trail if the trail is multi-Region or if
        /// the trail's home Region is the partition leader Region (for example, us-east-1).
        /// </para>
        /// </summary>
        public bool? IncludeGlobalServiceEvents { get; set; }

        /// <summary>
        /// Checks to see if the IncludeGlobalServiceEvents property is set.
        /// </summary>
        internal bool IsSetIncludeGlobalServiceEvents() => this.IncludeGlobalServiceEvents.HasValue;

        /// <summary>
        /// Gets and sets the property IsMultiRegionTrail. 
        /// <para>
        /// Specifies whether the trail exists only in one Region or exists in all Regions.
        /// </para>
        /// </summary>
        public bool? IsMultiRegionTrail { get; set; }

        /// <summary>
        /// Checks to see if the IsMultiRegionTrail property is set.
        /// </summary>
        internal bool IsSetIsMultiRegionTrail() => this.IsMultiRegionTrail.HasValue;

        /// <summary>
        /// Gets and sets the property IsOrganizationTrail. 
        /// <para>
        /// Specifies whether the trail is an organization trail.
        /// </para>
        /// </summary>
        public bool? IsOrganizationTrail { get; set; }

        /// <summary>
        /// Checks to see if the IsOrganizationTrail property is set.
        /// </summary>
        internal bool IsSetIsOrganizationTrail() => this.IsOrganizationTrail.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specifies the KMS key ID that encrypts the logs and digest files delivered by CloudTrail.
        /// The value is a fully specified ARN to a KMS key in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LogFileValidationEnabled. 
        /// <para>
        /// Specifies whether log file validation is enabled.
        /// </para>
        /// </summary>
        public bool? LogFileValidationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the LogFileValidationEnabled property is set.
        /// </summary>
        internal bool IsSetLogFileValidationEnabled() => this.LogFileValidationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the trail set by calling <a>CreateTrail</a>. The maximum length is 128 characters.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecursiveLogging. 
        /// <para>
        /// Specifies whether recursive logging is enabled for the trail. If you set <c>RecursiveLogging</c>
        /// to <c>false</c>, CloudTrail suppresses events generated by CloudTrail when it delivers
        /// log files to your trail's destinations, including Amazon S3 and CloudWatch Logs. The
        /// default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? RecursiveLogging { get; set; }

        /// <summary>
        /// Checks to see if the RecursiveLogging property is set.
        /// </summary>
        internal bool IsSetRecursiveLogging() => this.RecursiveLogging.HasValue;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Name of the Amazon S3 bucket into which CloudTrail delivers your trail files. See
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html">Amazon
        /// S3 Bucket naming rules</a>.
        /// </para>
        /// </summary>
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// Specifies the Amazon S3 key prefix that comes after the name of the bucket you have
        /// designated for log file delivery. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/get-and-view-cloudtrail-log-files.html#cloudtrail-find-log-files">Finding
        /// Your CloudTrail Log Files</a>. The maximum length is 200 characters.
        /// </para>
        /// </summary>
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property SnsTopicARN. 
        /// <para>
        /// Specifies the ARN of the Amazon SNS topic that CloudTrail uses to send notifications
        /// when log files are delivered. The following is the format of a topic ARN.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:us-east-2:123456789012:MyTopic</c> 
        /// </para>
        /// </summary>
        public string SnsTopicARN { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicARN property is set.
        /// </summary>
        internal bool IsSetSnsTopicARN() => this.SnsTopicARN != null;

        /// <summary>
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// This field is no longer in use. Use <c>SnsTopicARN</c>.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. Use SnsTopicARN.")]
        public string SnsTopicName { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicName property is set.
        /// </summary>
        internal bool IsSetSnsTopicName() => this.SnsTopicName != null;

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// Specifies the ARN of the trail. The following is the format of a trail ARN.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c> 
        /// </para>
        /// </summary>
        public string TrailARN { get; set; }

        /// <summary>
        /// Checks to see if the TrailARN property is set.
        /// </summary>
        internal bool IsSetTrailARN() => this.TrailARN != null;
    }
}
