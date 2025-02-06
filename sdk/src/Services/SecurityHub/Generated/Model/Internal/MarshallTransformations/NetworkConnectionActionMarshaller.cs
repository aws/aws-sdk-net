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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NetworkConnectionAction Marshaller
    /// </summary>
    public class NetworkConnectionActionMarshaller : IRequestMarshaller<NetworkConnectionAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NetworkConnectionAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlocked())
            {
                context.Writer.WritePropertyName("Blocked");
                context.Writer.WriteBooleanValue(requestObject.Blocked.Value);
            }

            if(requestObject.IsSetConnectionDirection())
            {
                context.Writer.WritePropertyName("ConnectionDirection");
                context.Writer.WriteStringValue(requestObject.ConnectionDirection);
            }

            if(requestObject.IsSetLocalPortDetails())
            {
                context.Writer.WritePropertyName("LocalPortDetails");
                context.Writer.WriteStartObject();

                var marshaller = ActionLocalPortDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LocalPortDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("Protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetRemoteIpDetails())
            {
                context.Writer.WritePropertyName("RemoteIpDetails");
                context.Writer.WriteStartObject();

                var marshaller = ActionRemoteIpDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RemoteIpDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRemotePortDetails())
            {
                context.Writer.WritePropertyName("RemotePortDetails");
                context.Writer.WriteStartObject();

                var marshaller = ActionRemotePortDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RemotePortDetails, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NetworkConnectionActionMarshaller Instance = new NetworkConnectionActionMarshaller();

    }
}