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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
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
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFunction Request Marshaller
    /// </summary>       
    public class CreateFunctionRequestMarshaller : IMarshaller<IRequest, CreateFunctionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFunctionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFunctionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2015-03-31/functions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetArchitectures())
            {
                context.Writer.WritePropertyName("Architectures");
                context.Writer.WriteStartArray();
                foreach(var publicRequestArchitecturesListValue in publicRequest.Architectures)
                {
                        context.Writer.WriteStringValue(publicRequestArchitecturesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCode())
            {
                context.Writer.WritePropertyName("Code");
                context.Writer.WriteStartObject();

                var marshaller = FunctionCodeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Code, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCodeSigningConfigArn())
            {
                context.Writer.WritePropertyName("CodeSigningConfigArn");
                context.Writer.WriteStringValue(publicRequest.CodeSigningConfigArn);
            }

            if(publicRequest.IsSetDeadLetterConfig())
            {
                context.Writer.WritePropertyName("DeadLetterConfig");
                context.Writer.WriteStartObject();

                var marshaller = DeadLetterConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeadLetterConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();

                var marshaller = EnvironmentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Environment, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEphemeralStorage())
            {
                context.Writer.WritePropertyName("EphemeralStorage");
                context.Writer.WriteStartObject();

                var marshaller = EphemeralStorageMarshaller.Instance;
                marshaller.Marshall(publicRequest.EphemeralStorage, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFileSystemConfigs())
            {
                context.Writer.WritePropertyName("FileSystemConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFileSystemConfigsListValue in publicRequest.FileSystemConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FileSystemConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestFileSystemConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFunctionName())
            {
                context.Writer.WritePropertyName("FunctionName");
                context.Writer.WriteStringValue(publicRequest.FunctionName);
            }

            if(publicRequest.IsSetHandler())
            {
                context.Writer.WritePropertyName("Handler");
                context.Writer.WriteStringValue(publicRequest.Handler);
            }

            if(publicRequest.IsSetImageConfig())
            {
                context.Writer.WritePropertyName("ImageConfig");
                context.Writer.WriteStartObject();

                var marshaller = ImageConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ImageConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKMSKeyArn())
            {
                context.Writer.WritePropertyName("KMSKeyArn");
                context.Writer.WriteStringValue(publicRequest.KMSKeyArn);
            }

            if(publicRequest.IsSetLayers())
            {
                context.Writer.WritePropertyName("Layers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLayersListValue in publicRequest.Layers)
                {
                        context.Writer.WriteStringValue(publicRequestLayersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLoggingConfig())
            {
                context.Writer.WritePropertyName("LoggingConfig");
                context.Writer.WriteStartObject();

                var marshaller = LoggingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.LoggingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMemorySize())
            {
                context.Writer.WritePropertyName("MemorySize");
                context.Writer.WriteNumberValue(publicRequest.MemorySize.Value);
            }

            if(publicRequest.IsSetPackageType())
            {
                context.Writer.WritePropertyName("PackageType");
                context.Writer.WriteStringValue(publicRequest.PackageType);
            }

            if(publicRequest.IsSetPublish())
            {
                context.Writer.WritePropertyName("Publish");
                context.Writer.WriteBooleanValue(publicRequest.Publish.Value);
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetRuntime())
            {
                context.Writer.WritePropertyName("Runtime");
                context.Writer.WriteStringValue(publicRequest.Runtime);
            }

            if(publicRequest.IsSetSnapStart())
            {
                context.Writer.WritePropertyName("SnapStart");
                context.Writer.WriteStartObject();

                var marshaller = SnapStartMarshaller.Instance;
                marshaller.Marshall(publicRequest.SnapStart, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(publicRequest.Timeout.Value);
            }

            if(publicRequest.IsSetTracingConfig())
            {
                context.Writer.WritePropertyName("TracingConfig");
                context.Writer.WriteStartObject();

                var marshaller = TracingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TracingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcConfig, context);

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
        private static CreateFunctionRequestMarshaller _instance = new CreateFunctionRequestMarshaller();        

        internal static CreateFunctionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFunctionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}