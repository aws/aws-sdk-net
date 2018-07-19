/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The result of calling the operation. The operation returns one object that is successfully
    /// processed by the operation.
    /// </summary>
    public partial class BatchDetectSyntaxItemResult
    {
        private int? _index;
        private List<SyntaxToken> _syntaxTokens = new List<SyntaxToken>();

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The zero-based index of the document in the input list.
        /// </para>
        /// </summary>
        public int Index
        {
            get { return this._index.GetValueOrDefault(); }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SyntaxTokens. 
        /// <para>
        /// The syntax tokens for the words in the document, one token for each word.
        /// </para>
        /// </summary>
        public List<SyntaxToken> SyntaxTokens
        {
            get { return this._syntaxTokens; }
            set { this._syntaxTokens = value; }
        }

        // Check to see if SyntaxTokens property is set
        internal bool IsSetSyntaxTokens()
        {
            return this._syntaxTokens != null && this._syntaxTokens.Count > 0; 
        }

    }
}