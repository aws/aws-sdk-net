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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the DescribeEndpoint operation.
    /// </summary>
    public partial class DescribeEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the endpoint you asked for information about was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// The URL of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the EndpointUrl property is set.
        /// </summary>
        internal bool IsSetEndpointUrl() => this.EndpointUrl != null;

        /// <summary>
        /// Gets and sets the property EventBuses. 
        /// <para>
        /// The event buses being used by the endpoint you asked for information about.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public List<EndpointEventBus> EventBuses { get; set; } = AWSConfigs.InitializeCollections ? new List<EndpointEventBus>() : null;

        /// <summary>
        /// Checks to see if the EventBuses property is set.
        /// </summary>
        internal bool IsSetEventBuses() => this.EventBuses != null && (this.EventBuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the endpoint you asked for information about was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfig. 
        /// <para>
        /// Whether replication is enabled or disabled for the endpoint you asked for information
        /// about.
        /// </para>
        /// </summary>
        public ReplicationConfig ReplicationConfig { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfig property is set.
        /// </summary>
        internal bool IsSetReplicationConfig() => this.ReplicationConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role used by the endpoint you asked for information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RoutingConfig. 
        /// <para>
        /// The routing configuration of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        public RoutingConfig RoutingConfig { get; set; }

        /// <summary>
        /// Checks to see if the RoutingConfig property is set.
        /// </summary>
        internal bool IsSetRoutingConfig() => this.RoutingConfig != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the endpoint you asked for information about.
        /// </para>
        /// </summary>
        public EndpointState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason the endpoint you asked for information about is in its current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
