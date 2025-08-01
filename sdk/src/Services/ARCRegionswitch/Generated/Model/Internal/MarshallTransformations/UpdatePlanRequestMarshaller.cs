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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
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
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePlan Request Marshaller
    /// </summary>       
    public class UpdatePlanRequestMarshaller : IMarshaller<IRequest, UpdatePlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ARCRegionswitch");
            string target = "ArcRegionSwitch.UpdatePlan";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
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
            if(publicRequest.IsSetArn())
            {
                context.Writer.WritePropertyName("arn");
                context.Writer.WriteStringValue(publicRequest.Arn);
            }

            if(publicRequest.IsSetAssociatedAlarms())
            {
                context.Writer.WritePropertyName("associatedAlarms");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAssociatedAlarmsKvp in publicRequest.AssociatedAlarms)
                {
                    context.Writer.WritePropertyName(publicRequestAssociatedAlarmsKvp.Key);
                    var publicRequestAssociatedAlarmsValue = publicRequestAssociatedAlarmsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AssociatedAlarmMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssociatedAlarmsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("executionRole");
                context.Writer.WriteStringValue(publicRequest.ExecutionRole);
            }

            if(publicRequest.IsSetRecoveryTimeObjectiveMinutes())
            {
                context.Writer.WritePropertyName("recoveryTimeObjectiveMinutes");
                context.Writer.WriteNumberValue(publicRequest.RecoveryTimeObjectiveMinutes.Value);
            }

            if(publicRequest.IsSetTriggers())
            {
                context.Writer.WritePropertyName("triggers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTriggersListValue in publicRequest.Triggers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TriggerMarshaller.Instance;
                    marshaller.Marshall(publicRequestTriggersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWorkflows())
            {
                context.Writer.WritePropertyName("workflows");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWorkflowsListValue in publicRequest.Workflows)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WorkflowMarshaller.Instance;
                    marshaller.Marshall(publicRequestWorkflowsListValue, context);

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
        private static UpdatePlanRequestMarshaller _instance = new UpdatePlanRequestMarshaller();        

        internal static UpdatePlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}