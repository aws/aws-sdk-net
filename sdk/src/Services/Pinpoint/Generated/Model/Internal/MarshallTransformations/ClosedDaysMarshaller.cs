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
                context.Writer.WriteStartArray();
                foreach(var requestObjectCUSTOMListValue in requestObject.CUSTOM)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectCUSTOMListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEMAIL())
            {
                context.Writer.WritePropertyName("EMAIL");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEMAILListValue in requestObject.EMAIL)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectEMAILListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPUSH())
            {
                context.Writer.WritePropertyName("PUSH");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPUSHListValue in requestObject.PUSH)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPUSHListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSMS())
            {
                context.Writer.WritePropertyName("SMS");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSMSListValue in requestObject.SMS)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectSMSListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVOICE())
            {
                context.Writer.WritePropertyName("VOICE");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVOICEListValue in requestObject.VOICE)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClosedDaysRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectVOICEListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClosedDaysMarshaller Instance = new ClosedDaysMarshaller();

    }
}