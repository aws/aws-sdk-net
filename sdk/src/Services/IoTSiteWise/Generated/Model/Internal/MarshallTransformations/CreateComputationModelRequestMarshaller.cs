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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateComputationModel Request Marshaller
    /// </summary>       
    public class CreateComputationModelRequestMarshaller : IMarshaller<IRequest, CreateComputationModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateComputationModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateComputationModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/computation-models";
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

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetComputationModelConfiguration())
            {
                context.Writer.WritePropertyName("computationModelConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ComputationModelConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComputationModelConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetComputationModelDataBinding())
            {
                context.Writer.WritePropertyName("computationModelDataBinding");
                context.Writer.WriteStartObject();
                foreach (var publicRequestComputationModelDataBindingKvp in publicRequest.ComputationModelDataBinding)
                {
                    context.Writer.WritePropertyName(publicRequestComputationModelDataBindingKvp.Key);
                    var publicRequestComputationModelDataBindingValue = publicRequestComputationModelDataBindingKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComputationModelDataBindingValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestComputationModelDataBindingValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetComputationModelDescription())
            {
                context.Writer.WritePropertyName("computationModelDescription");
                context.Writer.WriteStringValue(publicRequest.ComputationModelDescription);
            }

            if(publicRequest.IsSetComputationModelName())
            {
                context.Writer.WritePropertyName("computationModelName");
                context.Writer.WriteStringValue(publicRequest.ComputationModelName);
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

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static CreateComputationModelRequestMarshaller _instance = new CreateComputationModelRequestMarshaller();        

        internal static CreateComputationModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateComputationModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}