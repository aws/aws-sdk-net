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
    /// <para>Configuration information for an analysis scheme. Each analysis scheme has a unique name and specifies the language of the text to be
    /// processed. The following options can be configured for an analysis scheme: <c>Synonyms</c> ,
    /// <c>Stopwords</c> ,
    /// <c>StemmingDictionary</c> , and <c>AlgorithmicStemming</c> .</para>
    /// </summary>
    public partial class AnalysisScheme
    {
        
        private string analysisSchemeName;
        private string analysisSchemeLanguage;
        private AnalysisOptions analysisOptions;

        /// <summary>
        /// A string that represents the name of an index field. Field names begin with a letter and can contain the following characters: a-z
        /// (lowercase), 0-9, and _ (underscore). The name "score" is reserved and cannot be used as a field name. To reference a document's ID, you can
        /// use the name <c>_id</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9_]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AnalysisSchemeName
        {
            get { return this.analysisSchemeName; }
            set { this.analysisSchemeName = value; }
        }

        /// <summary>
        /// Sets the AnalysisSchemeName property
        /// </summary>
        /// <param name="analysisSchemeName">The value to set for the AnalysisSchemeName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AnalysisScheme WithAnalysisSchemeName(string analysisSchemeName)
        {
            this.analysisSchemeName = analysisSchemeName;
            return this;
        }
            

        // Check to see if AnalysisSchemeName property is set
        internal bool IsSetAnalysisSchemeName()
        {
            return this.analysisSchemeName != null;
        }

        /// <summary>
        /// An <a href="http://tools.ietf.org/html/rfc4646" target="_blank">IETF RFC 4646</a> language code or <c>mul</c> for multiple languages.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ar, bg, ca, cs, da, de, el, en, es, eu, fa, fi, fr, ga, gl, hi, hu, hy, id, it, ja, ko, lv, mul, nl, no, pt, ro, ru, sv, th, tr, zh-Hans, zh-Hant</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AnalysisSchemeLanguage
        {
            get { return this.analysisSchemeLanguage; }
            set { this.analysisSchemeLanguage = value; }
        }

        /// <summary>
        /// Sets the AnalysisSchemeLanguage property
        /// </summary>
        /// <param name="analysisSchemeLanguage">The value to set for the AnalysisSchemeLanguage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AnalysisScheme WithAnalysisSchemeLanguage(string analysisSchemeLanguage)
        {
            this.analysisSchemeLanguage = analysisSchemeLanguage;
            return this;
        }
            

        // Check to see if AnalysisSchemeLanguage property is set
        internal bool IsSetAnalysisSchemeLanguage()
        {
            return this.analysisSchemeLanguage != null;
        }

        /// <summary>
        /// Synonyms, stopwords, and stemming options for an analysis scheme.
        ///  
        /// </summary>
        public AnalysisOptions AnalysisOptions
        {
            get { return this.analysisOptions; }
            set { this.analysisOptions = value; }
        }

        /// <summary>
        /// Sets the AnalysisOptions property
        /// </summary>
        /// <param name="analysisOptions">The value to set for the AnalysisOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AnalysisScheme WithAnalysisOptions(AnalysisOptions analysisOptions)
        {
            this.analysisOptions = analysisOptions;
            return this;
        }
            

        // Check to see if AnalysisOptions property is set
        internal bool IsSetAnalysisOptions()
        {
            return this.analysisOptions != null;
        }
    }
}
