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
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionType())
            {
                context.Writer.WritePropertyName("ActionType");
                context.Writer.WriteStringValue(requestObject.ActionType);
            }

            if(requestObject.IsSetAwsApiCallAction())
            {
                context.Writer.WritePropertyName("AwsApiCallAction");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiCallActionMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiCallAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDnsRequestAction())
            {
                context.Writer.WritePropertyName("DnsRequestAction");
                context.Writer.WriteStartObject();

                var marshaller = DnsRequestActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DnsRequestAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkConnectionAction())
            {
                context.Writer.WritePropertyName("NetworkConnectionAction");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConnectionActionMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConnectionAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPortProbeAction())
            {
                context.Writer.WritePropertyName("PortProbeAction");
                context.Writer.WriteStartObject();

                var marshaller = PortProbeActionMarshaller.Instance;
                marshaller.Marshall(requestObject.PortProbeAction, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActionMarshaller Instance = new ActionMarshaller();

    }
}