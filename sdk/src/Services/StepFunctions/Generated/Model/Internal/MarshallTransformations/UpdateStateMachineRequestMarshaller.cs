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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StepFunctions.Model;
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
namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStateMachine Request Marshaller
    /// </summary>       
    public class UpdateStateMachineRequestMarshaller : IMarshaller<IRequest, UpdateStateMachineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStateMachineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStateMachineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StepFunctions");
            string target = "AWSStepFunctions.UpdateStateMachine";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-23";
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
            if(publicRequest.IsSetDefinition())
            {
                context.Writer.WritePropertyName("definition");
                context.Writer.WriteStringValue(publicRequest.Definition);
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("encryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLoggingConfiguration())
            {
                context.Writer.WritePropertyName("loggingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LoggingConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LoggingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPublish())
            {
                context.Writer.WritePropertyName("publish");
                context.Writer.WriteBooleanValue(publicRequest.Publish.Value);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetStateMachineArn())
            {
                context.Writer.WritePropertyName("stateMachineArn");
                context.Writer.WriteStringValue(publicRequest.StateMachineArn);
            }

            if(publicRequest.IsSetTracingConfiguration())
            {
                context.Writer.WritePropertyName("tracingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TracingConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TracingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVersionDescription())
            {
                context.Writer.WritePropertyName("versionDescription");
                context.Writer.WriteStringValue(publicRequest.VersionDescription);
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
        private static UpdateStateMachineRequestMarshaller _instance = new UpdateStateMachineRequestMarshaller();        

        internal static UpdateStateMachineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStateMachineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}