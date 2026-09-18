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
        public string CanonicalId { get; set; }

        /// <summary>
        /// Checks to see if the CanonicalId property is set.
        /// </summary>
        internal bool IsSetCanonicalId() => this.CanonicalId != null;

        /// <summary>
        /// Gets and sets the property HostResourceGuid. 
        /// <para>
        /// The identifier of the host resource that hosts the self-hosted AI resource. Present
        /// only on self-hosted AI resources.
        /// </para>
        /// </summary>
        public string HostResourceGuid { get; set; }

        /// <summary>
        /// Checks to see if the HostResourceGuid property is set.
        /// </summary>
        internal bool IsSetHostResourceGuid() => this.HostResourceGuid != null;

        /// <summary>
        /// Gets and sets the property HostResourceType. 
        /// <para>
        /// The <c>ResourceType</c> of the host resource that hosts the self-hosted AI resource,
        /// such as <c>AWS::EC2::Instance</c>. Present only on self-hosted AI resources.
        /// </para>
        /// </summary>
        public string HostResourceType { get; set; }

        /// <summary>
        /// Checks to see if the HostResourceType property is set.
        /// </summary>
        internal bool IsSetHostResourceType() => this.HostResourceType != null;

        /// <summary>
        /// Gets and sets the property SelfHostedAIAgentFrameworkResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>AgentFramework</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIAgentFrameworkResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedAIAgentFrameworkResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedAIAgentFrameworkResourceCount() => this.SelfHostedAIAgentFrameworkResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelfHostedAIAgentResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>Agent</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIAgentResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedAIAgentResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedAIAgentResourceCount() => this.SelfHostedAIAgentResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelfHostedAIAgentToolsAndIdentityResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>AgentToolsAndIdentity</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIAgentToolsAndIdentityResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedAIAgentToolsAndIdentityResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedAIAgentToolsAndIdentityResourceCount() => this.SelfHostedAIAgentToolsAndIdentityResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelfHostedAIDevelopmentResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>Development</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIDevelopmentResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedAIDevelopmentResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedAIDevelopmentResourceCount() => this.SelfHostedAIDevelopmentResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelfHostedAIExternalEndpointResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>ExternalEndpoint</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIExternalEndpointResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedAIExternalEndpointResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedAIExternalEndpointResourceCount() => this.SelfHostedAIExternalEndpointResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelfHostedAIModelResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>Model</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIModelResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedAIModelResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedAIModelResourceCount() => this.SelfHostedAIModelResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelfHostedAIModelServingResourceCount. 
        /// <para>
        /// The number of self-hosted AI resources of <c>ResourceSubCategory</c> <c>ModelServing</c>
        /// detected on the host resource. Present only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedAIModelServingResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedAIModelServingResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedAIModelServingResourceCount() => this.SelfHostedAIModelServingResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelfHostedTotalAIResourceCount. 
        /// <para>
        /// The total number of all self-hosted AI resources detected on the host resource. Present
        /// only on host resources.
        /// </para>
        /// </summary>
        public int? SelfHostedTotalAIResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelfHostedTotalAIResourceCount property is set.
        /// </summary>
        internal bool IsSetSelfHostedTotalAIResourceCount() => this.SelfHostedTotalAIResourceCount.HasValue;
    }
}
