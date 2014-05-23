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
    /// Returns information about the DescribeElasticIpsResult response and response metadata.
    /// </summary>
    public class DescribeElasticIpsResponse : AmazonWebServiceResponse
    {
        private DescribeElasticIpsResult _describeElasticIpsResult;

        /// <summary>
        /// Gets and sets the DescribeElasticIpsResult property.
        /// Represents the output of a DescribeElasticIps operation.
        /// </summary>
        public DescribeElasticIpsResult DescribeElasticIpsResult
        {
            get
            {
                if(this._describeElasticIpsResult == null)
                {
                    this._describeElasticIpsResult = new DescribeElasticIpsResult();
                }
                return this._describeElasticIpsResult;
            }
            set { this._describeElasticIpsResult = value; }
        }
    }
}