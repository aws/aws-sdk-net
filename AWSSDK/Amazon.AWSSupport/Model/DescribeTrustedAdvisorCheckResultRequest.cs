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
    /// by calling DescribeTrustedAdvisorChecks, you specify the <i>CheckId</i> for the check you want to retrieve from AWS Support.</para>
    /// <para>The response for this action contains a JSON-formatted TrustedAdvisorCheckResult object</para> <para>, which is a container for the
    /// following three objects:</para> <ol> <li> TrustedAdvisorCategorySpecificSummary </li>
    /// <li> TrustedAdvisorResourceDetail </li>
    /// <li> TrustedAdvisorResourcesSummary </li>
    /// </ol> <para>In addition, the response contains the following fields:</para> <ol> <li> <b>Status</b> . Overall status of the check.</li>
    /// <li> <b>Timestamp</b> . Time at which Trusted Advisor last ran the check. </li>
    /// <li> <b>CheckId</b> . Unique identifier for the specific check returned by the request.</li>
    /// </ol>
    /// </summary>
    /// <seealso cref="Amazon.AWSSupport.AmazonAWSSupport.DescribeTrustedAdvisorCheckResult"/>
    public class DescribeTrustedAdvisorCheckResultRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the CheckId property
        /// </summary>
        /// <param name="checkId">The value to set for the CheckId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrustedAdvisorCheckResultRequest WithCheckId(string checkId)
        {
            this.checkId = checkId;
            return this;
        }
            

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this.checkId != null;
        }

        /// <summary>
        /// Specifies the ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English and Japanese, for which
        /// the codes are <i>en</i> and <i>ja</i>, respectively.
        ///  
        /// </summary>
        public string Language
        {
            get { return this.language; }
            set { this.language = value; }
        }

        /// <summary>
        /// Sets the Language property
        /// </summary>
        /// <param name="language">The value to set for the Language property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrustedAdvisorCheckResultRequest WithLanguage(string language)
        {
            this.language = language;
            return this;
        }
            

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this.language != null;
        }
    }
}
    
