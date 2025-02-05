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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppRunner.Model;
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
namespace Amazon.AppRunner.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateService Request Marshaller
    /// </summary>       
    public class CreateServiceRequestMarshaller : IMarshaller<IRequest, CreateServiceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServiceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServiceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppRunner");
            string target = "AppRunner.CreateService";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-15";
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
            if(publicRequest.IsSetAutoScalingConfigurationArn())
            {
                context.Writer.WritePropertyName("AutoScalingConfigurationArn");
                context.Writer.WriteStringValue(publicRequest.AutoScalingConfigurationArn);
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHealthCheckConfiguration())
            {
                context.Writer.WritePropertyName("HealthCheckConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = HealthCheckConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.HealthCheckConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInstanceConfiguration())
            {
                context.Writer.WritePropertyName("InstanceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InstanceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InstanceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("NetworkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetObservabilityConfiguration())
            {
                context.Writer.WritePropertyName("ObservabilityConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ServiceObservabilityConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ObservabilityConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.WriteStringValue(publicRequest.ServiceName);
            }

            if(publicRequest.IsSetSourceConfiguration())
            {
                context.Writer.WritePropertyName("SourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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
        private static CreateServiceRequestMarshaller _instance = new CreateServiceRequestMarshaller();        

        internal static CreateServiceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServiceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}