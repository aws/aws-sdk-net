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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about the vector embeddings configuration of the knowledge base.
    /// </summary>
    public partial class KnowledgeBaseConfiguration
    {
        /// <summary>
        /// Gets and sets the property KendraKnowledgeBaseConfiguration. 
        /// <para>
        /// Settings for an Amazon Kendra knowledge base.
        /// </para>
        /// </summary>
        public KendraKnowledgeBaseConfiguration KendraKnowledgeBaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KendraKnowledgeBaseConfiguration property is set.
        /// </summary>
        internal bool IsSetKendraKnowledgeBaseConfiguration() => this.KendraKnowledgeBaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManagedKnowledgeBaseConfiguration. 
        /// <para>
        /// Contains configuration details for a knowledge base that uses a vector store fully
        /// managed by Amazon Bedrock. Specify this object when the knowledge base type is MANAGED.
        /// </para>
        /// </summary>
        public ManagedKnowledgeBaseConfiguration ManagedKnowledgeBaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedKnowledgeBaseConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedKnowledgeBaseConfiguration() => this.ManagedKnowledgeBaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property SqlKnowledgeBaseConfiguration. 
        /// <para>
        /// Specifies configurations for a knowledge base connected to an SQL database.
        /// </para>
        /// </summary>
        public SqlKnowledgeBaseConfiguration SqlKnowledgeBaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SqlKnowledgeBaseConfiguration property is set.
        /// </summary>
        internal bool IsSetSqlKnowledgeBaseConfiguration() => this.SqlKnowledgeBaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data that the data source is converted into for the knowledge base. Choose
        /// <c>MANAGED</c> to create a managed knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VectorKnowledgeBaseConfiguration. 
        /// <para>
        /// Contains details about the model that's used to convert the data source into vector
        /// embeddings.
        /// </para>
        /// </summary>
        public VectorKnowledgeBaseConfiguration VectorKnowledgeBaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VectorKnowledgeBaseConfiguration property is set.
        /// </summary>
        internal bool IsSetVectorKnowledgeBaseConfiguration() => this.VectorKnowledgeBaseConfiguration != null;
    }
}
