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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
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
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMaintenanceWindowTask Request Marshaller
    /// </summary>       
    public class UpdateMaintenanceWindowTaskRequestMarshaller : IMarshaller<IRequest, UpdateMaintenanceWindowTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMaintenanceWindowTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMaintenanceWindowTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.UpdateMaintenanceWindowTask";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
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
            if(publicRequest.IsSetAlarmConfiguration())
            {
                context.Writer.WritePropertyName("AlarmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AlarmConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AlarmConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCutoffBehavior())
            {
                context.Writer.WritePropertyName("CutoffBehavior");
                context.Writer.WriteStringValue(publicRequest.CutoffBehavior);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetLoggingInfo())
            {
                context.Writer.WritePropertyName("LoggingInfo");
                context.Writer.WriteStartObject();

                var marshaller = LoggingInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.LoggingInfo, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxConcurrency())
            {
                context.Writer.WritePropertyName("MaxConcurrency");
                context.Writer.WriteStringValue(publicRequest.MaxConcurrency);
            }

            if(publicRequest.IsSetMaxErrors())
            {
                context.Writer.WritePropertyName("MaxErrors");
                context.Writer.WriteStringValue(publicRequest.MaxErrors);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.WriteNumberValue(publicRequest.Priority.Value);
            }

            if(publicRequest.IsSetReplace())
            {
                context.Writer.WritePropertyName("Replace");
                context.Writer.WriteBooleanValue(publicRequest.Replace.Value);
            }

            if(publicRequest.IsSetServiceRoleArn())
            {
                context.Writer.WritePropertyName("ServiceRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceRoleArn);
            }

            if(publicRequest.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTaskArn())
            {
                context.Writer.WritePropertyName("TaskArn");
                context.Writer.WriteStringValue(publicRequest.TaskArn);
            }

            if(publicRequest.IsSetTaskInvocationParameters())
            {
                context.Writer.WritePropertyName("TaskInvocationParameters");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowTaskInvocationParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.TaskInvocationParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTaskParameters())
            {
                context.Writer.WritePropertyName("TaskParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTaskParametersKvp in publicRequest.TaskParameters)
                {
                    context.Writer.WritePropertyName(publicRequestTaskParametersKvp.Key);
                    var publicRequestTaskParametersValue = publicRequestTaskParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = MaintenanceWindowTaskParameterValueExpressionMarshaller.Instance;
                    marshaller.Marshall(publicRequestTaskParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWindowId())
            {
                context.Writer.WritePropertyName("WindowId");
                context.Writer.WriteStringValue(publicRequest.WindowId);
            }

            if(publicRequest.IsSetWindowTaskId())
            {
                context.Writer.WritePropertyName("WindowTaskId");
                context.Writer.WriteStringValue(publicRequest.WindowTaskId);
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
        private static UpdateMaintenanceWindowTaskRequestMarshaller _instance = new UpdateMaintenanceWindowTaskRequestMarshaller();        

        internal static UpdateMaintenanceWindowTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMaintenanceWindowTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}