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

namespace Amazon.Runtime.Identity
{
    /// <summary>
    /// An identity is an entity within the SDK representing who the customer is.
    /// For example, the customer's identity could be anonymous, a token, a public / private key pair, etc...
    /// </summary>
    public abstract class BaseIdentity
    {
        /// <summary>
        /// The time after which this identity will no longer be valid. If this is null, an expiration time
        /// is not known (for example, when using long-term credentials).
        /// </summary>
        public virtual DateTime? Expiration { get; set; }
    }
}
