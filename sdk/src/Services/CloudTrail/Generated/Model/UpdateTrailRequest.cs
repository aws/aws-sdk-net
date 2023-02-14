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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrail operation.
    /// Updates trail settings that control what events you are logging, and how to handle
    /// log files. Changes to a trail do not require stopping the CloudTrail service. Use
    /// this action to designate an existing bucket for log delivery. If the existing bucket
    /// has previously been a target for CloudTrail log files, an IAM policy exists for the
    /// bucket. <code>UpdateTrail</code> must be called from the region in which the trail
    /// was created; otherwise, an <code>InvalidHomeRegionException</code> is thrown.
    /// </summary>
    public partial class UpdateTrailRequest : AmazonCloudTrailRequest
    {
        private string _cloudWatchLogsLogGroupArn;
        private string _cloudWatchLogsRoleArn;
        private bool? _enableLogFileValidation;
        private bool? _includeGlobalServiceEvents;
        private bool? _isMultiRegionTrail;
        private bool? _isOrganizationTrail;
        private string _kmsKeyId;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _snsTopicName;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// Specifies a log group name using an Amazon Resource Name (ARN), a unique identifier
        /// that represents the log group to which CloudTrail logs are delivered. You must use
        /// a log group that exists in your account.
        /// </para>
        ///  
        /// <para>
        /// Not required unless you specify <code>CloudWatchLogsRoleArn</code>.
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
        /// log group. You must use a role that exists in your account.
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
        /// Gets and sets the property EnableLogFileValidation. 
        /// <para>
        /// Specifies whether log file validation is enabled. The default is false.
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
        public bool EnableLogFileValidation
        {
            get { return this._enableLogFileValidation.GetValueOrDefault(); }
            set { this._enableLogFileValidation = value; }
        }

        // Check to see if EnableLogFileValidation property is set
        internal bool IsSetEnableLogFileValidation()
        {
            return this._enableLogFileValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeGlobalServiceEvents. 
        /// <para>
        /// Specifies whether the trail is publishing events from global services such as IAM
        /// to the log files.
        /// </para>
        /// </summary>
        public bool IncludeGlobalServiceEvents
        {
            get { return this._includeGlobalServiceEvents.GetValueOrDefault(); }
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
        /// Specifies whether the trail applies only to the current region or to all regions.
        /// The default is false. If the trail exists only in the current region and this value
        /// is set to true, shadow trails (replications of the trail) will be created in the other
        /// regions. If the trail exists in all regions and this value is set to false, the trail
        /// will remain in the region where it was created, and its shadow trails in other regions
        /// will be deleted. As a best practice, consider using trails that log events in all
        /// regions.
        /// </para>
        /// </summary>
        public bool IsMultiRegionTrail
        {
            get { return this._isMultiRegionTrail.GetValueOrDefault(); }
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
        /// Specifies whether the trail is applied to all accounts in an organization in Organizations,
        /// or only for the current Amazon Web Services account. The default is false, and cannot
        /// be true unless the call is made on behalf of an Amazon Web Services account that is
        /// the management account or delegated administrator account for an organization in Organizations.
        /// If the trail is not an organization trail and this is set to <code>true</code>, the
        /// trail will be created in all Amazon Web Services accounts that belong to the organization.
        /// If the trail is an organization trail and this is set to <code>false</code>, the trail
        /// will remain in the current Amazon Web Services account but be deleted from all member
        /// accounts in the organization.
        /// </para>
        /// </summary>
        public bool IsOrganizationTrail
        {
            get { return this._isOrganizationTrail.GetValueOrDefault(); }
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
        /// Specifies the KMS key ID to use to encrypt the logs delivered by CloudTrail. The value
        /// can be an alias name prefixed by "alias/", a fully specified ARN to an alias, a fully
        /// specified ARN to a key, or a globally unique identifier.
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
        /// alias/MyAliasName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// arn:aws:kms:us-east-2:123456789012:alias/MyAliasName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 12345678-1234-1234-1234-123456789012
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the trail or trail ARN. If <code>Name</code> is a trail name,
        /// the string must meet the following requirements:
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
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <code>Name</code> is a trail ARN, it must be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Specifies the name of the Amazon S3 bucket designated for publishing log files. See
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/create_trail_naming_policy.html">Amazon
        /// S3 Bucket Naming Requirements</a>.
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
        /// designated for log file delivery. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-find-log-files.html">Finding
        /// Your CloudTrail Log Files</a>. The maximum length is 200 characters.
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
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// Specifies the name of the Amazon SNS topic defined for notification of log file delivery.
        /// The maximum length is 256 characters.
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

    }
}