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
    /// Container for the parameters to the UpdateAgent operation. Updates an existing agent.
    /// </summary>
    public partial class UpdateAgentRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ActionConnectorsToAdd. 
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
        public List<string> ActionConnectorsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActionConnectorsToAdd property is set.
        /// </summary>
        internal bool IsSetActionConnectorsToAdd() => this.ActionConnectorsToAdd != null && (this.ActionConnectorsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ActionConnectorsToRemove. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the action connectors to detach from the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> ActionConnectorsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActionConnectorsToRemove property is set.
        /// </summary>
        internal bool IsSetActionConnectorsToRemove() => this.ActionConnectorsToRemove != null && (this.ActionConnectorsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier for the agent to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

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
        /// Gets and sets the property SpacesToAdd. 
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
        public List<string> SpacesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SpacesToAdd property is set.
        /// </summary>
        internal bool IsSetSpacesToAdd() => this.SpacesToAdd != null && (this.SpacesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpacesToRemove. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the spaces to detach from the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> SpacesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SpacesToRemove property is set.
        /// </summary>
        internal bool IsSetSpacesToRemove() => this.SpacesToRemove != null && (this.SpacesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

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
