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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAppInstanceBots Request Marshaller
    /// </summary>       
    public class ListAppInstanceBotsRequestMarshaller : IMarshaller<IRequest, ListAppInstanceBotsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAppInstanceBotsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAppInstanceBotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKIdentity");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-20";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAppInstanceArn())
                request.Parameters.Add("app-instance-arn", StringUtils.FromString(publicRequest.AppInstanceArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/app-instance-bots";
            request.UseQueryString = true;

            return request;
        }
        private static ListAppInstanceBotsRequestMarshaller _instance = new ListAppInstanceBotsRequestMarshaller();        

        internal static ListAppInstanceBotsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAppInstanceBotsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}