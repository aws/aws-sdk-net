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

using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime
{
    /// <summary>
    /// Interface for resolving and prioritizing authentication schemes based on configuration preferences.
    /// </summary>
    public interface IAuthSchemeResolver
    {
        /// <summary>
        /// Resolves and reprioritizes authentication schemes based on the client configuration preferences.
        /// </summary>
        /// <param name="clientConfig">The client configuration containing authentication scheme preferences.</param>
        /// <param name="supportedSchemes">The list of authentication schemes supported by the service operation.</param>
        /// <returns>
        /// An ordered list of authentication schemes with preferred schemes prioritized first,
        /// followed by any remaining supported schemes. Unsupported schemes in the preference list are ignored.
        /// </returns>
        IReadOnlyList<IAuthSchemeOption> ResolveAuthSchemes(
            IClientConfig clientConfig, 
            IReadOnlyList<IAuthSchemeOption> supportedSchemes);
    }
}