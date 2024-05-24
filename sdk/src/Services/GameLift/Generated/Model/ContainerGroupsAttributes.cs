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
    /// The properties of container groups that are running on a container fleet. Container
    /// group properties for a fleet can't be changed.
    /// </para>
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a>DescribeFleetAttributes</a>, <a>CreateFleet</a> 
    /// </para>
    /// </summary>
    public partial class ContainerGroupsAttributes
    {
        private ConnectionPortRange _connectionPortRange;
        private List<ContainerGroupDefinitionProperty> _containerGroupDefinitionProperties = AWSConfigs.InitializeCollections ? new List<ContainerGroupDefinitionProperty>() : null;
        private ContainerGroupsPerInstance _containerGroupsPerInstance;

        /// <summary>
        /// Gets and sets the property ConnectionPortRange. 
        /// <para>
        /// A set of ports that allow inbound traffic to connect to processes running in the fleet's
        /// container groups. Amazon GameLift maps each connection port to a container port, which
        /// is assigned to a specific container process. A fleet's connection port range can't
        /// be changed, but you can control access to connection ports by updating a fleet's <c>EC2InboundPermissions</c>
        /// with <a>UpdateFleetPortSettings</a>. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ContainerGroupDefinitionProperties. 
        /// <para>
        /// A collection of properties that describe each container group in the fleet. A container
        /// fleet is deployed with one or more <a>ContainerGroupDefinition</a> resources, which
        /// is where these properties are set.
        /// </para>
        /// </summary>
        public List<ContainerGroupDefinitionProperty> ContainerGroupDefinitionProperties
        {
            get { return this._containerGroupDefinitionProperties; }
            set { this._containerGroupDefinitionProperties = value; }
        }

        // Check to see if ContainerGroupDefinitionProperties property is set
        internal bool IsSetContainerGroupDefinitionProperties()
        {
            return this._containerGroupDefinitionProperties != null && (this._containerGroupDefinitionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerGroupsPerInstance. 
        /// <para>
        /// Details about the number of replica container groups that Amazon GameLift deploys
        /// to each instance in the container fleet.
        /// </para>
        /// </summary>
        public ContainerGroupsPerInstance ContainerGroupsPerInstance
        {
            get { return this._containerGroupsPerInstance; }
            set { this._containerGroupsPerInstance = value; }
        }

        // Check to see if ContainerGroupsPerInstance property is set
        internal bool IsSetContainerGroupsPerInstance()
        {
            return this._containerGroupsPerInstance != null;
        }

    }
}