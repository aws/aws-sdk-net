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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
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
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePipe Request Marshaller
    /// </summary>       
    public class UpdatePipeRequestMarshaller : IMarshaller<IRequest, UpdatePipeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePipeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePipeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pipes");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-07";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
                throw new AmazonPipesException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v1/pipes/{Name}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDesiredState())
            {
                context.Writer.WritePropertyName("DesiredState");
                context.Writer.WriteStringValue(publicRequest.DesiredState);
            }

            if(publicRequest.IsSetEnrichment())
            {
                context.Writer.WritePropertyName("Enrichment");
                context.Writer.WriteStringValue(publicRequest.Enrichment);
            }

            if(publicRequest.IsSetEnrichmentParameters())
            {
                context.Writer.WritePropertyName("EnrichmentParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeEnrichmentParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.EnrichmentParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKmsKeyIdentifier())
            {
                context.Writer.WritePropertyName("KmsKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.KmsKeyIdentifier);
            }

            if(publicRequest.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("LogConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PipeLogConfigurationParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSourceParameters())
            {
                context.Writer.WritePropertyName("SourceParameters");
                context.Writer.WriteStartObject();

                var marshaller = UpdatePipeSourceParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTarget())
            {
                context.Writer.WritePropertyName("Target");
                context.Writer.WriteStringValue(publicRequest.Target);
            }

            if(publicRequest.IsSetTargetParameters())
            {
                context.Writer.WritePropertyName("TargetParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetParameters, context);

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
        private static UpdatePipeRequestMarshaller _instance = new UpdatePipeRequestMarshaller();        

        internal static UpdatePipeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePipeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}