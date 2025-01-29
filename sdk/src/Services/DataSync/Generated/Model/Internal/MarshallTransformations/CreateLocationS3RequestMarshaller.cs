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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
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
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLocationS3 Request Marshaller
    /// </summary>       
    public class CreateLocationS3RequestMarshaller : IMarshaller<IRequest, CreateLocationS3Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLocationS3Request)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLocationS3Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.CreateLocationS3";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
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
            if(publicRequest.IsSetAgentArns())
            {
                context.Writer.WritePropertyName("AgentArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAgentArnsListValue in publicRequest.AgentArns)
                {
                        context.Writer.WriteStringValue(publicRequestAgentArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetS3BucketArn())
            {
                context.Writer.WritePropertyName("S3BucketArn");
                context.Writer.WriteStringValue(publicRequest.S3BucketArn);
            }

            if(publicRequest.IsSetS3Config())
            {
                context.Writer.WritePropertyName("S3Config");
                context.Writer.WriteStartObject();

                var marshaller = S3ConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3Config, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetS3StorageClass())
            {
                context.Writer.WritePropertyName("S3StorageClass");
                context.Writer.WriteStringValue(publicRequest.S3StorageClass);
            }

            if(publicRequest.IsSetSubdirectory())
            {
                context.Writer.WritePropertyName("Subdirectory");
                context.Writer.WriteStringValue(publicRequest.Subdirectory);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagListEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
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
        private static CreateLocationS3RequestMarshaller _instance = new CreateLocationS3RequestMarshaller();        

        internal static CreateLocationS3RequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLocationS3RequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}