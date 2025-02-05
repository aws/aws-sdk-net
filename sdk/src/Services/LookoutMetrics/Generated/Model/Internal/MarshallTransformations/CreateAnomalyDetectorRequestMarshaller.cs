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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
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
namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAnomalyDetector Request Marshaller
    /// </summary>       
    public class CreateAnomalyDetectorRequestMarshaller : IMarshaller<IRequest, CreateAnomalyDetectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAnomalyDetectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAnomalyDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutMetrics");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateAnomalyDetector";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAnomalyDetectorConfig())
            {
                context.Writer.WritePropertyName("AnomalyDetectorConfig");
                context.Writer.WriteStartObject();

                var marshaller = AnomalyDetectorConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AnomalyDetectorConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAnomalyDetectorDescription())
            {
                context.Writer.WritePropertyName("AnomalyDetectorDescription");
                context.Writer.WriteStringValue(publicRequest.AnomalyDetectorDescription);
            }

            if(publicRequest.IsSetAnomalyDetectorName())
            {
                context.Writer.WritePropertyName("AnomalyDetectorName");
                context.Writer.WriteStringValue(publicRequest.AnomalyDetectorName);
            }

            if(publicRequest.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("KmsKeyArn");
                context.Writer.WriteStringValue(publicRequest.KmsKeyArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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
            


            return request;
        }
        private static CreateAnomalyDetectorRequestMarshaller _instance = new CreateAnomalyDetectorRequestMarshaller();        

        internal static CreateAnomalyDetectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAnomalyDetectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}