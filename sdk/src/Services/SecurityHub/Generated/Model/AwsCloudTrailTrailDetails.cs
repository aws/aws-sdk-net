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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _cloudWatchLogsLogGroupArn;
        private string _cloudWatchLogsRoleArn;
        private bool? _hasCustomEventSelectors;
        private string _homeRegion;
        private bool? _includeGlobalServiceEvents;
        private bool? _isMultiRegionTrail;
        private bool? _isOrganizationTrail;
        private string _kmsKeyId;
        private bool? _logFileValidationEnabled;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _snsTopicArn;
        private string _snsTopicName;
        private string _trailArn;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// The ARN of the log group that CloudTrail logs are delivered to.
        /// </para>
        /// </summary>
        public string CloudWatchLogsLogGroupArn
        {
            get { return this._cloudWatchLogsLogGroupArn; }
            set { this._cloudWatchLogsLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogsLogGroupArn property is set
        internal bool IsSetCloudWatchLogsLogGroupArn()
        {
            return this._cloudWatchLogsLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        /// The ARN of the role that the CloudWatch Events endpoint assumes when it writes to
        /// the log group.
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn
        {
            get { return this._cloudWatchLogsRoleArn; }
            set { this._cloudWatchLogsRoleArn = value; }
        }

        // Check to see if CloudWatchLogsRoleArn property is set
        internal bool IsSetCloudWatchLogsRoleArn()
        {
            return this._cloudWatchLogsRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property HasCustomEventSelectors. 
        /// <para>
        /// Indicates whether the trail has custom event selectors.
        /// </para>
        /// </summary>
        public bool? HasCustomEventSelectors
        {
            get { return this._hasCustomEventSelectors; }
            set { this._hasCustomEventSelectors = value; }
        }

        // Check to see if HasCustomEventSelectors property is set
        internal bool IsSetHasCustomEventSelectors()
        {
            return this._hasCustomEventSelectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The Region where the trail was created.
        /// </para>
        /// </summary>
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeGlobalServiceEvents. 
        /// <para>
        /// Indicates whether the trail publishes events from global services such as IAM to the
        /// log files.
        /// </para>
        /// </summary>
        public bool? IncludeGlobalServiceEvents
        {
            get { return this._includeGlobalServiceEvents; }
            set { this._includeGlobalServiceEvents = value; }
        }

        // Check to see if IncludeGlobalServiceEvents property is set
        internal bool IsSetIncludeGlobalServiceEvents()
        {
            return this._includeGlobalServiceEvents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsMultiRegionTrail. 
        /// <para>
        /// Indicates whether the trail applies only to the current Region or to all Regions.
        /// </para>
        /// </summary>
        public bool? IsMultiRegionTrail
        {
            get { return this._isMultiRegionTrail; }
            set { this._isMultiRegionTrail = value; }
        }

        // Check to see if IsMultiRegionTrail property is set
        internal bool IsSetIsMultiRegionTrail()
        {
            return this._isMultiRegionTrail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsOrganizationTrail. 
        /// <para>
        /// Whether the trail is created for all accounts in an organization in Organizations,
        /// or only for the current Amazon Web Services account.
        /// </para>
        /// </summary>
        public bool? IsOrganizationTrail
        {
            get { return this._isOrganizationTrail; }
            set { this._isOrganizationTrail = value; }
        }

        // Check to see if IsOrganizationTrail property is set
        internal bool IsSetIsOrganizationTrail()
        {
            return this._isOrganizationTrail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key ID to use to encrypt the logs.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LogFileValidationEnabled. 
        /// <para>
        /// Indicates whether CloudTrail log file validation is enabled.
        /// </para>
        /// </summary>
        public bool? LogFileValidationEnabled
        {
            get { return this._logFileValidationEnabled; }
            set { this._logFileValidationEnabled = value; }
        }

        // Check to see if LogFileValidationEnabled property is set
        internal bool IsSetLogFileValidationEnabled()
        {
            return this._logFileValidationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trail.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket where the log files are published.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The S3 key prefix. The key prefix is added after the name of the S3 bucket where the
        /// log files are published.
        /// </para>
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The ARN of the SNS topic that is used for notifications of log file delivery.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// The name of the SNS topic that is used for notifications of log file delivery.
        /// </para>
        /// </summary>
        public string SnsTopicName
        {
            get { return this._snsTopicName; }
            set { this._snsTopicName = value; }
        }

        // Check to see if SnsTopicName property is set
        internal bool IsSetSnsTopicName()
        {
            return this._snsTopicName != null;
        }

        /// <summary>
        /// Gets and sets the property TrailArn. 
        /// <para>
        /// The ARN of the trail.
        /// </para>
        /// </summary>
        public string TrailArn
        {
            get { return this._trailArn; }
            set { this._trailArn = value; }
        }

        // Check to see if TrailArn property is set
        internal bool IsSetTrailArn()
        {
            return this._trailArn != null;
        }

    }
}