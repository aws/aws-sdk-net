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
    /// UpdateFlow Request Marshaller
    /// </summary>       
    public class UpdateFlowRequestMarshaller : IMarshaller<IRequest, UpdateFlowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFlowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFlowArn())
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            request.AddPathResource("{FlowArn}", StringUtils.FromString(publicRequest.FlowArn));
            request.ResourcePath = "/v1/flows/{FlowArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetMaintenance())
            {
                context.Writer.WritePropertyName("maintenance");
                context.Writer.WriteStartObject();

                var marshaller = UpdateMaintenanceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Maintenance, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNdiConfig())
            {
                context.Writer.WritePropertyName("ndiConfig");
                context.Writer.WriteStartObject();

                var marshaller = NdiConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.NdiConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceFailoverConfig())
            {
                context.Writer.WritePropertyName("sourceFailoverConfig");
                context.Writer.WriteStartObject();

                var marshaller = UpdateFailoverConfigMarshaller.Instance;
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
        private static UpdateFlowRequestMarshaller _instance = new UpdateFlowRequestMarshaller();        

        internal static UpdateFlowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFlowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}