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

using Amazon.Runtime;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Returns information about the  TrustedAdvisorCheckResult response and response metadata.
    /// </summary>
    public class TrustedAdvisorCheckResponse : AmazonWebServiceResponse
    {
        private TrustedAdvisorCheckResult trustedAdvisorCheckResult;

        /// <summary>
        /// Gets and sets the TrustedAdvisorCheckResult property.
        /// JSON-formatted object contained in the DescribeTrustedAdvisorCheckResult response. This object has three child objects:
        /// TrustedAdvisorCategorySpecificSummary TrustedAdvisorResourceDetail TrustedAdvisorResourcesSummary
        /// </summary>
        public TrustedAdvisorCheckResult TrustedAdvisorCheckResult
        {
            get
            {
                if(this.trustedAdvisorCheckResult == null)
                {
                    this.trustedAdvisorCheckResult = new TrustedAdvisorCheckResult();
                }

                return this.trustedAdvisorCheckResult;
            }
            set { this.trustedAdvisorCheckResult = value; }
        }
    }
}
    
