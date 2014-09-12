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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */

using System;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DescribeChapCredentials service
    /// </summary>
    public partial class DescribeChapCredentialsResponse : DescribeChapCredentialsResult
    {
        /// <summary>
        /// Gets and sets the DescribeChapCredentialsResult property.
        /// Represents the output of a DescribeChapCredentials operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeChapCredentialsResult class are now available on the DescribeChapCredentialsResponse class. You should use the properties on DescribeChapCredentialsResponse instead of accessing them through DescribeChapCredentialsResult.")]
        public DescribeChapCredentialsResult DescribeChapCredentialsResult
        {
            get
            {
                return this;
            }
        }
    }
}