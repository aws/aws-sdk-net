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

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// <para>
    /// An authentication scheme resolver is an entity within the SDK that determines which authentication scheme to use 
    /// for a service.
    /// </para>
    /// 
    /// <para>
    /// It accepts data from the request (e.g. request members) and client (e.g. AWS region) and returns a list of
    /// authentication scheme options that the SDK should use when authenticating that request.
    /// </para>
    /// </summary>
    public interface IAuthSchemeResolver<T> where T : IAuthSchemeParameters
    {
        /// <summary>
        /// Resolve the authentication scheme that should be used. This is invoked once per SDK request, <i>before</i> endpoint resolution.
        /// </summary>
        /// <returns>
        /// <para>
        /// A list of authentication schemes, in order of preference, that should be used for the request.
        /// </para>
        /// <para>
        /// The SDK will choose the first scheme it supports, or fail the request if no schemes are supported.
        /// </para>
        /// </returns>
        List<IAuthSchemeOption> ResolveAuthScheme(T authParameters);
    }
}
