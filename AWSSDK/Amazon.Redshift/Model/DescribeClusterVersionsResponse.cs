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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about the DescribeClusterVersionsResult response and response metadata.
    /// </summary>
    public class DescribeClusterVersionsResponse : AmazonWebServiceResponse
    {
        private DescribeClusterVersionsResult _describeClusterVersionsResult;

        /// <summary>
        /// Gets and sets the DescribeClusterVersionsResult property.
        /// Represents the output of a DescribeClusterVersions operation.
        /// </summary>
        public DescribeClusterVersionsResult DescribeClusterVersionsResult
        {
            get
            {
                if(this._describeClusterVersionsResult == null)
                {
                    this._describeClusterVersionsResult = new DescribeClusterVersionsResult();
                }
                return this._describeClusterVersionsResult;
            }
            set { this._describeClusterVersionsResult = value; }
        }
    }
}