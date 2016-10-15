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
    /// CreateFleet Request Marshaller
    /// </summary>       
    public class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.CreateFleet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBuildId())
                {
                    context.Writer.WritePropertyName("BuildId");
                    context.Writer.Write(publicRequest.BuildId);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEC2InboundPermissions())
                {
                    context.Writer.WritePropertyName("EC2InboundPermissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEC2InboundPermissionsListValue in publicRequest.EC2InboundPermissions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = IpPermissionMarshaller.Instance;
                        marshaller.Marshall(publicRequestEC2InboundPermissionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEC2InstanceType())
                {
                    context.Writer.WritePropertyName("EC2InstanceType");
                    context.Writer.Write(publicRequest.EC2InstanceType);
                }

                if(publicRequest.IsSetLogPaths())
                {
                    context.Writer.WritePropertyName("LogPaths");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLogPathsListValue in publicRequest.LogPaths)
                    {
                            context.Writer.Write(publicRequestLogPathsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNewGameSessionProtectionPolicy())
                {
                    context.Writer.WritePropertyName("NewGameSessionProtectionPolicy");
                    context.Writer.Write(publicRequest.NewGameSessionProtectionPolicy);
                }

                if(publicRequest.IsSetResourceCreationLimitPolicy())
                {
                    context.Writer.WritePropertyName("ResourceCreationLimitPolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceCreationLimitPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceCreationLimitPolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRuntimeConfiguration())
                {
                    context.Writer.WritePropertyName("RuntimeConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RuntimeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RuntimeConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServerLaunchParameters())
                {
                    context.Writer.WritePropertyName("ServerLaunchParameters");
                    context.Writer.Write(publicRequest.ServerLaunchParameters);
                }

                if(publicRequest.IsSetServerLaunchPath())
                {
                    context.Writer.WritePropertyName("ServerLaunchPath");
                    context.Writer.Write(publicRequest.ServerLaunchPath);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}