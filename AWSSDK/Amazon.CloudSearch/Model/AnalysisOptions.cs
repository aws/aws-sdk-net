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
        private string algorithmicStemming;

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

        /// <summary>
        /// Sets the Synonyms property
        /// </summary>
        /// <param name="synonyms">The value to set for the Synonyms property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AnalysisOptions WithSynonyms(string synonyms)
        {
            this.synonyms = synonyms;
            return this;
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

        /// <summary>
        /// Sets the Stopwords property
        /// </summary>
        /// <param name="stopwords">The value to set for the Stopwords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AnalysisOptions WithStopwords(string stopwords)
        {
            this.stopwords = stopwords;
            return this;
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

        /// <summary>
        /// Sets the StemmingDictionary property
        /// </summary>
        /// <param name="stemmingDictionary">The value to set for the StemmingDictionary property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AnalysisOptions WithStemmingDictionary(string stemmingDictionary)
        {
            this.stemmingDictionary = stemmingDictionary;
            return this;
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
        public string AlgorithmicStemming
        {
            get { return this.algorithmicStemming; }
            set { this.algorithmicStemming = value; }
        }

        /// <summary>
        /// Sets the AlgorithmicStemming property
        /// </summary>
        /// <param name="algorithmicStemming">The value to set for the AlgorithmicStemming property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AnalysisOptions WithAlgorithmicStemming(string algorithmicStemming)
        {
            this.algorithmicStemming = algorithmicStemming;
            return this;
        }
            

        // Check to see if AlgorithmicStemming property is set
        internal bool IsSetAlgorithmicStemming()
        {
            return this.algorithmicStemming != null;
        }
    }
}
