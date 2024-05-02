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
    /// OpenHours Marshaller
    /// </summary>
    public class OpenHoursMarshaller : IRequestMarshaller<OpenHours, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OpenHours requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCUSTOM())
            {
                context.Writer.WritePropertyName("CUSTOM");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCUSTOMKvp in requestObject.CUSTOM)
                {
                    context.Writer.WritePropertyName(requestObjectCUSTOMKvp.Key);
                    var requestObjectCUSTOMValue = requestObjectCUSTOMKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectCUSTOMValueListValue in requestObjectCUSTOMValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OpenHoursRuleMarshaller.Instance;
                        marshaller.Marshall(requestObjectCUSTOMValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEMAIL())
            {
                context.Writer.WritePropertyName("EMAIL");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEMAILKvp in requestObject.EMAIL)
                {
                    context.Writer.WritePropertyName(requestObjectEMAILKvp.Key);
                    var requestObjectEMAILValue = requestObjectEMAILKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectEMAILValueListValue in requestObjectEMAILValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OpenHoursRuleMarshaller.Instance;
                        marshaller.Marshall(requestObjectEMAILValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPUSH())
            {
                context.Writer.WritePropertyName("PUSH");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPUSHKvp in requestObject.PUSH)
                {
                    context.Writer.WritePropertyName(requestObjectPUSHKvp.Key);
                    var requestObjectPUSHValue = requestObjectPUSHKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectPUSHValueListValue in requestObjectPUSHValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OpenHoursRuleMarshaller.Instance;
                        marshaller.Marshall(requestObjectPUSHValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSMS())
            {
                context.Writer.WritePropertyName("SMS");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSMSKvp in requestObject.SMS)
                {
                    context.Writer.WritePropertyName(requestObjectSMSKvp.Key);
                    var requestObjectSMSValue = requestObjectSMSKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectSMSValueListValue in requestObjectSMSValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OpenHoursRuleMarshaller.Instance;
                        marshaller.Marshall(requestObjectSMSValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVOICE())
            {
                context.Writer.WritePropertyName("VOICE");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectVOICEKvp in requestObject.VOICE)
                {
                    context.Writer.WritePropertyName(requestObjectVOICEKvp.Key);
                    var requestObjectVOICEValue = requestObjectVOICEKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectVOICEValueListValue in requestObjectVOICEValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OpenHoursRuleMarshaller.Instance;
                        marshaller.Marshall(requestObjectVOICEValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OpenHoursMarshaller Instance = new OpenHoursMarshaller();

    }
}