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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Player Marshaller
    /// </summary>
    public class PlayerMarshaller : IRequestMarshaller<Player, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Player requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetLatencyInMs())
            {
                context.Writer.WriteTextString("LatencyInMs");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectLatencyInMsKvp in requestObject.LatencyInMs)
                {
                    context.Writer.WriteTextString(requestObjectLatencyInMsKvp.Key);
                    var requestObjectLatencyInMsValue = requestObjectLatencyInMsKvp.Value;

                        context.Writer.WriteInt32(requestObjectLatencyInMsValue);
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPlayerAttributes())
            {
                context.Writer.WriteTextString("PlayerAttributes");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectPlayerAttributesKvp in requestObject.PlayerAttributes)
                {
                    context.Writer.WriteTextString(requestObjectPlayerAttributesKvp.Key);
                    var requestObjectPlayerAttributesValue = requestObjectPlayerAttributesKvp.Value;

                    context.Writer.WriteStartMap(null);

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlayerAttributesValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPlayerId())
            {
                context.Writer.WriteTextString("PlayerId");
                context.Writer.WriteTextString(requestObject.PlayerId);
            }
            if (requestObject.IsSetTeam())
            {
                context.Writer.WriteTextString("Team");
                context.Writer.WriteTextString(requestObject.Team);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PlayerMarshaller Instance = new PlayerMarshaller();

    }
}