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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Synonyms, stopwords, and stemming options for an analysis scheme.</para>
    /// </summary>
    public partial class AnalysisOptions
    {
        
        private string synonyms;
        private string stopwords;
        private string stemmingDictionary;
        private AlgorithmicStemming algorithmicStemming;


        /// <summary>
        /// A JSON object that defines synonym groups and aliases. A synonym group is an array of arrays, where each sub-array is a group of terms where
        /// each term in the group is considered a synonym of every other term in the group. The aliases value is an object that contains a collection
        /// of string:value pairs where the string specifies a term and the array of values specifies each of the aliases for that term. An alias is
        /// considered a synonym of the specified term, but the term is not considered a synonym of the alias.
        ///  
        /// </summary>
        public string Synonyms
        {
            get { return this.synonyms; }
            set { this.synonyms = value; }
        }

        // Check to see if Synonyms property is set
        internal bool IsSetSynonyms()
        {
            return this.synonyms != null;
        }

        /// <summary>
        /// A JSON array of terms to ignore during indexing and searching. For example, ["a", "an", "the", "of"]. The stopwords dictionary must
        /// explicitly list each word you want to ignore. Wildcards and regular expressions are not supported.
        ///  
        /// </summary>
        public string Stopwords
        {
            get { return this.stopwords; }
            set { this.stopwords = value; }
        }

        // Check to see if Stopwords property is set
        internal bool IsSetStopwords()
        {
            return this.stopwords != null;
        }

        /// <summary>
        /// A JSON object that contains a collection of string:value pairs that each map a term to its stem. For example, {"term1": "stem1", "term2":
        /// "stem2", "term3": "stem3"}. The stemming dictionary is applied in addition to any algorithmic stemming. This enables you to override the
        /// results of the algorithmic stemming to correct specific cases of overstemming or understemming. The maximum size of a stemming dictionary is
        /// 500 KB.
        ///  
        /// </summary>
        public string StemmingDictionary
        {
            get { return this.stemmingDictionary; }
            set { this.stemmingDictionary = value; }
        }

        // Check to see if StemmingDictionary property is set
        internal bool IsSetStemmingDictionary()
        {
            return this.stemmingDictionary != null;
        }

        /// <summary>
        /// The level of algorithmic stemming to perform: <c>none</c>, <c>minimal</c>, <c>light</c>, or <c>full</c>. The available levels vary depending
        /// on the language. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/text-processing-settings.html" target="_blank">Langage Specific Text
        /// Processing Settings</a> in the <i>Amazon CloudSearch Developer Guide</i>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>none, minimal, light, full</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public AlgorithmicStemming AlgorithmicStemming
        {
            get { return this.algorithmicStemming; }
            set { this.algorithmicStemming = value; }
        }

        // Check to see if AlgorithmicStemming property is set
        internal bool IsSetAlgorithmicStemming()
        {
            return this.algorithmicStemming != null;
        }
    }
}
