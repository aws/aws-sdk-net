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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Scte35DeliveryRestrictions Marshaller
    /// </summary>       
    public class Scte35DeliveryRestrictionsMarshaller : IRequestMarshaller<Scte35DeliveryRestrictions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Scte35DeliveryRestrictions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArchiveAllowedFlag())
            {
                context.Writer.WritePropertyName("archiveAllowedFlag");
                context.Writer.Write(requestObject.ArchiveAllowedFlag);
            }

            if(requestObject.IsSetDeviceRestrictions())
            {
                context.Writer.WritePropertyName("deviceRestrictions");
                context.Writer.Write(requestObject.DeviceRestrictions);
            }

            if(requestObject.IsSetNoRegionalBlackoutFlag())
            {
                context.Writer.WritePropertyName("noRegionalBlackoutFlag");
                context.Writer.Write(requestObject.NoRegionalBlackoutFlag);
            }

            if(requestObject.IsSetWebDeliveryAllowedFlag())
            {
                context.Writer.WritePropertyName("webDeliveryAllowedFlag");
                context.Writer.Write(requestObject.WebDeliveryAllowedFlag);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static Scte35DeliveryRestrictionsMarshaller Instance = new Scte35DeliveryRestrictionsMarshaller();

    }
}