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

using Smithy.Identity.Abstractions;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// The <a href="https://smithy.io/2.0/aws/aws-auth.html#aws-auth-sigv4-trait">AWS Signature Version 4 authentication scheme</a> (which 
    /// uses AWS credentials and the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">SigV4 signer</a>).
    /// </summary>
    public class AwsV4AuthScheme : IAuthScheme<AWSCredentials>
    {
        /// <inheritdoc/>
        public string SchemeId => "aws.auth#sigv4";
    }
}
