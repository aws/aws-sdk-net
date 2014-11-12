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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Returns information about the DescribeScalingProcessTypesResult response and response metadata.
    /// </summary>
    public class DescribeScalingProcessTypesResponse : AmazonWebServiceResponse
    {
        private DescribeScalingProcessTypesResult _describeScalingProcessTypesResult;

        /// <summary>
        /// Gets and sets the DescribeScalingProcessTypesResult property.
        /// Represents the output of a DescribeScalingProcessTypes operation.
        /// </summary>
        public DescribeScalingProcessTypesResult DescribeScalingProcessTypesResult
        {
            get
            {
                if(this._describeScalingProcessTypesResult == null)
                {
                    this._describeScalingProcessTypesResult = new DescribeScalingProcessTypesResult();
                }
                return this._describeScalingProcessTypesResult;
            }
            set { this._describeScalingProcessTypesResult = value; }
        }
    }
}