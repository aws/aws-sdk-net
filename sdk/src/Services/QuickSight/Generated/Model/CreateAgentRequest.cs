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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Container for the parameters to the CreateAgent operation.
    /// Creates an agent in Amazon QuickSight.
    /// </summary>
    public partial class CreateAgentRequest : AmazonQuickSightRequest
    {
        private List<string> _actionConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _agentId;
        private AgentLifecycle _agentLifecycle;
        private string _awsAccountId;
        private CustomPromptInput _customPromptInput;
        private string _description;
        private string _iconId;
        private string _name;
        private List<string> _spaces = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _starterPrompts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _welcomeMessage;

        /// <summary>
        /// Gets and sets the property ActionConnectors. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the action connectors to attach to the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ActionConnectors
        {
            get { return this._actionConnectors; }
            set { this._actionConnectors = value; }
        }

        // Check to see if ActionConnectors property is set
        internal bool IsSetActionConnectors()
        {
            return this._actionConnectors != null && (this._actionConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// A unique identifier for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentLifecycle. 
        /// <para>
        /// The lifecycle state of the agent. Valid values are <c>PREVIEW</c> and <c>PUBLISHED</c>.
        /// </para>
        /// </summary>
        public AgentLifecycle AgentLifecycle
        {
            get { return this._agentLifecycle; }
            set { this._agentLifecycle = value; }
        }

        // Check to see if AgentLifecycle property is set
        internal bool IsSetAgentLifecycle()
        {
            return this._agentLifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPromptInput. 
        /// <para>
        /// The custom prompt configuration for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public CustomPromptInput CustomPromptInput
        {
            get { return this._customPromptInput; }
            set { this._customPromptInput = value; }
        }

        // Check to see if CustomPromptInput property is set
        internal bool IsSetCustomPromptInput()
        {
            return this._customPromptInput != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property IconId. 
        /// <para>
        /// The icon identifier for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string IconId
        {
            get { return this._iconId; }
            set { this._iconId = value; }
        }

        // Check to see if IconId property is set
        internal bool IsSetIconId()
        {
            return this._iconId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property Spaces. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the spaces to attach to the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Spaces
        {
            get { return this._spaces; }
            set { this._spaces = value; }
        }

        // Check to see if Spaces property is set
        internal bool IsSetSpaces()
        {
            return this._spaces != null && (this._spaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StarterPrompts. 
        /// <para>
        /// A list of starter prompts that are displayed to users when they begin interacting
        /// with the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=3)]
        public List<string> StarterPrompts
        {
            get { return this._starterPrompts; }
            set { this._starterPrompts = value; }
        }

        // Check to see if StarterPrompts property is set
        internal bool IsSetStarterPrompts()
        {
            return this._starterPrompts != null && (this._starterPrompts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WelcomeMessage. 
        /// <para>
        /// The welcome message that is displayed when a user starts a conversation with the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=300)]
        public string WelcomeMessage
        {
            get { return this._welcomeMessage; }
            set { this._welcomeMessage = value; }
        }

        // Check to see if WelcomeMessage property is set
        internal bool IsSetWelcomeMessage()
        {
            return this._welcomeMessage != null;
        }

    }
}