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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SMSTemplateRequest Marshaller
    /// </summary>
    public class SMSTemplateRequestMarshaller : IRequestMarshaller<SMSTemplateRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SMSTemplateRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.WriteStringValue(requestObject.Body);
            }

            if(requestObject.IsSetDefaultSubstitutions())
            {
                context.Writer.WritePropertyName("DefaultSubstitutions");
                context.Writer.WriteStringValue(requestObject.DefaultSubstitutions);
            }

            if(requestObject.IsSetRecommenderId())
            {
                context.Writer.WritePropertyName("RecommenderId");
                context.Writer.WriteStringValue(requestObject.RecommenderId);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTemplateDescription())
            {
                context.Writer.WritePropertyName("TemplateDescription");
                context.Writer.WriteStringValue(requestObject.TemplateDescription);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SMSTemplateRequestMarshaller Instance = new SMSTemplateRequestMarshaller();

    }
}