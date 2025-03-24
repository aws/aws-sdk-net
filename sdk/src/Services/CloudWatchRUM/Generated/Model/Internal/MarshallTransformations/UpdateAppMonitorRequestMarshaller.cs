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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
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
namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAppMonitor Request Marshaller
    /// </summary>       
    public class UpdateAppMonitorRequestMarshaller : IMarshaller<IRequest, UpdateAppMonitorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAppMonitorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAppMonitorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetName())
                throw new AmazonCloudWatchRUMException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/appmonitor/{Name}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppMonitorConfiguration())
            {
                context.Writer.WritePropertyName("AppMonitorConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AppMonitorConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AppMonitorConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomEvents())
            {
                context.Writer.WritePropertyName("CustomEvents");
                context.Writer.WriteStartObject();

                var marshaller = CustomEventsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomEvents, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCwLogEnabled())
            {
                context.Writer.WritePropertyName("CwLogEnabled");
                context.Writer.WriteBooleanValue(publicRequest.CwLogEnabled.Value);
            }

            if(publicRequest.IsSetDeobfuscationConfiguration())
            {
                context.Writer.WritePropertyName("DeobfuscationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeobfuscationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeobfuscationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.WriteStringValue(publicRequest.Domain);
            }

            if(publicRequest.IsSetDomainList())
            {
                context.Writer.WritePropertyName("DomainList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDomainListListValue in publicRequest.DomainList)
                {
                        context.Writer.WriteStringValue(publicRequestDomainListListValue);
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
        private static UpdateAppMonitorRequestMarshaller _instance = new UpdateAppMonitorRequestMarshaller();        

        internal static UpdateAppMonitorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAppMonitorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}