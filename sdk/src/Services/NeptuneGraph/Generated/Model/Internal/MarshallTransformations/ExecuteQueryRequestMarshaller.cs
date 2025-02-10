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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
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
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExecuteQuery Request Marshaller
    /// </summary>       
    public class ExecuteQueryRequestMarshaller : IMarshaller<IRequest, ExecuteQueryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExecuteQueryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExecuteQueryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/queries";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetExplainMode())
            {
                context.Writer.WritePropertyName("explain");
                context.Writer.WriteStringValue(publicRequest.ExplainMode);
            }

            if(publicRequest.IsSetLanguage())
            {
                context.Writer.WritePropertyName("language");
                context.Writer.WriteStringValue(publicRequest.Language);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequestParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPlanCache())
            {
                context.Writer.WritePropertyName("planCache");
                context.Writer.WriteStringValue(publicRequest.PlanCache);
            }

            if(publicRequest.IsSetQueryString())
            {
                context.Writer.WritePropertyName("query");
                context.Writer.WriteStringValue(publicRequest.QueryString);
            }

            if(publicRequest.IsSetQueryTimeoutMilliseconds())
            {
                context.Writer.WritePropertyName("queryTimeoutMilliseconds");
                context.Writer.WriteNumberValue(publicRequest.QueryTimeoutMilliseconds.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetGraphIdentifier()) 
            {
                request.Headers["graphIdentifier"] = publicRequest.GraphIdentifier;
            }

            var hostPrefixLabels = new
            {
                graphIdentifier = StringUtils.FromString(publicRequest.GraphIdentifier),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.graphIdentifier))
                throw new AmazonNeptuneGraphException("graphIdentifier can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"{hostPrefixLabels.graphIdentifier}.";

            return request;
        }
        private static ExecuteQueryRequestMarshaller _instance = new ExecuteQueryRequestMarshaller();        

        internal static ExecuteQueryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExecuteQueryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}