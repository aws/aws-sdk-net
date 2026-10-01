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
    /// The log configuration for the results of the run command actions.
    /// </summary>
    public partial class AwsEcsClusterConfigurationExecuteCommandConfigurationLogConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property CloudWatchEncryptionEnabled. 
        /// <para>
        /// Whether to enable encryption on the CloudWatch logs.
        /// </para>
        /// </summary>
        public bool? CloudWatchEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetCloudWatchEncryptionEnabled() => this.CloudWatchEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupName. 
        /// <para>
        /// The name of the CloudWatch log group to send the logs to.
        /// </para>
        /// </summary>
        public string CloudWatchLogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogGroupName property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogGroupName() => this.CloudWatchLogGroupName != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket to send logs to.
        /// </para>
        /// </summary>
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3EncryptionEnabled. 
        /// <para>
        /// Whether to encrypt the logs that are sent to the S3 bucket.
        /// </para>
        /// </summary>
        public bool? S3EncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the S3EncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetS3EncryptionEnabled() => this.S3EncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// Identifies the folder in the S3 bucket to send the logs to.
        /// </para>
        /// </summary>
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;
    }
}
