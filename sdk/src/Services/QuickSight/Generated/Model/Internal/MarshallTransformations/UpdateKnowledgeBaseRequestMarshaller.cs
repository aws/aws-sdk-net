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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateKnowledgeBase Request Marshaller
    /// </summary>       
    public class UpdateKnowledgeBaseRequestMarshaller : IMarshaller<IRequest, UpdateKnowledgeBaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateKnowledgeBaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateKnowledgeBaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonQuickSightException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{KnowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            request.ResourcePath = "/v1/accounts/{AwsAccountId}/knowledge-bases/{KnowledgeBaseId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessControlConfiguration())
            {
                context.Writer.WritePropertyName("AccessControlConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AccessControlConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AccessControlConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetIsEmailNotificationOptedForIngestionFailures())
            {
                context.Writer.WritePropertyName("IsEmailNotificationOptedForIngestionFailures");
                context.Writer.WriteBooleanValue(publicRequest.IsEmailNotificationOptedForIngestionFailures.Value);
            }

            if(publicRequest.IsSetKnowledgeBaseConfiguration())
            {
                context.Writer.WritePropertyName("KnowledgeBaseConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KnowledgeBaseConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KnowledgeBaseConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMediaExtractionConfiguration())
            {
                context.Writer.WritePropertyName("MediaExtractionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MediaExtractionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MediaExtractionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateKnowledgeBaseRequestMarshaller _instance = new UpdateKnowledgeBaseRequestMarshaller();        

        internal static UpdateKnowledgeBaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateKnowledgeBaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}