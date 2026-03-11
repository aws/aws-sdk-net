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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateQueueOutboundCallerConfig operation.
    /// Updates the outbound caller ID name, number, and outbound whisper flow for a specified
    /// queue.
    /// 
    ///  <important> <ul> <li> 
    /// <para>
    /// If the phone number is claimed to a traffic distribution group that was created in
    /// the same Region as the Amazon Connect instance where you are calling this API, then
    /// you can use a full phone number ARN or a UUID for <c>OutboundCallerIdNumberId</c>.
    /// However, if the phone number is claimed to a traffic distribution group that is in
    /// one Region, and you are calling this API from an instance in another Amazon Web Services
    /// Region that is associated with the traffic distribution group, you must provide a
    /// full phone number ARN. If a UUID is provided in this scenario, you will receive a
    /// <c>ResourceNotFoundException</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only use the phone number ARN format that doesn't contain <c>instance</c> in the path,
    /// for example, <c>arn:aws:connect:us-east-1:1234567890:phone-number/uuid</c>. This is
    /// the same ARN format that is returned when you call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
    /// API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you plan to use IAM policies to allow/deny access to this API for phone number
    /// resources claimed to a traffic distribution group, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security_iam_resource-level-policy-examples.html#allow-deny-queue-actions-replica-region">Allow
    /// or Deny queue API actions for phone numbers in a replica Region</a>.
    /// </para>
    ///  </li> </ul> </important>
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