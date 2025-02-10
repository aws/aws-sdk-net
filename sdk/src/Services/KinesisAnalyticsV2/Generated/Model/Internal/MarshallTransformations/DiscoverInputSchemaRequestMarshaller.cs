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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
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
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DiscoverInputSchema Request Marshaller
    /// </summary>       
    public class DiscoverInputSchemaRequestMarshaller : IMarshaller<IRequest, DiscoverInputSchemaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DiscoverInputSchemaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DiscoverInputSchemaRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisAnalyticsV2");
            string target = "KinesisAnalytics_20180523.DiscoverInputSchema";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-23";
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
            if(publicRequest.IsSetInputProcessingConfiguration())
            {
                context.Writer.WritePropertyName("InputProcessingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InputProcessingConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputProcessingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputStartingPositionConfiguration())
            {
                context.Writer.WritePropertyName("InputStartingPositionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InputStartingPositionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputStartingPositionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceARN())
            {
                context.Writer.WritePropertyName("ResourceARN");
                context.Writer.WriteStringValue(publicRequest.ResourceARN);
            }

            if(publicRequest.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("S3Configuration");
                context.Writer.WriteStartObject();

                var marshaller = S3ConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceExecutionRole())
            {
                context.Writer.WritePropertyName("ServiceExecutionRole");
                context.Writer.WriteStringValue(publicRequest.ServiceExecutionRole);
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
        private static DiscoverInputSchemaRequestMarshaller _instance = new DiscoverInputSchemaRequestMarshaller();        

        internal static DiscoverInputSchemaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DiscoverInputSchemaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}