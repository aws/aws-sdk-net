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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PolicyDetails Marshaller
    /// </summary>
    public class PolicyDetailsMarshaller : IRequestMarshaller<PolicyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PolicyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCopyTags())
            {
                context.Writer.WritePropertyName("CopyTags");
                context.Writer.WriteBooleanValue(requestObject.CopyTags.Value);
            }

            if(requestObject.IsSetCreateInterval())
            {
                context.Writer.WritePropertyName("CreateInterval");
                context.Writer.WriteNumberValue(requestObject.CreateInterval.Value);
            }

            if(requestObject.IsSetCrossRegionCopyTargets())
            {
                context.Writer.WritePropertyName("CrossRegionCopyTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCrossRegionCopyTargetsListValue in requestObject.CrossRegionCopyTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CrossRegionCopyTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectCrossRegionCopyTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEventSource())
            {
                context.Writer.WritePropertyName("EventSource");
                context.Writer.WriteStartObject();

                var marshaller = EventSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.EventSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExclusions())
            {
                context.Writer.WritePropertyName("Exclusions");
                context.Writer.WriteStartObject();

                var marshaller = ExclusionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Exclusions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExtendDeletion())
            {
                context.Writer.WritePropertyName("ExtendDeletion");
                context.Writer.WriteBooleanValue(requestObject.ExtendDeletion.Value);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();

                var marshaller = ParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.Parameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPolicyLanguage())
            {
                context.Writer.WritePropertyName("PolicyLanguage");
                context.Writer.WriteStringValue(requestObject.PolicyLanguage);
            }

            if(requestObject.IsSetPolicyType())
            {
                context.Writer.WritePropertyName("PolicyType");
                context.Writer.WriteStringValue(requestObject.PolicyType);
            }

            if(requestObject.IsSetResourceLocations())
            {
                context.Writer.WritePropertyName("ResourceLocations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceLocationsListValue in requestObject.ResourceLocations)
                {
                        context.Writer.WriteStringValue(requestObjectResourceLocationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStringValue(requestObject.ResourceType);
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRetainInterval())
            {
                context.Writer.WritePropertyName("RetainInterval");
                context.Writer.WriteNumberValue(requestObject.RetainInterval.Value);
            }

            if(requestObject.IsSetSchedules())
            {
                context.Writer.WritePropertyName("Schedules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSchedulesListValue in requestObject.Schedules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ScheduleMarshaller.Instance;
                    marshaller.Marshall(requestObjectSchedulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetTags())
            {
                context.Writer.WritePropertyName("TargetTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetTagsListValue in requestObject.TargetTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyDetailsMarshaller Instance = new PolicyDetailsMarshaller();

    }
}