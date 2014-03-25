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
    /// <para>The result of a <c>DeleteAnalysisScheme</c> request. Contains the status of the deleted analysis scheme.</para>
    /// </summary>
    public partial class DeleteAnalysisSchemeResult
    {
        
        private AnalysisSchemeStatus analysisScheme;

        /// <summary>
        /// The status of the analysis scheme being deleted.
        ///  
        /// </summary>
        public AnalysisSchemeStatus AnalysisScheme
        {
            get { return this.analysisScheme; }
            set { this.analysisScheme = value; }
        }

        /// <summary>
        /// Sets the AnalysisScheme property
        /// </summary>
        /// <param name="analysisScheme">The value to set for the AnalysisScheme property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteAnalysisSchemeResult WithAnalysisScheme(AnalysisSchemeStatus analysisScheme)
        {
            this.analysisScheme = analysisScheme;
            return this;
        }
            

        // Check to see if AnalysisScheme property is set
        internal bool IsSetAnalysisScheme()
        {
            return this.analysisScheme != null;
        }
    }
}
