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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVSRealTime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IVSRealTime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParticipantTokenConfiguration Marshaller
    /// </summary>
    public class ParticipantTokenConfigurationMarshaller : IRequestMarshaller<ParticipantTokenConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParticipantTokenConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.Write(requestObjectAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("capabilities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCapabilitiesListValue in requestObject.Capabilities)
                {
                        context.Writer.Write(requestObjectCapabilitiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDuration())
            {
                context.Writer.WritePropertyName("duration");
                context.Writer.Write(requestObject.Duration);
            }

            if(requestObject.IsSetUserId())
            {
                context.Writer.WritePropertyName("userId");
                context.Writer.Write(requestObject.UserId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParticipantTokenConfigurationMarshaller Instance = new ParticipantTokenConfigurationMarshaller();

    }
}