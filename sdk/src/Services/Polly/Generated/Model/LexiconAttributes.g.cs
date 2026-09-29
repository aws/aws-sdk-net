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
    /// Contains metadata describing the lexicon such as the number of lexemes, language code,
    /// and so on. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
    /// Lexicons</a>.
    /// </summary>
    public partial class LexiconAttributes
    {
        /// <summary>
        /// Gets and sets the property Alphabet. 
        /// <para>
        /// Phonetic alphabet used in the lexicon. Valid values are <c>ipa</c> and <c>x-sampa</c>.
        /// </para>
        /// </summary>
        public string Alphabet { get; set; }

        /// <summary>
        /// Checks to see if the Alphabet property is set.
        /// </summary>
        internal bool IsSetAlphabet() => this.Alphabet != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Language code that the lexicon applies to. A lexicon with a language code such as
        /// "en" would be applied to all English languages (en-GB, en-US, en-AUS, en-WLS, and
        /// so on.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Date lexicon was last modified (a timestamp value).
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property LexemesCount. 
        /// <para>
        /// Number of lexemes in the lexicon.
        /// </para>
        /// </summary>
        public int? LexemesCount { get; set; }

        /// <summary>
        /// Checks to see if the LexemesCount property is set.
        /// </summary>
        internal bool IsSetLexemesCount() => this.LexemesCount.HasValue;

        /// <summary>
        /// Gets and sets the property LexiconArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the lexicon.
        /// </para>
        /// </summary>
        public string LexiconArn { get; set; }

        /// <summary>
        /// Checks to see if the LexiconArn property is set.
        /// </summary>
        internal bool IsSetLexiconArn() => this.LexiconArn != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// Total size of the lexicon, in characters.
        /// </para>
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;
    }
}
