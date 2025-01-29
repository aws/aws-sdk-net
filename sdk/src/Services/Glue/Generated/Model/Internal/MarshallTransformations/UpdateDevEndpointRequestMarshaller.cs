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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
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
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDevEndpoint Request Marshaller
    /// </summary>       
    public class UpdateDevEndpointRequestMarshaller : IMarshaller<IRequest, UpdateDevEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDevEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDevEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.UpdateDevEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if(publicRequest.IsSetAddArguments())
            {
                context.Writer.WritePropertyName("AddArguments");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAddArgumentsKvp in publicRequest.AddArguments)
                {
                    context.Writer.WritePropertyName(publicRequestAddArgumentsKvp.Key);
                    var publicRequestAddArgumentsValue = publicRequestAddArgumentsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAddArgumentsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAddPublicKeys())
            {
                context.Writer.WritePropertyName("AddPublicKeys");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAddPublicKeysListValue in publicRequest.AddPublicKeys)
                {
                        context.Writer.WriteStringValue(publicRequestAddPublicKeysListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCustomLibraries())
            {
                context.Writer.WritePropertyName("CustomLibraries");
                context.Writer.WriteStartObject();

                var marshaller = DevEndpointCustomLibrariesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomLibraries, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeleteArguments())
            {
                context.Writer.WritePropertyName("DeleteArguments");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeleteArgumentsListValue in publicRequest.DeleteArguments)
                {
                        context.Writer.WriteStringValue(publicRequestDeleteArgumentsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeletePublicKeys())
            {
                context.Writer.WritePropertyName("DeletePublicKeys");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeletePublicKeysListValue in publicRequest.DeletePublicKeys)
                {
                        context.Writer.WriteStringValue(publicRequestDeletePublicKeysListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEndpointName())
            {
                context.Writer.WritePropertyName("EndpointName");
                context.Writer.WriteStringValue(publicRequest.EndpointName);
            }

            if(publicRequest.IsSetPublicKey())
            {
                context.Writer.WritePropertyName("PublicKey");
                context.Writer.WriteStringValue(publicRequest.PublicKey);
            }

            if(publicRequest.IsSetUpdateEtlLibraries())
            {
                context.Writer.WritePropertyName("UpdateEtlLibraries");
                context.Writer.WriteBooleanValue(publicRequest.UpdateEtlLibraries.Value);
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
        private static UpdateDevEndpointRequestMarshaller _instance = new UpdateDevEndpointRequestMarshaller();        

        internal static UpdateDevEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDevEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}