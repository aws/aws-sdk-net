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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// A complex type that describes a location where chat logs will be stored. Each member
    /// represents the configuration of one log destination. For logging, you define only
    /// one type of destination (for CloudWatch Logs, Kinesis Firehose, or S3).
    /// </summary>
    public partial class DestinationConfiguration
    {
        private CloudWatchLogsDestinationConfiguration _cloudWatchLogs;
        private FirehoseDestinationConfiguration _firehose;
        private S3DestinationConfiguration _s3;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// An Amazon CloudWatch Logs destination configuration where chat activity will be logged.
        /// </para>
        /// </summary>
        public CloudWatchLogsDestinationConfiguration CloudWatchLogs
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
        /// An Amazon Kinesis Data Firehose destination configuration where chat activity will
        /// be logged.
        /// </para>
        /// </summary>
        public FirehoseDestinationConfiguration Firehose
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
        /// An Amazon S3 destination configuration where chat activity will be logged.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3
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