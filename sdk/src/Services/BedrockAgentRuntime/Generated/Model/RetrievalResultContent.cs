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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// Contains information about a chunk of text from a data source in the knowledge base.
    /// If the result is from a structured data source, the cell in the database and the type
    /// of the value is also identified.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html#API_agent-runtime_Retrieve_ResponseSyntax">Retrieve
    /// response</a> – in the <c>content</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_ResponseSyntax">RetrieveAndGenerate
    /// response</a> – in the <c>content</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_ResponseSyntax">InvokeAgent
    /// response</a> – in the <c>content</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RetrievalResultContent
    {
        private string _byteContent;
        private List<RetrievalResultContentColumn> _row = AWSConfigs.InitializeCollections ? new List<RetrievalResultContentColumn>() : null;
        private string _text;
        private RetrievalResultContentType _type;

        /// <summary>
        /// Gets and sets the property ByteContent. 
        /// <para>
        /// A data URI with base64-encoded content from the data source. The URI is in the following
        /// format: returned in the following format: <c>data:image/jpeg;base64,${base64-encoded
        /// string}</c>.
        /// </para>
        /// </summary>
        public string ByteContent
        {
            get { return this._byteContent; }
            set { this._byteContent = value; }
        }

        // Check to see if ByteContent property is set
        internal bool IsSetByteContent()
        {
            return this._byteContent != null;
        }

        /// <summary>
        /// Gets and sets the property Row. 
        /// <para>
        /// Specifies information about the rows with the cells to return in retrieval.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<RetrievalResultContentColumn> Row
        {
            get { return this._row; }
            set { this._row = value; }
        }

        // Check to see if Row property is set
        internal bool IsSetRow()
        {
            return this._row != null && (this._row.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The cited text from the data source.
        /// </para>
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of content in the retrieval result.
        /// </para>
        /// </summary>
        public RetrievalResultContentType Type
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