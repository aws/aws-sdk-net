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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
    /// Returns the objects or data listed below if successful. Otherwise, returns an error.
    /// </summary>
    public partial class CreateTrailResponse : AmazonWebServiceResponse
    {
        private string _cloudWatchLogsLogGroupArn;
        private string _cloudWatchLogsRoleArn;
        private bool? _includeGlobalServiceEvents;
        private bool? _isMultiRegionTrail;
        private bool? _isOrganizationTrail;
        private string _kmsKeyId;
        private bool? _logFileValidationEnabled;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _snsTopicARN;
        private string _snsTopicName;
        private string _trailARN;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the log group to which CloudTrail logs
        /// will be delivered.
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
        /// Specifies the role for the CloudWatch Logs endpoint to assume to write to a user's
        /// log group.
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
        /// Gets and sets the property IncludeGlobalServiceEvents. 
        /// <para>
        /// Specifies whether the trail is publishing events from global services such as IAM
        /// to the log files.
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
        /// Specifies whether the trail exists in one Region or in all Regions.
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
        /// Specifies whether the trail is an organization trail.
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
        /// Specifies the KMS key ID that encrypts the events delivered by CloudTrail. The value
        /// is a fully specified ARN to a KMS key in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012</c>
        /// 
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
        /// Specifies whether log file integrity validation is enabled.
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
        /// Specifies the name of the trail.
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
        /// Specifies the name of the Amazon S3 bucket designated for publishing log files.
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
        /// Specifies the Amazon S3 key prefix that comes after the name of the bucket you have
        /// designated for log file delivery. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/get-and-view-cloudtrail-log-files.html#cloudtrail-find-log-files">Finding
        /// Your CloudTrail Log Files</a>.
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
        /// Gets and sets the property SnsTopicARN. 
        /// <para>
        /// Specifies the ARN of the Amazon SNS topic that CloudTrail uses to send notifications
        /// when log files are delivered. The format of a topic ARN is:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:us-east-2:123456789012:MyTopic</c> 
        /// </para>
        /// </summary>
        public string SnsTopicARN
        {
            get { return this._snsTopicARN; }
            set { this._snsTopicARN = value; }
        }

        // Check to see if SnsTopicARN property is set
        internal bool IsSetSnsTopicARN()
        {
            return this._snsTopicARN != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// This field is no longer in use. Use <c>SnsTopicARN</c>.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. Use SnsTopicARN.")]
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
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// Specifies the ARN of the trail that was created. The format of a trail ARN is:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c> 
        /// </para>
        /// </summary>
        public string TrailARN
        {
            get { return this._trailARN; }
            set { this._trailARN = value; }
        }

        // Check to see if TrailARN property is set
        internal bool IsSetTrailARN()
        {
            return this._trailARN != null;
        }

    }
}