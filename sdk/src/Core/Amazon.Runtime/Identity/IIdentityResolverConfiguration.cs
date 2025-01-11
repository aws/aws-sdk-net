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

namespace Amazon.Runtime.Identity
{
    /// <summary>
    /// The identity resolvers configured in the SDK.
    /// </summary>
    public interface IIdentityResolverConfiguration
    {
        /// <summary>
        /// Retrieves an identity resolver for the specified identity type.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the identity, which must inherit from <see cref="BaseIdentity"/>.
        /// </typeparam>
        IIdentityResolver GetIdentityResolver<T>() where T : BaseIdentity;
    }
}