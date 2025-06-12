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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Detailed information about the agent.
    /// </summary>
    public partial class AgentDetails
    {
        private List<int> _agentCpuCores = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _agentVersion;
        private List<ComponentVersion> _componentVersions = AWSConfigs.InitializeCollections ? new List<ComponentVersion>() : null;
        private string _instanceId;
        private string _instanceType;
        private List<int> _reservedCpuCores = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property AgentCpuCores. 
        /// <para>
        /// List of CPU cores reserved for the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public List<int> AgentCpuCores
        {
            get { return this._agentCpuCores; }
            set { this._agentCpuCores = value; }
        }

        // Check to see if AgentCpuCores property is set
        internal bool IsSetAgentCpuCores()
        {
            return this._agentCpuCores != null && (this._agentCpuCores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// Current agent version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersions. 
        /// <para>
        /// List of versions being used by agent components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<ComponentVersion> ComponentVersions
        {
            get { return this._componentVersions; }
            set { this._componentVersions = value; }
        }

        // Check to see if ComponentVersions property is set
        internal bool IsSetComponentVersions()
        {
            return this._componentVersions != null && (this._componentVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// ID of EC2 instance agent is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=64)]
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Type of EC2 instance agent is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedCpuCores. <note> 
        /// <para>
        /// This field should not be used. Use agentCpuCores instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// List of CPU cores reserved for processes other than the agent running on the EC2 instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public List<int> ReservedCpuCores
        {
            get { return this._reservedCpuCores; }
            set { this._reservedCpuCores = value; }
        }

        // Check to see if ReservedCpuCores property is set
        internal bool IsSetReservedCpuCores()
        {
            return this._reservedCpuCores != null && (this._reservedCpuCores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}