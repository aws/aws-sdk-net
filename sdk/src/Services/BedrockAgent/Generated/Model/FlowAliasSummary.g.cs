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
    /// Contains information about an alias of a flow.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_ListFlowAliases.html#API_agent_ListFlowAliases_ResponseSyntax">ListFlowAliases
    /// response</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class FlowAliasSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConcurrencyConfiguration. 
        /// <para>
        /// The configuration that specifies how nodes in the flow are executed concurrently.
        /// </para>
        /// </summary>
        public FlowAliasConcurrencyConfiguration ConcurrencyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrencyConfiguration property is set.
        /// </summary>
        internal bool IsSetConcurrencyConfiguration() => this.ConcurrencyConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the alias was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowId { get; set; }

        /// <summary>
        /// Checks to see if the FlowId property is set.
        /// </summary>
        internal bool IsSetFlowId() => this.FlowId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the alias of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alias.
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
        /// A list of configurations about the versions that the alias maps to. Currently, you
        /// can only specify one.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the alias was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
