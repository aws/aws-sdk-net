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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
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
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetNextMessage Request Marshaller
    /// </summary>       
    public class GetNextMessageRequestMarshaller : IMarshaller<IRequest, GetNextMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetNextMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetNextMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAssistantId())
                throw new AmazonQConnectException("Request object does not have required field AssistantId set");
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonQConnectException("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            
            if (publicRequest.IsSetNextMessageToken())
                request.Parameters.Add("nextMessageToken", StringUtils.FromString(publicRequest.NextMessageToken));
            request.ResourcePath = "/assistants/{assistantId}/sessions/{sessionId}/messages/next";
            request.UseQueryString = true;

            return request;
        }
        private static GetNextMessageRequestMarshaller _instance = new GetNextMessageRequestMarshaller();        

        internal static GetNextMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetNextMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}