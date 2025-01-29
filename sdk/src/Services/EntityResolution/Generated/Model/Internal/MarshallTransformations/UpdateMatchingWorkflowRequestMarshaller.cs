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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
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
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMatchingWorkflow Request Marshaller
    /// </summary>       
    public class UpdateMatchingWorkflowRequestMarshaller : IMarshaller<IRequest, UpdateMatchingWorkflowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMatchingWorkflowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMatchingWorkflowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EntityResolution");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetWorkflowName())
                throw new AmazonEntityResolutionException("Request object does not have required field WorkflowName set");
            request.AddPathResource("{workflowName}", StringUtils.FromString(publicRequest.WorkflowName));
            request.ResourcePath = "/matchingworkflows/{workflowName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetIncrementalRunConfig())
            {
                context.Writer.WritePropertyName("incrementalRunConfig");
                context.Writer.WriteStartObject();

                var marshaller = IncrementalRunConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.IncrementalRunConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputSourceConfig())
            {
                context.Writer.WritePropertyName("inputSourceConfig");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputSourceConfigListValue in publicRequest.InputSourceConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputSourceConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOutputSourceConfig())
            {
                context.Writer.WritePropertyName("outputSourceConfig");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutputSourceConfigListValue in publicRequest.OutputSourceConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputSourceConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResolutionTechniques())
            {
                context.Writer.WritePropertyName("resolutionTechniques");
                context.Writer.WriteStartObject();

                var marshaller = ResolutionTechniquesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResolutionTechniques, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
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
        private static UpdateMatchingWorkflowRequestMarshaller _instance = new UpdateMatchingWorkflowRequestMarshaller();        

        internal static UpdateMatchingWorkflowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMatchingWorkflowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}