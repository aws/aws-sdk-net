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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Esam Marshaller
    /// </summary>
    public class EsamMarshaller : IRequestMarshaller<Esam, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Esam requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcquisitionPointId())
            {
                context.Writer.WritePropertyName("acquisitionPointId");
                context.Writer.Write(requestObject.AcquisitionPointId);
            }

            if(requestObject.IsSetAdAvailOffset())
            {
                context.Writer.WritePropertyName("adAvailOffset");
                context.Writer.Write(requestObject.AdAvailOffset);
            }

            if(requestObject.IsSetPasswordParam())
            {
                context.Writer.WritePropertyName("passwordParam");
                context.Writer.Write(requestObject.PasswordParam);
            }

            if(requestObject.IsSetPoisEndpoint())
            {
                context.Writer.WritePropertyName("poisEndpoint");
                context.Writer.Write(requestObject.PoisEndpoint);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("username");
                context.Writer.Write(requestObject.Username);
            }

            if(requestObject.IsSetZoneIdentity())
            {
                context.Writer.WritePropertyName("zoneIdentity");
                context.Writer.Write(requestObject.ZoneIdentity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EsamMarshaller Instance = new EsamMarshaller();

    }
}
#pragma warning restore CS0612,CS0618