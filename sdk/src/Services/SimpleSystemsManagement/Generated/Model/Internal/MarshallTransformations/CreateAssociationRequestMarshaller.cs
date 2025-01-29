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
    /// CreateAssociation Request Marshaller
    /// </summary>       
    public class CreateAssociationRequestMarshaller : IMarshaller<IRequest, CreateAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.CreateAssociation";
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

            if(publicRequest.IsSetApplyOnlyAtCronInterval())
            {
                context.Writer.WritePropertyName("ApplyOnlyAtCronInterval");
                context.Writer.WriteBooleanValue(publicRequest.ApplyOnlyAtCronInterval.Value);
            }

            if(publicRequest.IsSetAssociationName())
            {
                context.Writer.WritePropertyName("AssociationName");
                context.Writer.WriteStringValue(publicRequest.AssociationName);
            }

            if(publicRequest.IsSetAutomationTargetParameterName())
            {
                context.Writer.WritePropertyName("AutomationTargetParameterName");
                context.Writer.WriteStringValue(publicRequest.AutomationTargetParameterName);
            }

            if(publicRequest.IsSetCalendarNames())
            {
                context.Writer.WritePropertyName("CalendarNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCalendarNamesListValue in publicRequest.CalendarNames)
                {
                        context.Writer.WriteStringValue(publicRequestCalendarNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetComplianceSeverity())
            {
                context.Writer.WritePropertyName("ComplianceSeverity");
                context.Writer.WriteStringValue(publicRequest.ComplianceSeverity);
            }

            if(publicRequest.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("DocumentVersion");
                context.Writer.WriteStringValue(publicRequest.DocumentVersion);
            }

            if(publicRequest.IsSetDuration())
            {
                context.Writer.WritePropertyName("Duration");
                context.Writer.WriteNumberValue(publicRequest.Duration.Value);
            }

            if(publicRequest.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(publicRequest.InstanceId);
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

            if(publicRequest.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("OutputLocation");
                context.Writer.WriteStartObject();

                var marshaller = InstanceAssociationOutputLocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputLocation, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                    {
                            context.Writer.WriteStringValue(publicRequestParametersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.WriteStringValue(publicRequest.ScheduleExpression);
            }

            if(publicRequest.IsSetScheduleOffset())
            {
                context.Writer.WritePropertyName("ScheduleOffset");
                context.Writer.WriteNumberValue(publicRequest.ScheduleOffset.Value);
            }

            if(publicRequest.IsSetSyncCompliance())
            {
                context.Writer.WritePropertyName("SyncCompliance");
                context.Writer.WriteStringValue(publicRequest.SyncCompliance);
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

            if(publicRequest.IsSetTargetLocations())
            {
                context.Writer.WritePropertyName("TargetLocations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetLocationsListValue in publicRequest.TargetLocations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetLocationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetMaps())
            {
                context.Writer.WritePropertyName("TargetMaps");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetMapsListValue in publicRequest.TargetMaps)
                {
                    context.Writer.WriteStartObject();
                    foreach (var publicRequestTargetMapsListValueKvp in publicRequestTargetMapsListValue)
                    {
                        context.Writer.WritePropertyName(publicRequestTargetMapsListValueKvp.Key);
                        var publicRequestTargetMapsListValueValue = publicRequestTargetMapsListValueKvp.Value;

                        context.Writer.WriteStartArray();
                        foreach(var publicRequestTargetMapsListValueValueListValue in publicRequestTargetMapsListValueValue)
                        {
                                context.Writer.WriteStringValue(publicRequestTargetMapsListValueValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static CreateAssociationRequestMarshaller _instance = new CreateAssociationRequestMarshaller();        

        internal static CreateAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}