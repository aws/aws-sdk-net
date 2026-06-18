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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeContainerGroupPortMappings operation.
    /// <b>This API works with the following fleet types:</b> Container
    /// 
    ///  
    /// <para>
    /// Retrieves the port mappings for a container group running on a container fleet. Port
    /// mappings show how container ports are mapped to connection ports on the fleet instance.
    /// Use this operation to find the connection port for a specific container on a fleet
    /// instance.
    /// </para>
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Get port mappings for a game server container group. Provide the fleet ID, set <c>ContainerGroupType</c>
    /// to <c>GAME_SERVER</c>, and specify the <c>ComputeName</c> for the game server container
    /// group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Get port mappings for a per-instance container group. Provide the fleet ID, set <c>ContainerGroupType</c>
    /// to <c>PER_INSTANCE</c>, and specify the <c>InstanceId</c> for the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Optionally filter results to a single container by providing a <c>ContainerName</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// This operation returns the fleet ID, fleet ARN, location, container group definition
    /// ARN, container group type, compute name (for game server container groups), instance
    /// ID, and a list of <c>ContainerGroupPortMapping</c> objects. Each object contains the
    /// container name, runtime ID, and a list of port mappings that show how container ports
    /// map to connection ports on the instance.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-remote-access.html">Connect
    /// to containers</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-create-groups.html">Create
    /// a container group definition</a> 
    /// </para>
    /// </summary>
    public partial class DescribeContainerGroupPortMappingsRequest : AmazonGameLiftRequest
    {
        private string _computeName;
        private ContainerGroupType _containerGroupType;
        private string _containerName;
        private string _fleetId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// A unique identifier for the compute resource for which to retrieve port mappings.
        /// For a container fleet, a compute represents a game server container group running
        /// on a fleet instance. You can use either the compute name or ARN value.
        /// </para>
        ///  
        /// <para>
        /// When <c>ContainerGroupType</c> is <c>GAME_SERVER</c>, this parameter is required.
        /// </para>
        ///  
        /// <para>
        /// When <c>ContainerGroupType</c> is <c>PER_INSTANCE</c>, do not provide this parameter.
        /// If you provide a compute name with <c>PER_INSTANCE</c>, the request fails with an
        /// <c>InvalidRequestException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ComputeName
        {
            get { return this._computeName; }
            set { this._computeName = value; }
        }

        // Check to see if ComputeName property is set
        internal bool IsSetComputeName()
        {
            return this._computeName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerGroupType. 
        /// <para>
        /// The type of container group to retrieve port mappings for.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GAME_SERVER</c> -- Get port mappings for a game server container group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PER_INSTANCE</c> -- Get port mappings for a per-instance container group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerGroupType ContainerGroupType
        {
            get { return this._containerGroupType; }
            set { this._containerGroupType = value; }
        }

        // Check to see if ContainerGroupType property is set
        internal bool IsSetContainerGroupType()
        {
            return this._containerGroupType != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// A container name to filter the results. When provided, the operation returns port
        /// mappings for the specified container only. If no container with the specified name
        /// exists in the container group, the request fails with a <c>NotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// If not provided, the operation returns port mappings for all containers in the container
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the container fleet. You can use either the fleet ID or ARN
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// A unique identifier for the fleet instance to retrieve port mappings for.
        /// </para>
        ///  
        /// <para>
        /// When <c>ContainerGroupType</c> is <c>PER_INSTANCE</c>, this parameter is required.
        /// </para>
        ///  
        /// <para>
        /// When <c>ContainerGroupType</c> is <c>GAME_SERVER</c>, this parameter is optional.
        /// If you provide an instance ID, it must match the instance that's running the specified
        /// compute. If the instance ID doesn't match, the request fails with an <c>InvalidRequestException</c>.
        /// </para>
        /// </summary>
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

    }
}