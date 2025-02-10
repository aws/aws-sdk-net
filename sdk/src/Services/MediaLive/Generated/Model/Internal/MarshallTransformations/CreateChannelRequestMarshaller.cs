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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
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
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateChannel Request Marshaller
    /// </summary>       
    public class CreateChannelRequestMarshaller : IMarshaller<IRequest, CreateChannelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateChannelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateChannelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/prod/channels";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAnywhereSettings())
            {
                context.Writer.WritePropertyName("anywhereSettings");
                context.Writer.WriteStartObject();

                var marshaller = AnywhereSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AnywhereSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCdiInputSpecification())
            {
                context.Writer.WritePropertyName("cdiInputSpecification");
                context.Writer.WriteStartObject();

                var marshaller = CdiInputSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CdiInputSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetChannelClass())
            {
                context.Writer.WritePropertyName("channelClass");
                context.Writer.WriteStringValue(publicRequest.ChannelClass);
            }

            if(publicRequest.IsSetChannelEngineVersion())
            {
                context.Writer.WritePropertyName("channelEngineVersion");
                context.Writer.WriteStartObject();

                var marshaller = ChannelEngineVersionRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ChannelEngineVersion, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDestinations())
            {
                context.Writer.WritePropertyName("destinations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequestDestinationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("dryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetEncoderSettings())
            {
                context.Writer.WritePropertyName("encoderSettings");
                context.Writer.WriteStartObject();

                var marshaller = EncoderSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncoderSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputAttachments())
            {
                context.Writer.WritePropertyName("inputAttachments");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputAttachmentsListValue in publicRequest.InputAttachments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputAttachmentMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputAttachmentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInputSpecification())
            {
                context.Writer.WritePropertyName("inputSpecification");
                context.Writer.WriteStartObject();

                var marshaller = InputSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLogLevel())
            {
                context.Writer.WritePropertyName("logLevel");
                context.Writer.WriteStringValue(publicRequest.LogLevel);
            }

            if(publicRequest.IsSetMaintenance())
            {
                context.Writer.WritePropertyName("maintenance");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceCreateSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Maintenance, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRequestId())
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(publicRequest.RequestId);
            }

            else if(!(publicRequest.IsSetRequestId()))
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetReserved())
            {
                context.Writer.WritePropertyName("reserved");
                context.Writer.WriteStringValue(publicRequest.Reserved);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
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

            if(publicRequest.IsSetVpc())
            {
                context.Writer.WritePropertyName("vpc");
                context.Writer.WriteStartObject();

                var marshaller = VpcOutputSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Vpc, context);

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
        private static CreateChannelRequestMarshaller _instance = new CreateChannelRequestMarshaller();        

        internal static CreateChannelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateChannelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}