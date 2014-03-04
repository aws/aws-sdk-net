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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Returns information about the  DescribeConfigurationOptionsResult response and response metadata.
    /// </summary>
    public class DescribeConfigurationOptionsResponse : AmazonWebServiceResponse
    {
        private DescribeConfigurationOptionsResult describeConfigurationOptionsResult;

        /// <summary>
        /// Gets and sets the DescribeConfigurationOptionsResult property.
        /// Describes the settings for a specified configuration set.
        /// </summary>
        public DescribeConfigurationOptionsResult DescribeConfigurationOptionsResult
        {
            get 
            {
                if(this.describeConfigurationOptionsResult == null)
                {
                    this.describeConfigurationOptionsResult = new DescribeConfigurationOptionsResult();
                }

                return this.describeConfigurationOptionsResult; 
            }
            set { this.describeConfigurationOptionsResult = value; }
        }
    }
}
    
