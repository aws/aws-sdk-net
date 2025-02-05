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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OriginationRoute Marshaller
    /// </summary>
    public class OriginationRouteMarshaller : IRequestMarshaller<OriginationRoute, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OriginationRoute requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHost())
            {
                context.Writer.WritePropertyName("Host");
                context.Writer.WriteStringValue(requestObject.Host);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.WriteNumberValue(requestObject.Priority.Value);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("Protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetWeight())
            {
                context.Writer.WritePropertyName("Weight");
                context.Writer.WriteNumberValue(requestObject.Weight.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OriginationRouteMarshaller Instance = new OriginationRouteMarshaller();

    }
}