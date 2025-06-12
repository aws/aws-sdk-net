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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The data for the AI Prompt
    /// </summary>
    public partial class AIPromptData
    {
        private string _aiPromptArn;
        private string _aiPromptId;
        private AIPromptAPIFormat _apiFormat;
        private string _assistantArn;
        private string _assistantId;
        private string _description;
        private string _modelId;
        private DateTime? _modifiedTime;
        private string _name;
        private Origin _origin;
        private Status _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AIPromptTemplateConfiguration _templateConfiguration;
        private AIPromptTemplateType _templateType;
        private AIPromptType _type;
        private VisibilityStatus _visibilityStatus;

        /// <summary>
        /// Gets and sets the property AiPromptArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AiPromptArn
        {
            get { return this._aiPromptArn; }
            set { this._aiPromptArn = value; }
        }

        // Check to see if AiPromptArn property is set
        internal bool IsSetAiPromptArn()
        {
            return this._aiPromptArn != null;
        }

        /// <summary>
        /// Gets and sets the property AiPromptId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect AI prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AiPromptId
        {
            get { return this._aiPromptId; }
            set { this._aiPromptId = value; }
        }

        // Check to see if AiPromptId property is set
        internal bool IsSetAiPromptId()
        {
            return this._aiPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property ApiFormat. 
        /// <para>
        /// The API format used for this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIPromptAPIFormat ApiFormat
        {
            get { return this._apiFormat; }
            set { this._apiFormat = value; }
        }

        // Check to see if ApiFormat property is set
        internal bool IsSetApiFormat()
        {
            return this._apiFormat != null;
        }

        /// <summary>
        /// Gets and sets the property AssistantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q in Connect assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantArn
        {
            get { return this._assistantArn; }
            set { this._assistantArn = value; }
        }

        // Check to see if AssistantArn property is set
        internal bool IsSetAssistantArn()
        {
            return this._assistantArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The identifier of the model used for this AI Prompt. The following model Ids are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>anthropic.claude-3-haiku--v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apac.amazon.nova-lite-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apac.amazon.nova-micro-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apac.amazon.nova-pro-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apac.anthropic.claude-3-5-sonnet--v2:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apac.anthropic.claude-3-haiku-20240307-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu.amazon.nova-lite-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu.amazon.nova-micro-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu.amazon.nova-pro-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu.anthropic.claude-3-7-sonnet-20250219-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu.anthropic.claude-3-haiku-20240307-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us.amazon.nova-lite-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us.amazon.nova-micro-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us.amazon.nova-pro-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us.anthropic.claude-3-5-haiku-20241022-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us.anthropic.claude-3-7-sonnet-20250219-v1:0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us.anthropic.claude-3-haiku-20240307-v1:0</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedTime. 
        /// <para>
        /// The time the AI Prompt was last modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTime
        {
            get { return this._modifiedTime; }
            set { this._modifiedTime = value; }
        }

        // Check to see if ModifiedTime property is set
        internal bool IsSetModifiedTime()
        {
            return this._modifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AI Prompt
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Origin. 
        /// <para>
        /// The origin of the AI Prompt. <c>SYSTEM</c> for a default AI Prompt created by Q in
        /// Connect or <c>CUSTOMER</c> for an AI Prompt created by calling AI Prompt creation
        /// APIs. 
        /// </para>
        /// </summary>
        public Origin Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the AI Prompt.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The configuration of the prompt template for this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIPromptTemplateConfiguration TemplateConfiguration
        {
            get { return this._templateConfiguration; }
            set { this._templateConfiguration = value; }
        }

        // Check to see if TemplateConfiguration property is set
        internal bool IsSetTemplateConfiguration()
        {
            return this._templateConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of the prompt template for this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIPromptTemplateType TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIPromptType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VisibilityStatus. 
        /// <para>
        /// The visibility status of the AI Prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VisibilityStatus VisibilityStatus
        {
            get { return this._visibilityStatus; }
            set { this._visibilityStatus = value; }
        }

        // Check to see if VisibilityStatus property is set
        internal bool IsSetVisibilityStatus()
        {
            return this._visibilityStatus != null;
        }

    }
}