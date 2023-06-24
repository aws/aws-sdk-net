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

namespace Amazon.Runtime.Endpoints
{
    /// <summary>
    /// Static endpoint provider.
    /// Use to resolve an endpoint to a given url.
    /// </summary>
    public class StaticEndpointProvider : IEndpointProvider
    {
        private readonly string _url;

        public StaticEndpointProvider(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            _url = url;
        }

        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            return new Endpoint(_url);
        }
    }
}