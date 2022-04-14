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
using System.Diagnostics;

namespace Amazon.Runtime
{
    /// <summary>
    /// Contains the metadata necessary for <see cref="BearerTokenSigner"/> to sign outgoing Api requests
    /// with an Authorization header.
    /// </summary>
    /// <remarks>
    /// This class is the focused public projection of the internal class
    /// <see cref="Amazon.Runtime.Credentials.Internal.SsoToken"/>
    /// </remarks>
    [DebuggerDisplay("{"+ nameof(Token) + "}")]
    public class AWSToken
    {
        public string Token { get; set; }
        public DateTime? ExpiresAt { get; set; }

        public override string ToString()
        {
            return Token;
        }
    }
}