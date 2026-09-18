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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFlowAlias operation. Creates an alias of
    /// a flow for deployment. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
    /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class CreateFlowAliasRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConcurrencyConfiguration. 
        /// <para>
        /// The configuration that specifies how nodes in the flow are executed in parallel.
        /// </para>
        /// </summary>
        public FlowAliasConcurrencyConfiguration ConcurrencyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrencyConfiguration property is set.
        /// </summary>
        internal bool IsSetConcurrencyConfiguration() => this.ConcurrencyConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow for which to create an alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowIdentifier() => this.FlowIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoutingConfiguration. 
        /// <para>
        /// Contains information about the version to which to map the alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<FlowAliasRoutingConfigurationListItem> RoutingConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<FlowAliasRoutingConfigurationListItem>() : null;

        /// <summary>
        /// Checks to see if the RoutingConfiguration property is set.
        /// </summary>
        internal bool IsSetRoutingConfiguration() => this.RoutingConfiguration != null && (this.RoutingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags that you want to attach to the alias of the flow. For more information, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tagging.html">Tagging
        /// resources in Amazon Bedrock</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
