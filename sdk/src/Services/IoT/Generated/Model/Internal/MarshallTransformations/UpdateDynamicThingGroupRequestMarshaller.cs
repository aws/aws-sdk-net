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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
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
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDynamicThingGroup Request Marshaller
    /// </summary>       
    public class UpdateDynamicThingGroupRequestMarshaller : IMarshaller<IRequest, UpdateDynamicThingGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDynamicThingGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDynamicThingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetThingGroupName())
                throw new AmazonIoTException("Request object does not have required field ThingGroupName set");
            request.AddPathResource("{thingGroupName}", StringUtils.FromString(publicRequest.ThingGroupName));
            request.ResourcePath = "/dynamic-thing-groups/{thingGroupName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetExpectedVersion())
            {
                context.Writer.WritePropertyName("expectedVersion");
                context.Writer.WriteNumberValue(publicRequest.ExpectedVersion.Value);
            }

            if(publicRequest.IsSetIndexName())
            {
                context.Writer.WritePropertyName("indexName");
                context.Writer.WriteStringValue(publicRequest.IndexName);
            }

            if(publicRequest.IsSetQueryString())
            {
                context.Writer.WritePropertyName("queryString");
                context.Writer.WriteStringValue(publicRequest.QueryString);
            }

            if(publicRequest.IsSetQueryVersion())
            {
                context.Writer.WritePropertyName("queryVersion");
                context.Writer.WriteStringValue(publicRequest.QueryVersion);
            }

            if(publicRequest.IsSetThingGroupProperties())
            {
                context.Writer.WritePropertyName("thingGroupProperties");
                context.Writer.WriteStartObject();

                var marshaller = ThingGroupPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ThingGroupProperties, context);

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
        private static UpdateDynamicThingGroupRequestMarshaller _instance = new UpdateDynamicThingGroupRequestMarshaller();        

        internal static UpdateDynamicThingGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDynamicThingGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}