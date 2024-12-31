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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The configuration details for retrieving information from a knowledge base.
    /// </summary>
    public partial class RetrieveConfig
    {
        private string _knowledgeBaseId;
        private KnowledgeBaseRetrievalConfiguration _knowledgeBaseRetrievalConfiguration;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
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
        /// Gets and sets the property KnowledgeBaseRetrievalConfiguration. 
        /// <para>
        /// Contains configuration details for knowledge base retrieval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseRetrievalConfiguration KnowledgeBaseRetrievalConfiguration
        {
            get { return this._knowledgeBaseRetrievalConfiguration; }
            set { this._knowledgeBaseRetrievalConfiguration = value; }
        }

        // Check to see if KnowledgeBaseRetrievalConfiguration property is set
        internal bool IsSetKnowledgeBaseRetrievalConfiguration()
        {
            return this._knowledgeBaseRetrievalConfiguration != null;
        }

    }
}