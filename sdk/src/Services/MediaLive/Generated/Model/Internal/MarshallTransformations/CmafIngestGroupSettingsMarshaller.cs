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
    /// CmafIngestGroupSettings Marshaller
    /// </summary>
    public class CmafIngestGroupSettingsMarshaller : IRequestMarshaller<CmafIngestGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CmafIngestGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteObjectStart();

                var marshaller = OutputLocationRefMarshaller.Instance;
                marshaller.Marshall(requestObject.Destination, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKlvBehavior())
            {
                context.Writer.WritePropertyName("klvBehavior");
                context.Writer.Write(requestObject.KlvBehavior);
            }

            if(requestObject.IsSetKlvNameModifier())
            {
                context.Writer.WritePropertyName("klvNameModifier");
                context.Writer.Write(requestObject.KlvNameModifier);
            }

            if(requestObject.IsSetNielsenId3Behavior())
            {
                context.Writer.WritePropertyName("nielsenId3Behavior");
                context.Writer.Write(requestObject.NielsenId3Behavior);
            }

            if(requestObject.IsSetNielsenId3NameModifier())
            {
                context.Writer.WritePropertyName("nielsenId3NameModifier");
                context.Writer.Write(requestObject.NielsenId3NameModifier);
            }

            if(requestObject.IsSetScte35NameModifier())
            {
                context.Writer.WritePropertyName("scte35NameModifier");
                context.Writer.Write(requestObject.Scte35NameModifier);
            }

            if(requestObject.IsSetScte35Type())
            {
                context.Writer.WritePropertyName("scte35Type");
                context.Writer.Write(requestObject.Scte35Type);
            }

            if(requestObject.IsSetSegmentLength())
            {
                context.Writer.WritePropertyName("segmentLength");
                context.Writer.Write(requestObject.SegmentLength);
            }

            if(requestObject.IsSetSegmentLengthUnits())
            {
                context.Writer.WritePropertyName("segmentLengthUnits");
                context.Writer.Write(requestObject.SegmentLengthUnits);
            }

            if(requestObject.IsSetSendDelayMs())
            {
                context.Writer.WritePropertyName("sendDelayMs");
                context.Writer.Write(requestObject.SendDelayMs);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CmafIngestGroupSettingsMarshaller Instance = new CmafIngestGroupSettingsMarshaller();

    }
}