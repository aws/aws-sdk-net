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
    /// Output Format of Document
    /// </summary>
    public partial class DocumentOutputFormat
    {
        private DocumentOutputAdditionalFileFormat _additionalFileFormat;
        private DocumentOutputTextFormat _textFormat;

        /// <summary>
        /// Gets and sets the property AdditionalFileFormat.
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentOutputAdditionalFileFormat AdditionalFileFormat
        {
            get { return this._additionalFileFormat; }
            set { this._additionalFileFormat = value; }
        }

        // Check to see if AdditionalFileFormat property is set
        internal bool IsSetAdditionalFileFormat()
        {
            return this._additionalFileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TextFormat.
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentOutputTextFormat TextFormat
        {
            get { return this._textFormat; }
            set { this._textFormat = value; }
        }

        // Check to see if TextFormat property is set
        internal bool IsSetTextFormat()
        {
            return this._textFormat != null;
        }

    }
}