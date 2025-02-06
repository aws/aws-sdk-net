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
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConvert");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2017-08-29/jobs";
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

            if(publicRequest.IsSetBillingTagsSource())
            {
                context.Writer.WritePropertyName("billingTagsSource");
                context.Writer.WriteStringValue(publicRequest.BillingTagsSource);
            }

            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
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

            if(publicRequest.IsSetJobEngineVersion())
            {
                context.Writer.WritePropertyName("jobEngineVersion");
                context.Writer.WriteStringValue(publicRequest.JobEngineVersion);
            }

            if(publicRequest.IsSetJobTemplate())
            {
                context.Writer.WritePropertyName("jobTemplate");
                context.Writer.WriteStringValue(publicRequest.JobTemplate);
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

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetSettings())
            {
                context.Writer.WritePropertyName("settings");
                context.Writer.WriteStartObject();

                var marshaller = JobSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Settings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSimulateReservedQueue())
            {
                context.Writer.WritePropertyName("simulateReservedQueue");
                context.Writer.WriteStringValue(publicRequest.SimulateReservedQueue);
            }

            if(publicRequest.IsSetStatusUpdateInterval())
            {
                context.Writer.WritePropertyName("statusUpdateInterval");
                context.Writer.WriteStringValue(publicRequest.StatusUpdateInterval);
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

            if(publicRequest.IsSetUserMetadata())
            {
                context.Writer.WritePropertyName("userMetadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestUserMetadataKvp in publicRequest.UserMetadata)
                {
                    context.Writer.WritePropertyName(publicRequestUserMetadataKvp.Key);
                    var publicRequestUserMetadataValue = publicRequestUserMetadataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestUserMetadataValue);
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
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}