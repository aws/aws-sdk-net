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
    /// Contains details about the vector embeddings configuration of the knowledge base.
    /// </summary>
    public partial class KnowledgeBaseConfiguration
    {
        private KendraKnowledgeBaseConfiguration _kendraKnowledgeBaseConfiguration;
        private SqlKnowledgeBaseConfiguration _sqlKnowledgeBaseConfiguration;
        private KnowledgeBaseType _type;
        private VectorKnowledgeBaseConfiguration _vectorKnowledgeBaseConfiguration;

        /// <summary>
        /// Gets and sets the property KendraKnowledgeBaseConfiguration. 
        /// <para>
        /// Settings for an Amazon Kendra knowledge base.
        /// </para>
        /// </summary>
        public KendraKnowledgeBaseConfiguration KendraKnowledgeBaseConfiguration
        {
            get { return this._kendraKnowledgeBaseConfiguration; }
            set { this._kendraKnowledgeBaseConfiguration = value; }
        }

        // Check to see if KendraKnowledgeBaseConfiguration property is set
        internal bool IsSetKendraKnowledgeBaseConfiguration()
        {
            return this._kendraKnowledgeBaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqlKnowledgeBaseConfiguration. 
        /// <para>
        /// Specifies configurations for a knowledge base connected to an SQL database.
        /// </para>
        /// </summary>
        public SqlKnowledgeBaseConfiguration SqlKnowledgeBaseConfiguration
        {
            get { return this._sqlKnowledgeBaseConfiguration; }
            set { this._sqlKnowledgeBaseConfiguration = value; }
        }

        // Check to see if SqlKnowledgeBaseConfiguration property is set
        internal bool IsSetSqlKnowledgeBaseConfiguration()
        {
            return this._sqlKnowledgeBaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data that the data source is converted into for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseType Type
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
        /// Gets and sets the property VectorKnowledgeBaseConfiguration. 
        /// <para>
        /// Contains details about the model that's used to convert the data source into vector
        /// embeddings.
        /// </para>
        /// </summary>
        public VectorKnowledgeBaseConfiguration VectorKnowledgeBaseConfiguration
        {
            get { return this._vectorKnowledgeBaseConfiguration; }
            set { this._vectorKnowledgeBaseConfiguration = value; }
        }

        // Check to see if VectorKnowledgeBaseConfiguration property is set
        internal bool IsSetVectorKnowledgeBaseConfiguration()
        {
            return this._vectorKnowledgeBaseConfiguration != null;
        }

    }
}