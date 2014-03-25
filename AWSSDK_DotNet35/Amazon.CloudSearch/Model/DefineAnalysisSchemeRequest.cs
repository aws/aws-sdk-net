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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DefineAnalysisScheme operation.
    /// <para>Configures an analysis scheme for a domain. An analysis scheme defines language-specific text processing options for a <c>text</c>
    /// field. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
    /// >Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
    /// </summary>
    public partial class DefineAnalysisSchemeRequest : AmazonCloudSearchRequest
    {
        private string domainName;
        private AnalysisScheme analysisScheme;


        /// <summary>
        /// A string that represents the name of a domain. Domain names are unique across the domains owned by an account within an AWS region. Domain
        /// names start with a letter or number and can contain the following characters: a-z (lowercase), 0-9, and - (hyphen).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 28</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9\-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// Configuration information for an analysis scheme. Each analysis scheme has a unique name and specifies the language of the text to be
        /// processed. The following options can be configured for an analysis scheme: <c>Synonyms</c>, <c>Stopwords</c>, <c>StemmingDictionary</c>, and
        /// <c>AlgorithmicStemming</c>.
        ///  
        /// </summary>
        public AnalysisScheme AnalysisScheme
        {
            get { return this.analysisScheme; }
            set { this.analysisScheme = value; }
        }

        // Check to see if AnalysisScheme property is set
        internal bool IsSetAnalysisScheme()
        {
            return this.analysisScheme != null;
        }

    }
}
    
