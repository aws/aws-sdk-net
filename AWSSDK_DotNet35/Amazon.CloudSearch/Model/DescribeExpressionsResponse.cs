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
    /// Returns information about the  DescribeExpressions response and response metadata.
    /// </summary>
    public partial class DescribeExpressionsResponse : DescribeExpressionsResult
    {
        /// <summary>
        /// Gets and sets the DescribeExpressionsResult property.
        /// The result of a DescribeExpressions request. Contains the expressions configured for the domain specified in the request.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeExpressionsResult class are now available on the DescribeExpressionsResponse class. You should use the properties on DescribeExpressionsResponse instead of accessing them through DescribeExpressionsResult.")]
        public DescribeExpressionsResult DescribeExpressionsResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
