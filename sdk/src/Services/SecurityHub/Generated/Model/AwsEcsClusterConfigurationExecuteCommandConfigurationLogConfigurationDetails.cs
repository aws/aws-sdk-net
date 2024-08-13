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
    /// The log configuration for the results of the run command actions.
    /// </summary>
    public partial class AwsEcsClusterConfigurationExecuteCommandConfigurationLogConfigurationDetails
    {
        private bool? _cloudWatchEncryptionEnabled;
        private string _cloudWatchLogGroupName;
        private string _s3BucketName;
        private bool? _s3EncryptionEnabled;
        private string _s3KeyPrefix;

        /// <summary>
        /// Gets and sets the property CloudWatchEncryptionEnabled. 
        /// <para>
        /// Whether to enable encryption on the CloudWatch logs.
        /// </para>
        /// </summary>
        public bool? CloudWatchEncryptionEnabled
        {
            get { return this._cloudWatchEncryptionEnabled; }
            set { this._cloudWatchEncryptionEnabled = value; }
        }

        // Check to see if CloudWatchEncryptionEnabled property is set
        internal bool IsSetCloudWatchEncryptionEnabled()
        {
            return this._cloudWatchEncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupName. 
        /// <para>
        /// The name of the CloudWatch log group to send the logs to.
        /// </para>
        /// </summary>
        public string CloudWatchLogGroupName
        {
            get { return this._cloudWatchLogGroupName; }
            set { this._cloudWatchLogGroupName = value; }
        }

        // Check to see if CloudWatchLogGroupName property is set
        internal bool IsSetCloudWatchLogGroupName()
        {
            return this._cloudWatchLogGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket to send logs to.
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
        /// Gets and sets the property S3EncryptionEnabled. 
        /// <para>
        /// Whether to encrypt the logs that are sent to the S3 bucket.
        /// </para>
        /// </summary>
        public bool? S3EncryptionEnabled
        {
            get { return this._s3EncryptionEnabled; }
            set { this._s3EncryptionEnabled = value; }
        }

        // Check to see if S3EncryptionEnabled property is set
        internal bool IsSetS3EncryptionEnabled()
        {
            return this._s3EncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// Identifies the folder in the S3 bucket to send the logs to.
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

    }
}