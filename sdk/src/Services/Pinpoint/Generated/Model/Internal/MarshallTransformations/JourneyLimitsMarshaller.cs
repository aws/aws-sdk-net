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
    /// JourneyLimits Marshaller
    /// </summary>       
    public class JourneyLimitsMarshaller : IRequestMarshaller<JourneyLimits, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JourneyLimits requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDailyCap())
            {
                context.Writer.WritePropertyName("DailyCap");
                context.Writer.Write(requestObject.DailyCap);
            }

            if(requestObject.IsSetEndpointReentryCap())
            {
                context.Writer.WritePropertyName("EndpointReentryCap");
                context.Writer.Write(requestObject.EndpointReentryCap);
            }

            if(requestObject.IsSetEndpointReentryInterval())
            {
                context.Writer.WritePropertyName("EndpointReentryInterval");
                context.Writer.Write(requestObject.EndpointReentryInterval);
            }

            if(requestObject.IsSetMessagesPerSecond())
            {
                context.Writer.WritePropertyName("MessagesPerSecond");
                context.Writer.Write(requestObject.MessagesPerSecond);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static JourneyLimitsMarshaller Instance = new JourneyLimitsMarshaller();

    }
}