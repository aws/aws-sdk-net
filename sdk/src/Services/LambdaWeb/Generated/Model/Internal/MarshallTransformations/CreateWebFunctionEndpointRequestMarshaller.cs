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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaWeb.Model;
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
namespace Amazon.LambdaWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWebFunctionEndpoint Request Marshaller
    /// </summary>       
    public class CreateWebFunctionEndpointRequestMarshaller : IMarshaller<IRequest, CreateWebFunctionEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWebFunctionEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWebFunctionEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LambdaWeb");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-07";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFunctionName())
                throw new AmazonLambdaWebException("Request object does not have required field FunctionName set");
            request.AddPathResource("{functionName}", StringUtils.FromString(publicRequest.FunctionName));
            request.ResourcePath = "/2025-03-07/web-functions/{functionName}/endpoints";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthType())
            {
                context.Writer.WritePropertyName("authType");
                context.Writer.WriteStringValue(publicRequest.AuthType);
            }

            if(publicRequest.IsSetAutoDeploymentMode())
            {
                context.Writer.WritePropertyName("autoDeploymentMode");
                context.Writer.WriteStringValue(publicRequest.AutoDeploymentMode);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEndpointName())
            {
                context.Writer.WritePropertyName("endpointName");
                context.Writer.WriteStringValue(publicRequest.EndpointName);
            }

            if(publicRequest.IsSetEndpointType())
            {
                context.Writer.WritePropertyName("endpointType");
                context.Writer.WriteStringValue(publicRequest.EndpointType);
            }

            if(publicRequest.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRegionsListValue in publicRequest.Regions)
                {
                        context.Writer.WriteStringValue(publicRequestRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRevisionWeights())
            {
                context.Writer.WritePropertyName("revisionWeights");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRevisionWeightsListValue in publicRequest.RevisionWeights)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RevisionWeightMarshaller.Instance;
                    marshaller.Marshall(publicRequestRevisionWeightsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetScalingConfig())
            {
                context.Writer.WritePropertyName("scalingConfig");
                context.Writer.WriteStartObject();

                var marshaller = ScalingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScalingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetThrottleConfig())
            {
                context.Writer.WritePropertyName("throttleConfig");
                context.Writer.WriteStartObject();

                var marshaller = ThrottleConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ThrottleConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateWebFunctionEndpointRequestMarshaller _instance = new CreateWebFunctionEndpointRequestMarshaller();        

        internal static CreateWebFunctionEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWebFunctionEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}