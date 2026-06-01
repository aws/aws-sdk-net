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
    /// An agent resource in Amazon QuickSight that provides AI-powered conversational experiences.
    /// </summary>
    public partial class Agent
    {
        private List<string> _actionConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _agentId;
        private AgentLifecycle _agentLifecycle;
        private AgentStatus _agentStatus;
        private string _arn;
        private DateTime? _createdAt;
        private string _creator;
        private CustomPromptInterface _customPromptInterface;
        private string _description;
        private string _errorMessage;
        private string _iconId;
        private string _name;
        private List<string> _spaces = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _starterPrompts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;
        private string _welcomeMessage;

        /// <summary>
        /// Gets and sets the property ActionConnectors. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the action connectors attached to the agent.
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
        /// The unique identifier for the agent.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus AgentStatus
        {
            get { return this._agentStatus; }
            set { this._agentStatus = value; }
        }

        // Check to see if AgentStatus property is set
        internal bool IsSetAgentStatus()
        {
            return this._agentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the agent was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Creator. 
        /// <para>
        /// The identity of the user who created the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Creator
        {
            get { return this._creator; }
            set { this._creator = value; }
        }

        // Check to see if Creator property is set
        internal bool IsSetCreator()
        {
            return this._creator != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPromptInterface. 
        /// <para>
        /// The custom prompt interface configuration for the agent.
        /// </para>
        /// </summary>
        public CustomPromptInterface CustomPromptInterface
        {
            get { return this._customPromptInterface; }
            set { this._customPromptInterface = value; }
        }

        // Check to see if CustomPromptInterface property is set
        internal bool IsSetCustomPromptInterface()
        {
            return this._customPromptInterface != null;
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
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message associated with the agent, if applicable.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
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
        /// The Amazon Resource Names (ARNs) of the spaces attached to the agent.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the agent was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
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