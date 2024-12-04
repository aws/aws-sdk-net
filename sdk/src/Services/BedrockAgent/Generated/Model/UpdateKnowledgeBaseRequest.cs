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
    /// Container for the parameters to the UpdateKnowledgeBase operation.
    /// Updates the configuration of a knowledge base with the fields that you specify. Because
    /// all fields will be overwritten, you must include the same values for fields that you
    /// want to keep the same.
    /// 
    ///  
    /// <para>
    /// You can change the following fields:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>description</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>roleArn</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can't change the <c>knowledgeBaseConfiguration</c> or <c>storageConfiguration</c>
    /// fields, so you must specify the same configurations as when you created the knowledge
    /// base. You can send a <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_GetKnowledgeBase.html">GetKnowledgeBase</a>
    /// request and copy the same configurations.
    /// </para>
    /// </summary>
    public partial class UpdateKnowledgeBaseRequest : AmazonBedrockAgentRequest
    {
        private string _description;
        private KnowledgeBaseConfiguration _knowledgeBaseConfiguration;
        private string _knowledgeBaseId;
        private string _name;
        private string _roleArn;
        private StorageConfiguration _storageConfiguration;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies a new description for the knowledge base.
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
        /// Gets and sets the property KnowledgeBaseConfiguration. 
        /// <para>
        /// Specifies the configuration for the embeddings model used for the knowledge base.
        /// You must use the same configuration as when the knowledge base was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseConfiguration KnowledgeBaseConfiguration
        {
            get { return this._knowledgeBaseConfiguration; }
            set { this._knowledgeBaseConfiguration = value; }
        }

        // Check to see if KnowledgeBaseConfiguration property is set
        internal bool IsSetKnowledgeBaseConfiguration()
        {
            return this._knowledgeBaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies a new name for the knowledge base.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Specifies a different Amazon Resource Name (ARN) of the IAM role with permissions
        /// to invoke API operations on the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Specifies the configuration for the vector store used for the knowledge base. You
        /// must use the same configuration as when the knowledge base was created.
        /// </para>
        /// </summary>
        public StorageConfiguration StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null;
        }

    }
}