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
        /// <summary>
        /// Gets and sets the property AnalysisOptions.
        /// </summary>
        public AnalysisOptions AnalysisOptions { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisOptions property is set.
        /// </summary>
        internal bool IsSetAnalysisOptions() => this.AnalysisOptions != null;

        /// <summary>
        /// Gets and sets the property AnalysisSchemeLanguage.
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisSchemeLanguage AnalysisSchemeLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisSchemeLanguage property is set.
        /// </summary>
        internal bool IsSetAnalysisSchemeLanguage() => this.AnalysisSchemeLanguage != null;

        /// <summary>
        /// Gets and sets the property AnalysisSchemeName.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AnalysisSchemeName { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisSchemeName property is set.
        /// </summary>
        internal bool IsSetAnalysisSchemeName() => this.AnalysisSchemeName != null;
    }
}
