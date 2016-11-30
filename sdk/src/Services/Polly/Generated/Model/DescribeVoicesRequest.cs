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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Polly.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVoices operation.
    /// Returns the list of voices that are available for use when requesting speech synthesis.
    /// Each voice speaks a specified language, is either male or female, and is identified
    /// by an ID, which is the ASCII version of the voice name. 
    /// 
    ///  
    /// <para>
    /// When synthesizing speech ( <code>SynthesizeSpeech</code> ), you provide the voice
    /// ID for the voice you want from the list of voices returned by <code>DescribeVoices</code>.
    /// </para>
    ///  
    /// <para>
    /// For example, you want your news reader application to read news in a specific language,
    /// but giving a user the option to choose the voice. Using the <code>DescribeVoices</code>
    /// operation you can provide the user with a list of available voices to select from.
    /// </para>
    ///  
    /// <para>
    ///  You can optionally specify a language code to filter the available voices. For example,
    /// if you specify <code>en-US</code>, the operation returns a list of all available US
    /// English voices. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>polly:DescribeVoices</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeVoicesRequest : AmazonPollyRequest
    {
        private LanguageCode _languageCode;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        ///  The language identification tag (ISO 639 code for the language name-ISO 3166 country
        /// code) for filtering the list of voices returned. If you don't specify this optional
        /// parameter, all available voices are returned. 
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token returned from the previous <code>DescribeVoices</code>
        /// operation. If present, this indicates where to continue the listing.
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

    }
}