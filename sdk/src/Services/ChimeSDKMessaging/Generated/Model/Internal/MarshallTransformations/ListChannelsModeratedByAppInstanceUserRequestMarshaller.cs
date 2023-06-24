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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListChannelsModeratedByAppInstanceUser Request Marshaller
    /// </summary>       
    public class ListChannelsModeratedByAppInstanceUserRequestMarshaller : IMarshaller<IRequest, ListChannelsModeratedByAppInstanceUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListChannelsModeratedByAppInstanceUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListChannelsModeratedByAppInstanceUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "GET";

            request.AddSubResource("scope", "app-instance-user-moderated-channels");
            
            if (publicRequest.IsSetAppInstanceUserArn())
                request.Parameters.Add("app-instance-user-arn", StringUtils.FromString(publicRequest.AppInstanceUserArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/channels";
        
            if (publicRequest.IsSetChimeBearer()) 
            {
                request.Headers["x-amz-chime-bearer"] = publicRequest.ChimeBearer;
            }
            request.UseQueryString = true;

            return request;
        }
        private static ListChannelsModeratedByAppInstanceUserRequestMarshaller _instance = new ListChannelsModeratedByAppInstanceUserRequestMarshaller();        

        internal static ListChannelsModeratedByAppInstanceUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListChannelsModeratedByAppInstanceUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}