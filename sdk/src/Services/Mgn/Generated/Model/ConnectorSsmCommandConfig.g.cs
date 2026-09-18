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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Connector SSM command config.
    /// </summary>
    public partial class ConnectorSsmCommandConfig
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupName. 
        /// <para>
        /// Connector SSM command config CloudWatch log group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string CloudWatchLogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogGroupName property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogGroupName() => this.CloudWatchLogGroupName != null;

        /// <summary>
        /// Gets and sets the property CloudWatchOutputEnabled. 
        /// <para>
        /// Connector SSM command config CloudWatch output enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? CloudWatchOutputEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchOutputEnabled property is set.
        /// </summary>
        internal bool IsSetCloudWatchOutputEnabled() => this.CloudWatchOutputEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// Connector SSM command config output S3 bucket name.
        /// </para>
        /// </summary>
        public string OutputS3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3BucketName property is set.
        /// </summary>
        internal bool IsSetOutputS3BucketName() => this.OutputS3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3OutputEnabled. 
        /// <para>
        /// Connector SSM command config S3 output enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? S3OutputEnabled { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputEnabled property is set.
        /// </summary>
        internal bool IsSetS3OutputEnabled() => this.S3OutputEnabled.HasValue;
    }
}
