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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Synonyms, stopwords, and stemming options for an analysis scheme. Includes tokenization
    /// dictionary for Japanese.
    /// </summary>
    public partial class AnalysisOptions
    {
        private AlgorithmicStemming _algorithmicStemming;
        private string _japaneseTokenizationDictionary;
        private string _stemmingDictionary;
        private string _stopwords;
        private string _synonyms;

        /// <summary>
        /// Gets and sets the property AlgorithmicStemming. 
        /// <para>
        /// The level of algorithmic stemming to perform: <c>none</c>, <c>minimal</c>, <c>light</c>,
        /// or <c>full</c>. The available levels vary depending on the language. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/text-processing.html#text-processing-settings"
        /// target="_blank">Language Specific Text Processing Settings</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i> 
        /// </para>
        /// </summary>
        public AlgorithmicStemming AlgorithmicStemming
        {
            get { return this._algorithmicStemming; }
            set { this._algorithmicStemming = value; }
        }

        // Check to see if AlgorithmicStemming property is set
        internal bool IsSetAlgorithmicStemming()
        {
            return this._algorithmicStemming != null;
        }

        /// <summary>
        /// Gets and sets the property JapaneseTokenizationDictionary. 
        /// <para>
        /// A JSON array that contains a collection of terms, tokens, readings and part of speech
        /// for Japanese Tokenizaiton. The Japanese tokenization dictionary enables you to override
        /// the default tokenization for selected terms. This is only valid for Japanese language
        /// fields.
        /// </para>
        /// </summary>
        public string JapaneseTokenizationDictionary
        {
            get { return this._japaneseTokenizationDictionary; }
            set { this._japaneseTokenizationDictionary = value; }
        }

        // Check to see if JapaneseTokenizationDictionary property is set
        internal bool IsSetJapaneseTokenizationDictionary()
        {
            return this._japaneseTokenizationDictionary != null;
        }

        /// <summary>
        /// Gets and sets the property StemmingDictionary. 
        /// <para>
        /// A JSON object that contains a collection of string:value pairs that each map a term
        /// to its stem. For example, <c>{"term1": "stem1", "term2": "stem2", "term3": "stem3"}</c>.
        /// The stemming dictionary is applied in addition to any algorithmic stemming. This enables
        /// you to override the results of the algorithmic stemming to correct specific cases
        /// of overstemming or understemming. The maximum size of a stemming dictionary is 500
        /// KB.
        /// </para>
        /// </summary>
        public string StemmingDictionary
        {
            get { return this._stemmingDictionary; }
            set { this._stemmingDictionary = value; }
        }

        // Check to see if StemmingDictionary property is set
        internal bool IsSetStemmingDictionary()
        {
            return this._stemmingDictionary != null;
        }

        /// <summary>
        /// Gets and sets the property Stopwords. 
        /// <para>
        /// A JSON array of terms to ignore during indexing and searching. For example, <c>["a",
        /// "an", "the", "of"]</c>. The stopwords dictionary must explicitly list each word you
        /// want to ignore. Wildcards and regular expressions are not supported. 
        /// </para>
        /// </summary>
        public string Stopwords
        {
            get { return this._stopwords; }
            set { this._stopwords = value; }
        }

        // Check to see if Stopwords property is set
        internal bool IsSetStopwords()
        {
            return this._stopwords != null;
        }

        /// <summary>
        /// Gets and sets the property Synonyms. 
        /// <para>
        /// A JSON object that defines synonym groups and aliases. A synonym group is an array
        /// of arrays, where each sub-array is a group of terms where each term in the group is
        /// considered a synonym of every other term in the group. The aliases value is an object
        /// that contains a collection of string:value pairs where the string specifies a term
        /// and the array of values specifies each of the aliases for that term. An alias is considered
        /// a synonym of the specified term, but the term is not considered a synonym of the alias.
        /// For more information about specifying synonyms, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html#synonyms">Synonyms</a>
        /// in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Synonyms
        {
            get { return this._synonyms; }
            set { this._synonyms = value; }
        }

        // Check to see if Synonyms property is set
        internal bool IsSetSynonyms()
        {
            return this._synonyms != null;
        }

    }
}