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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
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
namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutExternalModel Request Marshaller
    /// </summary>       
    public class PutExternalModelRequestMarshaller : IMarshaller<IRequest, PutExternalModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutExternalModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutExternalModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FraudDetector");
            string target = "AWSHawksNestServiceFacade.PutExternalModel";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-15";
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
            if(publicRequest.IsSetInputConfiguration())
            {
                context.Writer.WritePropertyName("inputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ModelInputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInvokeModelEndpointRoleArn())
            {
                context.Writer.WritePropertyName("invokeModelEndpointRoleArn");
                context.Writer.WriteStringValue(publicRequest.InvokeModelEndpointRoleArn);
            }

            if(publicRequest.IsSetModelEndpoint())
            {
                context.Writer.WritePropertyName("modelEndpoint");
                context.Writer.WriteStringValue(publicRequest.ModelEndpoint);
            }

            if(publicRequest.IsSetModelEndpointStatus())
            {
                context.Writer.WritePropertyName("modelEndpointStatus");
                context.Writer.WriteStringValue(publicRequest.ModelEndpointStatus);
            }

            if(publicRequest.IsSetModelSource())
            {
                context.Writer.WritePropertyName("modelSource");
                context.Writer.WriteStringValue(publicRequest.ModelSource);
            }

            if(publicRequest.IsSetOutputConfiguration())
            {
                context.Writer.WritePropertyName("outputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ModelOutputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConfiguration, context);

                context.Writer.WriteEndObject();
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
        private static PutExternalModelRequestMarshaller _instance = new PutExternalModelRequestMarshaller();        

        internal static PutExternalModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutExternalModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}