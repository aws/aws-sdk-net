/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ScheduleMarshaller Instance = new ScheduleMarshaller();

    }
}