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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFeatureGroup Request Marshaller
    /// </summary>       
    public class CreateFeatureGroupRequestMarshaller : IMarshaller<IRequest, CreateFeatureGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFeatureGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFeatureGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateFeatureGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEventTimeFeatureName())
            {
                context.Writer.WritePropertyName("EventTimeFeatureName");
                context.Writer.WriteStringValue(publicRequest.EventTimeFeatureName);
            }

            if(publicRequest.IsSetFeatureDefinitions())
            {
                context.Writer.WritePropertyName("FeatureDefinitions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFeatureDefinitionsListValue in publicRequest.FeatureDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FeatureDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestFeatureDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFeatureGroupName())
            {
                context.Writer.WritePropertyName("FeatureGroupName");
                context.Writer.WriteStringValue(publicRequest.FeatureGroupName);
            }

            if(publicRequest.IsSetOfflineStoreConfig())
            {
                context.Writer.WritePropertyName("OfflineStoreConfig");
                context.Writer.WriteStartObject();

                var marshaller = OfflineStoreConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OfflineStoreConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOnlineStoreConfig())
            {
                context.Writer.WritePropertyName("OnlineStoreConfig");
                context.Writer.WriteStartObject();

                var marshaller = OnlineStoreConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OnlineStoreConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRecordIdentifierFeatureName())
            {
                context.Writer.WritePropertyName("RecordIdentifierFeatureName");
                context.Writer.WriteStringValue(publicRequest.RecordIdentifierFeatureName);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetThroughputConfig())
            {
                context.Writer.WritePropertyName("ThroughputConfig");
                context.Writer.WriteStartObject();

                var marshaller = ThroughputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ThroughputConfig, context);

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
        private static CreateFeatureGroupRequestMarshaller _instance = new CreateFeatureGroupRequestMarshaller();        

        internal static CreateFeatureGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFeatureGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}