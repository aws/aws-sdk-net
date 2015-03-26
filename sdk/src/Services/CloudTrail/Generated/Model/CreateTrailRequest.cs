/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrail operation.
    /// From the command line, use <code>create-subscription</code>. 
    /// 
    ///  
    /// <para>
    /// Creates a trail that specifies the settings for delivery of log data to an Amazon
    /// S3 bucket. 
    /// </para>
    /// </summary>
    public partial class CreateTrailRequest : AmazonCloudTrailRequest
    {
        private string _cloudWatchLogsLogGroupArn;
        private string _cloudWatchLogsRoleArn;
        private bool? _includeGlobalServiceEvents;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _snsTopicName;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// Specifies a log group name using an Amazon Resource Name (ARN), a unique identifier
        /// that represents the log group to which CloudTrail logs will be delivered. Not required
        /// unless you specify CloudWatchLogsRoleArn.
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
        /// Specifies the role for the CloudWatch Logs endpoint to assume to write to a user’s
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
        /// Specifies the Amazon S3 key prefix that precedes the name of the bucket you have designated
        /// for log file delivery.
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