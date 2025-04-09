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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
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
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartCapacityTask Request Marshaller
    /// </summary>       
    public class StartCapacityTaskRequestMarshaller : IMarshaller<IRequest, StartCapacityTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartCapacityTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartCapacityTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetOutpostIdentifier())
                throw new AmazonOutpostsException("Request object does not have required field OutpostIdentifier set");
            request.AddPathResource("{OutpostId}", StringUtils.FromString(publicRequest.OutpostIdentifier));
            request.ResourcePath = "/outposts/{OutpostId}/capacity";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssetId())
            {
                context.Writer.WritePropertyName("AssetId");
                context.Writer.WriteStringValue(publicRequest.AssetId);
            }

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetInstancePools())
            {
                context.Writer.WritePropertyName("InstancePools");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstancePoolsListValue in publicRequest.InstancePools)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceTypeCapacityMarshaller.Instance;
                    marshaller.Marshall(publicRequestInstancePoolsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInstancesToExclude())
            {
                context.Writer.WritePropertyName("InstancesToExclude");
                context.Writer.WriteStartObject();

                var marshaller = InstancesToExcludeMarshaller.Instance;
                marshaller.Marshall(publicRequest.InstancesToExclude, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOrderId())
            {
                context.Writer.WritePropertyName("OrderId");
                context.Writer.WriteStringValue(publicRequest.OrderId);
            }

            if(publicRequest.IsSetTaskActionOnBlockingInstances())
            {
                context.Writer.WritePropertyName("TaskActionOnBlockingInstances");
                context.Writer.WriteStringValue(publicRequest.TaskActionOnBlockingInstances);
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
        private static StartCapacityTaskRequestMarshaller _instance = new StartCapacityTaskRequestMarshaller();        

        internal static StartCapacityTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartCapacityTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}