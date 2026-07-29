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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaMicrovms.Model;
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
namespace Amazon.LambdaMicrovms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMicrovmImage Request Marshaller
    /// </summary>       
    public class UpdateMicrovmImageRequestMarshaller : IMarshaller<IRequest, UpdateMicrovmImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMicrovmImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMicrovmImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LambdaMicrovms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-09";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetImageIdentifier())
                throw new AmazonLambdaMicrovmsException("Request object does not have required field ImageIdentifier set");
            request.AddPathResource("{imageIdentifier}", StringUtils.FromString(publicRequest.ImageIdentifier));
            request.ResourcePath = "/2025-09-09/microvm-images/{imageIdentifier}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalOsCapabilities())
            {
                context.Writer.WritePropertyName("additionalOsCapabilities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalOsCapabilitiesListValue in publicRequest.AdditionalOsCapabilities)
                {
                        context.Writer.WriteStringValue(publicRequestAdditionalOsCapabilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBaseImageArn())
            {
                context.Writer.WritePropertyName("baseImageArn");
                context.Writer.WriteStringValue(publicRequest.BaseImageArn);
            }

            if(publicRequest.IsSetBaseImageVersion())
            {
                context.Writer.WritePropertyName("baseImageVersion");
                context.Writer.WriteStringValue(publicRequest.BaseImageVersion);
            }

            if(publicRequest.IsSetBuildRoleArn())
            {
                context.Writer.WritePropertyName("buildRoleArn");
                context.Writer.WriteStringValue(publicRequest.BuildRoleArn);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCodeArtifact())
            {
                context.Writer.WritePropertyName("codeArtifact");
                context.Writer.WriteStartObject();

                var marshaller = CodeArtifactMarshaller.Instance;
                marshaller.Marshall(publicRequest.CodeArtifact, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCpuConfigurations())
            {
                context.Writer.WritePropertyName("cpuConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCpuConfigurationsListValue in publicRequest.CpuConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CpuConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCpuConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEgressNetworkConnectors())
            {
                context.Writer.WritePropertyName("egressNetworkConnectors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEgressNetworkConnectorsListValue in publicRequest.EgressNetworkConnectors)
                {
                        context.Writer.WriteStringValue(publicRequestEgressNetworkConnectorsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("environmentVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEnvironmentVariablesKvp in publicRequest.EnvironmentVariables)
                {
                    context.Writer.WritePropertyName(publicRequestEnvironmentVariablesKvp.Key);
                    var publicRequestEnvironmentVariablesValue = publicRequestEnvironmentVariablesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEnvironmentVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHooks())
            {
                context.Writer.WritePropertyName("hooks");
                context.Writer.WriteStartObject();

                var marshaller = HooksMarshaller.Instance;
                marshaller.Marshall(publicRequest.Hooks, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLogging())
            {
                context.Writer.WritePropertyName("logging");
                context.Writer.WriteStartObject();

                var marshaller = LoggingMarshaller.Instance;
                marshaller.Marshall(publicRequest.Logging, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResources())
            {
                context.Writer.WritePropertyName("resources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourcesListValue in publicRequest.Resources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourcesMarshaller.Instance;
                    marshaller.Marshall(publicRequestResourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateMicrovmImageRequestMarshaller _instance = new UpdateMicrovmImageRequestMarshaller();        

        internal static UpdateMicrovmImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMicrovmImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}