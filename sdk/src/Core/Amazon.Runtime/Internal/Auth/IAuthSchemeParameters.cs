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
    /// <para>
    /// The input to the authentication scheme resolver (an interface for passing in the data required 
    /// for determining the authentication scheme).
    /// </para>
    /// </summary>
    /// <remarks>
    /// Service specific implementations may include additional properties, for example "region" if the
    /// service is configured to use SigV4.
    /// </remarks>
    public interface IAuthSchemeParameters
    {
        /// <summary>
        /// The service operation being invoked by the SDK.
        /// </summary>
        /// <remarks>
        /// This is included by default for all generated authentication scheme parameters.
        /// </remarks>
        string Operation { get; set; }
    }
}
