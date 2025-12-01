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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralAccount.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralAccount.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TaskDetails Marshaller
    /// </summary>
    public class TaskDetailsMarshaller : IRequestMarshaller<TaskDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TaskDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("DisplayName");
                context.Writer.WriteStringValue(requestObject.DisplayName);
            }

            if(requestObject.IsSetIndustrySegments())
            {
                context.Writer.WritePropertyName("IndustrySegments");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIndustrySegmentsListValue in requestObject.IndustrySegments)
                {
                        context.Writer.WriteStringValue(requestObjectIndustrySegmentsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLocalizedContents())
            {
                context.Writer.WritePropertyName("LocalizedContents");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLocalizedContentsListValue in requestObject.LocalizedContents)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LocalizedContentMarshaller.Instance;
                    marshaller.Marshall(requestObjectLocalizedContentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLogoUrl())
            {
                context.Writer.WritePropertyName("LogoUrl");
                context.Writer.WriteStringValue(requestObject.LogoUrl);
            }

            if(requestObject.IsSetPrimarySolutionType())
            {
                context.Writer.WritePropertyName("PrimarySolutionType");
                context.Writer.WriteStringValue(requestObject.PrimarySolutionType);
            }

            if(requestObject.IsSetTranslationSourceLocale())
            {
                context.Writer.WritePropertyName("TranslationSourceLocale");
                context.Writer.WriteStringValue(requestObject.TranslationSourceLocale);
            }

            if(requestObject.IsSetWebsiteUrl())
            {
                context.Writer.WritePropertyName("WebsiteUrl");
                context.Writer.WriteStringValue(requestObject.WebsiteUrl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TaskDetailsMarshaller Instance = new TaskDetailsMarshaller();

    }
}