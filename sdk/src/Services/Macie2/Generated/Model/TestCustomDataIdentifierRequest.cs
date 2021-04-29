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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the TestCustomDataIdentifier operation.
    /// Tests a custom data identifier.
    /// </summary>
    public partial class TestCustomDataIdentifierRequest : AmazonMacie2Request
    {
        private List<string> _ignoreWords = new List<string>();
        private List<string> _keywords = new List<string>();
        private int? _maximumMatchDistance;
        private string _regex;
        private string _sampleText;

        /// <summary>
        /// Gets and sets the property IgnoreWords. 
        /// <para>
        /// An array that lists specific character sequences (ignore words) to exclude from the
        /// results. If the text matched by the regular expression is the same as any string in
        /// this array, Amazon Macie ignores it. The array can contain as many as 10 ignore words.
        /// Each ignore word can contain 4 - 90 characters. Ignore words are case sensitive.
        /// </para>
        /// </summary>
        public List<string> IgnoreWords
        {
            get { return this._ignoreWords; }
            set { this._ignoreWords = value; }
        }

        // Check to see if IgnoreWords property is set
        internal bool IsSetIgnoreWords()
        {
            return this._ignoreWords != null && this._ignoreWords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        /// An array that lists specific character sequences (keywords), one of which must be
        /// within proximity (maximumMatchDistance) of the regular expression to match. The array
        /// can contain as many as 50 keywords. Each keyword can contain 3 - 90 characters. Keywords
        /// aren't case sensitive.
        /// </para>
        /// </summary>
        public List<string> Keywords
        {
            get { return this._keywords; }
            set { this._keywords = value; }
        }

        // Check to see if Keywords property is set
        internal bool IsSetKeywords()
        {
            return this._keywords != null && this._keywords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumMatchDistance. 
        /// <para>
        /// The maximum number of characters that can exist between text that matches the regex
        /// pattern and the character sequences specified by the keywords array. Macie includes
        /// or excludes a result based on the proximity of a keyword to text that matches the
        /// regex pattern. The distance can be 1 - 300 characters. The default value is 50.
        /// </para>
        /// </summary>
        public int MaximumMatchDistance
        {
            get { return this._maximumMatchDistance.GetValueOrDefault(); }
            set { this._maximumMatchDistance = value; }
        }

        // Check to see if MaximumMatchDistance property is set
        internal bool IsSetMaximumMatchDistance()
        {
            return this._maximumMatchDistance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regular expression (<i>regex</i>) that defines the pattern to match. The expression
        /// can contain as many as 512 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

        /// <summary>
        /// Gets and sets the property SampleText. 
        /// <para>
        /// The sample text to inspect by using the custom data identifier. The text can contain
        /// as many as 1,000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SampleText
        {
            get { return this._sampleText; }
            set { this._sampleText = value; }
        }

        // Check to see if SampleText property is set
        internal bool IsSetSampleText()
        {
            return this._sampleText != null;
        }

    }
}