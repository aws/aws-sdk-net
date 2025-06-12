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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the DescribeEndpoint operation.
    /// </summary>
    public partial class DescribeEndpointResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private string _endpointId;
        private string _endpointUrl;
        private List<EndpointEventBus> _eventBuses = AWSConfigs.InitializeCollections ? new List<EndpointEventBus>() : null;
        private DateTime? _lastModifiedTime;
        private string _name;
        private ReplicationConfig _replicationConfig;
        private string _roleArn;
        private RoutingConfig _routingConfig;
        private EndpointState _state;
        private string _stateReason;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the endpoint you asked for information about was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// The URL of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EndpointUrl
        {
            get { return this._endpointUrl; }
            set { this._endpointUrl = value; }
        }

        // Check to see if EndpointUrl property is set
        internal bool IsSetEndpointUrl()
        {
            return this._endpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property EventBuses. 
        /// <para>
        /// The event buses being used by the endpoint you asked for information about.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<EndpointEventBus> EventBuses
        {
            get { return this._eventBuses; }
            set { this._eventBuses = value; }
        }

        // Check to see if EventBuses property is set
        internal bool IsSetEventBuses()
        {
            return this._eventBuses != null && (this._eventBuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the endpoint you asked for information about was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ReplicationConfig. 
        /// <para>
        /// Whether replication is enabled or disabled for the endpoint you asked for information
        /// about.
        /// </para>
        /// </summary>
        public ReplicationConfig ReplicationConfig
        {
            get { return this._replicationConfig; }
            set { this._replicationConfig = value; }
        }

        // Check to see if ReplicationConfig property is set
        internal bool IsSetReplicationConfig()
        {
            return this._replicationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role used by the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingConfig. 
        /// <para>
        /// The routing configuration of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        public RoutingConfig RoutingConfig
        {
            get { return this._routingConfig; }
            set { this._routingConfig = value; }
        }

        // Check to see if RoutingConfig property is set
        internal bool IsSetRoutingConfig()
        {
            return this._routingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        public EndpointState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason the endpoint you asked for information about is in its current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

    }
}