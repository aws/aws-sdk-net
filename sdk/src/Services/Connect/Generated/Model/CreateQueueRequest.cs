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
    /// Container for the parameters to the CreateQueue operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Creates a new queue for the specified Amazon Connect instance.
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
    public partial class CreateQueueRequest : AmazonConnectRequest
    {
        private string _description;
        private string _hoursOfOperationId;
        private string _instanceId;
        private int? _maxContacts;
        private string _name;
        private OutboundCallerConfig _outboundCallerConfig;
        private List<string> _quickConnectIds = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HoursOfOperationId
        {
            get { return this._hoursOfOperationId; }
            set { this._hoursOfOperationId = value; }
        }

        // Check to see if HoursOfOperationId property is set
        internal bool IsSetHoursOfOperationId()
        {
            return this._hoursOfOperationId != null;
        }

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
        /// Gets and sets the property MaxContacts. 
        /// <para>
        /// The maximum number of contacts that can be in the queue before it is considered full.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaxContacts
        {
            get { return this._maxContacts.GetValueOrDefault(); }
            set { this._maxContacts = value; }
        }

        // Check to see if MaxContacts property is set
        internal bool IsSetMaxContacts()
        {
            return this._maxContacts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCallerConfig. 
        /// <para>
        /// The outbound caller ID name, number, and outbound whisper flow.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property QuickConnectIds. 
        /// <para>
        /// The quick connects available to agents who are working the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> QuickConnectIds
        {
            get { return this._quickConnectIds; }
            set { this._quickConnectIds = value; }
        }

        // Check to see if QuickConnectIds property is set
        internal bool IsSetQuickConnectIds()
        {
            return this._quickConnectIds != null && this._quickConnectIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}