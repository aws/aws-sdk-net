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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the options for Verified Access logs.
    /// </summary>
    public partial class VerifiedAccessLogs
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// CloudWatch Logs logging destination.
        /// </para>
        /// </summary>
        public VerifiedAccessLogCloudWatchLogsDestination CloudWatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogs property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogs() => this.CloudWatchLogs != null;

        /// <summary>
        /// Gets and sets the property IncludeTrustContext. 
        /// <para>
        /// Indicates whether trust data is included in the logs.
        /// </para>
        /// </summary>
        public bool? IncludeTrustContext { get; set; }

        /// <summary>
        /// Checks to see if the IncludeTrustContext property is set.
        /// </summary>
        internal bool IsSetIncludeTrustContext() => this.IncludeTrustContext.HasValue;

        /// <summary>
        /// Gets and sets the property KinesisDataFirehose. 
        /// <para>
        /// Kinesis logging destination.
        /// </para>
        /// </summary>
        public VerifiedAccessLogKinesisDataFirehoseDestination KinesisDataFirehose { get; set; }

        /// <summary>
        /// Checks to see if the KinesisDataFirehose property is set.
        /// </summary>
        internal bool IsSetKinesisDataFirehose() => this.KinesisDataFirehose != null;

        /// <summary>
        /// Gets and sets the property LogVersion. 
        /// <para>
        /// The log version.
        /// </para>
        /// </summary>
        public string LogVersion { get; set; }

        /// <summary>
        /// Checks to see if the LogVersion property is set.
        /// </summary>
        internal bool IsSetLogVersion() => this.LogVersion != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Amazon S3 logging options.
        /// </para>
        /// </summary>
        public VerifiedAccessLogS3Destination S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}
