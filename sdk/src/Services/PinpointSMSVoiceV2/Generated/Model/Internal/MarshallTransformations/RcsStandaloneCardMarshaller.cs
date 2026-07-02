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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RcsStandaloneCard Marshaller
    /// </summary>
    public class RcsStandaloneCardMarshaller : IRequestMarshaller<RcsStandaloneCard, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RcsStandaloneCard requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCardContent())
            {
                context.Writer.WritePropertyName("CardContent");
                context.Writer.WriteStartObject();

                var marshaller = RcsCardContentMarshaller.Instance;
                marshaller.Marshall(requestObject.CardContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCardOrientation())
            {
                context.Writer.WritePropertyName("CardOrientation");
                context.Writer.WriteStringValue(requestObject.CardOrientation);
            }

            if(requestObject.IsSetThumbnailImageAlignment())
            {
                context.Writer.WritePropertyName("ThumbnailImageAlignment");
                context.Writer.WriteStringValue(requestObject.ThumbnailImageAlignment);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RcsStandaloneCardMarshaller Instance = new RcsStandaloneCardMarshaller();

    }
}