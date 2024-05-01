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
    /// Information about logs for a build project. These can be logs in CloudWatch Logs,
    /// built in a specified S3 bucket, or both.
    /// </summary>
    public partial class LogsConfig
    {
        private CloudWatchLogsConfig _cloudWatchLogs;
        private S3LogsConfig _s3Logs;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        ///  Information about CloudWatch Logs for a build project. CloudWatch Logs are enabled
        /// by default. 
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
        /// Gets and sets the property S3Logs. 
        /// <para>
        ///  Information about logs built to an S3 bucket for a build project. S3 logs are not
        /// enabled by default. 
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

    }
}