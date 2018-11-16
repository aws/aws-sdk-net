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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about build logs in Amazon CloudWatch Logs.
    /// </summary>
    public partial class LogsLocation
    {
        private CloudWatchLogsConfig _cloudWatchLogs;
        private string _deepLink;
        private string _groupName;
        private string _s3DeepLink;
        private S3LogsConfig _s3Logs;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        ///  Information about Amazon CloudWatch Logs for a build project. 
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
        /// Gets and sets the property DeepLink. 
        /// <para>
        /// The URL to an individual build log in Amazon CloudWatch Logs.
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
        /// The name of the Amazon CloudWatch Logs group for the build logs.
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
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the Amazon CloudWatch Logs stream for the build logs.
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