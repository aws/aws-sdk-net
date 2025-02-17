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
    /// Settings for parsing document contents. If you exclude this field, the default parser
    /// converts the contents of each document into text before splitting it into chunks.
    /// Specify the parsing strategy to use in the <c>parsingStrategy</c> field and include
    /// the relevant configuration, or omit it to use the Amazon Bedrock default parser. For
    /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-advanced-parsing.html">Parsing
    /// options for your data source</a>.
    /// 
    ///  <note> 
    /// <para>
    /// If you specify <c>BEDROCK_DATA_AUTOMATION</c> or <c>BEDROCK_FOUNDATION_MODEL</c> and
    /// it fails to parse a file, the Amazon Bedrock default parser will be used instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ParsingConfiguration
    {
        private BedrockDataAutomationConfiguration _bedrockDataAutomationConfiguration;
        private BedrockFoundationModelConfiguration _bedrockFoundationModelConfiguration;
        private ParsingStrategy _parsingStrategy;

        /// <summary>
        /// Gets and sets the property BedrockDataAutomationConfiguration. 
        /// <para>
        /// If you specify <c>BEDROCK_DATA_AUTOMATION</c> as the parsing strategy for ingesting
        /// your data source, use this object to modify configurations for using the Amazon Bedrock
        /// Data Automation parser.
        /// </para>
        /// </summary>
        public BedrockDataAutomationConfiguration BedrockDataAutomationConfiguration
        {
            get { return this._bedrockDataAutomationConfiguration; }
            set { this._bedrockDataAutomationConfiguration = value; }
        }

        // Check to see if BedrockDataAutomationConfiguration property is set
        internal bool IsSetBedrockDataAutomationConfiguration()
        {
            return this._bedrockDataAutomationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BedrockFoundationModelConfiguration. 
        /// <para>
        /// If you specify <c>BEDROCK_FOUNDATION_MODEL</c> as the parsing strategy for ingesting
        /// your data source, use this object to modify configurations for using a foundation
        /// model to parse documents.
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