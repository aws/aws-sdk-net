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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAgent operation. Creates an agent in Amazon
    /// QuickSight.
    /// </summary>
    public partial class CreateAgentRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ActionConnectors. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the action connectors to attach to the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> ActionConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActionConnectors property is set.
        /// </summary>
        internal bool IsSetActionConnectors() => this.ActionConnectors != null && (this.ActionConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// A unique identifier for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentLifecycle. 
        /// <para>
        /// The lifecycle state of the agent. Valid values are <c>PREVIEW</c> and <c>PUBLISHED</c>.
        /// </para>
        /// </summary>
        public AgentLifecycle AgentLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the AgentLifecycle property is set.
        /// </summary>
        internal bool IsSetAgentLifecycle() => this.AgentLifecycle != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CustomPromptInput. 
        /// <para>
        /// The custom prompt configuration for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public CustomPromptInput CustomPromptInput { get; set; }

        /// <summary>
        /// Checks to see if the CustomPromptInput property is set.
        /// </summary>
        internal bool IsSetCustomPromptInput() => this.CustomPromptInput != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IconId. 
        /// <para>
        /// The icon identifier for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string IconId { get; set; }

        /// <summary>
        /// Checks to see if the IconId property is set.
        /// </summary>
        internal bool IsSetIconId() => this.IconId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Spaces. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the spaces to attach to the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> Spaces { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Spaces property is set.
        /// </summary>
        internal bool IsSetSpaces() => this.Spaces != null && (this.Spaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StarterPrompts. 
        /// <para>
        /// A list of starter prompts that are displayed to users when they begin interacting
        /// with the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 3)]
        public List<string> StarterPrompts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StarterPrompts property is set.
        /// </summary>
        internal bool IsSetStarterPrompts() => this.StarterPrompts != null && (this.StarterPrompts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WelcomeMessage. 
        /// <para>
        /// The welcome message that is displayed when a user starts a conversation with the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 300)]
        public string WelcomeMessage { get; set; }

        /// <summary>
        /// Checks to see if the WelcomeMessage property is set.
        /// </summary>
        internal bool IsSetWelcomeMessage() => this.WelcomeMessage != null;
    }
}
