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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomationRuntime.Model;
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
namespace Amazon.BedrockDataAutomationRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeDataAutomationAsync Request Marshaller
    /// </summary>       
    public class InvokeDataAutomationAsyncRequestMarshaller : IMarshaller<IRequest, InvokeDataAutomationAsyncRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeDataAutomationAsyncRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeDataAutomationAsyncRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomationRuntime");
            string target = "AmazonBedrockKeystoneRuntimeService.InvokeDataAutomationAsync";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-06-13";
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
            if(publicRequest.IsSetBlueprints())
            {
                context.Writer.WritePropertyName("blueprints");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBlueprintsListValue in publicRequest.Blueprints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BlueprintMarshaller.Instance;
                    marshaller.Marshall(publicRequestBlueprintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
            if(publicRequest.IsSetDataAutomationConfiguration())
            {
                context.Writer.WritePropertyName("dataAutomationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataAutomationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataAutomationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataAutomationProfileArn())
            {
                context.Writer.WritePropertyName("dataAutomationProfileArn");
                context.Writer.WriteStringValue(publicRequest.DataAutomationProfileArn);
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("encryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
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
        private static InvokeDataAutomationAsyncRequestMarshaller _instance = new InvokeDataAutomationAsyncRequestMarshaller();        

        internal static InvokeDataAutomationAsyncRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeDataAutomationAsyncRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}