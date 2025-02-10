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
    /// Contains configurations for using Amazon Bedrock Data Automation as the parser for
    /// ingesting your data sources.
    /// </summary>
    public partial class BedrockDataAutomationConfiguration
    {
        private ParsingModality _parsingModality;

        /// <summary>
        /// Gets and sets the property ParsingModality. 
        /// <para>
        /// Specifies whether to enable parsing of multimodal data, including both text and/or
        /// images.
        /// </para>
        /// </summary>
        public ParsingModality ParsingModality
        {
            get { return this._parsingModality; }
            set { this._parsingModality = value; }
        }

        // Check to see if ParsingModality property is set
        internal bool IsSetParsingModality()
        {
            return this._parsingModality != null;
        }

    }
}