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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RAM.Model;
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
namespace Amazon.RAM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateResourceShare Request Marshaller
    /// </summary>       
    public class AssociateResourceShareRequestMarshaller : IMarshaller<IRequest, AssociateResourceShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateResourceShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateResourceShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RAM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-04";
            request.HttpMethod = "POST";

            request.ResourcePath = "/associateresourceshare";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetPrincipals())
            {
                context.Writer.WritePropertyName("principals");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPrincipalsListValue in publicRequest.Principals)
                {
                        context.Writer.WriteStringValue(publicRequestPrincipalsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceArns())
            {
                context.Writer.WritePropertyName("resourceArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceArnsListValue in publicRequest.ResourceArns)
                {
                        context.Writer.WriteStringValue(publicRequestResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceShareArn())
            {
                context.Writer.WritePropertyName("resourceShareArn");
                context.Writer.WriteStringValue(publicRequest.ResourceShareArn);
            }

            if(publicRequest.IsSetSources())
            {
                context.Writer.WritePropertyName("sources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                {
                        context.Writer.WriteStringValue(publicRequestSourcesListValue);
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
        private static AssociateResourceShareRequestMarshaller _instance = new AssociateResourceShareRequestMarshaller();        

        internal static AssociateResourceShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateResourceShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}