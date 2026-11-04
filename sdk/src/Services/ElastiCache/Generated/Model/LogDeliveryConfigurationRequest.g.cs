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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Specifies the destination, format and type of the logs.
    /// </summary>
    public partial class LogDeliveryConfigurationRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationDetails. 
        /// <para>
        /// Configuration details of either a CloudWatch Logs destination or Kinesis Data Firehose
        /// destination.
        /// </para>
        /// </summary>
        public DestinationDetails DestinationDetails { get; set; }

        /// <summary>
        /// Checks to see if the DestinationDetails property is set.
        /// </summary>
        internal bool IsSetDestinationDetails() => this.DestinationDetails != null;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// Specify either <c>cloudwatch-logs</c> or <c>kinesis-firehose</c> as the destination
        /// type.
        /// </para>
        /// </summary>
        public DestinationType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specify if log delivery is enabled. Default <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LogFormat. 
        /// <para>
        /// Specifies either JSON or TEXT
        /// </para>
        /// </summary>
        public LogFormat LogFormat { get; set; }

        /// <summary>
        /// Checks to see if the LogFormat property is set.
        /// </summary>
        internal bool IsSetLogFormat() => this.LogFormat != null;

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// Refers to <a href="https://redis.io/commands/slowlog">slow-log</a> or engine-log..
        /// </para>
        /// </summary>
        public LogType LogType { get; set; }

        /// <summary>
        /// Checks to see if the LogType property is set.
        /// </summary>
        internal bool IsSetLogType() => this.LogType != null;
    }
}
