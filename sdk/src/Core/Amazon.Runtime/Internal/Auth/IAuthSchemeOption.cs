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

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// The output from the authentication scheme resolver. The resolver returns a list of auth scheme options, 
    /// in the order that they should be used.
    /// </summary>
    public interface IAuthSchemeOption
    {
        /// <summary>
        /// The ID of the scheme to use. This value matches the one returned by <see cref="IAuthScheme{T}.SchemeId"/>.
        /// </summary>
        string SchemeId { get; set; }
    }
}
