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
    /// <b>This data type is used with the Amazon GameLift containers feature, which is currently
    /// in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// Configuration details for a set of container groups, for use when creating a fleet
    /// with compute type <c>CONTAINER</c>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Used with:</b> <a>CreateFleet</a> 
    /// </para>
    /// </summary>
    public partial class ContainerGroupsConfiguration
    {
        private ConnectionPortRange _connectionPortRange;
        private List<string> _containerGroupDefinitionNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _desiredReplicaContainerGroupsPerInstance;

        /// <summary>
        /// Gets and sets the property ConnectionPortRange. 
        /// <para>
        /// A set of ports to allow inbound traffic, including game clients, to connect to processes
        /// running in the container fleet. 
        /// </para>
        ///  
        /// <para>
        /// Connection ports are dynamically mapped to container ports, which are assigned to
        /// individual processes running in a container. The connection port range must have enough
        /// ports to map to all container ports across a fleet instance. To calculate the minimum
        /// connection ports needed, use the following formula: 
        /// </para>
        ///  
        /// <para>
        ///  <i>[Total number of container ports as defined for containers in the replica container
        /// group] * [Desired or calculated number of replica container groups per instance] +
        /// [Total number of container ports as defined for containers in the daemon container
        /// group]</i> 
        /// </para>
        ///  
        /// <para>
        /// As a best practice, double the minimum number of connection ports.
        /// </para>
        ///  <note> 
        /// <para>
        /// Use the fleet's <c>EC2InboundPermissions</c> property to control external access to
        /// connection ports. Set this property to the connection port numbers that you want to
        /// open access to. See <a>IpPermission</a> for more details.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionPortRange ConnectionPortRange
        {
            get { return this._connectionPortRange; }
            set { this._connectionPortRange = value; }
        }

        // Check to see if ConnectionPortRange property is set
        internal bool IsSetConnectionPortRange()
        {
            return this._connectionPortRange != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerGroupDefinitionNames. 
        /// <para>
        /// The list of container group definition names to deploy to a new container fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> ContainerGroupDefinitionNames
        {
            get { return this._containerGroupDefinitionNames; }
            set { this._containerGroupDefinitionNames = value; }
        }

        // Check to see if ContainerGroupDefinitionNames property is set
        internal bool IsSetContainerGroupDefinitionNames()
        {
            return this._containerGroupDefinitionNames != null && (this._containerGroupDefinitionNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DesiredReplicaContainerGroupsPerInstance. 
        /// <para>
        /// The number of times to replicate the replica container group on each instance in a
        /// container fleet. By default, Amazon GameLift calculates the maximum number of replica
        /// container groups that can fit on a fleet instance (based on CPU and memory resources).
        /// Leave this parameter empty if you want to use the maximum number, or specify a desired
        /// number to override the maximum. The desired number is used if it's less than the maximum
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? DesiredReplicaContainerGroupsPerInstance
        {
            get { return this._desiredReplicaContainerGroupsPerInstance; }
            set { this._desiredReplicaContainerGroupsPerInstance = value; }
        }

        // Check to see if DesiredReplicaContainerGroupsPerInstance property is set
        internal bool IsSetDesiredReplicaContainerGroupsPerInstance()
        {
            return this._desiredReplicaContainerGroupsPerInstance.HasValue; 
        }

    }
}