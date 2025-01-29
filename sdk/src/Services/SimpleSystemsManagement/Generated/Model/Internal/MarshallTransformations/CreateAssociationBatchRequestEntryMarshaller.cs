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
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAssociationBatchRequestEntry Marshaller
    /// </summary>
    public class CreateAssociationBatchRequestEntryMarshaller : IRequestMarshaller<CreateAssociationBatchRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateAssociationBatchRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlarmConfiguration())
            {
                context.Writer.WritePropertyName("AlarmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AlarmConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AlarmConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetApplyOnlyAtCronInterval())
            {
                context.Writer.WritePropertyName("ApplyOnlyAtCronInterval");
                context.Writer.WriteBooleanValue(requestObject.ApplyOnlyAtCronInterval.Value);
            }

            if(requestObject.IsSetAssociationName())
            {
                context.Writer.WritePropertyName("AssociationName");
                context.Writer.WriteStringValue(requestObject.AssociationName);
            }

            if(requestObject.IsSetAutomationTargetParameterName())
            {
                context.Writer.WritePropertyName("AutomationTargetParameterName");
                context.Writer.WriteStringValue(requestObject.AutomationTargetParameterName);
            }

            if(requestObject.IsSetCalendarNames())
            {
                context.Writer.WritePropertyName("CalendarNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCalendarNamesListValue in requestObject.CalendarNames)
                {
                        context.Writer.WriteStringValue(requestObjectCalendarNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComplianceSeverity())
            {
                context.Writer.WritePropertyName("ComplianceSeverity");
                context.Writer.WriteStringValue(requestObject.ComplianceSeverity);
            }

            if(requestObject.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("DocumentVersion");
                context.Writer.WriteStringValue(requestObject.DocumentVersion);
            }

            if(requestObject.IsSetDuration())
            {
                context.Writer.WritePropertyName("Duration");
                context.Writer.WriteNumberValue(requestObject.Duration.Value);
            }

            if(requestObject.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(requestObject.InstanceId);
            }

            if(requestObject.IsSetMaxConcurrency())
            {
                context.Writer.WritePropertyName("MaxConcurrency");
                context.Writer.WriteStringValue(requestObject.MaxConcurrency);
            }

            if(requestObject.IsSetMaxErrors())
            {
                context.Writer.WritePropertyName("MaxErrors");
                context.Writer.WriteStringValue(requestObject.MaxErrors);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("OutputLocation");
                context.Writer.WriteStartObject();

                var marshaller = InstanceAssociationOutputLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectParametersValueListValue in requestObjectParametersValue)
                    {
                            context.Writer.WriteStringValue(requestObjectParametersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.WriteStringValue(requestObject.ScheduleExpression);
            }

            if(requestObject.IsSetScheduleOffset())
            {
                context.Writer.WritePropertyName("ScheduleOffset");
                context.Writer.WriteNumberValue(requestObject.ScheduleOffset.Value);
            }

            if(requestObject.IsSetSyncCompliance())
            {
                context.Writer.WritePropertyName("SyncCompliance");
                context.Writer.WriteStringValue(requestObject.SyncCompliance);
            }

            if(requestObject.IsSetTargetLocations())
            {
                context.Writer.WritePropertyName("TargetLocations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetLocationsListValue in requestObject.TargetLocations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetLocationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetLocationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetMaps())
            {
                context.Writer.WritePropertyName("TargetMaps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetMapsListValue in requestObject.TargetMaps)
                {
                    context.Writer.WriteStartObject();
                    foreach (var requestObjectTargetMapsListValueKvp in requestObjectTargetMapsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectTargetMapsListValueKvp.Key);
                        var requestObjectTargetMapsListValueValue = requestObjectTargetMapsListValueKvp.Value;

                        context.Writer.WriteStartArray();
                        foreach(var requestObjectTargetMapsListValueValueListValue in requestObjectTargetMapsListValueValue)
                        {
                                context.Writer.WriteStringValue(requestObjectTargetMapsListValueValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetsListValue in requestObject.Targets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateAssociationBatchRequestEntryMarshaller Instance = new CreateAssociationBatchRequestEntryMarshaller();

    }
}