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
    /// Returns information about the DescribeReservedNodesResult response and response metadata.
    /// </summary>
    public class DescribeReservedNodesResponse : AmazonWebServiceResponse
    {
        private DescribeReservedNodesResult _describeReservedNodesResult;

        /// <summary>
        /// Gets and sets the DescribeReservedNodesResult property.
        /// Represents the output of a DescribeReservedNodes operation.
        /// </summary>
        public DescribeReservedNodesResult DescribeReservedNodesResult
        {
            get
            {
                if(this._describeReservedNodesResult == null)
                {
                    this._describeReservedNodesResult = new DescribeReservedNodesResult();
                }
                return this._describeReservedNodesResult;
            }
            set { this._describeReservedNodesResult = value; }
        }
    }
}