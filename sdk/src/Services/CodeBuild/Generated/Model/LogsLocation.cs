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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about build logs in CloudWatch Logs.
    /// </summary>
    public partial class LogsLocation
    {
        private CloudWatchLogsConfig _cloudWatchLogs;
        private string _cloudWatchLogsArn;
        private string _deepLink;
        private string _groupName;
        private string _s3DeepLink;
        private S3LogsConfig _s3Logs;
        private string _s3LogsArn;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        ///  Information about CloudWatch Logs for a build project. 
        /// </para>
        /// </summary>
        public CloudWatchLogsConfig CloudWatchLogs
        {
            get { return this._cloudWatchLogs; }
            set { this._cloudWatchLogs = value; }
        }

        // Check to see if CloudWatchLogs property is set
        internal bool IsSetCloudWatchLogs()
        {
            return this._cloudWatchLogs != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogsArn. 
        /// <para>
        /// The ARN of the CloudWatch Logs stream for a build execution. Its format is <c>arn:${Partition}:logs:${Region}:${Account}:log-group:${LogGroupName}:log-stream:${LogStreamName}</c>.
        /// The CloudWatch Logs stream is created during the PROVISIONING phase of a build and
        /// the ARN will not be valid until it is created. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_amazoncloudwatchlogs.html#amazoncloudwatchlogs-resources-for-iam-policies">Resources
        /// Defined by CloudWatch Logs</a>.
        /// </para>
        /// </summary>
        public string CloudWatchLogsArn
        {
            get { return this._cloudWatchLogsArn; }
            set { this._cloudWatchLogsArn = value; }
        }

        // Check to see if CloudWatchLogsArn property is set
        internal bool IsSetCloudWatchLogsArn()
        {
            return this._cloudWatchLogsArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeepLink. 
        /// <para>
        /// The URL to an individual build log in CloudWatch Logs. The log stream is created during
        /// the PROVISIONING phase of a build and the <c>deeplink</c> will not be valid until
        /// it is created.
        /// </para>
        /// </summary>
        public string DeepLink
        {
            get { return this._deepLink; }
            set { this._deepLink = value; }
        }

        // Check to see if DeepLink property is set
        internal bool IsSetDeepLink()
        {
            return this._deepLink != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the CloudWatch Logs group for the build logs.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property S3DeepLink. 
        /// <para>
        ///  The URL to a build log in an S3 bucket. 
        /// </para>
        /// </summary>
        public string S3DeepLink
        {
            get { return this._s3DeepLink; }
            set { this._s3DeepLink = value; }
        }

        // Check to see if S3DeepLink property is set
        internal bool IsSetS3DeepLink()
        {
            return this._s3DeepLink != null;
        }

        /// <summary>
        /// Gets and sets the property S3Logs. 
        /// <para>
        ///  Information about S3 logs for a build project. 
        /// </para>
        /// </summary>
        public S3LogsConfig S3Logs
        {
            get { return this._s3Logs; }
            set { this._s3Logs = value; }
        }

        // Check to see if S3Logs property is set
        internal bool IsSetS3Logs()
        {
            return this._s3Logs != null;
        }

        /// <summary>
        /// Gets and sets the property S3LogsArn. 
        /// <para>
        ///  The ARN of S3 logs for a build project. Its format is <c>arn:${Partition}:s3:::${BucketName}/${ObjectName}</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_amazons3.html#amazons3-resources-for-iam-policies">Resources
        /// Defined by Amazon S3</a>. 
        /// </para>
        /// </summary>
        public string S3LogsArn
        {
            get { return this._s3LogsArn; }
            set { this._s3LogsArn = value; }
        }

        // Check to see if S3LogsArn property is set
        internal bool IsSetS3LogsArn()
        {
            return this._s3LogsArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the CloudWatch Logs stream for the build logs.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}