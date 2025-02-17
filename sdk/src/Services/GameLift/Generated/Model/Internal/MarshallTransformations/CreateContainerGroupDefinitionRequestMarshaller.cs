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

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContainerGroupDefinition Request Marshaller
    /// </summary>       
    public class CreateContainerGroupDefinitionRequestMarshaller : IMarshaller<IRequest, CreateContainerGroupDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContainerGroupDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateContainerGroupDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.CreateContainerGroupDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContainerGroupType())
                {
                    context.Writer.WritePropertyName("ContainerGroupType");
                    context.Writer.Write(publicRequest.ContainerGroupType);
                }

                if(publicRequest.IsSetGameServerContainerDefinition())
                {
                    context.Writer.WritePropertyName("GameServerContainerDefinition");
                    context.Writer.WriteObjectStart();

                    var marshaller = GameServerContainerDefinitionInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GameServerContainerDefinition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOperatingSystem())
                {
                    context.Writer.WritePropertyName("OperatingSystem");
                    context.Writer.Write(publicRequest.OperatingSystem);
                }

                if(publicRequest.IsSetSupportContainerDefinitions())
                {
                    context.Writer.WritePropertyName("SupportContainerDefinitions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSupportContainerDefinitionsListValue in publicRequest.SupportContainerDefinitions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SupportContainerDefinitionInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestSupportContainerDefinitionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTotalMemoryLimitMebibytes())
                {
                    context.Writer.WritePropertyName("TotalMemoryLimitMebibytes");
                    context.Writer.Write(publicRequest.TotalMemoryLimitMebibytes);
                }

                if(publicRequest.IsSetTotalVcpuLimit())
                {
                    context.Writer.WritePropertyName("TotalVcpuLimit");
                    if(StringUtils.IsSpecialDoubleValue(publicRequest.TotalVcpuLimit))
                    {
                        context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.TotalVcpuLimit));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.TotalVcpuLimit);
                    }
                }

                if(publicRequest.IsSetVersionDescription())
                {
                    context.Writer.WritePropertyName("VersionDescription");
                    context.Writer.Write(publicRequest.VersionDescription);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateContainerGroupDefinitionRequestMarshaller _instance = new CreateContainerGroupDefinitionRequestMarshaller();        

        internal static CreateContainerGroupDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateContainerGroupDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}