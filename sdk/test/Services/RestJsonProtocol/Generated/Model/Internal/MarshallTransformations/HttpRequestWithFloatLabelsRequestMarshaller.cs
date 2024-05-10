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
    /// HttpRequestWithFloatLabels Request Marshaller
    /// </summary>       
    public class HttpRequestWithFloatLabelsRequestMarshaller : IMarshaller<IRequest, HttpRequestWithFloatLabelsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpRequestWithFloatLabelsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(HttpRequestWithFloatLabelsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDouble())
                throw new AmazonRestJsonProtocolException("Request object does not have required field Double set");
            request.AddPathResource("{double}", StringUtils.FromDouble(publicRequest.Double));
            if (!publicRequest.IsSetFloat())
                throw new AmazonRestJsonProtocolException("Request object does not have required field Float set");
            request.AddPathResource("{float}", StringUtils.FromFloat(publicRequest.Float));
            request.ResourcePath = "/FloatHttpLabels/{float}/{double}";

            return request;
        }
        private static HttpRequestWithFloatLabelsRequestMarshaller _instance = new HttpRequestWithFloatLabelsRequestMarshaller();        

        internal static HttpRequestWithFloatLabelsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpRequestWithFloatLabelsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}