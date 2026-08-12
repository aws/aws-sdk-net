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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
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
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartAgentRecommendationGeneration Request Marshaller
    /// </summary>       
    public class StartAgentRecommendationGenerationRequestMarshaller : IMarshaller<IRequest, StartAgentRecommendationGenerationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAgentRecommendationGenerationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartAgentRecommendationGenerationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetProfileArn())
                throw new AmazonWellArchitectedException("Request object does not have required field ProfileArn set");
            request.AddPathResource("{profileArn}", StringUtils.FromString(publicRequest.ProfileArn));
            request.ResourcePath = "/api/v1/agent-profiles/{profileArn}/generations";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalContext())
            {
                context.Writer.WritePropertyName("additionalContext");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequest.AdditionalContext);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.WriteStartObject();

                var marshaller = ScopeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Scope, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTypes())
            {
                context.Writer.WritePropertyName("types");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTypesListValue in publicRequest.Types)
                {
                        context.Writer.WriteStringValue(publicRequestTypesListValue);
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
        private static StartAgentRecommendationGenerationRequestMarshaller _instance = new StartAgentRecommendationGenerationRequestMarshaller();        

        internal static StartAgentRecommendationGenerationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartAgentRecommendationGenerationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}