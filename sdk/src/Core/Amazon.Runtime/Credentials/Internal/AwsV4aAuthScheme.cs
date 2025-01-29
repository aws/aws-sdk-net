﻿/*
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

using Smithy.Identity.Abstractions;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// The <a href="https://smithy.io/2.0/aws/aws-auth.html#aws-auth-sigv4a-trait">AWS Signature Version 4 Asymmetric (SigV4A) authentication 
    /// scheme</a> (which uses AWS credentials and the SigV4A signer).
    /// </summary>
    public class AwsV4aAuthScheme : IAuthScheme<AWSCredentials>
    {
        /// <inheritdoc/>
        public string SchemeId => "aws.auth#sigv4a";

#pragma warning disable CA1065
        public IIdentityResolver IdentityResolver => throw new System.NotImplementedException();
#pragma warning restore CA1065
    }
}
