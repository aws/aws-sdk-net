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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetBuiltinIntents operation.
    /// Gets a list of built-in intents that meet the specified criteria.
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <c>lex:GetBuiltinIntents</c> action.
    /// </para>
    /// </summary>
    public partial class GetBuiltinIntentsRequest : AmazonLexModelBuildingServiceRequest
    {
        private Locale _locale;
        private int? _maxResults;
        private string _nextToken;
        private string _signatureContains;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// A list of locales that the intent supports.
        /// </para>
        /// </summary>
        public Locale Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of intents to return in the response. The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that fetches the next page of intents. If this API call is truncated,
        /// Amazon Lex returns a pagination token in the response. To fetch the next page of intents,
        /// use the pagination token in the next request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureContains. 
        /// <para>
        /// Substring to match in built-in intent signatures. An intent will be returned if any
        /// part of its signature matches the substring. For example, "xyz" matches both "xyzabc"
        /// and "abcxyz." To find the signature for an intent, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/standard-intents">Standard
        /// Built-in Intents</a> in the <i>Alexa Skills Kit</i>.
        /// </para>
        /// </summary>
        public string SignatureContains
        {
            get { return this._signatureContains; }
            set { this._signatureContains = value; }
        }

        // Check to see if SignatureContains property is set
        internal bool IsSetSignatureContains()
        {
            return this._signatureContains != null;
        }

    }
}