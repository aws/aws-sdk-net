/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Amazon.Util;

using Amazon.Runtime.Internal.Auth;
using System.Net.Http;

namespace Amazon.Runtime
{
    [CLSCompliant(false)]
    public partial interface IClientConfig
    {
        /// <summary>
        /// Gets the ProxyHost property.
        /// </summary>
        string ProxyHost { get;  }

        /// <summary>
        /// Gets the ProxyPort property.
        /// </summary>
        int ProxyPort { get;  }

        /// <summary>
        /// Returns a WebProxy instance configured to match the proxy settings
        /// in the client configuration.
        /// </summary>
        IWebProxy GetWebProxy();

#if PCL
        /// <summary>
        /// IHttpClientFactory used to create new HttpClients.
        /// If null, an HttpClient will be created by the SDK.
        /// The client must not be shared with other parts of the application, and will be disposed of by the SDK after use.
        /// Note that IClientConfig members such as ProxyHost, ProxyPort, GetWebProxy, and AllowAutoRedirect
        /// will have no effect unless they're used explicitly by the IHttpClientFactory implementation.
        /// If this property is set then HttpClient caching will be disabled,
        /// regardless of the CacheHttpClient property's value.
        /// 
        /// See https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/http-stack?context=xamarin/ios and
        /// https://docs.microsoft.com/en-us/xamarin/android/app-fundamentals/http-stack?context=xamarin%2Fcross-platform&tabs=macos#ssltls-implementation-build-option
        /// for guidance on creating HttpClients for your platform.
        /// </summary>
        IHttpClientFactory HttpClientFactory { get; }
#else
        /// <summary>
        /// HttpClientFactory used to create new HttpClients.
        /// If null, an HttpClient will be created by the SDK.
        /// Note that IClientConfig members such as ProxyHost, ProxyPort, GetWebProxy, and AllowAutoRedirect
        /// will have no effect unless they're used explicitly by the HttpClientFactory implementation.
        ///
        /// See https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/http-stack?context=xamarin/ios and
        /// https://docs.microsoft.com/en-us/xamarin/android/app-fundamentals/http-stack?context=xamarin%2Fcross-platform&tabs=macos#ssltls-implementation-build-option
        /// for guidance on creating HttpClients for your platform.
        /// </summary>
        HttpClientFactory HttpClientFactory { get; }
#endif
    }
}