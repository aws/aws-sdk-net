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
    /// The assistant data.
    /// </summary>
    public partial class AssistantData
    {
        private Dictionary<string, AIAgentConfigurationData> _aiAgentConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, AIAgentConfigurationData>() : null;
        private string _assistantArn;
        private string _assistantId;
        private AssistantCapabilityConfiguration _capabilityConfiguration;
        private string _description;
        private AssistantIntegrationConfiguration _integrationConfiguration;
        private string _name;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private AssistantStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AssistantType _type;

        /// <summary>
        /// Gets and sets the property AiAgentConfiguration. 
        /// <para>
        /// The configuration of the AI Agents (mapped by AI Agent Type to AI Agent version) that
        /// is set on the Amazon Q in Connect Assistant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AIAgentConfigurationData> AiAgentConfiguration
        {
            get { return this._aiAgentConfiguration; }
            set { this._aiAgentConfiguration = value; }
        }

        // Check to see if AiAgentConfiguration property is set
        internal bool IsSetAiAgentConfiguration()
        {
            return this._aiAgentConfiguration != null && (this._aiAgentConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The identifier of the Amazon Q in Connect assistant.
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
        /// Gets and sets the property CapabilityConfiguration. 
        /// <para>
        /// The configuration information for the Amazon Q in Connect assistant capability. 
        /// </para>
        /// </summary>
        public AssistantCapabilityConfiguration CapabilityConfiguration
        {
            get { return this._capabilityConfiguration; }
            set { this._capabilityConfiguration = value; }
        }

        // Check to see if CapabilityConfiguration property is set
        internal bool IsSetCapabilityConfiguration()
        {
            return this._capabilityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
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
        /// Gets and sets the property IntegrationConfiguration. 
        /// <para>
        /// The configuration information for the Amazon Q in Connect assistant integration.
        /// </para>
        /// </summary>
        public AssistantIntegrationConfiguration IntegrationConfiguration
        {
            get { return this._integrationConfiguration; }
            set { this._integrationConfiguration = value; }
        }

        // Check to see if IntegrationConfiguration property is set
        internal bool IsSetIntegrationConfiguration()
        {
            return this._integrationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name.
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
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The configuration information for the customer managed key used for encryption. 
        /// </para>
        ///  
        /// <para>
        /// This KMS key must have a policy that allows <c>kms:CreateGrant</c>, <c>kms:DescribeKey</c>,
        /// <c>kms:Decrypt</c>, and <c>kms:GenerateDataKey*</c> permissions to the IAM identity
        /// using the key to invoke Amazon Q in Connect. To use Amazon Q in Connect with chat,
        /// the key policy must also allow <c>kms:Decrypt</c>, <c>kms:GenerateDataKey*</c>, and
        /// <c>kms:DescribeKey</c> permissions to the <c>connect.amazonaws.com</c> service principal.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about setting up a customer managed key for Amazon Q in Connect,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-q.html">Enable
        /// Amazon Q in Connect for your instance</a>.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssistantStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssistantType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}