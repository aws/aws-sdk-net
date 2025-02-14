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
using System;
using System.Collections.Generic;

namespace Amazon.Runtime.Credentials.Internal.IdentityResolvers
{
    /// <inheritdoc/>
    public class DefaultIdentityResolverConfiguration : IIdentityResolverConfiguration
    {
        public static readonly IIdentityResolverConfiguration Instance = new DefaultIdentityResolverConfiguration();
        private static readonly Dictionary<Type, IIdentityResolver> identityResolvers = new Dictionary<Type, IIdentityResolver>()
            {
                { typeof(AnonymousAWSCredentials), new AnonymousIdentityResolver() },
                { typeof(AWSCredentials), new DefaultAWSCredentialsIdentityResolver() },
            };

        /// <inheritdoc/>
        public IIdentityResolver GetIdentityResolver<T>() where T : BaseIdentity
        {
            if(identityResolvers.TryGetValue(typeof(T), out var identityResolver))
                return identityResolver;

            throw new NotImplementedException($"{typeof(T).Name} is not supported");

        }
    }
}
