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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SqsAction Marshaller
    /// </summary>       
    public class SqsActionMarshaller : IRequestMarshaller<SqsAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SqsAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPayload())
            {
                context.Writer.WritePropertyName("payload");
                context.Writer.WriteObjectStart();

                var marshaller = PayloadMarshaller.Instance;
                marshaller.Marshall(requestObject.Payload, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQueueUrl())
            {
                context.Writer.WritePropertyName("queueUrl");
                context.Writer.Write(requestObject.QueueUrl);
            }

            if(requestObject.IsSetUseBase64())
            {
                context.Writer.WritePropertyName("useBase64");
                context.Writer.Write(requestObject.UseBase64);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SqsActionMarshaller Instance = new SqsActionMarshaller();

    }
}