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
    /// Returns information about the  DescribeCasesResult response and response metadata.
    /// </summary>
    public class DescribeCasesResponse : AmazonWebServiceResponse
    {
        private DescribeCasesResult describeCasesResult;

        /// <summary>
        /// Gets and sets the DescribeCasesResult property.
        /// Returns an array of CaseDetails objects and a NextToken that defines a point for pagination in the result set.
        /// </summary>
        public DescribeCasesResult DescribeCasesResult
        {
            get
            {
                if(this.describeCasesResult == null)
                {
                    this.describeCasesResult = new DescribeCasesResult();
                }

                return this.describeCasesResult;
            }
            set { this.describeCasesResult = value; }
        }
    }
}
    
