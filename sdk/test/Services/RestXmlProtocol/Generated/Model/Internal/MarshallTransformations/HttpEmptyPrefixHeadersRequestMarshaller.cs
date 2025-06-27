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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpEmptyPrefixHeaders Request Marshaller
    /// </summary>       
    public partial class HttpEmptyPrefixHeadersRequestMarshaller : IMarshaller<IRequest, HttpEmptyPrefixHeadersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpEmptyPrefixHeadersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(HttpEmptyPrefixHeadersRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "GET";
        
            if (publicRequest.IsSetPrefixHeaders()) 
            {
                //Map of headers with prefix "".
                foreach (var kvpPrefixHeaders in publicRequest.PrefixHeaders)
                {
                     request.Headers[$"{kvpPrefixHeaders.Key}"] = kvpPrefixHeaders.Value;
                }
            }
        
            if (publicRequest.IsSetSpecificHeader()) 
            {
                request.Headers["hello"] = publicRequest.SpecificHeader;
            }
            request.ResourcePath = "/HttpEmptyPrefixHeaders";


            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static HttpEmptyPrefixHeadersRequestMarshaller _instance = new HttpEmptyPrefixHeadersRequestMarshaller();        

        internal static HttpEmptyPrefixHeadersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpEmptyPrefixHeadersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, HttpEmptyPrefixHeadersRequest publicRequest);
    }    
}