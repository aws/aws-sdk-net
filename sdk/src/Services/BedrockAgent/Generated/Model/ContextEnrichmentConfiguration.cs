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
    /// Context enrichment configuration is used to provide additional context to the RAG
    /// application.
    /// </summary>
    public partial class ContextEnrichmentConfiguration
    {
        private BedrockFoundationModelContextEnrichmentConfiguration _bedrockFoundationModelConfiguration;
        private ContextEnrichmentType _type;

        /// <summary>
        /// Gets and sets the property BedrockFoundationModelConfiguration. 
        /// <para>
        /// The configuration of the Amazon Bedrock foundation model used for context enrichment.
        /// </para>
        /// </summary>
        public BedrockFoundationModelContextEnrichmentConfiguration BedrockFoundationModelConfiguration
        {
            get { return this._bedrockFoundationModelConfiguration; }
            set { this._bedrockFoundationModelConfiguration = value; }
        }

        // Check to see if BedrockFoundationModelConfiguration property is set
        internal bool IsSetBedrockFoundationModelConfiguration()
        {
            return this._bedrockFoundationModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The method used for context enrichment. It must be Amazon Bedrock foundation models.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContextEnrichmentType Type
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