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
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrustedAdvisorCheckResult operation.
    /// <para>Returns the results of the Trusted Advisor check that has the specified check ID. Check IDs can be obtained by calling
    /// DescribeTrustedAdvisorChecks.</para> <para>The response contains a TrustedAdvisorCheckResult object, which contains these three
    /// objects:</para>
    /// <ul>
    /// <li> TrustedAdvisorCategorySpecificSummary </li>
    /// <li> TrustedAdvisorResourceDetail </li>
    /// <li> TrustedAdvisorResourcesSummary </li>
    /// 
    /// </ul>
    /// <para>In addition, the response contains these fields:</para>
    /// <ul>
    /// <li> <b>Status.</b> The alert status of the check: "ok" (green), "warning" (yellow), "error" (red), or "not_available".</li>
    /// <li> <b>Timestamp.</b> The time of the last refresh of the check.</li>
    /// <li> <b>CheckId.</b> The unique identifier for the check.</li>
    /// 
    /// </ul>
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckResultRequest : AmazonAWSSupportRequest
    {
        private string checkId;
        private string language;


        /// <summary>
        /// The unique identifier for the Trusted Advisor check.
        ///  
        /// </summary>
        public string CheckId
        {
            get { return this.checkId; }
            set { this.checkId = value; }
        }

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this.checkId != null;
        }

        /// <summary>
        /// The ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English ("en") and Japanese ("ja").
        /// Language parameters must be passed explicitly for operations that take them.
        ///  
        /// </summary>
        public string Language
        {
            get { return this.language; }
            set { this.language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this.language != null;
        }

    }
}
    
