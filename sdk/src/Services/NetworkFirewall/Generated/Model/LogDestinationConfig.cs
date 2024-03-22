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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Defines where Network Firewall sends logs for the firewall for one log type. This
    /// is used in <a>LoggingConfiguration</a>. You can send each type of log to an Amazon
    /// S3 bucket, a CloudWatch log group, or a Kinesis Data Firehose delivery stream.
    /// 
    ///  
    /// <para>
    /// Network Firewall generates logs for stateful rule groups. You can save alert and flow
    /// log types. The stateful rules engine records flow logs for all network traffic that
    /// it receives. It records alert logs for traffic that matches stateful rules that have
    /// the rule action set to <c>DROP</c> or <c>ALERT</c>. 
    /// </para>
    /// </summary>
    public partial class LogDestinationConfig
    {
        private Dictionary<string, string> _logDestination = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private LogDestinationType _logDestinationType;
        private LogType _logType;

        /// <summary>
        /// Gets and sets the property LogDestination. 
        /// <para>
        /// The named location for the logs, provided in a key:value mapping that is specific
        /// to the chosen destination type. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For an Amazon S3 bucket, provide the name of the bucket, with key <c>bucketName</c>,
        /// and optionally provide a prefix, with key <c>prefix</c>. The following example specifies
        /// an Amazon S3 bucket named <c>DOC-EXAMPLE-BUCKET</c> and the prefix <c>alerts</c>:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"LogDestination": { "bucketName": "DOC-EXAMPLE-BUCKET", "prefix": "alerts" }</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a CloudWatch log group, provide the name of the CloudWatch log group, with key
        /// <c>logGroup</c>. The following example specifies a log group named <c>alert-log-group</c>:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"LogDestination": { "logGroup": "alert-log-group" }</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Kinesis Data Firehose delivery stream, provide the name of the delivery stream,
        /// with key <c>deliveryStream</c>. The following example specifies a delivery stream
        /// named <c>alert-delivery-stream</c>: 
        /// </para>
        ///  
        /// <para>
        ///  <c>"LogDestination": { "deliveryStream": "alert-delivery-stream" }</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> LogDestination
        {
            get { return this._logDestination; }
            set { this._logDestination = value; }
        }

        // Check to see if LogDestination property is set
        internal bool IsSetLogDestination()
        {
            return this._logDestination != null && (this._logDestination.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogDestinationType. 
        /// <para>
        /// The type of storage destination to send these logs to. You can send logs to an Amazon
        /// S3 bucket, a CloudWatch log group, or a Kinesis Data Firehose delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=30)]
        public LogDestinationType LogDestinationType
        {
            get { return this._logDestinationType; }
            set { this._logDestinationType = value; }
        }

        // Check to see if LogDestinationType property is set
        internal bool IsSetLogDestinationType()
        {
            return this._logDestinationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// The type of log to send. Alert logs report traffic that matches a <a>StatefulRule</a>
        /// with an action setting that sends an alert log message. Flow logs are standard network
        /// traffic flow logs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}