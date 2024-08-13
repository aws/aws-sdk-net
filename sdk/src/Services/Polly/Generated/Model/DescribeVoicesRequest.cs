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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
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
    /// Container for the parameters to the DescribeVoices operation.
    /// Returns the list of voices that are available for use when requesting speech synthesis.
    /// Each voice speaks a specified language, is either male or female, and is identified
    /// by an ID, which is the ASCII version of the voice name. 
    /// 
    ///  
    /// <para>
    /// When synthesizing speech ( <c>SynthesizeSpeech</c> ), you provide the voice ID for
    /// the voice you want from the list of voices returned by <c>DescribeVoices</c>.
    /// </para>
    ///  
    /// <para>
    /// For example, you want your news reader application to read news in a specific language,
    /// but giving a user the option to choose the voice. Using the <c>DescribeVoices</c>
    /// operation you can provide the user with a list of available voices to select from.
    /// </para>
    ///  
    /// <para>
    ///  You can optionally specify a language code to filter the available voices. For example,
    /// if you specify <c>en-US</c>, the operation returns a list of all available US English
    /// voices. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>polly:DescribeVoices</c> action.
    /// </para>
    /// </summary>
    public partial class DescribeVoicesRequest : AmazonPollyRequest
    {
        private Engine _engine;
        private bool? _includeAdditionalLanguageCodes;
        private LanguageCode _languageCode;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Specifies the engine (<c>standard</c>, <c>neural</c>, <c>long-form</c> or <c>generative</c>)
        /// used by Amazon Polly when processing input text for speech synthesis. 
        /// </para>
        /// </summary>
        public Engine Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAdditionalLanguageCodes. 
        /// <para>
        /// Boolean value indicating whether to return any bilingual voices that use the specified
        /// language as an additional language. For instance, if you request all languages that
        /// use US English (es-US), and there is an Italian voice that speaks both Italian (it-IT)
        /// and US English, that voice will be included if you specify <c>yes</c> but not if you
        /// specify <c>no</c>.
        /// </para>
        /// </summary>
        public bool? IncludeAdditionalLanguageCodes
        {
            get { return this._includeAdditionalLanguageCodes; }
            set { this._includeAdditionalLanguageCodes = value; }
        }

        // Check to see if IncludeAdditionalLanguageCodes property is set
        internal bool IsSetIncludeAdditionalLanguageCodes()
        {
            return this._includeAdditionalLanguageCodes.HasValue; 
        }

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
        /// An opaque pagination token returned from the previous <c>DescribeVoices</c> operation.
        /// If present, this indicates where to continue the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
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