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
    /// Container for the parameters to the CreateRoutingProfile operation.
    /// Creates a new routing profile.
    /// </summary>
    public partial class CreateRoutingProfileRequest : AmazonConnectRequest
    {
        private string _defaultOutboundQueueId;
        private string _description;
        private string _instanceId;
        private List<MediaConcurrency> _mediaConcurrencies = new List<MediaConcurrency>();
        private string _name;
        private List<RoutingProfileQueueConfig> _queueConfigs = new List<RoutingProfileQueueConfig>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DefaultOutboundQueueId. 
        /// <para>
        /// The default outbound queue for the routing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DefaultOutboundQueueId
        {
            get { return this._defaultOutboundQueueId; }
            set { this._defaultOutboundQueueId = value; }
        }

        // Check to see if DefaultOutboundQueueId property is set
        internal bool IsSetDefaultOutboundQueueId()
        {
            return this._defaultOutboundQueueId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the routing profile. Must not be more than 250 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
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
        /// Gets and sets the property MediaConcurrencies. 
        /// <para>
        /// The channels that agents can handle in the Contact Control Panel (CCP) for this routing
        /// profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MediaConcurrency> MediaConcurrencies
        {
            get { return this._mediaConcurrencies; }
            set { this._mediaConcurrencies = value; }
        }

        // Check to see if MediaConcurrencies property is set
        internal bool IsSetMediaConcurrencies()
        {
            return this._mediaConcurrencies != null && this._mediaConcurrencies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the routing profile. Must not be more than 127 characters.
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
        /// Gets and sets the property QueueConfigs. 
        /// <para>
        /// The inbound queues associated with the routing profile. If no queue is added, the
        /// agent can make only outbound calls.
        /// </para>
        ///  
        /// <para>
        /// The limit of 10 array members applies to the maximum number of <code>RoutingProfileQueueConfig</code>
        /// objects that can be passed during a CreateRoutingProfile API request. It is different
        /// from the quota of 50 queues per routing profile per instance that is listed in <a
        /// href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect service quotas</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<RoutingProfileQueueConfig> QueueConfigs
        {
            get { return this._queueConfigs; }
            set { this._queueConfigs = value; }
        }

        // Check to see if QueueConfigs property is set
        internal bool IsSetQueueConfigs()
        {
            return this._queueConfigs != null && this._queueConfigs.Count > 0; 
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