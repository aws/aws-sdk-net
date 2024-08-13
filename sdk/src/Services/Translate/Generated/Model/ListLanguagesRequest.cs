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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the ListLanguages operation.
    /// Provides a list of languages (RFC-5646 codes and names) that Amazon Translate supports.
    /// </summary>
    public partial class ListLanguagesRequest : AmazonTranslateRequest
    {
        private DisplayLanguageCode _displayLanguageCode;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DisplayLanguageCode. 
        /// <para>
        /// The language code for the language to use to display the language names in the response.
        /// The language code is <c>en</c> by default. 
        /// </para>
        /// </summary>
        public DisplayLanguageCode DisplayLanguageCode
        {
            get { return this._displayLanguageCode; }
            set { this._displayLanguageCode = value; }
        }

        // Check to see if DisplayLanguageCode property is set
        internal bool IsSetDisplayLanguageCode()
        {
            return this._displayLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in each response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Include the NextToken value to fetch the next group of supported languages. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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

    }
}