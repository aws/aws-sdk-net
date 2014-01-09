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
using Amazon.Runtime;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Contains the following objects or data if successful. Otherwise, returns an error.</para>
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckSummariesResult : AmazonWebServiceResponse
    {
        
        private List<TrustedAdvisorCheckSummary> summaries = new List<TrustedAdvisorCheckSummary>();


        /// <summary>
        /// The summary information for the requested Trusted Advisor checks.
        ///  
        /// </summary>
        public List<TrustedAdvisorCheckSummary> Summaries
        {
            get { return this.summaries; }
            set { this.summaries = value; }
        }

        // Check to see if Summaries property is set
        internal bool IsSetSummaries()
        {
            return this.summaries.Count > 0;
        }
    }
}
