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

/*
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpPrefixHeaders Request Marshaller
    /// </summary>       
    public class HttpPrefixHeadersRequestMarshaller : IMarshaller<IRequest, HttpPrefixHeadersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpPrefixHeadersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(HttpPrefixHeadersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "GET";

            request.ResourcePath = "/HttpPrefixHeaders";
        
            if (publicRequest.IsSetFoo()) 
            {
                request.Headers["X-Foo"] = publicRequest.Foo;
            }
        
            if (publicRequest.IsSetFooMap()) 
            {
                //Map of headers with prefix "X-Foo-".
                foreach (var kvpFooMap in publicRequest.FooMap)
                {
                     request.Headers[$"X-Foo-{kvpFooMap.Key}"] = kvpFooMap.Value;
                }
            }

            return request;
        }
        private static HttpPrefixHeadersRequestMarshaller _instance = new HttpPrefixHeadersRequestMarshaller();        

        internal static HttpPrefixHeadersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpPrefixHeadersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}