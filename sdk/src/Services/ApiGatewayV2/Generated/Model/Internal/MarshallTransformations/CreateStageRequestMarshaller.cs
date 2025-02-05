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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
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
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStage Request Marshaller
    /// </summary>       
    public class CreateStageRequestMarshaller : IMarshaller<IRequest, CreateStageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            request.ResourcePath = "/v2/apis/{apiId}/stages";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessLogSettings())
            {
                context.Writer.WritePropertyName("accessLogSettings");
                context.Writer.WriteStartObject();

                var marshaller = AccessLogSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AccessLogSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoDeploy())
            {
                context.Writer.WritePropertyName("autoDeploy");
                context.Writer.WriteBooleanValue(publicRequest.AutoDeploy.Value);
            }

            if(publicRequest.IsSetClientCertificateId())
            {
                context.Writer.WritePropertyName("clientCertificateId");
                context.Writer.WriteStringValue(publicRequest.ClientCertificateId);
            }

            if(publicRequest.IsSetDefaultRouteSettings())
            {
                context.Writer.WritePropertyName("defaultRouteSettings");
                context.Writer.WriteStartObject();

                var marshaller = RouteSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DefaultRouteSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeploymentId())
            {
                context.Writer.WritePropertyName("deploymentId");
                context.Writer.WriteStringValue(publicRequest.DeploymentId);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetRouteSettings())
            {
                context.Writer.WritePropertyName("routeSettings");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRouteSettingsKvp in publicRequest.RouteSettings)
                {
                    context.Writer.WritePropertyName(publicRequestRouteSettingsKvp.Key);
                    var publicRequestRouteSettingsValue = publicRequestRouteSettingsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = RouteSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequestRouteSettingsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStageName())
            {
                context.Writer.WritePropertyName("stageName");
                context.Writer.WriteStringValue(publicRequest.StageName);
            }

            if(publicRequest.IsSetStageVariables())
            {
                context.Writer.WritePropertyName("stageVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestStageVariablesKvp in publicRequest.StageVariables)
                {
                    context.Writer.WritePropertyName(publicRequestStageVariablesKvp.Key);
                    var publicRequestStageVariablesValue = publicRequestStageVariablesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestStageVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateStageRequestMarshaller _instance = new CreateStageRequestMarshaller();        

        internal static CreateStageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}