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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateQueueOutboundCallerConfig operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Updates the outbound caller ID name, number, and outbound whisper flow for a specified
    /// queue.
    /// </para>
    ///  <important> 
    /// <para>
    /// If the number being used in the input is claimed to a traffic distribution group,
    /// and you are calling this API using an instance in the Amazon Web Services Region where
    /// the traffic distribution group was created, you can use either a full phone number
    /// ARN or UUID value for the <code>OutboundCallerIdNumberId</code> value of the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_OutboundCallerConfig">OutboundCallerConfig</a>
    /// request body parameter. However, if the number is claimed to a traffic distribution
    /// group and you are calling this API using an instance in the alternate Amazon Web Services
    /// Region associated with the traffic distribution group, you must provide a full phone
    /// number ARN. If a UUID is provided in this scenario, you will receive a <code>ResourceNotFoundException</code>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateQueueOutboundCallerConfigRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private OutboundCallerConfig _outboundCallerConfig;
        private string _queueId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCallerConfig. 
        /// <para>
        /// The outbound caller ID name, number, and outbound whisper flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutboundCallerConfig OutboundCallerConfig
        {
            get { return this._outboundCallerConfig; }
            set { this._outboundCallerConfig = value; }
        }

        // Check to see if OutboundCallerConfig property is set
        internal bool IsSetOutboundCallerConfig()
        {
            return this._outboundCallerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The identifier for the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

    }
}