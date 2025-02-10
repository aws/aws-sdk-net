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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTaskTemplate Request Marshaller
    /// </summary>       
    public class UpdateTaskTemplateRequestMarshaller : IMarshaller<IRequest, UpdateTaskTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTaskTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTaskTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            if (!publicRequest.IsSetTaskTemplateId())
                throw new AmazonConnectException("Request object does not have required field TaskTemplateId set");
            request.AddPathResource("{TaskTemplateId}", StringUtils.FromString(publicRequest.TaskTemplateId));
            request.ResourcePath = "/instance/{InstanceId}/task/template/{TaskTemplateId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConstraints())
            {
                context.Writer.WritePropertyName("Constraints");
                context.Writer.WriteStartObject();

                var marshaller = TaskTemplateConstraintsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Constraints, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContactFlowId())
            {
                context.Writer.WritePropertyName("ContactFlowId");
                context.Writer.WriteStringValue(publicRequest.ContactFlowId);
            }

            if(publicRequest.IsSetDefaults())
            {
                context.Writer.WritePropertyName("Defaults");
                context.Writer.WriteStartObject();

                var marshaller = TaskTemplateDefaultsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Defaults, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFields())
            {
                context.Writer.WritePropertyName("Fields");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFieldsListValue in publicRequest.Fields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaskTemplateFieldMarshaller.Instance;
                    marshaller.Marshall(publicRequestFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSelfAssignFlowId())
            {
                context.Writer.WritePropertyName("SelfAssignFlowId");
                context.Writer.WriteStringValue(publicRequest.SelfAssignFlowId);
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(publicRequest.Status);
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
        private static UpdateTaskTemplateRequestMarshaller _instance = new UpdateTaskTemplateRequestMarshaller();        

        internal static UpdateTaskTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTaskTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}