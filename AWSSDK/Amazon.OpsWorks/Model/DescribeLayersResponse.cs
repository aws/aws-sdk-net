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
    /// Returns information about the DescribeLayersResult response and response metadata.
    /// </summary>
    public class DescribeLayersResponse : AmazonWebServiceResponse
    {
        private DescribeLayersResult _describeLayersResult;

        /// <summary>
        /// Gets and sets the DescribeLayersResult property.
        /// Represents the output of a DescribeLayers operation.
        /// </summary>
        public DescribeLayersResult DescribeLayersResult
        {
            get
            {
                if(this._describeLayersResult == null)
                {
                    this._describeLayersResult = new DescribeLayersResult();
                }
                return this._describeLayersResult;
            }
            set { this._describeLayersResult = value; }
        }
    }
}