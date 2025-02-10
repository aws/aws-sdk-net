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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
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
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStreamProcessor Request Marshaller
    /// </summary>       
    public class CreateStreamProcessorRequestMarshaller : IMarshaller<IRequest, CreateStreamProcessorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStreamProcessorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStreamProcessorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.CreateStreamProcessor";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";
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
            if(publicRequest.IsSetDataSharingPreference())
            {
                context.Writer.WritePropertyName("DataSharingPreference");
                context.Writer.WriteStartObject();

                var marshaller = StreamProcessorDataSharingPreferenceMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSharingPreference, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInput())
            {
                context.Writer.WritePropertyName("Input");
                context.Writer.WriteStartObject();

                var marshaller = StreamProcessorInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Input, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNotificationChannel())
            {
                context.Writer.WritePropertyName("NotificationChannel");
                context.Writer.WriteStartObject();

                var marshaller = StreamProcessorNotificationChannelMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationChannel, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutput())
            {
                context.Writer.WritePropertyName("Output");
                context.Writer.WriteStartObject();

                var marshaller = StreamProcessorOutputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Output, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRegionsOfInterest())
            {
                context.Writer.WritePropertyName("RegionsOfInterest");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRegionsOfInterestListValue in publicRequest.RegionsOfInterest)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RegionOfInterestMarshaller.Instance;
                    marshaller.Marshall(publicRequestRegionsOfInterestListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSettings())
            {
                context.Writer.WritePropertyName("Settings");
                context.Writer.WriteStartObject();

                var marshaller = StreamProcessorSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Settings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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
        private static CreateStreamProcessorRequestMarshaller _instance = new CreateStreamProcessorRequestMarshaller();        

        internal static CreateStreamProcessorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStreamProcessorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}