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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Braket.Model;
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
namespace Amazon.Braket.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateQuantumTask Request Marshaller
    /// </summary>       
    public class CreateQuantumTaskRequestMarshaller : IMarshaller<IRequest, CreateQuantumTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateQuantumTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateQuantumTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Braket");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/quantum-task";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteStringValue(publicRequest.Action);
            }

            if(publicRequest.IsSetAssociations())
            {
                context.Writer.WritePropertyName("associations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociationsListValue in publicRequest.Associations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssociationMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssociationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

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
            if(publicRequest.IsSetDeviceArn())
            {
                context.Writer.WritePropertyName("deviceArn");
                context.Writer.WriteStringValue(publicRequest.DeviceArn);
            }

            if(publicRequest.IsSetDeviceParameters())
            {
                context.Writer.WritePropertyName("deviceParameters");
                context.Writer.WriteStringValue(publicRequest.DeviceParameters);
            }

            if(publicRequest.IsSetJobToken())
            {
                context.Writer.WritePropertyName("jobToken");
                context.Writer.WriteStringValue(publicRequest.JobToken);
            }

            if(publicRequest.IsSetOutputS3Bucket())
            {
                context.Writer.WritePropertyName("outputS3Bucket");
                context.Writer.WriteStringValue(publicRequest.OutputS3Bucket);
            }

            if(publicRequest.IsSetOutputS3KeyPrefix())
            {
                context.Writer.WritePropertyName("outputS3KeyPrefix");
                context.Writer.WriteStringValue(publicRequest.OutputS3KeyPrefix);
            }

            if(publicRequest.IsSetShots())
            {
                context.Writer.WritePropertyName("shots");
                context.Writer.WriteNumberValue(publicRequest.Shots.Value);
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
            


            return request;
        }
        private static CreateQuantumTaskRequestMarshaller _instance = new CreateQuantumTaskRequestMarshaller();        

        internal static CreateQuantumTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateQuantumTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}