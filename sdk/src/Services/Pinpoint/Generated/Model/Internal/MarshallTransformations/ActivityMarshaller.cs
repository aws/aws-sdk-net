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
    /// Activity Marshaller
    /// </summary>
    public class ActivityMarshaller : IRequestMarshaller<Activity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Activity requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConditionalSplit())
            {
                context.Writer.WritePropertyName("ConditionalSplit");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalSplitActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.ConditionalSplit, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContactCenter())
            {
                context.Writer.WritePropertyName("ContactCenter");
                context.Writer.WriteObjectStart();

                var marshaller = ContactCenterActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.ContactCenter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCUSTOM())
            {
                context.Writer.WritePropertyName("CUSTOM");
                context.Writer.WriteObjectStart();

                var marshaller = CustomMessageActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.CUSTOM, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEMAIL())
            {
                context.Writer.WritePropertyName("EMAIL");
                context.Writer.WriteObjectStart();

                var marshaller = EmailMessageActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.EMAIL, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHoldout())
            {
                context.Writer.WritePropertyName("Holdout");
                context.Writer.WriteObjectStart();

                var marshaller = HoldoutActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.Holdout, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMultiCondition())
            {
                context.Writer.WritePropertyName("MultiCondition");
                context.Writer.WriteObjectStart();

                var marshaller = MultiConditionalSplitActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.MultiCondition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPUSH())
            {
                context.Writer.WritePropertyName("PUSH");
                context.Writer.WriteObjectStart();

                var marshaller = PushMessageActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.PUSH, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRandomSplit())
            {
                context.Writer.WritePropertyName("RandomSplit");
                context.Writer.WriteObjectStart();

                var marshaller = RandomSplitActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.RandomSplit, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSMS())
            {
                context.Writer.WritePropertyName("SMS");
                context.Writer.WriteObjectStart();

                var marshaller = SMSMessageActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.SMS, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWait())
            {
                context.Writer.WritePropertyName("Wait");
                context.Writer.WriteObjectStart();

                var marshaller = WaitActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.Wait, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActivityMarshaller Instance = new ActivityMarshaller();

    }
}