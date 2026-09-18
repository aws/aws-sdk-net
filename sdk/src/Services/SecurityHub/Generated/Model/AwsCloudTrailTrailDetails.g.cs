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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a CloudTrail trail.
    /// </summary>
    public partial class AwsCloudTrailTrailDetails
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// The ARN of the log group that CloudTrail logs are delivered to.
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
        /// The ARN of the role that the CloudWatch Events endpoint assumes when it writes to
        /// the log group.
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
        /// Indicates whether the trail has custom event selectors.
        /// </para>
        /// </summary>
        public bool? HasCustomEventSelectors { get; set; }

        /// <summary>
        /// Checks to see if the HasCustomEventSelectors property is set.
        /// </summary>
        internal bool IsSetHasCustomEventSelectors() => this.HasCustomEventSelectors.HasValue;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The Region where the trail was created.
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
        /// Indicates whether the trail publishes events from global services such as IAM to the
        /// log files.
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
        /// Indicates whether the trail applies only to the current Region or to all Regions.
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
        /// Whether the trail is created for all accounts in an organization in Organizations,
        /// or only for the current Amazon Web Services account.
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
        /// The KMS key ID to use to encrypt the logs.
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
        /// Indicates whether CloudTrail log file validation is enabled.
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
        /// The name of the trail.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket where the log files are published.
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
        /// The S3 key prefix. The key prefix is added after the name of the S3 bucket where the
        /// log files are published.
        /// </para>
        /// </summary>
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The ARN of the SNS topic that is used for notifications of log file delivery.
        /// </para>
        /// </summary>
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// The name of the SNS topic that is used for notifications of log file delivery.
        /// </para>
        /// </summary>
        public string SnsTopicName { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicName property is set.
        /// </summary>
        internal bool IsSetSnsTopicName() => this.SnsTopicName != null;

        /// <summary>
        /// Gets and sets the property TrailArn. 
        /// <para>
        /// The ARN of the trail.
        /// </para>
        /// </summary>
        public string TrailArn { get; set; }

        /// <summary>
        /// Checks to see if the TrailArn property is set.
        /// </summary>
        internal bool IsSetTrailArn() => this.TrailArn != null;
    }
}
