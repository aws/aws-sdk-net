/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Internal
{
    /// <summary>
    /// Custom EC2 retry policy.
    /// This policy adds service specific error codes to retry on.
    /// </summary>
    public class EC2RetryPolicy : DefaultRetryPolicy
    {
        /// <summary>
        /// Constructor for EC2RetryPolicy.
        /// </summary>
        /// <param name="config">The IClientConfig object</param>
        public EC2RetryPolicy(IClientConfig config) :
            base(config)
        {
            ThrottlingErrorCodes.Add("EC2ThrottledException");
        }
    }

    /// <summary>
    /// Custom EC2 retry policy.
    /// This policy adds service specific error codes to retry on.
    /// </summary>
    public class EC2StandardRetryPolicy : StandardRetryPolicy
    {
        /// <summary>
        /// Constructor for EC2StandardRetryPolicy.
        /// </summary>
        /// <param name="config">The IClientConfig object</param>
        public EC2StandardRetryPolicy(IClientConfig config) :
            base(config)
        {
            ThrottlingErrorCodes.Add("EC2ThrottledException");
        }
    }

    /// <summary>
    /// Custom EC2 retry policy.
    /// This policy adds service specific error codes to retry on.
    /// </summary>
    public class EC2AdaptiveRetryPolicy : AdaptiveRetryPolicy
    {
        /// <summary>
        /// Constructor for EC2AdaptiveRetryPolicy.
        /// </summary>
        /// <param name="config">The IClientConfig object</param>
        public EC2AdaptiveRetryPolicy(IClientConfig config) :
            base(config)
        {
            ThrottlingErrorCodes.Add("EC2ThrottledException");
        }
    }
}
