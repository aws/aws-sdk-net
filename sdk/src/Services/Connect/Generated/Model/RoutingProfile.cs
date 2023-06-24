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
    /// Contains information about a routing profile.
    /// </summary>
    public partial class RoutingProfile
    {
        private string _defaultOutboundQueueId;
        private string _description;
        private string _instanceId;
        private List<MediaConcurrency> _mediaConcurrencies = new List<MediaConcurrency>();
        private string _name;
        private long? _numberOfAssociatedQueues;
        private long? _numberOfAssociatedUsers;
        private string _routingProfileArn;
        private string _routingProfileId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DefaultOutboundQueueId. 
        /// <para>
        /// The identifier of the default outbound queue for this routing profile.
        /// </para>
        /// </summary>
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
        /// The description of the routing profile.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The channels agents can handle in the Contact Control Panel (CCP) for this routing
        /// profile.
        /// </para>
        /// </summary>
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
        /// The name of the routing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property NumberOfAssociatedQueues. 
        /// <para>
        /// The number of associated queues in routing profile.
        /// </para>
        /// </summary>
        public long NumberOfAssociatedQueues
        {
            get { return this._numberOfAssociatedQueues.GetValueOrDefault(); }
            set { this._numberOfAssociatedQueues = value; }
        }

        // Check to see if NumberOfAssociatedQueues property is set
        internal bool IsSetNumberOfAssociatedQueues()
        {
            return this._numberOfAssociatedQueues.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedUsers. 
        /// <para>
        /// The number of associated users in routing profile.
        /// </para>
        /// </summary>
        public long NumberOfAssociatedUsers
        {
            get { return this._numberOfAssociatedUsers.GetValueOrDefault(); }
            set { this._numberOfAssociatedUsers = value; }
        }

        // Check to see if NumberOfAssociatedUsers property is set
        internal bool IsSetNumberOfAssociatedUsers()
        {
            return this._numberOfAssociatedUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoutingProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the routing profile.
        /// </para>
        /// </summary>
        public string RoutingProfileArn
        {
            get { return this._routingProfileArn; }
            set { this._routingProfileArn = value; }
        }

        // Check to see if RoutingProfileArn property is set
        internal bool IsSetRoutingProfileArn()
        {
            return this._routingProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the routing profile.
        /// </para>
        /// </summary>
        public string RoutingProfileId
        {
            get { return this._routingProfileId; }
            set { this._routingProfileId = value; }
        }

        // Check to see if RoutingProfileId property is set
        internal bool IsSetRoutingProfileId()
        {
            return this._routingProfileId != null;
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