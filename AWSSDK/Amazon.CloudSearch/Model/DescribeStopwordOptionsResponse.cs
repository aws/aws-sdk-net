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
    /// Returns information about the  DescribeStopwordOptionsResult response and response metadata.
    /// </summary>
    public class DescribeStopwordOptionsResponse : AmazonWebServiceResponse
    {
        private DescribeStopwordOptionsResult describeStopwordOptionsResult;

        /// <summary>
        /// Gets and sets the DescribeStopwordOptionsResult property.
        /// A response message that contains the stopword options for a search domain.
        /// </summary>
        public DescribeStopwordOptionsResult DescribeStopwordOptionsResult
        {
            get 
            {
                if(this.describeStopwordOptionsResult == null)
                {
                    this.describeStopwordOptionsResult = new DescribeStopwordOptionsResult();
                }

                return this.describeStopwordOptionsResult; 
            }
            set { this.describeStopwordOptionsResult = value; }
        }
    }
}
    
