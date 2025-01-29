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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
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
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateJobTemplate Request Marshaller
    /// </summary>       
    public class UpdateJobTemplateRequestMarshaller : IMarshaller<IRequest, UpdateJobTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConvert");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-29";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
                throw new AmazonMediaConvertException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/2017-08-29/jobTemplates/{name}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccelerationSettings())
            {
                context.Writer.WritePropertyName("accelerationSettings");
                context.Writer.WriteStartObject();

                var marshaller = AccelerationSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AccelerationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCategory())
            {
                context.Writer.WritePropertyName("category");
                context.Writer.WriteStringValue(publicRequest.Category);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetHopDestinations())
            {
                context.Writer.WritePropertyName("hopDestinations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestHopDestinationsListValue in publicRequest.HopDestinations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HopDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequestHopDestinationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(publicRequest.Priority.Value);
            }

            if(publicRequest.IsSetQueue())
            {
                context.Writer.WritePropertyName("queue");
                context.Writer.WriteStringValue(publicRequest.Queue);
            }

            if(publicRequest.IsSetSettings())
            {
                context.Writer.WritePropertyName("settings");
                context.Writer.WriteStartObject();

                var marshaller = JobTemplateSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Settings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStatusUpdateInterval())
            {
                context.Writer.WritePropertyName("statusUpdateInterval");
                context.Writer.WriteStringValue(publicRequest.StatusUpdateInterval);
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
        private static UpdateJobTemplateRequestMarshaller _instance = new UpdateJobTemplateRequestMarshaller();        

        internal static UpdateJobTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}