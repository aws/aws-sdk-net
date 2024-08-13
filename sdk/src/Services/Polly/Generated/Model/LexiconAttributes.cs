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
    /// Contains metadata describing the lexicon such as the number of lexemes, language code,
    /// and so on. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
    /// Lexicons</a>.
    /// </summary>
    public partial class LexiconAttributes
    {
        private string _alphabet;
        private LanguageCode _languageCode;
        private DateTime? _lastModified;
        private int? _lexemesCount;
        private string _lexiconArn;
        private int? _size;

        /// <summary>
        /// Gets and sets the property Alphabet. 
        /// <para>
        /// Phonetic alphabet used in the lexicon. Valid values are <c>ipa</c> and <c>x-sampa</c>.
        /// </para>
        /// </summary>
        public string Alphabet
        {
            get { return this._alphabet; }
            set { this._alphabet = value; }
        }

        // Check to see if Alphabet property is set
        internal bool IsSetAlphabet()
        {
            return this._alphabet != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Language code that the lexicon applies to. A lexicon with a language code such as
        /// "en" would be applied to all English languages (en-GB, en-US, en-AUS, en-WLS, and
        /// so on.
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Date lexicon was last modified (a timestamp value).
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LexemesCount. 
        /// <para>
        /// Number of lexemes in the lexicon.
        /// </para>
        /// </summary>
        public int? LexemesCount
        {
            get { return this._lexemesCount; }
            set { this._lexemesCount = value; }
        }

        // Check to see if LexemesCount property is set
        internal bool IsSetLexemesCount()
        {
            return this._lexemesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LexiconArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the lexicon.
        /// </para>
        /// </summary>
        public string LexiconArn
        {
            get { return this._lexiconArn; }
            set { this._lexiconArn = value; }
        }

        // Check to see if LexiconArn property is set
        internal bool IsSetLexiconArn()
        {
            return this._lexiconArn != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// Total size of the lexicon, in characters.
        /// </para>
        /// </summary>
        public int? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}