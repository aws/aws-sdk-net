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
    /// Container for the parameters to the CreateTrail operation. Creates a trail that specifies
    /// the settings for delivery of log data to an Amazon S3 bucket.
    /// </summary>
    public partial class CreateTrailRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// Specifies a log group name using an Amazon Resource Name (ARN), a unique identifier
        /// that represents the log group to which CloudTrail logs will be delivered. You must
        /// use a log group that exists in your account.
        /// </para>
        ///  
        /// <para>
        /// Not required unless you specify <c>CloudWatchLogsRoleArn</c>.
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
        /// log group. You must use a role that exists in your account.
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsRoleArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsRoleArn() => this.CloudWatchLogsRoleArn != null;

        /// <summary>
        /// Gets and sets the property EnableLogFileValidation. 
        /// <para>
        /// Specifies whether log file integrity validation is enabled. The default is false.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you disable log file integrity validation, the chain of digest files is broken
        /// after one hour. CloudTrail does not create digest files for log files that were delivered
        /// during a period in which log file integrity validation was disabled. For example,
        /// if you enable log file integrity validation at noon on January 1, disable it at noon
        /// on January 2, and re-enable it at noon on January 10, digest files will not be created
        /// for the log files delivered from noon on January 2 to noon on January 10. The same
        /// applies whenever you stop CloudTrail logging or delete a trail.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? EnableLogFileValidation { get; set; }

        /// <summary>
        /// Checks to see if the EnableLogFileValidation property is set.
        /// </summary>
        internal bool IsSetEnableLogFileValidation() => this.EnableLogFileValidation.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeGlobalServiceEvents. 
        /// <para>
        /// Specifies whether the trail is publishing events from global services such as IAM
        /// to the log files. Setting this value to <c>true</c> only delivers global service events
        /// to the trail if the trail is multi-Region or if the trail's home Region is the partition
        /// leader Region (for example, us-east-1).
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
        /// Specifies whether the trail is created in the current Region or in all Regions. The
        /// default is false, which creates a trail only in the Region where you are signed in.
        /// As a best practice, consider creating trails that log events in all Regions.
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
        /// Specifies whether the trail is created for all accounts in an organization in Organizations,
        /// or only for the current Amazon Web Services account. The default is false, and cannot
        /// be true unless the call is made on behalf of an Amazon Web Services account that is
        /// the management account or delegated administrator account for an organization in Organizations.
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
        /// Specifies the KMS key ID to use to encrypt the logs and digest files delivered by
        /// CloudTrail. The value can be an alias name prefixed by <c>alias/</c>, a fully specified
        /// ARN to an alias, a fully specified ARN to a key, or a globally unique identifier.
        /// </para>
        ///  
        /// <para>
        /// CloudTrail also supports KMS multi-Region keys. For more information about multi-Region
        /// keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:kms:us-east-2:123456789012:alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>12345678-1234-1234-1234-123456789012</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the trail. The name must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Specifies the name of the Amazon S3 bucket designated for publishing log files. For
        /// information about bucket naming rules, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html">Bucket
        /// naming rules</a> in the <i>Amazon Simple Storage Service User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// Specifies the name or ARN of the Amazon SNS topic defined for notification of log
        /// file delivery. The maximum length is 256 characters.
        /// </para>
        /// </summary>
        public string SnsTopicName { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicName property is set.
        /// </summary>
        internal bool IsSetSnsTopicName() => this.SnsTopicName != null;

        /// <summary>
        /// Gets and sets the property TagsList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> TagsList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagsList property is set.
        /// </summary>
        internal bool IsSetTagsList() => this.TagsList != null && (this.TagsList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
