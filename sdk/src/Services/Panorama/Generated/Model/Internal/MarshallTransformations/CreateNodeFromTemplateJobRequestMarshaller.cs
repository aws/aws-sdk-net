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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Panorama.Model;
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
namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNodeFromTemplateJob Request Marshaller
    /// </summary>       
    public class CreateNodeFromTemplateJobRequestMarshaller : IMarshaller<IRequest, CreateNodeFromTemplateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNodeFromTemplateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNodeFromTemplateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Panorama");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/packages/template-job";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetJobTags())
            {
                context.Writer.WritePropertyName("JobTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestJobTagsListValue in publicRequest.JobTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = JobResourceTagsMarshaller.Instance;
                    marshaller.Marshall(publicRequestJobTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNodeDescription())
            {
                context.Writer.WritePropertyName("NodeDescription");
                context.Writer.WriteStringValue(publicRequest.NodeDescription);
            }

            if(publicRequest.IsSetNodeName())
            {
                context.Writer.WritePropertyName("NodeName");
                context.Writer.WriteStringValue(publicRequest.NodeName);
            }

            if(publicRequest.IsSetOutputPackageName())
            {
                context.Writer.WritePropertyName("OutputPackageName");
                context.Writer.WriteStringValue(publicRequest.OutputPackageName);
            }

            if(publicRequest.IsSetOutputPackageVersion())
            {
                context.Writer.WritePropertyName("OutputPackageVersion");
                context.Writer.WriteStringValue(publicRequest.OutputPackageVersion);
            }

            if(publicRequest.IsSetTemplateParameters())
            {
                context.Writer.WritePropertyName("TemplateParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTemplateParametersKvp in publicRequest.TemplateParameters)
                {
                    context.Writer.WritePropertyName(publicRequestTemplateParametersKvp.Key);
                    var publicRequestTemplateParametersValue = publicRequestTemplateParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTemplateParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTemplateType())
            {
                context.Writer.WritePropertyName("TemplateType");
                context.Writer.WriteStringValue(publicRequest.TemplateType);
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
        private static CreateNodeFromTemplateJobRequestMarshaller _instance = new CreateNodeFromTemplateJobRequestMarshaller();        

        internal static CreateNodeFromTemplateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNodeFromTemplateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}