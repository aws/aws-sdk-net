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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CommunicationTimeConfig Marshaller
    /// </summary>
    public class CommunicationTimeConfigMarshaller : IRequestMarshaller<CommunicationTimeConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CommunicationTimeConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEmail())
            {
                context.Writer.WritePropertyName("email");
                context.Writer.WriteStartObject();

                var marshaller = TimeWindowMarshaller.Instance;
                marshaller.Marshall(requestObject.Email, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLocalTimeZoneConfig())
            {
                context.Writer.WritePropertyName("localTimeZoneConfig");
                context.Writer.WriteStartObject();

                var marshaller = LocalTimeZoneConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LocalTimeZoneConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSms())
            {
                context.Writer.WritePropertyName("sms");
                context.Writer.WriteStartObject();

                var marshaller = TimeWindowMarshaller.Instance;
                marshaller.Marshall(requestObject.Sms, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTelephony())
            {
                context.Writer.WritePropertyName("telephony");
                context.Writer.WriteStartObject();

                var marshaller = TimeWindowMarshaller.Instance;
                marshaller.Marshall(requestObject.Telephony, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CommunicationTimeConfigMarshaller Instance = new CommunicationTimeConfigMarshaller();

    }
}