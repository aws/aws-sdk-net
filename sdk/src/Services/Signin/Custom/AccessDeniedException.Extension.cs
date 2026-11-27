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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signin.Model
{
    // Reports the OAuth2 Error value to Core's credential refresh classifier through the
    // ICredentialRefreshErrorCode interface. The Sign-In service reports why it rejected a refresh (TOKEN_EXPIRED,
    // USER_CREDENTIALS_CHANGED or INSUFFICIENT_PERMISSIONS, which are non-recoverable) in Error, while the wire
    // ErrorCode is the generic "AccessDeniedException". Core reads the value through the interface, with no
    // reflection, so the getter is not removed by trimming. The interface is implemented explicitly, so this adds no
    // member to AccessDeniedException's public surface.
    public partial class AccessDeniedException : ICredentialRefreshErrorCode
    {
        // Explicit implementation keeps this SDK-contract member off AccessDeniedException's public surface.
        // CA1033 is intentionally suppressed (matching the ICoreAmazonSignin explicit members in this package):
        // only Core reads the value, so no child type needs a callable alternative.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1033:Interface methods should be callable by child types")]
        string ICredentialRefreshErrorCode.EffectiveRefreshErrorCode => this.Error?.Value;
    }
}
