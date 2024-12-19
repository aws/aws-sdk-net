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

namespace Amazon.Runtime
{
    /// <summary>
    /// <para>
    /// A signer is an entity within the SDK representing a way to generate a signature for a request.
    /// </para>
    /// <para>
    /// A signature is metadata attached to a request that will be sent to the service in order to allow
    /// the service to authenticate the SDK customer's identity.
    /// </para>
    /// </summary>
#pragma warning disable CA1040 // Avoid empty interfaces
    public interface ISigner
#pragma warning restore CA1040 // Avoid empty interfaces
    {
        // TODO: This is a marker interface at the moment since the signers defined in the SDK
        // currently reference internal types that need to be extracted / refactored (e.g. IRequest).
    }
}
