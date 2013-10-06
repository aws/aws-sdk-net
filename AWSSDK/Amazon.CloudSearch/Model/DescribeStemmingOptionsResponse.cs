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
    /// Returns information about the  DescribeStemmingOptionsResult response and response metadata.
    /// </summary>
    public class DescribeStemmingOptionsResponse : AmazonWebServiceResponse
    {
        private DescribeStemmingOptionsResult describeStemmingOptionsResult;

        /// <summary>
        /// Gets and sets the DescribeStemmingOptionsResult property.
        /// A response message that contains the stemming options for a search domain.
        /// </summary>
        public DescribeStemmingOptionsResult DescribeStemmingOptionsResult
        {
            get 
            {
                if(this.describeStemmingOptionsResult == null)
                {
                    this.describeStemmingOptionsResult = new DescribeStemmingOptionsResult();
                }

                return this.describeStemmingOptionsResult; 
            }
            set { this.describeStemmingOptionsResult = value; }
        }
    }
}
    
