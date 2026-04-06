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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a single line of text from a source document, annotated with its line number
    /// for precise referencing.
    /// </summary>
    public partial class AutomatedReasoningPolicyAnnotatedLine
    {
        private int? _lineNumber;
        private string _lineText;

        /// <summary>
        /// Gets and sets the property LineNumber. 
        /// <para>
        /// The line number of this text within the source document.
        /// </para>
        /// </summary>
        public int? LineNumber
        {
            get { return this._lineNumber; }
            set { this._lineNumber = value; }
        }

        // Check to see if LineNumber property is set
        internal bool IsSetLineNumber()
        {
            return this._lineNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineText. 
        /// <para>
        /// The actual text content of this line from the source document.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string LineText
        {
            get { return this._lineText; }
            set { this._lineText = value; }
        }

        // Check to see if LineText property is set
        internal bool IsSetLineText()
        {
            return this._lineText != null;
        }

    }
}