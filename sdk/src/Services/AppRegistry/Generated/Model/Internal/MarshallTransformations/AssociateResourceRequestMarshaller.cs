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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppRegistry.Model;
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
namespace Amazon.AppRegistry.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateResource Request Marshaller
    /// </summary>       
    public class AssociateResourceRequestMarshaller : IMarshaller<IRequest, AssociateResourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateResourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppRegistry");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-06-24";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetApplication())
                throw new AmazonAppRegistryException("Request object does not have required field Application set");
            request.AddPathResource("{application}", StringUtils.FromString(publicRequest.Application));
            if (!publicRequest.IsSetResource())
                throw new AmazonAppRegistryException("Request object does not have required field Resource set");
            request.AddPathResource("{resource}", StringUtils.FromString(publicRequest.Resource));
            if (!publicRequest.IsSetResourceType())
                throw new AmazonAppRegistryException("Request object does not have required field ResourceType set");
            request.AddPathResource("{resourceType}", StringUtils.FromString(publicRequest.ResourceType));
            request.ResourcePath = "/applications/{application}/resources/{resourceType}/{resource}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetOptions())
            {
                context.Writer.WritePropertyName("options");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOptionsListValue in publicRequest.Options)
                {
                        context.Writer.WriteStringValue(publicRequestOptionsListValue);
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
        private static AssociateResourceRequestMarshaller _instance = new AssociateResourceRequestMarshaller();        

        internal static AssociateResourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateResourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}