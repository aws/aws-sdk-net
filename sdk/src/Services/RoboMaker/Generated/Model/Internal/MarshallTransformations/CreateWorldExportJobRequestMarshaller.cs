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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
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
namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorldExportJob Request Marshaller
    /// </summary>       
    public class CreateWorldExportJobRequestMarshaller : IMarshaller<IRequest, CreateWorldExportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorldExportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWorldExportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RoboMaker");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/createWorldExportJob";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetIamRole())
            {
                context.Writer.WritePropertyName("iamRole");
                context.Writer.WriteStringValue(publicRequest.IamRole);
            }

            if(publicRequest.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("outputLocation");
                context.Writer.WriteStartObject();

                var marshaller = OutputLocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputLocation, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorlds())
            {
                context.Writer.WritePropertyName("worlds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWorldsListValue in publicRequest.Worlds)
                {
                        context.Writer.WriteStringValue(publicRequestWorldsListValue);
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
        private static CreateWorldExportJobRequestMarshaller _instance = new CreateWorldExportJobRequestMarshaller();        

        internal static CreateWorldExportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWorldExportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}