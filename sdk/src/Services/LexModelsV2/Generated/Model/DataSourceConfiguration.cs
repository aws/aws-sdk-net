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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains details about the configuration of the knowledge store used for the <c>AMAZON.QnAIntent</c>.
    /// You must have already created the knowledge store and indexed the documents within
    /// it.
    /// </summary>
    public partial class DataSourceConfiguration
    {
        private BedrockKnowledgeStoreConfiguration _bedrockKnowledgeStoreConfiguration;
        private QnAKendraConfiguration _kendraConfiguration;
        private OpensearchConfiguration _opensearchConfiguration;

        /// <summary>
        /// Gets and sets the property BedrockKnowledgeStoreConfiguration. 
        /// <para>
        /// Contains details about the configuration of the Amazon Bedrock knowledge base used
        /// for the <c>AMAZON.QnAIntent</c>. To set up a knowledge base, follow the steps at <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base.html">Building
        /// a knowledge base</a>.
        /// </para>
        /// </summary>
        public BedrockKnowledgeStoreConfiguration BedrockKnowledgeStoreConfiguration
        {
            get { return this._bedrockKnowledgeStoreConfiguration; }
            set { this._bedrockKnowledgeStoreConfiguration = value; }
        }

        // Check to see if BedrockKnowledgeStoreConfiguration property is set
        internal bool IsSetBedrockKnowledgeStoreConfiguration()
        {
            return this._bedrockKnowledgeStoreConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KendraConfiguration. 
        /// <para>
        /// Contains details about the configuration of the Amazon Kendra index used for the <c>AMAZON.QnAIntent</c>.
        /// To create a Amazon Kendra index, follow the steps at <a href="https://docs.aws.amazon.com/kendra/latest/dg/create-index.html">Creating
        /// an index</a>.
        /// </para>
        /// </summary>
        public QnAKendraConfiguration KendraConfiguration
        {
            get { return this._kendraConfiguration; }
            set { this._kendraConfiguration = value; }
        }

        // Check to see if KendraConfiguration property is set
        internal bool IsSetKendraConfiguration()
        {
            return this._kendraConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OpensearchConfiguration. 
        /// <para>
        /// Contains details about the configuration of the Amazon OpenSearch Service database
        /// used for the <c>AMAZON.QnAIntent</c>. To create a domain, follow the steps at <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html">Creating
        /// and managing Amazon OpenSearch Service domains</a>.
        /// </para>
        /// </summary>
        public OpensearchConfiguration OpensearchConfiguration
        {
            get { return this._opensearchConfiguration; }
            set { this._opensearchConfiguration = value; }
        }

        // Check to see if OpensearchConfiguration property is set
        internal bool IsSetOpensearchConfiguration()
        {
            return this._opensearchConfiguration != null;
        }

    }
}