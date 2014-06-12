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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DescribeDeployments service
    /// </summary>
    public partial class DescribeDeploymentsResponse : DescribeDeploymentsResult
    {
        /// <summary>
        /// Gets and sets the DescribeDeploymentsResult property.
        /// Represents the output of a DescribeDeployments operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeDeploymentsResult class are now available on the DescribeDeploymentsResponse class. You should use the properties on DescribeDeploymentsResponse instead of accessing them through DescribeDeploymentsResult.")]
        public DescribeDeploymentsResult DescribeDeploymentsResult
        {
            get
            {
                return this;
            }
        }
    }
}