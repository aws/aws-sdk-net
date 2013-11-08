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
    /// <para>This action responds with the results of a Trusted Advisor check. Once you have obtained the list of available Trusted Advisor checks
    /// by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html"
    /// >DescribeTrustedAdvisorChecks</a> , you specify the <i>CheckId</i> for the check you want to retrieve from AWS Support.</para> <para>The
    /// response for this action contains a JSON-formatted <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckResultResult.html"
    /// >TrustedAdvisorCheckResult</a> object</para> <para>, which is a container for the following three objects:</para> <ol> <li> <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCategorySpecificSummary.html"
    /// >TrustedAdvisorCategorySpecificSummary</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourceDetail.html"
    /// >TrustedAdvisorResourceDetail</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourcesSummary.html"
    /// >TrustedAdvisorResourcesSummary</a> </li>
    /// </ol> <para>In addition, the response contains the following fields:</para> <ol> <li> <b>Status</b> . Overall status of the check.</li>
    /// <li> <b>Timestamp</b> . Time at which Trusted Advisor last ran the check. </li>
    /// <li> <b>CheckId</b> . Unique identifier for the specific check returned by the request.</li>
    /// </ol>
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckResultRequest : AmazonWebServiceRequest
    {
        private string checkId;
        private string language;

        /// <summary>
        /// 
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
        /// Specifies the ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English and Japanese, for which
        /// the codes are <i>en</i> and <i>ja</i>, respectively. Language parameters must be passed explicitly for operations that take them.
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
    
