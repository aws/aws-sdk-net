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
    /// Represents a content element within an annotated chunk. This union type allows for
    /// different types of content elements to be included in document chunks, such as individual
    /// lines of text with their line numbers.
    /// </summary>
    public partial class AutomatedReasoningPolicyAnnotatedContent
    {
        private AutomatedReasoningPolicyAnnotatedLine _line;

        /// <summary>
        /// Gets and sets the property Line. 
        /// <para>
        /// An annotated line of text from the source document, including both the line number
        /// and the text content.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAnnotatedLine Line
        {
            get { return this._line; }
            set { this._line = value; }
        }

        // Check to see if Line property is set
        internal bool IsSetLine()
        {
            return this._line != null;
        }

    }
}