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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Settings for parsing document contents. By default, the service converts the contents
    /// of each document into text before splitting it into chunks. To improve processing
    /// of PDF files with tables and images, you can configure the data source to convert
    /// the pages of text into images and use a model to describe the contents of each page.
    /// </summary>
    public partial class ParsingConfiguration
    {
        private BedrockFoundationModelConfigurationForParsing _bedrockFoundationModelConfiguration;
        private ParsingStrategy _parsingStrategy;

        /// <summary>
        /// Gets and sets the property BedrockFoundationModelConfiguration. 
        /// <para>
        /// Settings for a foundation model used to parse documents for a data source.
        /// </para>
        /// </summary>
        public BedrockFoundationModelConfigurationForParsing BedrockFoundationModelConfiguration
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