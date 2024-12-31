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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Standard Output Configuration of Document
    /// </summary>
    public partial class DocumentStandardOutputConfiguration
    {
        private DocumentStandardExtraction _extraction;
        private DocumentStandardGenerativeField _generativeField;
        private DocumentOutputFormat _outputFormat;

        /// <summary>
        /// Gets and sets the property Extraction.
        /// </summary>
        public DocumentStandardExtraction Extraction
        {
            get { return this._extraction; }
            set { this._extraction = value; }
        }

        // Check to see if Extraction property is set
        internal bool IsSetExtraction()
        {
            return this._extraction != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeField.
        /// </summary>
        public DocumentStandardGenerativeField GenerativeField
        {
            get { return this._generativeField; }
            set { this._generativeField = value; }
        }

        // Check to see if GenerativeField property is set
        internal bool IsSetGenerativeField()
        {
            return this._generativeField != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormat.
        /// </summary>
        public DocumentOutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

    }
}