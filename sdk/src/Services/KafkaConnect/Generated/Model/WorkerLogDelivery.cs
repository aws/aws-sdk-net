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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
    public partial class WorkerLogDelivery
    {
        private CloudWatchLogsLogDelivery _cloudWatchLogs;
        private FirehoseLogDelivery _firehose;
        private S3LogDelivery _s3;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// Details about delivering logs to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudWatchLogsLogDelivery CloudWatchLogs
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
        /// Gets and sets the property Firehose. 
        /// <para>
        /// Details about delivering logs to Amazon Kinesis Data Firehose.
        /// </para>
        /// </summary>
        public FirehoseLogDelivery Firehose
        {
            get { return this._firehose; }
            set { this._firehose = value; }
        }

        // Check to see if Firehose property is set
        internal bool IsSetFirehose()
        {
            return this._firehose != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Details about delivering logs to Amazon S3.
        /// </para>
        /// </summary>
        public S3LogDelivery S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}