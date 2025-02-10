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
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InputIdentifier Marshaller
    /// </summary>
    public class InputIdentifierMarshaller : IRequestMarshaller<InputIdentifier, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InputIdentifier requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIotEventsInputIdentifier())
            {
                context.Writer.WritePropertyName("iotEventsInputIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = IotEventsInputIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.IotEventsInputIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIotSiteWiseInputIdentifier())
            {
                context.Writer.WritePropertyName("iotSiteWiseInputIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = IotSiteWiseInputIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.IotSiteWiseInputIdentifier, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputIdentifierMarshaller Instance = new InputIdentifierMarshaller();

    }
}