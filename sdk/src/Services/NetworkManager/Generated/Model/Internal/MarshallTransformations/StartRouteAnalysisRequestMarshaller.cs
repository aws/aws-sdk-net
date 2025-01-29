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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
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
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartRouteAnalysis Request Marshaller
    /// </summary>       
    public class StartRouteAnalysisRequestMarshaller : IMarshaller<IRequest, StartRouteAnalysisRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartRouteAnalysisRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartRouteAnalysisRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGlobalNetworkId())
                throw new AmazonNetworkManagerException("Request object does not have required field GlobalNetworkId set");
            request.AddPathResource("{globalNetworkId}", StringUtils.FromString(publicRequest.GlobalNetworkId));
            request.ResourcePath = "/global-networks/{globalNetworkId}/route-analyses";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteStartObject();

                var marshaller = RouteAnalysisEndpointOptionsSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Destination, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIncludeReturnPath())
            {
                context.Writer.WritePropertyName("IncludeReturnPath");
                context.Writer.WriteBooleanValue(publicRequest.IncludeReturnPath.Value);
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStartObject();

                var marshaller = RouteAnalysisEndpointOptionsSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Source, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUseMiddleboxes())
            {
                context.Writer.WritePropertyName("UseMiddleboxes");
                context.Writer.WriteBooleanValue(publicRequest.UseMiddleboxes.Value);
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
        private static StartRouteAnalysisRequestMarshaller _instance = new StartRouteAnalysisRequestMarshaller();        

        internal static StartRouteAnalysisRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartRouteAnalysisRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}