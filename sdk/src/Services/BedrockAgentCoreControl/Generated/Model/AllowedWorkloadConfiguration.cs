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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration that restricts which workloads in the request's identity chain are
    /// allowed to invoke the target, identified by their hosting environments and workload
    /// identities. At launch, this is supported only for AgentCore Runtime targets, and the
    /// allowed workloads are AgentCore Gateways.
    /// </summary>
    public partial class AllowedWorkloadConfiguration
    {
        private List<HostingEnvironment> _hostingEnvironments = AWSConfigs.InitializeCollections ? new List<HostingEnvironment>() : null;
        private List<string> _workloadIdentities = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property HostingEnvironments. 
        /// <para>
        /// The list of hosting environments whose workloads are allowed to invoke the target.
        /// At launch, the only supported hosting environment is AgentCore Gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<HostingEnvironment> HostingEnvironments
        {
            get { return this._hostingEnvironments; }
            set { this._hostingEnvironments = value; }
        }

        // Check to see if HostingEnvironments property is set
        internal bool IsSetHostingEnvironments()
        {
            return this._hostingEnvironments != null && (this._hostingEnvironments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentities. 
        /// <para>
        /// The list of workload identities that are allowed to invoke the target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> WorkloadIdentities
        {
            get { return this._workloadIdentities; }
            set { this._workloadIdentities = value; }
        }

        // Check to see if WorkloadIdentities property is set
        internal bool IsSetWorkloadIdentities()
        {
            return this._workloadIdentities != null && (this._workloadIdentities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}