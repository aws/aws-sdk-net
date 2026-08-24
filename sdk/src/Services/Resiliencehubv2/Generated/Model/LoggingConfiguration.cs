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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Configuration for test execution logging destinations.
    /// </summary>
    public partial class LoggingConfiguration
    {
        private string _cloudWatchLogGroupArn;
        private string _logSchemaVersion;
        private string _s3BucketName;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// The ARN of the CloudWatch Logs log group for log delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=31)]
        public string CloudWatchLogGroupArn
        {
            get { return this._cloudWatchLogGroupArn; }
            set { this._cloudWatchLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogGroupArn property is set
        internal bool IsSetCloudWatchLogGroupArn()
        {
            return this._cloudWatchLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogSchemaVersion. 
        /// <para>
        /// The version of the log schema.
        /// </para>
        /// </summary>
        public string LogSchemaVersion
        {
            get { return this._logSchemaVersion; }
            set { this._logSchemaVersion = value; }
        }

        // Check to see if LogSchemaVersion property is set
        internal bool IsSetLogSchemaVersion()
        {
            return this._logSchemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket for log delivery.
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

    }
}