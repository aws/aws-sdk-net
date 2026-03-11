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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceDiscovery.Model;
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
namespace Amazon.ServiceDiscovery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DiscoverInstances Request Marshaller
    /// </summary>       
    public class DiscoverInstancesRequestMarshaller : IMarshaller<IRequest, DiscoverInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DiscoverInstancesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DiscoverInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceDiscovery");
            string target = "Route53AutoNaming_v20170314.DiscoverInstances";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-14";
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
            if(publicRequest.IsSetHealthStatus())
            {
                context.Writer.WritePropertyName("HealthStatus");
                context.Writer.WriteStringValue(publicRequest.HealthStatus);
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNamespaceName())
            {
                context.Writer.WritePropertyName("NamespaceName");
                context.Writer.WriteStringValue(publicRequest.NamespaceName);
            }

            if(publicRequest.IsSetOptionalParameters())
            {
                context.Writer.WritePropertyName("OptionalParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestOptionalParametersKvp in publicRequest.OptionalParameters)
                {
                    context.Writer.WritePropertyName(publicRequestOptionalParametersKvp.Key);
                    var publicRequestOptionalParametersValue = publicRequestOptionalParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestOptionalParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOwnerAccount())
            {
                context.Writer.WritePropertyName("OwnerAccount");
                context.Writer.WriteStringValue(publicRequest.OwnerAccount);
            }

            if(publicRequest.IsSetQueryParameters())
            {
                context.Writer.WritePropertyName("QueryParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestQueryParametersKvp in publicRequest.QueryParameters)
                {
                    context.Writer.WritePropertyName(publicRequestQueryParametersKvp.Key);
                    var publicRequestQueryParametersValue = publicRequestQueryParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestQueryParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.WriteStringValue(publicRequest.ServiceName);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"data-";

            return request;
        }
        private static DiscoverInstancesRequestMarshaller _instance = new DiscoverInstancesRequestMarshaller();        

        internal static DiscoverInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DiscoverInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}