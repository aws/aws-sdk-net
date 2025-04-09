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
    /// UpdateInput Request Marshaller
    /// </summary>       
    public class UpdateInputRequestMarshaller : IMarshaller<IRequest, UpdateInputRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInputRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateInputRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInputId())
                throw new AmazonMediaLiveException("Request object does not have required field InputId set");
            request.AddPathResource("{inputId}", StringUtils.FromString(publicRequest.InputId));
            request.ResourcePath = "/prod/inputs/{inputId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDestinations())
            {
                context.Writer.WritePropertyName("destinations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputDestinationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestDestinationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInputDevices())
            {
                context.Writer.WritePropertyName("inputDevices");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputDevicesListValue in publicRequest.InputDevices)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputDeviceRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputDevicesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInputSecurityGroups())
            {
                context.Writer.WritePropertyName("inputSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputSecurityGroupsListValue in publicRequest.InputSecurityGroups)
                {
                        context.Writer.WriteStringValue(publicRequestInputSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMediaConnectFlows())
            {
                context.Writer.WritePropertyName("mediaConnectFlows");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMediaConnectFlowsListValue in publicRequest.MediaConnectFlows)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MediaConnectFlowRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestMediaConnectFlowsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMulticastSettings())
            {
                context.Writer.WritePropertyName("multicastSettings");
                context.Writer.WriteStartObject();

                var marshaller = MulticastSettingsUpdateRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.MulticastSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSdiSources())
            {
                context.Writer.WritePropertyName("sdiSources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSdiSourcesListValue in publicRequest.SdiSources)
                {
                        context.Writer.WriteStringValue(publicRequestSdiSourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSmpte2110ReceiverGroupSettings())
            {
                context.Writer.WritePropertyName("smpte2110ReceiverGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = Smpte2110ReceiverGroupSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Smpte2110ReceiverGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSources())
            {
                context.Writer.WritePropertyName("sources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputSourceRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSrtSettings())
            {
                context.Writer.WritePropertyName("srtSettings");
                context.Writer.WriteStartObject();

                var marshaller = SrtSettingsRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.SrtSettings, context);

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
        private static UpdateInputRequestMarshaller _instance = new UpdateInputRequestMarshaller();        

        internal static UpdateInputRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInputRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}