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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Returns information about the  DescribeInstanceHealth response and response metadata.
    /// </summary>
    public class DescribeInstanceHealthResponse : DescribeInstanceHealthResult
    {
        /// <summary>
        /// Gets and sets the DescribeInstanceHealthResult property.
        /// The output for the DescribeInstanceHealth action.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeInstanceHealthResult class are now available on the DescribeInstanceHealthResponse class. You should use the properties on DescribeInstanceHealthResponse instead of accessing them through DescribeInstanceHealthResult.")]
        public DescribeInstanceHealthResult DescribeInstanceHealthResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
