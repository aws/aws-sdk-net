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
using Amazon.Runtime;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Returns information about the DescribeDeploymentsResult response and response metadata.
    /// </summary>
    public class DescribeDeploymentsResponse : AmazonWebServiceResponse
    {
        private DescribeDeploymentsResult _describeDeploymentsResult;

        /// <summary>
        /// Gets and sets the DescribeDeploymentsResult property.
        /// Represents the output of a DescribeDeployments operation.
        /// </summary>
        public DescribeDeploymentsResult DescribeDeploymentsResult
        {
            get
            {
                if(this._describeDeploymentsResult == null)
                {
                    this._describeDeploymentsResult = new DescribeDeploymentsResult();
                }
                return this._describeDeploymentsResult;
            }
            set { this._describeDeploymentsResult = value; }
        }
    }
}