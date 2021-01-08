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
    /// UpdateGameServerGroup Request Marshaller
    /// </summary>       
    public class UpdateGameServerGroupRequestMarshaller : IMarshaller<IRequest, UpdateGameServerGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGameServerGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGameServerGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.UpdateGameServerGroup";
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
                if(publicRequest.IsSetBalancingStrategy())
                {
                    context.Writer.WritePropertyName("BalancingStrategy");
                    context.Writer.Write(publicRequest.BalancingStrategy);
                }

                if(publicRequest.IsSetGameServerGroupName())
                {
                    context.Writer.WritePropertyName("GameServerGroupName");
                    context.Writer.Write(publicRequest.GameServerGroupName);
                }

                if(publicRequest.IsSetGameServerProtectionPolicy())
                {
                    context.Writer.WritePropertyName("GameServerProtectionPolicy");
                    context.Writer.Write(publicRequest.GameServerProtectionPolicy);
                }

                if(publicRequest.IsSetInstanceDefinitions())
                {
                    context.Writer.WritePropertyName("InstanceDefinitions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceDefinitionsListValue in publicRequest.InstanceDefinitions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InstanceDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestInstanceDefinitionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateGameServerGroupRequestMarshaller _instance = new UpdateGameServerGroupRequestMarshaller();        

        internal static UpdateGameServerGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGameServerGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}