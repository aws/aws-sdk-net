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
using System;
using System.Collections.Generic;

namespace AWSSDK.ProtocolTests.Utils
{
    /// <summary>
    /// IHttpRequestFactory that creates <see cref="MockHttpRequest{T}"/> instances and keeps track of them
    /// so tests can assert on what the SDK sent.
    /// </summary>
    internal class MockHttpRequestFactory<TRequestContent> : IHttpRequestFactory<TRequestContent>
    {
        private readonly Func<MockHttpRequest<TRequestContent>, MockHttpResponse> _responseCreator;

        public MockHttpRequestFactory(MockHttpResponse response)
            : this(request => response)
        {
        }

        public MockHttpRequestFactory(Func<MockHttpRequest<TRequestContent>, MockHttpResponse> responseCreator)
        {
            _responseCreator = responseCreator;
        }

        public List<MockHttpRequest<TRequestContent>> Requests { get; } = new List<MockHttpRequest<TRequestContent>>();

        public MockHttpRequest<TRequestContent> LastCreatedRequest { get; private set; }

        public IHttpRequest<TRequestContent> CreateHttpRequest(Uri requestUri)
        {
            LastCreatedRequest = new MockHttpRequest<TRequestContent>(requestUri, _responseCreator);
            Requests.Add(LastCreatedRequest);
            return LastCreatedRequest;
        }

        public void Dispose()
        {
        }
    }
}
