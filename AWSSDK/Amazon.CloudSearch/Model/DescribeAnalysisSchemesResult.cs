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
    /// <para>The result of a <c>DescribeAnalysisSchemes</c> request. Contains the analysis schemes configured for the domain specified in the
    /// request.</para>
    /// </summary>
    public partial class DescribeAnalysisSchemesResult
    {
        
        private List<AnalysisSchemeStatus> analysisSchemes = new List<AnalysisSchemeStatus>();

        /// <summary>
        /// The analysis scheme descriptions.
        ///  
        /// </summary>
        public List<AnalysisSchemeStatus> AnalysisSchemes
        {
            get { return this.analysisSchemes; }
            set { this.analysisSchemes = value; }
        }
        /// <summary>
        /// Adds elements to the AnalysisSchemes collection
        /// </summary>
        /// <param name="analysisSchemes">The values to add to the AnalysisSchemes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAnalysisSchemesResult WithAnalysisSchemes(params AnalysisSchemeStatus[] analysisSchemes)
        {
            foreach (AnalysisSchemeStatus element in analysisSchemes)
            {
                this.analysisSchemes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AnalysisSchemes collection
        /// </summary>
        /// <param name="analysisSchemes">The values to add to the AnalysisSchemes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAnalysisSchemesResult WithAnalysisSchemes(IEnumerable<AnalysisSchemeStatus> analysisSchemes)
        {
            foreach (AnalysisSchemeStatus element in analysisSchemes)
            {
                this.analysisSchemes.Add(element);
            }

            return this;
        }

        // Check to see if AnalysisSchemes property is set
        internal bool IsSetAnalysisSchemes()
        {
            return this.analysisSchemes.Count > 0;
        }
    }
}
