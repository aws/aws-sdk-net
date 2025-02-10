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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
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
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDecoderManifest Request Marshaller
    /// </summary>       
    public class UpdateDecoderManifestRequestMarshaller : IMarshaller<IRequest, UpdateDecoderManifestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDecoderManifestRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDecoderManifestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTFleetWise");
            string target = "IoTAutobahnControlPlane.UpdateDecoderManifest";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-17";
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
            if(publicRequest.IsSetDefaultForUnmappedSignals())
            {
                context.Writer.WritePropertyName("defaultForUnmappedSignals");
                context.Writer.WriteStringValue(publicRequest.DefaultForUnmappedSignals);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNetworkInterfacesToAdd())
            {
                context.Writer.WritePropertyName("networkInterfacesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNetworkInterfacesToAddListValue in publicRequest.NetworkInterfacesToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NetworkInterfaceMarshaller.Instance;
                    marshaller.Marshall(publicRequestNetworkInterfacesToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNetworkInterfacesToRemove())
            {
                context.Writer.WritePropertyName("networkInterfacesToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNetworkInterfacesToRemoveListValue in publicRequest.NetworkInterfacesToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestNetworkInterfacesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNetworkInterfacesToUpdate())
            {
                context.Writer.WritePropertyName("networkInterfacesToUpdate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNetworkInterfacesToUpdateListValue in publicRequest.NetworkInterfacesToUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NetworkInterfaceMarshaller.Instance;
                    marshaller.Marshall(publicRequestNetworkInterfacesToUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSignalDecodersToAdd())
            {
                context.Writer.WritePropertyName("signalDecodersToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSignalDecodersToAddListValue in publicRequest.SignalDecodersToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SignalDecoderMarshaller.Instance;
                    marshaller.Marshall(publicRequestSignalDecodersToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSignalDecodersToRemove())
            {
                context.Writer.WritePropertyName("signalDecodersToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSignalDecodersToRemoveListValue in publicRequest.SignalDecodersToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestSignalDecodersToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSignalDecodersToUpdate())
            {
                context.Writer.WritePropertyName("signalDecodersToUpdate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSignalDecodersToUpdateListValue in publicRequest.SignalDecodersToUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SignalDecoderMarshaller.Instance;
                    marshaller.Marshall(publicRequestSignalDecodersToUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
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
        private static UpdateDecoderManifestRequestMarshaller _instance = new UpdateDecoderManifestRequestMarshaller();        

        internal static UpdateDecoderManifestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDecoderManifestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}