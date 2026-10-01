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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// This is the response object from the GetLexicon operation.
    /// </summary>
    public partial class GetLexiconResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Lexicon. 
        /// <para>
        /// Lexicon object that provides name and the string content of the lexicon. 
        /// </para>
        /// </summary>
        public Lexicon Lexicon { get; set; }

        /// <summary>
        /// Checks to see if the Lexicon property is set.
        /// </summary>
        internal bool IsSetLexicon() => this.Lexicon != null;

        /// <summary>
        /// Gets and sets the property LexiconAttributes. 
        /// <para>
        /// Metadata of the lexicon, including phonetic alphabetic used, language code, lexicon
        /// ARN, number of lexemes defined in the lexicon, and size of lexicon in bytes.
        /// </para>
        /// </summary>
        public LexiconAttributes LexiconAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LexiconAttributes property is set.
        /// </summary>
        internal bool IsSetLexiconAttributes() => this.LexiconAttributes != null;
    }
}
