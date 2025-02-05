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
    /// CreatePackageImportJob Request Marshaller
    /// </summary>       
    public class CreatePackageImportJobRequestMarshaller : IMarshaller<IRequest, CreatePackageImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePackageImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePackageImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Panorama");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/packages/import-jobs";
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
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetInputConfig())
            {
                context.Writer.WritePropertyName("InputConfig");
                context.Writer.WriteStartObject();

                var marshaller = PackageImportJobInputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputConfig, context);

                context.Writer.WriteEndObject();
            }

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

            if(publicRequest.IsSetJobType())
            {
                context.Writer.WritePropertyName("JobType");
                context.Writer.WriteStringValue(publicRequest.JobType);
            }

            if(publicRequest.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("OutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = PackageImportJobOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConfig, context);

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
        private static CreatePackageImportJobRequestMarshaller _instance = new CreatePackageImportJobRequestMarshaller();        

        internal static CreatePackageImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePackageImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}