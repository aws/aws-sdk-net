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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
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
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if(publicRequest.IsSetAllocatedCapacity())
            {
                context.Writer.WritePropertyName("AllocatedCapacity");
                context.Writer.WriteNumberValue(publicRequest.AllocatedCapacity.Value);
            }

            if(publicRequest.IsSetCodeGenConfigurationNodes())
            {
                context.Writer.WritePropertyName("CodeGenConfigurationNodes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCodeGenConfigurationNodesKvp in publicRequest.CodeGenConfigurationNodes)
                {
                    context.Writer.WritePropertyName(publicRequestCodeGenConfigurationNodesKvp.Key);
                    var publicRequestCodeGenConfigurationNodesValue = publicRequestCodeGenConfigurationNodesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CodeGenConfigurationNodeMarshaller.Instance;
                    marshaller.Marshall(publicRequestCodeGenConfigurationNodesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteStartObject();

                var marshaller = JobCommandMarshaller.Instance;
                marshaller.Marshall(publicRequest.Command, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConnections())
            {
                context.Writer.WritePropertyName("Connections");
                context.Writer.WriteStartObject();

                var marshaller = ConnectionsListMarshaller.Instance;
                marshaller.Marshall(publicRequest.Connections, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDefaultArguments())
            {
                context.Writer.WritePropertyName("DefaultArguments");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDefaultArgumentsKvp in publicRequest.DefaultArguments)
                {
                    context.Writer.WritePropertyName(publicRequestDefaultArgumentsKvp.Key);
                    var publicRequestDefaultArgumentsValue = publicRequestDefaultArgumentsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestDefaultArgumentsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetExecutionClass())
            {
                context.Writer.WritePropertyName("ExecutionClass");
                context.Writer.WriteStringValue(publicRequest.ExecutionClass);
            }

            if(publicRequest.IsSetExecutionProperty())
            {
                context.Writer.WritePropertyName("ExecutionProperty");
                context.Writer.WriteStartObject();

                var marshaller = ExecutionPropertyMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExecutionProperty, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGlueVersion())
            {
                context.Writer.WritePropertyName("GlueVersion");
                context.Writer.WriteStringValue(publicRequest.GlueVersion);
            }

            if(publicRequest.IsSetJobMode())
            {
                context.Writer.WritePropertyName("JobMode");
                context.Writer.WriteStringValue(publicRequest.JobMode);
            }

            if(publicRequest.IsSetJobRunQueuingEnabled())
            {
                context.Writer.WritePropertyName("JobRunQueuingEnabled");
                context.Writer.WriteBooleanValue(publicRequest.JobRunQueuingEnabled.Value);
            }

            if(publicRequest.IsSetLogUri())
            {
                context.Writer.WritePropertyName("LogUri");
                context.Writer.WriteStringValue(publicRequest.LogUri);
            }

            if(publicRequest.IsSetMaintenanceWindow())
            {
                context.Writer.WritePropertyName("MaintenanceWindow");
                context.Writer.WriteStringValue(publicRequest.MaintenanceWindow);
            }

            if(publicRequest.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("MaxCapacity");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.MaxCapacity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.MaxCapacity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.MaxCapacity.Value);
                }
            }

            if(publicRequest.IsSetMaxRetries())
            {
                context.Writer.WritePropertyName("MaxRetries");
                context.Writer.WriteNumberValue(publicRequest.MaxRetries.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNonOverridableArguments())
            {
                context.Writer.WritePropertyName("NonOverridableArguments");
                context.Writer.WriteStartObject();
                foreach (var publicRequestNonOverridableArgumentsKvp in publicRequest.NonOverridableArguments)
                {
                    context.Writer.WritePropertyName(publicRequestNonOverridableArgumentsKvp.Key);
                    var publicRequestNonOverridableArgumentsValue = publicRequestNonOverridableArgumentsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestNonOverridableArgumentsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNotificationProperty())
            {
                context.Writer.WritePropertyName("NotificationProperty");
                context.Writer.WriteStartObject();

                var marshaller = NotificationPropertyMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationProperty, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("NumberOfWorkers");
                context.Writer.WriteNumberValue(publicRequest.NumberOfWorkers.Value);
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetSecurityConfiguration())
            {
                context.Writer.WritePropertyName("SecurityConfiguration");
                context.Writer.WriteStringValue(publicRequest.SecurityConfiguration);
            }

            if(publicRequest.IsSetSourceControlDetails())
            {
                context.Writer.WritePropertyName("SourceControlDetails");
                context.Writer.WriteStartObject();

                var marshaller = SourceControlDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceControlDetails, context);

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

            if(publicRequest.IsSetWorkerType())
            {
                context.Writer.WritePropertyName("WorkerType");
                context.Writer.WriteStringValue(publicRequest.WorkerType);
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
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}