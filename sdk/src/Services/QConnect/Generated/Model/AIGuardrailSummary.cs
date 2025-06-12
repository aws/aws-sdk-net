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
    /// The summary of the AI Guardrail.
    /// </summary>
    public partial class AIGuardrailSummary
    {
        private string _aiGuardrailArn;
        private string _aiGuardrailId;
        private string _assistantArn;
        private string _assistantId;
        private string _description;
        private DateTime? _modifiedTime;
        private string _name;
        private Status _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VisibilityStatus _visibilityStatus;

        /// <summary>
        /// Gets and sets the property AiGuardrailArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AiGuardrailArn
        {
            get { return this._aiGuardrailArn; }
            set { this._aiGuardrailArn = value; }
        }

        // Check to see if AiGuardrailArn property is set
        internal bool IsSetAiGuardrailArn()
        {
            return this._aiGuardrailArn != null;
        }

        /// <summary>
        /// Gets and sets the property AiGuardrailId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AiGuardrailId
        {
            get { return this._aiGuardrailId; }
            set { this._aiGuardrailId = value; }
        }

        // Check to see if AiGuardrailId property is set
        internal bool IsSetAiGuardrailId()
        {
            return this._aiGuardrailId != null;
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
        /// A description of the AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
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
        /// Gets and sets the property ModifiedTime. 
        /// <para>
        /// The time the AI Guardrail was last modified.
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
        /// The name of the AI Guardrail.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the AI Guardrail.
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
        /// Gets and sets the property VisibilityStatus. 
        /// <para>
        /// The visibility status of the AI Guardrail.
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