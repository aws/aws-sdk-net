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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains details about the resource being queried.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_RequestSyntax">RetrieveAndGenerate
    /// request</a> – in the <c>retrieveAndGenerateConfiguration</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RetrieveAndGenerateConfiguration
    {
        /// <summary>
        /// Gets and sets the property ExternalSourcesConfiguration. 
        /// <para>
        /// The configuration for the external source wrapper object in the <c>retrieveAndGenerate</c>
        /// function.
        /// </para>
        /// </summary>
        public ExternalSourcesRetrieveAndGenerateConfiguration ExternalSourcesConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExternalSourcesConfiguration property is set.
        /// </summary>
        internal bool IsSetExternalSourcesConfiguration() => this.ExternalSourcesConfiguration != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfiguration. 
        /// <para>
        /// Contains details about the knowledge base for retrieving information and generating
        /// responses.
        /// </para>
        /// </summary>
        public KnowledgeBaseRetrieveAndGenerateConfiguration KnowledgeBaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseConfiguration property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseConfiguration() => this.KnowledgeBaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource that contains your data for retrieving information and generating
        /// responses.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose to use <c>EXTERNAL_SOURCES</c>, then currently only Anthropic Claude
        /// 3 Sonnet models for knowledge bases are supported.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetrieveAndGenerateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
