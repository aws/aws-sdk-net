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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCopyTags())
            {
                context.Writer.WritePropertyName("CopyTags");
                context.Writer.Write(requestObject.CopyTags);
            }

            if(requestObject.IsSetCreateInterval())
            {
                context.Writer.WritePropertyName("CreateInterval");
                context.Writer.Write(requestObject.CreateInterval);
            }

            if(requestObject.IsSetCrossRegionCopyTargets())
            {
                context.Writer.WritePropertyName("CrossRegionCopyTargets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCrossRegionCopyTargetsListValue in requestObject.CrossRegionCopyTargets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CrossRegionCopyTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectCrossRegionCopyTargetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventSource())
            {
                context.Writer.WritePropertyName("EventSource");
                context.Writer.WriteObjectStart();

                var marshaller = EventSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.EventSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExclusions())
            {
                context.Writer.WritePropertyName("Exclusions");
                context.Writer.WriteObjectStart();

                var marshaller = ExclusionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Exclusions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExtendDeletion())
            {
                context.Writer.WritePropertyName("ExtendDeletion");
                context.Writer.Write(requestObject.ExtendDeletion);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteObjectStart();

                var marshaller = ParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.Parameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPolicyLanguage())
            {
                context.Writer.WritePropertyName("PolicyLanguage");
                context.Writer.Write(requestObject.PolicyLanguage);
            }

            if(requestObject.IsSetPolicyType())
            {
                context.Writer.WritePropertyName("PolicyType");
                context.Writer.Write(requestObject.PolicyType);
            }

            if(requestObject.IsSetResourceLocations())
            {
                context.Writer.WritePropertyName("ResourceLocations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceLocationsListValue in requestObject.ResourceLocations)
                {
                        context.Writer.Write(requestObjectResourceLocationsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.Write(requestObject.ResourceType);
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.Write(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRetainInterval())
            {
                context.Writer.WritePropertyName("RetainInterval");
                context.Writer.Write(requestObject.RetainInterval);
            }

            if(requestObject.IsSetSchedules())
            {
                context.Writer.WritePropertyName("Schedules");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSchedulesListValue in requestObject.Schedules)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ScheduleMarshaller.Instance;
                    marshaller.Marshall(requestObjectSchedulesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetTags())
            {
                context.Writer.WritePropertyName("TargetTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetTagsListValue in requestObject.TargetTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyDetailsMarshaller Instance = new PolicyDetailsMarshaller();

    }
}