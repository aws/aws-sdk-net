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
    /// Configuration information for an analysis scheme. Each analysis scheme has a unique
    /// name and specifies the language of the text to be processed. The following options
    /// can be configured for an analysis scheme: <c>Synonyms</c>, <c>Stopwords</c>, <c>StemmingDictionary</c>,
    /// <c>JapaneseTokenizationDictionary</c> and <c>AlgorithmicStemming</c>.
    /// </summary>
    public partial class AnalysisScheme
    {
        private AnalysisOptions _analysisOptions;
        private AnalysisSchemeLanguage _analysisSchemeLanguage;
        private string _analysisSchemeName;

        /// <summary>
        /// Gets and sets the property AnalysisOptions.
        /// </summary>
        public AnalysisOptions AnalysisOptions
        {
            get { return this._analysisOptions; }
            set { this._analysisOptions = value; }
        }

        // Check to see if AnalysisOptions property is set
        internal bool IsSetAnalysisOptions()
        {
            return this._analysisOptions != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisSchemeLanguage.
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisSchemeLanguage AnalysisSchemeLanguage
        {
            get { return this._analysisSchemeLanguage; }
            set { this._analysisSchemeLanguage = value; }
        }

        // Check to see if AnalysisSchemeLanguage property is set
        internal bool IsSetAnalysisSchemeLanguage()
        {
            return this._analysisSchemeLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisSchemeName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AnalysisSchemeName
        {
            get { return this._analysisSchemeName; }
            set { this._analysisSchemeName = value; }
        }

        // Check to see if AnalysisSchemeName property is set
        internal bool IsSetAnalysisSchemeName()
        {
            return this._analysisSchemeName != null;
        }

    }
}