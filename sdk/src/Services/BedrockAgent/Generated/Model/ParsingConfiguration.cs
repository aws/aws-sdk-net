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
    /// Settings for parsing document contents. By default, the service converts the contents
    /// of each document into text before splitting it into chunks. To improve processing
    /// of PDF files with tables and images, you can configure the data source to convert
    /// the pages of text into images and use a model to describe the contents of each page.
    /// 
    ///  
    /// <para>
    /// To use a model to parse PDF documents, set the parsing strategy to <c>BEDROCK_FOUNDATION_MODEL</c>
    /// and specify the model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
    /// profile</a> to use by ARN. You can also override the default parsing prompt with instructions
    /// for how to interpret images and tables in your documents. The following models are
    /// supported.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Anthropic Claude 3 Sonnet - <c>anthropic.claude-3-sonnet-20240229-v1:0</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Anthropic Claude 3 Haiku - <c>anthropic.claude-3-haiku-20240307-v1:0</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can get the ARN of a model with the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListFoundationModels.html">ListFoundationModels</a>
    /// action. Standard model usage charges apply for the foundation model parsing strategy.
    /// </para>
    /// </summary>
    public partial class ParsingConfiguration
    {
        private BedrockFoundationModelConfiguration _bedrockFoundationModelConfiguration;
        private ParsingStrategy _parsingStrategy;

        /// <summary>
        /// Gets and sets the property BedrockFoundationModelConfiguration. 
        /// <para>
        /// Settings for a foundation model used to parse documents for a data source.
        /// </para>
        /// </summary>
        public BedrockFoundationModelConfiguration BedrockFoundationModelConfiguration
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
        /// Gets and sets the property ParsingStrategy. 
        /// <para>
        /// The parsing strategy for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParsingStrategy ParsingStrategy
        {
            get { return this._parsingStrategy; }
            set { this._parsingStrategy = value; }
        }

        // Check to see if ParsingStrategy property is set
        internal bool IsSetParsingStrategy()
        {
            return this._parsingStrategy != null;
        }

    }
}