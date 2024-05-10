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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Configuration details of either a CloudWatch Logs destination or Kinesis Data Firehose
    /// destination.
    /// </summary>
    public partial class DestinationDetails
    {
        private CloudWatchLogsDestinationDetails _cloudWatchLogsDetails;
        private KinesisFirehoseDestinationDetails _kinesisFirehoseDetails;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsDetails. 
        /// <para>
        /// The configuration details of the CloudWatch Logs destination.
        /// </para>
        /// </summary>
        public CloudWatchLogsDestinationDetails CloudWatchLogsDetails
        {
            get { return this._cloudWatchLogsDetails; }
            set { this._cloudWatchLogsDetails = value; }
        }

        // Check to see if CloudWatchLogsDetails property is set
        internal bool IsSetCloudWatchLogsDetails()
        {
            return this._cloudWatchLogsDetails != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseDetails. 
        /// <para>
        /// The configuration details of the Kinesis Data Firehose destination.
        /// </para>
        /// </summary>
        public KinesisFirehoseDestinationDetails KinesisFirehoseDetails
        {
            get { return this._kinesisFirehoseDetails; }
            set { this._kinesisFirehoseDetails = value; }
        }

        // Check to see if KinesisFirehoseDetails property is set
        internal bool IsSetKinesisFirehoseDetails()
        {
            return this._kinesisFirehoseDetails != null;
        }

    }
}