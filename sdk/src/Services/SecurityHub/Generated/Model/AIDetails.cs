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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about self-hosted AI resources and their host resources. The
    /// fields that are present depend on the role of the resource.
    /// 
    ///  
    /// <para>
    /// On a self-hosted AI resource (a resource with a <c>SelfHosted::AI::</c> resource type,
    /// such as <c>SelfHosted::AI::Model</c> or <c>SelfHosted::AI::Agent</c>), the <c>HostResourceGuid</c>
    /// and <c>HostResourceType</c> fields link the resource to its host. The <c>CanonicalId</c>
    /// field identifies what the resource is, enabling aggregation of identical resources
    /// across multiple hosts.
    /// </para>
    ///  
    /// <para>
    /// On a host resource (such as an Amazon EC2 instance), the <c>SelfHostedAI*ResourceCount</c>
    /// fields contain the count for each <c>ResourceSubCategory</c> and the total count of
    /// self-hosted AI resources detected on the host.
    /// </para>
    /// </summary>
    public partial class AIDetails
    {
        private string _canonicalId;
        private string _hostResourceGuid;
        private string _hostResourceType;
        private int? _selfHostedAIAgentFrameworkResourceCount;
        private int? _selfHostedAIAgentResourceCount;
        private int? _selfHostedAIAgentToolsAndIdentityResourceCount;
        private int? _selfHostedAIDevelopmentResourceCount;
        private int? _selfHostedAIExternalEndpointResourceCount;
        private int? _selfHostedAIModelResourceCount;
        private int? _selfHostedAIModelServingResourceCount;
        private int? _selfHostedTotalAIResourceCount;

        /// <summary>
        /// Gets and sets the property CanonicalId. 
        /// <para>
        /// The canonical identifier for the AI resource, independent of where it is deployed.
        /// Multiple occurrences of the same resource on different hosts share the same <c>CanonicalId</c>.
        /// For model resources, the value follows the format <c>model/&lt;purl&gt;</c>, such
        /// as <c>model/pkg:huggingface/meta-llama/llama-3-8b</c>. Present only on self-hosted
        /// AI resources.
        /// </para>
        /// </summary>
        public string CanonicalId
        {
            get { return this._canonicalId; }
            set { this._canonicalId = value; }
        }

        // Check to see if CanonicalId property is set
        internal bool IsSetCanonicalId()
        {
            return this._canonicalId != null;
        }

        /// <summary>
        /// Gets and sets the property HostResourceGuid. 
        /// <para>
        /// The identifier of the host resource that hosts the self-hosted AI resource. Present
        /// only on self-hosted AI resources.
        /// </para>
        /// </summary>
        public string HostResourceGuid
        {
            get { return this._hostResourceGuid; }
            set { this._hostResourceGuid = value; }
        }

        // Check to see if HostResourceGuid property is set
        internal bool IsSetHostResourceGuid()
        {
            return this._hostResourceGuid != null;
        }

        /// <summary>
        /// Gets and sets the property HostResourceType. 
        /// <para>
        /// The <c>ResourceType</c> of the host resource that hosts the self-hosted AI resource,
        /// such as <c>AWS::EC2::Instance</c>. Present only on self-hosted AI resources.
        /// </para>
        /// </summary>
        public string HostResourceType
        {
            get { return this._hostResourceType; }
            set { this._hostResourceType = value; }
        }

        // Check to see if HostResourceType property is set
        internal bool IsSetHostResourceType()
        {
            return this._hostResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SelfHostedAIAgentFrameworkResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>AgentFramework</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIAgentFrameworkResourceCount
        {
            get { return this._selfHostedAIAgentFrameworkResourceCount; }
            set { this._selfHostedAIAgentFrameworkResourceCount = value; }
        }

        // Check to see if SelfHostedAIAgentFrameworkResourceCount property is set
        internal bool IsSetSelfHostedAIAgentFrameworkResourceCount()
        {
            return this._selfHostedAIAgentFrameworkResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelfHostedAIAgentResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>Agent</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIAgentResourceCount
        {
            get { return this._selfHostedAIAgentResourceCount; }
            set { this._selfHostedAIAgentResourceCount = value; }
        }

        // Check to see if SelfHostedAIAgentResourceCount property is set
        internal bool IsSetSelfHostedAIAgentResourceCount()
        {
            return this._selfHostedAIAgentResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelfHostedAIAgentToolsAndIdentityResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>AgentToolsAndIdentity</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIAgentToolsAndIdentityResourceCount
        {
            get { return this._selfHostedAIAgentToolsAndIdentityResourceCount; }
            set { this._selfHostedAIAgentToolsAndIdentityResourceCount = value; }
        }

        // Check to see if SelfHostedAIAgentToolsAndIdentityResourceCount property is set
        internal bool IsSetSelfHostedAIAgentToolsAndIdentityResourceCount()
        {
            return this._selfHostedAIAgentToolsAndIdentityResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelfHostedAIDevelopmentResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>Development</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIDevelopmentResourceCount
        {
            get { return this._selfHostedAIDevelopmentResourceCount; }
            set { this._selfHostedAIDevelopmentResourceCount = value; }
        }

        // Check to see if SelfHostedAIDevelopmentResourceCount property is set
        internal bool IsSetSelfHostedAIDevelopmentResourceCount()
        {
            return this._selfHostedAIDevelopmentResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelfHostedAIExternalEndpointResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>ExternalEndpoint</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIExternalEndpointResourceCount
        {
            get { return this._selfHostedAIExternalEndpointResourceCount; }
            set { this._selfHostedAIExternalEndpointResourceCount = value; }
        }

        // Check to see if SelfHostedAIExternalEndpointResourceCount property is set
        internal bool IsSetSelfHostedAIExternalEndpointResourceCount()
        {
            return this._selfHostedAIExternalEndpointResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelfHostedAIModelResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>Model</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIModelResourceCount
        {
            get { return this._selfHostedAIModelResourceCount; }
            set { this._selfHostedAIModelResourceCount = value; }
        }

        // Check to see if SelfHostedAIModelResourceCount property is set
        internal bool IsSetSelfHostedAIModelResourceCount()
        {
            return this._selfHostedAIModelResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelfHostedAIModelServingResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>ModelServing</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIModelServingResourceCount
        {
            get { return this._selfHostedAIModelServingResourceCount; }
            set { this._selfHostedAIModelServingResourceCount = value; }
        }

        // Check to see if SelfHostedAIModelServingResourceCount property is set
        internal bool IsSetSelfHostedAIModelServingResourceCount()
        {
            return this._selfHostedAIModelServingResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelfHostedTotalAIResourceCount. 
        /// <para>
        /// The total number of all self-hosted AI resources detected on the host resource. Present
        /// only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedTotalAIResourceCount
        {
            get { return this._selfHostedTotalAIResourceCount; }
            set { this._selfHostedTotalAIResourceCount = value; }
        }

        // Check to see if SelfHostedTotalAIResourceCount property is set
        internal bool IsSetSelfHostedTotalAIResourceCount()
        {
            return this._selfHostedTotalAIResourceCount.HasValue; 
        }

    }
}