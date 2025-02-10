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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpRequestWithGreedyLabelInPath Request Marshaller
    /// </summary>       
    public class HttpRequestWithGreedyLabelInPathRequestMarshaller : IMarshaller<IRequest, HttpRequestWithGreedyLabelInPathRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpRequestWithGreedyLabelInPathRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(HttpRequestWithGreedyLabelInPathRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetBaz())
                throw new AmazonRestJsonProtocolException("Request object does not have required field Baz set");
            request.AddPathResource("{baz+}", StringUtils.FromString(publicRequest.Baz.TrimStart('/')));
            if (!publicRequest.IsSetFoo())
                throw new AmazonRestJsonProtocolException("Request object does not have required field Foo set");
            request.AddPathResource("{foo}", StringUtils.FromString(publicRequest.Foo));
            request.ResourcePath = "/HttpRequestWithGreedyLabelInPath/foo/{foo}/baz/{baz+}";

            return request;
        }
        private static HttpRequestWithGreedyLabelInPathRequestMarshaller _instance = new HttpRequestWithGreedyLabelInPathRequestMarshaller();        

        internal static HttpRequestWithGreedyLabelInPathRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpRequestWithGreedyLabelInPathRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}