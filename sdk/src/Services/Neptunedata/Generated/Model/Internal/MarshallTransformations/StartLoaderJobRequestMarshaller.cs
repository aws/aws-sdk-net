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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptunedata.Model;
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
namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartLoaderJob Request Marshaller
    /// </summary>       
    public class StartLoaderJobRequestMarshaller : IMarshaller<IRequest, StartLoaderJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartLoaderJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartLoaderJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptunedata");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/loader";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDependencies())
            {
                context.Writer.WritePropertyName("dependencies");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDependenciesListValue in publicRequest.Dependencies)
                {
                        context.Writer.WriteStringValue(publicRequestDependenciesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFailOnError())
            {
                context.Writer.WritePropertyName("failOnError");
                context.Writer.WriteBooleanValue(publicRequest.FailOnError.Value);
            }

            if(publicRequest.IsSetFormat())
            {
                context.Writer.WritePropertyName("format");
                context.Writer.WriteStringValue(publicRequest.Format);
            }

            if(publicRequest.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("iamRoleArn");
                context.Writer.WriteStringValue(publicRequest.IamRoleArn);
            }

            if(publicRequest.IsSetMode())
            {
                context.Writer.WritePropertyName("mode");
                context.Writer.WriteStringValue(publicRequest.Mode);
            }

            if(publicRequest.IsSetParallelism())
            {
                context.Writer.WritePropertyName("parallelism");
                context.Writer.WriteStringValue(publicRequest.Parallelism);
            }

            if(publicRequest.IsSetParserConfiguration())
            {
                context.Writer.WritePropertyName("parserConfiguration");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParserConfigurationKvp in publicRequest.ParserConfiguration)
                {
                    context.Writer.WritePropertyName(publicRequestParserConfigurationKvp.Key);
                    var publicRequestParserConfigurationValue = publicRequestParserConfigurationKvp.Value;

                        context.Writer.WriteStringValue(publicRequestParserConfigurationValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetQueueRequest())
            {
                context.Writer.WritePropertyName("queueRequest");
                context.Writer.WriteBooleanValue(publicRequest.QueueRequest.Value);
            }

            if(publicRequest.IsSetS3BucketRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.WriteStringValue(publicRequest.S3BucketRegion);
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStringValue(publicRequest.Source);
            }

            if(publicRequest.IsSetUpdateSingleCardinalityProperties())
            {
                context.Writer.WritePropertyName("updateSingleCardinalityProperties");
                context.Writer.WriteBooleanValue(publicRequest.UpdateSingleCardinalityProperties.Value);
            }

            if(publicRequest.IsSetUserProvidedEdgeIds())
            {
                context.Writer.WritePropertyName("userProvidedEdgeIds");
                context.Writer.WriteBooleanValue(publicRequest.UserProvidedEdgeIds.Value);
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
        private static StartLoaderJobRequestMarshaller _instance = new StartLoaderJobRequestMarshaller();        

        internal static StartLoaderJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartLoaderJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}