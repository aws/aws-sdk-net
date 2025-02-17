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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAsyncInvoke Request Marshaller
    /// </summary>       
    public class GetAsyncInvokeRequestMarshaller : IMarshaller<IRequest, GetAsyncInvokeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAsyncInvokeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAsyncInvokeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-30";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetInvocationArn())
                throw new AmazonBedrockRuntimeException("Request object does not have required field InvocationArn set");
            request.AddPathResource("{invocationArn}", StringUtils.FromString(publicRequest.InvocationArn));
            request.ResourcePath = "/async-invoke/{invocationArn}";

            return request;
        }
        private static GetAsyncInvokeRequestMarshaller _instance = new GetAsyncInvokeRequestMarshaller();        

        internal static GetAsyncInvokeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAsyncInvokeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}