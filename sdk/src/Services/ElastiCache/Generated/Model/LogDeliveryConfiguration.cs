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
    /// Returns the destination, format and type of the logs.
    /// </summary>
    public partial class LogDeliveryConfiguration
    {
        private DestinationDetails _destinationDetails;
        private DestinationType _destinationType;
        private LogFormat _logFormat;
        private LogType _logType;
        private string _message;
        private LogDeliveryConfigurationStatus _status;

        /// <summary>
        /// Gets and sets the property DestinationDetails. 
        /// <para>
        /// Configuration details of either a CloudWatch Logs destination or Kinesis Data Firehose
        /// destination.
        /// </para>
        /// </summary>
        public DestinationDetails DestinationDetails
        {
            get { return this._destinationDetails; }
            set { this._destinationDetails = value; }
        }

        // Check to see if DestinationDetails property is set
        internal bool IsSetDestinationDetails()
        {
            return this._destinationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// Returns the destination type, either <c>cloudwatch-logs</c> or <c>kinesis-firehose</c>.
        /// </para>
        /// </summary>
        public DestinationType DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogFormat. 
        /// <para>
        /// Returns the log format, either JSON or TEXT.
        /// </para>
        /// </summary>
        public LogFormat LogFormat
        {
            get { return this._logFormat; }
            set { this._logFormat = value; }
        }

        // Check to see if LogFormat property is set
        internal bool IsSetLogFormat()
        {
            return this._logFormat != null;
        }

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// Refers to <a href="https://redis.io/commands/slowlog">slow-log</a> or engine-log.
        /// </para>
        /// </summary>
        public LogType LogType
        {
            get { return this._logType; }
            set { this._logType = value; }
        }

        // Check to see if LogType property is set
        internal bool IsSetLogType()
        {
            return this._logType != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Returns an error message for the log delivery configuration.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Returns the log delivery configuration status. Values are one of <c>enabling</c> |
        /// <c>disabling</c> | <c>modifying</c> | <c>active</c> | <c>error</c> 
        /// </para>
        /// </summary>
        public LogDeliveryConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}