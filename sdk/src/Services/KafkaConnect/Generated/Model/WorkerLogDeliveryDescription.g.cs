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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Workers can send worker logs to different destination types. This configuration specifies
    /// the details of these destinations.
    /// </summary>
    public partial class WorkerLogDeliveryDescription
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// Details about delivering logs to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudWatchLogsLogDeliveryDescription CloudWatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogs property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogs() => this.CloudWatchLogs != null;

        /// <summary>
        /// Gets and sets the property Firehose. 
        /// <para>
        /// Details about delivering logs to Amazon Kinesis Data Firehose.
        /// </para>
        /// </summary>
        public FirehoseLogDeliveryDescription Firehose { get; set; }

        /// <summary>
        /// Checks to see if the Firehose property is set.
        /// </summary>
        internal bool IsSetFirehose() => this.Firehose != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Details about delivering logs to Amazon S3.
        /// </para>
        /// </summary>
        public S3LogDeliveryDescription S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}
