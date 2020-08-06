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
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PushNotificationTemplateRequest Marshaller
    /// </summary>       
    public class PushNotificationTemplateRequestMarshaller : IRequestMarshaller<PushNotificationTemplateRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PushNotificationTemplateRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetADM())
            {
                context.Writer.WritePropertyName("ADM");
                context.Writer.WriteObjectStart();

                var marshaller = AndroidPushNotificationTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.ADM, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAPNS())
            {
                context.Writer.WritePropertyName("APNS");
                context.Writer.WriteObjectStart();

                var marshaller = APNSPushNotificationTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.APNS, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBaidu())
            {
                context.Writer.WritePropertyName("Baidu");
                context.Writer.WriteObjectStart();

                var marshaller = AndroidPushNotificationTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.Baidu, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefault())
            {
                context.Writer.WritePropertyName("Default");
                context.Writer.WriteObjectStart();

                var marshaller = DefaultPushNotificationTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.Default, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultSubstitutions())
            {
                context.Writer.WritePropertyName("DefaultSubstitutions");
                context.Writer.Write(requestObject.DefaultSubstitutions);
            }

            if(requestObject.IsSetGCM())
            {
                context.Writer.WritePropertyName("GCM");
                context.Writer.WriteObjectStart();

                var marshaller = AndroidPushNotificationTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.GCM, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRecommenderId())
            {
                context.Writer.WritePropertyName("RecommenderId");
                context.Writer.Write(requestObject.RecommenderId);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTemplateDescription())
            {
                context.Writer.WritePropertyName("TemplateDescription");
                context.Writer.Write(requestObject.TemplateDescription);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PushNotificationTemplateRequestMarshaller Instance = new PushNotificationTemplateRequestMarshaller();

    }
}