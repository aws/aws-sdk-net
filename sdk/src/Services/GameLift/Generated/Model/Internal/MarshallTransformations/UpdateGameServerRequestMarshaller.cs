/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGameServer Request Marshaller
    /// </summary>       
    public class UpdateGameServerRequestMarshaller : IMarshaller<IRequest, UpdateGameServerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGameServerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGameServerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.UpdateGameServer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCustomSortKey())
                {
                    context.Writer.WritePropertyName("CustomSortKey");
                    context.Writer.Write(publicRequest.CustomSortKey);
                }

                if(publicRequest.IsSetGameServerData())
                {
                    context.Writer.WritePropertyName("GameServerData");
                    context.Writer.Write(publicRequest.GameServerData);
                }

                if(publicRequest.IsSetGameServerGroupName())
                {
                    context.Writer.WritePropertyName("GameServerGroupName");
                    context.Writer.Write(publicRequest.GameServerGroupName);
                }

                if(publicRequest.IsSetGameServerId())
                {
                    context.Writer.WritePropertyName("GameServerId");
                    context.Writer.Write(publicRequest.GameServerId);
                }

                if(publicRequest.IsSetHealthCheck())
                {
                    context.Writer.WritePropertyName("HealthCheck");
                    context.Writer.Write(publicRequest.HealthCheck);
                }

                if(publicRequest.IsSetUtilizationStatus())
                {
                    context.Writer.WritePropertyName("UtilizationStatus");
                    context.Writer.Write(publicRequest.UtilizationStatus);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateGameServerRequestMarshaller _instance = new UpdateGameServerRequestMarshaller();        

        internal static UpdateGameServerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGameServerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}