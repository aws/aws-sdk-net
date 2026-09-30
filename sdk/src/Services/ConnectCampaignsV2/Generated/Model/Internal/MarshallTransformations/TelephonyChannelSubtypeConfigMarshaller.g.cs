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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TelephonyChannelSubtypeConfig Marshaller
    /// </summary>
    public partial class TelephonyChannelSubtypeConfigMarshaller : IRequestMarshaller<TelephonyChannelSubtypeConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(TelephonyChannelSubtypeConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCapacity())
            {
                context.Writer.WritePropertyName("capacity");
                if (StringUtils.IsSpecialDoubleValue(requestObject.Capacity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Capacity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Capacity.Value);
                }
            }

            if (requestObject.IsSetConnectQueueId())
            {
                context.Writer.WritePropertyName("connectQueueId");
                context.Writer.WriteStringValue(requestObject.ConnectQueueId);
            }

            if (requestObject.IsSetDefaultOutboundConfig())
            {
                context.Writer.WritePropertyName("defaultOutboundConfig");
                context.Writer.WriteStartObject();

                var marshaller = TelephonyOutboundConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultOutboundConfig, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetOutboundMode())
            {
                context.Writer.WritePropertyName("outboundMode");
                context.Writer.WriteStartObject();

                var marshaller = TelephonyOutboundModeMarshaller.Instance;
                marshaller.Marshall(requestObject.OutboundMode, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static TelephonyChannelSubtypeConfigMarshaller Instance = new TelephonyChannelSubtypeConfigMarshaller();
    }
}
