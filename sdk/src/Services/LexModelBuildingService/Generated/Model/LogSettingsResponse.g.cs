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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// The settings for conversation logs.
    /// </summary>
    public partial class LogSettingsResponse
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination where logs are delivered.
        /// </para>
        /// </summary>
        public Destination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the key used to encrypt audio logs in an S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// The type of logging that is enabled.
        /// </para>
        /// </summary>
        public LogType LogType { get; set; }

        /// <summary>
        /// Checks to see if the LogType property is set.
        /// </summary>
        internal bool IsSetLogType() => this.LogType != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch Logs log group or S3 bucket where
        /// the logs are delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourcePrefix. 
        /// <para>
        /// The resource prefix is the first part of the S3 object key within the S3 bucket that
        /// you specified to contain audio logs. For CloudWatch Logs it is the prefix of the log
        /// stream name within the log group that you specified. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ResourcePrefix { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePrefix property is set.
        /// </summary>
        internal bool IsSetResourcePrefix() => this.ResourcePrefix != null;
    }
}
