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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the DetectSyntax operation.
    /// </summary>
    public partial class DetectSyntaxResponse : AmazonWebServiceResponse
    {
        private List<SyntaxToken> _syntaxTokens = AWSConfigs.InitializeCollections ? new List<SyntaxToken>() : null;

        /// <summary>
        /// Gets and sets the property SyntaxTokens. 
        /// <para>
        /// A collection of syntax tokens describing the text. For each token, the response provides
        /// the text, the token type, where the text begins and ends, and the level of confidence
        /// that Amazon Comprehend has that the token is correct. For a list of token types, see
        /// <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
        /// in the Comprehend Developer Guide. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SyntaxToken> SyntaxTokens
        {
            get { return this._syntaxTokens; }
            set { this._syntaxTokens = value; }
        }

        // Check to see if SyntaxTokens property is set
        internal bool IsSetSyntaxTokens()
        {
            return this._syntaxTokens != null && (this._syntaxTokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}