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
    /// Returns information about the  DescribeTrustedAdvisorChecksResult response and response metadata.
    /// </summary>
    public class DescribeTrustedAdvisorChecksResponse : AmazonWebServiceResponse
    {
        private DescribeTrustedAdvisorChecksResult describeTrustedAdvisorChecksResult;

        /// <summary>
        /// Gets and sets the DescribeTrustedAdvisorChecksResult property.
        /// Returns the objects or data listed below if successful. Otherwise, returns an error.
        /// </summary>
        public DescribeTrustedAdvisorChecksResult DescribeTrustedAdvisorChecksResult
        {
            get
            {
                if(this.describeTrustedAdvisorChecksResult == null)
                {
                    this.describeTrustedAdvisorChecksResult = new DescribeTrustedAdvisorChecksResult();
                }

                return this.describeTrustedAdvisorChecksResult;
            }
            set { this.describeTrustedAdvisorChecksResult = value; }
        }
    }
}
    
