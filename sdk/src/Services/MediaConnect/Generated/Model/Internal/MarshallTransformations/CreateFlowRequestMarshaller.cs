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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
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
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFlow Request Marshaller
    /// </summary>       
    public class CreateFlowRequestMarshaller : IMarshaller<IRequest, CreateFlowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFlowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/flows";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("availabilityZone");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZone);
            }

            if(publicRequest.IsSetEntitlements())
            {
                context.Writer.WritePropertyName("entitlements");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEntitlementsListValue in publicRequest.Entitlements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GrantEntitlementRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestEntitlementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFlowSize())
            {
                context.Writer.WritePropertyName("flowSize");
                context.Writer.WriteStringValue(publicRequest.FlowSize);
            }

            if(publicRequest.IsSetMaintenance())
            {
                context.Writer.WritePropertyName("maintenance");
                context.Writer.WriteStartObject();

                var marshaller = AddMaintenanceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Maintenance, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMediaStreams())
            {
                context.Writer.WritePropertyName("mediaStreams");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMediaStreamsListValue in publicRequest.MediaStreams)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddMediaStreamRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestMediaStreamsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNdiConfig())
            {
                context.Writer.WritePropertyName("ndiConfig");
                context.Writer.WriteStartObject();

                var marshaller = NdiConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.NdiConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputs())
            {
                context.Writer.WritePropertyName("outputs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddOutputRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStartObject();

                var marshaller = SetSourceRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.Source, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceFailoverConfig())
            {
                context.Writer.WritePropertyName("sourceFailoverConfig");
                context.Writer.WriteStartObject();

                var marshaller = FailoverConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceFailoverConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceMonitoringConfig())
            {
                context.Writer.WritePropertyName("sourceMonitoringConfig");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceMonitoringConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSources())
            {
                context.Writer.WritePropertyName("sources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SetSourceRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVpcInterfaces())
            {
                context.Writer.WritePropertyName("vpcInterfaces");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVpcInterfacesListValue in publicRequest.VpcInterfaces)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VpcInterfaceRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestVpcInterfacesListValue, context);

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
        private static CreateFlowRequestMarshaller _instance = new CreateFlowRequestMarshaller();        

        internal static CreateFlowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFlowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}