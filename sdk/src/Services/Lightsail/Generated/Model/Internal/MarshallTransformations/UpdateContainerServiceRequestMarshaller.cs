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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
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
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateContainerService Request Marshaller
    /// </summary>       
    public class UpdateContainerServiceRequestMarshaller : IMarshaller<IRequest, UpdateContainerServiceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateContainerServiceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateContainerServiceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.UpdateContainerService";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
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
            if(publicRequest.IsSetIsDisabled())
            {
                context.Writer.WritePropertyName("isDisabled");
                context.Writer.WriteBooleanValue(publicRequest.IsDisabled.Value);
            }

            if(publicRequest.IsSetPower())
            {
                context.Writer.WritePropertyName("power");
                context.Writer.WriteStringValue(publicRequest.Power);
            }

            if(publicRequest.IsSetPrivateRegistryAccess())
            {
                context.Writer.WritePropertyName("privateRegistryAccess");
                context.Writer.WriteStartObject();

                var marshaller = PrivateRegistryAccessRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.PrivateRegistryAccess, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPublicDomainNames())
            {
                context.Writer.WritePropertyName("publicDomainNames");
                context.Writer.WriteStartObject();
                foreach (var publicRequestPublicDomainNamesKvp in publicRequest.PublicDomainNames)
                {
                    context.Writer.WritePropertyName(publicRequestPublicDomainNamesKvp.Key);
                    var publicRequestPublicDomainNamesValue = publicRequestPublicDomainNamesKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestPublicDomainNamesValueListValue in publicRequestPublicDomainNamesValue)
                    {
                            context.Writer.WriteStringValue(publicRequestPublicDomainNamesValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScale())
            {
                context.Writer.WritePropertyName("scale");
                context.Writer.WriteNumberValue(publicRequest.Scale.Value);
            }

            if(publicRequest.IsSetServiceName())
            {
                context.Writer.WritePropertyName("serviceName");
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
            


            return request;
        }
        private static UpdateContainerServiceRequestMarshaller _instance = new UpdateContainerServiceRequestMarshaller();        

        internal static UpdateContainerServiceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateContainerServiceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}