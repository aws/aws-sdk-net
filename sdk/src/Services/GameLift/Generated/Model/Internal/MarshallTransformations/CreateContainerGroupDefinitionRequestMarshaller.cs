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
                if(publicRequest.IsSetContainerDefinitions())
                {
                    context.Writer.WritePropertyName("ContainerDefinitions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestContainerDefinitionsListValue in publicRequest.ContainerDefinitions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ContainerDefinitionInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestContainerDefinitionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetSchedulingStrategy())
                {
                    context.Writer.WritePropertyName("SchedulingStrategy");
                    context.Writer.Write(publicRequest.SchedulingStrategy);
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

                if(publicRequest.IsSetTotalCpuLimit())
                {
                    context.Writer.WritePropertyName("TotalCpuLimit");
                    context.Writer.Write(publicRequest.TotalCpuLimit.Value);
                }

                if(publicRequest.IsSetTotalMemoryLimit())
                {
                    context.Writer.WritePropertyName("TotalMemoryLimit");
                    context.Writer.Write(publicRequest.TotalMemoryLimit.Value);
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