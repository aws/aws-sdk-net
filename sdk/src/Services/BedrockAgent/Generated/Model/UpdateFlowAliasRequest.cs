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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Container for the parameters to the UpdateFlowAlias operation.
    /// Modifies the alias of a flow. Include both fields that you want to keep and ones that
    /// you want to change. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
    /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class UpdateFlowAliasRequest : AmazonBedrockAgentRequest
    {
        private string _aliasIdentifier;
        private FlowAliasConcurrencyConfiguration _concurrencyConfiguration;
        private string _description;
        private string _flowIdentifier;
        private string _name;
        private List<FlowAliasRoutingConfigurationListItem> _routingConfiguration = AWSConfigs.InitializeCollections ? new List<FlowAliasRoutingConfigurationListItem>() : null;

        /// <summary>
        /// Gets and sets the property AliasIdentifier. 
        /// <para>
        /// The unique identifier of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AliasIdentifier
        {
            get { return this._aliasIdentifier; }
            set { this._aliasIdentifier = value; }
        }

        // Check to see if AliasIdentifier property is set
        internal bool IsSetAliasIdentifier()
        {
            return this._aliasIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ConcurrencyConfiguration. 
        /// <para>
        /// The configuration that specifies how nodes in the flow are executed in parallel.
        /// </para>
        /// </summary>
        public FlowAliasConcurrencyConfiguration ConcurrencyConfiguration
        {
            get { return this._concurrencyConfiguration; }
            set { this._concurrencyConfiguration = value; }
        }

        // Check to see if ConcurrencyConfiguration property is set
        internal bool IsSetConcurrencyConfiguration()
        {
            return this._concurrencyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowIdentifier
        {
            get { return this._flowIdentifier; }
            set { this._flowIdentifier = value; }
        }

        // Check to see if FlowIdentifier property is set
        internal bool IsSetFlowIdentifier()
        {
            return this._flowIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingConfiguration. 
        /// <para>
        /// Contains information about the version to which to map the alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<FlowAliasRoutingConfigurationListItem> RoutingConfiguration
        {
            get { return this._routingConfiguration; }
            set { this._routingConfiguration = value; }
        }

        // Check to see if RoutingConfiguration property is set
        internal bool IsSetRoutingConfiguration()
        {
            return this._routingConfiguration != null && (this._routingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}