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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
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
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SparseJsonMaps Request Marshaller
    /// </summary>       
    public class SparseJsonMapsRequestMarshaller : IMarshaller<IRequest, SparseJsonMapsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SparseJsonMapsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SparseJsonMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "/SparseJsonMaps";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetSparseBooleanMap())
            {
                context.Writer.WritePropertyName("sparseBooleanMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSparseBooleanMapKvp in publicRequest.SparseBooleanMap)
                {
                    context.Writer.WritePropertyName(publicRequestSparseBooleanMapKvp.Key);
                    var publicRequestSparseBooleanMapValue = publicRequestSparseBooleanMapKvp.Value;

                    if (publicRequestSparseBooleanMapValue == null)
                    {
                        context.Writer.WriteNullValue();
                    }
                    else
                    {
                        context.Writer.WriteBooleanValue(publicRequestSparseBooleanMapValue.Value);
                    }
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSparseNumberMap())
            {
                context.Writer.WritePropertyName("sparseNumberMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSparseNumberMapKvp in publicRequest.SparseNumberMap)
                {
                    context.Writer.WritePropertyName(publicRequestSparseNumberMapKvp.Key);
                    var publicRequestSparseNumberMapValue = publicRequestSparseNumberMapKvp.Value;

                    if (publicRequestSparseNumberMapValue == null)
                    {
                        context.Writer.WriteNullValue();
                    }
                    else
                    {
                        context.Writer.WriteNumberValue(publicRequestSparseNumberMapValue.Value);
                    }
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSparseSetMap())
            {
                context.Writer.WritePropertyName("sparseSetMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSparseSetMapKvp in publicRequest.SparseSetMap)
                {
                    context.Writer.WritePropertyName(publicRequestSparseSetMapKvp.Key);
                    var publicRequestSparseSetMapValue = publicRequestSparseSetMapKvp.Value;

                    if (publicRequestSparseSetMapValue == null)
                    {
                        context.Writer.WriteNullValue();
                    }
                    else
                    {
                        context.Writer.WriteStartArray();
                        foreach(var publicRequestSparseSetMapValueListValue in publicRequestSparseSetMapValue)
                        {
                                context.Writer.WriteStringValue(publicRequestSparseSetMapValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSparseStringMap())
            {
                context.Writer.WritePropertyName("sparseStringMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSparseStringMapKvp in publicRequest.SparseStringMap)
                {
                    context.Writer.WritePropertyName(publicRequestSparseStringMapKvp.Key);
                    var publicRequestSparseStringMapValue = publicRequestSparseStringMapKvp.Value;

                    if (publicRequestSparseStringMapValue == null)
                    {
                        context.Writer.WriteNullValue();
                    }
                    else
                    {
                            context.Writer.WriteStringValue(publicRequestSparseStringMapValue);
                    }
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSparseStructMap())
            {
                context.Writer.WritePropertyName("sparseStructMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSparseStructMapKvp in publicRequest.SparseStructMap)
                {
                    context.Writer.WritePropertyName(publicRequestSparseStructMapKvp.Key);
                    var publicRequestSparseStructMapValue = publicRequestSparseStructMapKvp.Value;

                    if (publicRequestSparseStructMapValue == null)
                    {
                        context.Writer.WriteNullValue();
                    }
                    else
                    {
                        context.Writer.WriteStartObject();

                        var marshaller = GreetingStructMarshaller.Instance;
                        marshaller.Marshall(publicRequestSparseStructMapValue, context);

                        context.Writer.WriteEndObject();
                    }
                }
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
        private static SparseJsonMapsRequestMarshaller _instance = new SparseJsonMapsRequestMarshaller();        

        internal static SparseJsonMapsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SparseJsonMapsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}