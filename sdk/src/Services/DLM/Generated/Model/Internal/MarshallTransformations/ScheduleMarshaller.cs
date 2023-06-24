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
            if(requestObject.IsSetArchiveRule())
            {
                context.Writer.WritePropertyName("ArchiveRule");
                context.Writer.WriteObjectStart();

                var marshaller = ArchiveRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.ArchiveRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCopyTags())
            {
                context.Writer.WritePropertyName("CopyTags");
                context.Writer.Write(requestObject.CopyTags);
            }

            if(requestObject.IsSetCreateRule())
            {
                context.Writer.WritePropertyName("CreateRule");
                context.Writer.WriteObjectStart();

                var marshaller = CreateRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCrossRegionCopyRules())
            {
                context.Writer.WritePropertyName("CrossRegionCopyRules");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCrossRegionCopyRulesListValue in requestObject.CrossRegionCopyRules)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CrossRegionCopyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectCrossRegionCopyRulesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDeprecateRule())
            {
                context.Writer.WritePropertyName("DeprecateRule");
                context.Writer.WriteObjectStart();

                var marshaller = DeprecateRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.DeprecateRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFastRestoreRule())
            {
                context.Writer.WritePropertyName("FastRestoreRule");
                context.Writer.WriteObjectStart();

                var marshaller = FastRestoreRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.FastRestoreRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRetainRule())
            {
                context.Writer.WritePropertyName("RetainRule");
                context.Writer.WriteObjectStart();

                var marshaller = RetainRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.RetainRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetShareRules())
            {
                context.Writer.WritePropertyName("ShareRules");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectShareRulesListValue in requestObject.ShareRules)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ShareRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectShareRulesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTagsToAdd())
            {
                context.Writer.WritePropertyName("TagsToAdd");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagsToAddListValue in requestObject.TagsToAdd)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsToAddListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVariableTags())
            {
                context.Writer.WritePropertyName("VariableTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVariableTagsListValue in requestObject.VariableTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariableTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduleMarshaller Instance = new ScheduleMarshaller();

    }
}