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
using ThirdParty.Json.LitJson;

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
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCachingConfig())
                {
                    context.Writer.WritePropertyName("cachingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = CachingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CachingConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataSourceName())
                {
                    context.Writer.WritePropertyName("dataSourceName");
                    context.Writer.Write(publicRequest.DataSourceName);
                }

                if(publicRequest.IsSetFieldName())
                {
                    context.Writer.WritePropertyName("fieldName");
                    context.Writer.Write(publicRequest.FieldName);
                }

                if(publicRequest.IsSetKind())
                {
                    context.Writer.WritePropertyName("kind");
                    context.Writer.Write(publicRequest.Kind);
                }

                if(publicRequest.IsSetPipelineConfig())
                {
                    context.Writer.WritePropertyName("pipelineConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PipelineConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PipelineConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestMappingTemplate())
                {
                    context.Writer.WritePropertyName("requestMappingTemplate");
                    context.Writer.Write(publicRequest.RequestMappingTemplate);
                }

                if(publicRequest.IsSetResponseMappingTemplate())
                {
                    context.Writer.WritePropertyName("responseMappingTemplate");
                    context.Writer.Write(publicRequest.ResponseMappingTemplate);
                }

                if(publicRequest.IsSetSyncConfig())
                {
                    context.Writer.WritePropertyName("syncConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = SyncConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SyncConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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