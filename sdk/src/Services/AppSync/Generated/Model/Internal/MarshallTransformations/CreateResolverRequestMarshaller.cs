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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
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
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateResolver Request Marshaller
    /// </summary>       
    public class CreateResolverRequestMarshaller : IMarshaller<IRequest, CreateResolverRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateResolverRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateResolverRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
                throw new AmazonAppSyncException("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            if (!publicRequest.IsSetTypeName())
                throw new AmazonAppSyncException("Request object does not have required field TypeName set");
            request.AddPathResource("{typeName}", StringUtils.FromString(publicRequest.TypeName));
            request.ResourcePath = "/v1/apis/{apiId}/types/{typeName}/resolvers";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCachingConfig())
            {
                context.Writer.WritePropertyName("cachingConfig");
                context.Writer.WriteStartObject();

                var marshaller = CachingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CachingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCode())
            {
                context.Writer.WritePropertyName("code");
                context.Writer.WriteStringValue(publicRequest.Code);
            }

            if(publicRequest.IsSetDataSourceName())
            {
                context.Writer.WritePropertyName("dataSourceName");
                context.Writer.WriteStringValue(publicRequest.DataSourceName);
            }

            if(publicRequest.IsSetFieldName())
            {
                context.Writer.WritePropertyName("fieldName");
                context.Writer.WriteStringValue(publicRequest.FieldName);
            }

            if(publicRequest.IsSetKind())
            {
                context.Writer.WritePropertyName("kind");
                context.Writer.WriteStringValue(publicRequest.Kind);
            }

            if(publicRequest.IsSetMaxBatchSize())
            {
                context.Writer.WritePropertyName("maxBatchSize");
                context.Writer.WriteNumberValue(publicRequest.MaxBatchSize.Value);
            }

            if(publicRequest.IsSetMetricsConfig())
            {
                context.Writer.WritePropertyName("metricsConfig");
                context.Writer.WriteStringValue(publicRequest.MetricsConfig);
            }

            if(publicRequest.IsSetPipelineConfig())
            {
                context.Writer.WritePropertyName("pipelineConfig");
                context.Writer.WriteStartObject();

                var marshaller = PipelineConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.PipelineConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequestMappingTemplate())
            {
                context.Writer.WritePropertyName("requestMappingTemplate");
                context.Writer.WriteStringValue(publicRequest.RequestMappingTemplate);
            }

            if(publicRequest.IsSetResponseMappingTemplate())
            {
                context.Writer.WritePropertyName("responseMappingTemplate");
                context.Writer.WriteStringValue(publicRequest.ResponseMappingTemplate);
            }

            if(publicRequest.IsSetRuntime())
            {
                context.Writer.WritePropertyName("runtime");
                context.Writer.WriteStartObject();

                var marshaller = AppSyncRuntimeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Runtime, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSyncConfig())
            {
                context.Writer.WritePropertyName("syncConfig");
                context.Writer.WriteStartObject();

                var marshaller = SyncConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SyncConfig, context);

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
        private static CreateResolverRequestMarshaller _instance = new CreateResolverRequestMarshaller();        

        internal static CreateResolverRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateResolverRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}