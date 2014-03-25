/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Returns information about the  DescribeScalingParameters response and response metadata.
    /// </summary>
    public partial class DescribeScalingParametersResponse : DescribeScalingParametersResult
    {
        /// <summary>
        /// Gets and sets the DescribeScalingParametersResult property.
        /// The result of a DescribeScalingParameters request. Contains the scaling parameters configured for the domain specified in the request.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeScalingParametersResult class are now available on the DescribeScalingParametersResponse class. You should use the properties on DescribeScalingParametersResponse instead of accessing them through DescribeScalingParametersResult.")]
        public DescribeScalingParametersResult DescribeScalingParametersResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
