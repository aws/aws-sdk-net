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
    /// Instructions for interpreting the contents of a document.
    /// </summary>
    public partial class ParsingPrompt
    {
        private string _parsingPromptText;

        /// <summary>
        /// Gets and sets the property ParsingPromptText. 
        /// <para>
        /// Instructions for interpreting the contents of a document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public string ParsingPromptText
        {
            get { return this._parsingPromptText; }
            set { this._parsingPromptText = value; }
        }

        // Check to see if ParsingPromptText property is set
        internal bool IsSetParsingPromptText()
        {
            return this._parsingPromptText != null;
        }

    }
}