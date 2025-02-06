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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
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
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGameSessionQueue Request Marshaller
    /// </summary>       
    public class CreateGameSessionQueueRequestMarshaller : IMarshaller<IRequest, CreateGameSessionQueueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGameSessionQueueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGameSessionQueueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.CreateGameSessionQueue";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
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
            if(publicRequest.IsSetCustomEventData())
            {
                context.Writer.WritePropertyName("CustomEventData");
                context.Writer.WriteStringValue(publicRequest.CustomEventData);
            }

            if(publicRequest.IsSetDestinations())
            {
                context.Writer.WritePropertyName("Destinations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GameSessionQueueDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequestDestinationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilterConfiguration())
            {
                context.Writer.WritePropertyName("FilterConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FilterConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.FilterConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNotificationTarget())
            {
                context.Writer.WritePropertyName("NotificationTarget");
                context.Writer.WriteStringValue(publicRequest.NotificationTarget);
            }

            if(publicRequest.IsSetPlayerLatencyPolicies())
            {
                context.Writer.WritePropertyName("PlayerLatencyPolicies");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlayerLatencyPoliciesListValue in publicRequest.PlayerLatencyPolicies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PlayerLatencyPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequestPlayerLatencyPoliciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPriorityConfiguration())
            {
                context.Writer.WritePropertyName("PriorityConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PriorityConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PriorityConfiguration, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("TimeoutInSeconds");
                context.Writer.WriteNumberValue(publicRequest.TimeoutInSeconds.Value);
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
        private static CreateGameSessionQueueRequestMarshaller _instance = new CreateGameSessionQueueRequestMarshaller();        

        internal static CreateGameSessionQueueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGameSessionQueueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}