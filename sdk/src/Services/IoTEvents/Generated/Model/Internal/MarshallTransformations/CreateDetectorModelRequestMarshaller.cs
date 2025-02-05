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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
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
namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDetectorModel Request Marshaller
    /// </summary>       
    public class CreateDetectorModelRequestMarshaller : IMarshaller<IRequest, CreateDetectorModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDetectorModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDetectorModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTEvents");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/detector-models";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDetectorModelDefinition())
            {
                context.Writer.WritePropertyName("detectorModelDefinition");
                context.Writer.WriteStartObject();

                var marshaller = DetectorModelDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.DetectorModelDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDetectorModelDescription())
            {
                context.Writer.WritePropertyName("detectorModelDescription");
                context.Writer.WriteStringValue(publicRequest.DetectorModelDescription);
            }

            if(publicRequest.IsSetDetectorModelName())
            {
                context.Writer.WritePropertyName("detectorModelName");
                context.Writer.WriteStringValue(publicRequest.DetectorModelName);
            }

            if(publicRequest.IsSetEvaluationMethod())
            {
                context.Writer.WritePropertyName("evaluationMethod");
                context.Writer.WriteStringValue(publicRequest.EvaluationMethod);
            }

            if(publicRequest.IsSetKey())
            {
                context.Writer.WritePropertyName("key");
                context.Writer.WriteStringValue(publicRequest.Key);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
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
        private static CreateDetectorModelRequestMarshaller _instance = new CreateDetectorModelRequestMarshaller();        

        internal static CreateDetectorModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDetectorModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}