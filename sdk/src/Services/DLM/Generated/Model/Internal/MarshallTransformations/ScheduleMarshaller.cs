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
    /// Schedule Marshaller
    /// </summary>
    public class ScheduleMarshaller : IRequestMarshaller<Schedule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Schedule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArchiveRule())
            {
                context.Writer.WritePropertyName("ArchiveRule");
                context.Writer.WriteStartObject();

                var marshaller = ArchiveRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.ArchiveRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCopyTags())
            {
                context.Writer.WritePropertyName("CopyTags");
                context.Writer.WriteBooleanValue(requestObject.CopyTags.Value);
            }

            if(requestObject.IsSetCreateRule())
            {
                context.Writer.WritePropertyName("CreateRule");
                context.Writer.WriteStartObject();

                var marshaller = CreateRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCrossRegionCopyRules())
            {
                context.Writer.WritePropertyName("CrossRegionCopyRules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCrossRegionCopyRulesListValue in requestObject.CrossRegionCopyRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CrossRegionCopyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectCrossRegionCopyRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDeprecateRule())
            {
                context.Writer.WritePropertyName("DeprecateRule");
                context.Writer.WriteStartObject();

                var marshaller = DeprecateRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.DeprecateRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFastRestoreRule())
            {
                context.Writer.WritePropertyName("FastRestoreRule");
                context.Writer.WriteStartObject();

                var marshaller = FastRestoreRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.FastRestoreRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRetainRule())
            {
                context.Writer.WritePropertyName("RetainRule");
                context.Writer.WriteStartObject();

                var marshaller = RetainRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.RetainRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetShareRules())
            {
                context.Writer.WritePropertyName("ShareRules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectShareRulesListValue in requestObject.ShareRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ShareRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectShareRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTagsToAdd())
            {
                context.Writer.WritePropertyName("TagsToAdd");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagsToAddListValue in requestObject.TagsToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVariableTags())
            {
                context.Writer.WritePropertyName("VariableTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVariableTagsListValue in requestObject.VariableTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariableTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduleMarshaller Instance = new ScheduleMarshaller();

    }
}