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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
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
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeDataAutomationLibraryIngestionJob Request Marshaller
    /// </summary>       
    public class InvokeDataAutomationLibraryIngestionJobRequestMarshaller : IMarshaller<IRequest, InvokeDataAutomationLibraryIngestionJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeDataAutomationLibraryIngestionJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeDataAutomationLibraryIngestionJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetLibraryArn())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field LibraryArn set");
            request.AddPathResource("{libraryArn}", StringUtils.FromString(publicRequest.LibraryArn));
            request.ResourcePath = "/data-automation-libraries/{libraryArn}/library-ingestion-jobs/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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
            if(publicRequest.IsSetEntityType())
            {
                context.Writer.WritePropertyName("entityType");
                context.Writer.WriteStringValue(publicRequest.EntityType);
            }

            if(publicRequest.IsSetInputConfiguration())
            {
                context.Writer.WritePropertyName("inputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNotificationConfiguration())
            {
                context.Writer.WritePropertyName("notificationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NotificationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOperationType())
            {
                context.Writer.WritePropertyName("operationType");
                context.Writer.WriteStringValue(publicRequest.OperationType);
            }

            if(publicRequest.IsSetOutputConfiguration())
            {
                context.Writer.WritePropertyName("outputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OutputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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
        private static InvokeDataAutomationLibraryIngestionJobRequestMarshaller _instance = new InvokeDataAutomationLibraryIngestionJobRequestMarshaller();        

        internal static InvokeDataAutomationLibraryIngestionJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeDataAutomationLibraryIngestionJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}