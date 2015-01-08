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

/*
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */

using System;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DescribePartition service
    /// </summary>
    public partial class DescribePartitionResponse : DescribePartitionResult
    {
        /// <summary>
        /// Gets and sets the DescribePartitionResult property.
        /// Represents the output of a DescribePartition operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribePartitionResult class are now available on the DescribePartitionResponse class. You should use the properties on DescribePartitionResponse instead of accessing them through DescribePartitionResult.")]
        public DescribePartitionResult DescribePartitionResult
        {
            get
            {
                return this;
            }
        }
    }
}