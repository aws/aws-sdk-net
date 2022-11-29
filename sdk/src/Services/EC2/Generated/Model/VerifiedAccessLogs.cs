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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the destinations for Verified Access logs.
    /// </summary>
    public partial class VerifiedAccessLogs
    {
        private VerifiedAccessLogCloudWatchLogsDestination _cloudWatchLogs;
        private VerifiedAccessLogKinesisDataFirehoseDestination _kinesisDataFirehose;
        private VerifiedAccessLogS3Destination _s3;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// CloudWatch Logs logging destination.
        /// </para>
        /// </summary>
        public VerifiedAccessLogCloudWatchLogsDestination CloudWatchLogs
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
        /// Gets and sets the property KinesisDataFirehose. 
        /// <para>
        /// Kinesis logging destination.
        /// </para>
        /// </summary>
        public VerifiedAccessLogKinesisDataFirehoseDestination KinesisDataFirehose
        {
            get { return this._kinesisDataFirehose; }
            set { this._kinesisDataFirehose = value; }
        }

        // Check to see if KinesisDataFirehose property is set
        internal bool IsSetKinesisDataFirehose()
        {
            return this._kinesisDataFirehose != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Amazon S3 logging options.
        /// </para>
        /// </summary>
        public VerifiedAccessLogS3Destination S3
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