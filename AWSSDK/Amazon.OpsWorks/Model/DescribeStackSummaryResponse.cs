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
    /// Returns information about the DescribeStackSummaryResult response and response metadata.
    /// </summary>
    public class DescribeStackSummaryResponse : AmazonWebServiceResponse
    {
        private DescribeStackSummaryResult _describeStackSummaryResult;

        /// <summary>
        /// Gets and sets the DescribeStackSummaryResult property.
        /// Represents the output of a DescribeStackSummary operation.
        /// </summary>
        public DescribeStackSummaryResult DescribeStackSummaryResult
        {
            get
            {
                if(this._describeStackSummaryResult == null)
                {
                    this._describeStackSummaryResult = new DescribeStackSummaryResult();
                }
                return this._describeStackSummaryResult;
            }
            set { this._describeStackSummaryResult = value; }
        }
    }
}