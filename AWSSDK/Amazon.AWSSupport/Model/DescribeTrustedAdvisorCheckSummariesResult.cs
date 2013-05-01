/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public class DescribeTrustedAdvisorCheckSummariesResult
    {
        
        private List<TrustedAdvisorCheckSummary> summaries = new List<TrustedAdvisorCheckSummary>();

        /// <summary>
        /// List of <a href="API_TrustedAdvisorCheckSummary.html" title="TrustedAdvisorCheckSummary">TrustedAdvisorCheckSummary</a> objects returned by
        /// the <a href="API_DescribeTrustedAdvisorCheckSummaries.html"
        /// title="DescribeTrustedAdvisorCheckSummaries">DescribeTrustedAdvisorCheckSummaries</a> request.
        ///  
        /// </summary>
        public List<TrustedAdvisorCheckSummary> Summaries
        {
            get { return this.summaries; }
            set { this.summaries = value; }
        }
        /// <summary>
        /// Adds elements to the Summaries collection
        /// </summary>
        /// <param name="summaries">The values to add to the Summaries collection </param>
        /// <returns>this instance</returns>
        public DescribeTrustedAdvisorCheckSummariesResult WithSummaries(params TrustedAdvisorCheckSummary[] summaries)
        {
            foreach (TrustedAdvisorCheckSummary element in summaries)
            {
                this.summaries.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Summaries collection
        /// </summary>
        /// <param name="summaries">The values to add to the Summaries collection </param>
        /// <returns>this instance</returns>
        public DescribeTrustedAdvisorCheckSummariesResult WithSummaries(IEnumerable<TrustedAdvisorCheckSummary> summaries)
        {
            foreach (TrustedAdvisorCheckSummary element in summaries)
            {
                this.summaries.Add(element);
            }

            return this;
        }

        // Check to see if Summaries property is set
        internal bool IsSetSummaries()
        {
            return this.summaries.Count > 0;
        }
    }
}
