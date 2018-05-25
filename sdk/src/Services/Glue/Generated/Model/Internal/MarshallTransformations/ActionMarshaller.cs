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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Action Marshaller
    /// </summary>       
    public class ActionMarshaller : IRequestMarshaller<Action, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Action requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArguments())
            {
                context.Writer.WritePropertyName("Arguments");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectArgumentsKvp in requestObject.Arguments)
                {
                    context.Writer.WritePropertyName(requestObjectArgumentsKvp.Key);
                    var requestObjectArgumentsValue = requestObjectArgumentsKvp.Value;

                        context.Writer.Write(requestObjectArgumentsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJobName())
            {
                context.Writer.WritePropertyName("JobName");
                context.Writer.Write(requestObject.JobName);
            }

            if(requestObject.IsSetNotificationProperty())
            {
                context.Writer.WritePropertyName("NotificationProperty");
                context.Writer.WriteObjectStart();

                var marshaller = NotificationPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.NotificationProperty, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.Write(requestObject.Timeout);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ActionMarshaller Instance = new ActionMarshaller();

    }
}