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

#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ClosedDays Marshaller
    /// </summary>
    public class ClosedDaysMarshaller : IRequestMarshaller<ClosedDays, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ClosedDays requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCUSTOM())
            {
                context.Writer.WritePropertyName("CUSTOM");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCUSTOMListValue in requestObject.CUSTOM)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectCUSTOMListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEMAIL())
            {
                context.Writer.WritePropertyName("EMAIL");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEMAILListValue in requestObject.EMAIL)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectEMAILListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPUSH())
            {
                context.Writer.WritePropertyName("PUSH");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPUSHListValue in requestObject.PUSH)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPUSHListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSMS())
            {
                context.Writer.WritePropertyName("SMS");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSMSListValue in requestObject.SMS)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectSMSListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVOICE())
            {
                context.Writer.WritePropertyName("VOICE");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVOICEListValue in requestObject.VOICE)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectVOICEListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClosedDaysMarshaller Instance = new ClosedDaysMarshaller();

    }
}