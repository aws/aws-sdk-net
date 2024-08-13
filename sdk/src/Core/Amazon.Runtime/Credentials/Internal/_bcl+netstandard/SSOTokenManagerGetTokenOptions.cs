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
using System.Collections.Generic;
using Amazon.Runtime.SharedInterfaces;

namespace Amazon.Runtime.Credentials.Internal
{
    public class SSOTokenManagerGetTokenOptions
    {
        private const string SsoClientTypePublic = "public";

        /// <inheritdoc cref="SsoToken.StartUrl"/>
        public string StartUrl { get; set; }

        /// <inheritdoc cref="SsoToken.Session"/>
        public string Session { get; set; }

        /// <inheritdoc cref="SsoToken.Region"/>
        public string Region { get; set; }

        /// <summary>
        /// Set to override the sso cache location.  Leave null
        /// to use the Default
        /// </summary>
        public string CacheFolderLocation { get; set; }

        /// <inheritdoc cref="SSOAWSCredentialsOptions.ClientName"/>
        public string ClientName { get; set; }

        /// <inheritdoc cref="GetSsoTokenRequest.ClientType"/>
        public string ClientType { get; set; } = SsoClientTypePublic;

        /// <inheritdoc cref="GetSsoTokenRequest.Scopes"/>
        public IList<string> Scopes { get; set; }

        /// <inheritdoc cref="SSOAWSCredentialsOptions.SsoVerificationCallback"/>
        public Action<SsoVerificationArguments> SsoVerificationCallback { get; set; }

        /// <inheritdoc cref="GetSsoTokenRequest.PkceFlowOptions"/>
        public PkceFlowOptions PkceFlowOptions { get; set; }

        /// <summary>
        /// This field controls how <see cref="SSOTokenManager"/> should behave if it does not find a valid or
        /// refreshable token.
        /// <para />
        /// If <c>true</c>, then <see cref="SSOTokenManager"/> will use ICoreAmazonSSOOIDC.GetSsoToken
        /// to start an authorization flow and mint a new token and cache the result.
        /// If <c>false</c> <see cref="SSOTokenManager"/> will throw an exception if it finds
        /// an expired token.  It will take no action if finds no cached token.
        /// <para />
        /// NOTE: If setting to <c>true</c>, either <see cref="SsoVerificationCallback"/> or <see cref="PkceFlowOptions"/> must 
        /// also be set for authorization flow to succeed.
        /// </summary>
        public bool SupportsGettingNewToken { get; set; } = true;
    }
}
