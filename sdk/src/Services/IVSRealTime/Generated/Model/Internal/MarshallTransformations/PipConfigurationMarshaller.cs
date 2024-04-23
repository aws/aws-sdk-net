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

#pragma warning disable CS0612,CS0618
namespace Amazon.IVSRealTime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipConfiguration Marshaller
    /// </summary>
    public class PipConfigurationMarshaller : IRequestMarshaller<PipConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFeaturedParticipantAttribute())
            {
                context.Writer.WritePropertyName("featuredParticipantAttribute");
                context.Writer.Write(requestObject.FeaturedParticipantAttribute);
            }

            if(requestObject.IsSetGridGap())
            {
                context.Writer.WritePropertyName("gridGap");
                context.Writer.Write(requestObject.GridGap);
            }

            if(requestObject.IsSetOmitStoppedVideo())
            {
                context.Writer.WritePropertyName("omitStoppedVideo");
                context.Writer.Write(requestObject.OmitStoppedVideo);
            }

            if(requestObject.IsSetPipBehavior())
            {
                context.Writer.WritePropertyName("pipBehavior");
                context.Writer.Write(requestObject.PipBehavior);
            }

            if(requestObject.IsSetPipHeight())
            {
                context.Writer.WritePropertyName("pipHeight");
                context.Writer.Write(requestObject.PipHeight);
            }

            if(requestObject.IsSetPipOffset())
            {
                context.Writer.WritePropertyName("pipOffset");
                context.Writer.Write(requestObject.PipOffset);
            }

            if(requestObject.IsSetPipParticipantAttribute())
            {
                context.Writer.WritePropertyName("pipParticipantAttribute");
                context.Writer.Write(requestObject.PipParticipantAttribute);
            }

            if(requestObject.IsSetPipPosition())
            {
                context.Writer.WritePropertyName("pipPosition");
                context.Writer.Write(requestObject.PipPosition);
            }

            if(requestObject.IsSetPipWidth())
            {
                context.Writer.WritePropertyName("pipWidth");
                context.Writer.Write(requestObject.PipWidth);
            }

            if(requestObject.IsSetVideoFillMode())
            {
                context.Writer.WritePropertyName("videoFillMode");
                context.Writer.Write(requestObject.VideoFillMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipConfigurationMarshaller Instance = new PipConfigurationMarshaller();

    }
}
#pragma warning restore CS0612,CS0618