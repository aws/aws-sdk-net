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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Returns information about the  DescribeDefaultSearchFieldResult response and response metadata.
    /// </summary>
    public class DescribeDefaultSearchFieldResponse : AmazonWebServiceResponse
    {
        private DescribeDefaultSearchFieldResult describeDefaultSearchFieldResult;

        /// <summary>
        /// Gets and sets the DescribeDefaultSearchFieldResult property.
        /// A response message that contains the default search field for a search domain.
        /// </summary>
        public DescribeDefaultSearchFieldResult DescribeDefaultSearchFieldResult
        {
            get 
            {
                if(this.describeDefaultSearchFieldResult == null)
                {
                    this.describeDefaultSearchFieldResult = new DescribeDefaultSearchFieldResult();
                }

                return this.describeDefaultSearchFieldResult; 
            }
            set { this.describeDefaultSearchFieldResult = value; }
        }
    }
}
    
