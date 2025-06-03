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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VideoOverlay Marshaller
    /// </summary>
    public class VideoOverlayMarshaller : IRequestMarshaller<VideoOverlay, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoOverlay requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCrop())
            {
                context.Writer.WritePropertyName("crop");
                context.Writer.WriteStartObject();

                var marshaller = VideoOverlayCropMarshaller.Instance;
                marshaller.Marshall(requestObject.Crop, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEndTimecode())
            {
                context.Writer.WritePropertyName("endTimecode");
                context.Writer.WriteStringValue(requestObject.EndTimecode);
            }

            if(requestObject.IsSetInitialPosition())
            {
                context.Writer.WritePropertyName("initialPosition");
                context.Writer.WriteStartObject();

                var marshaller = VideoOverlayPositionMarshaller.Instance;
                marshaller.Marshall(requestObject.InitialPosition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStartObject();

                var marshaller = VideoOverlayInputMarshaller.Instance;
                marshaller.Marshall(requestObject.Input, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPlayback())
            {
                context.Writer.WritePropertyName("playback");
                context.Writer.WriteStringValue(requestObject.Playback);
            }

            if(requestObject.IsSetStartTimecode())
            {
                context.Writer.WritePropertyName("startTimecode");
                context.Writer.WriteStringValue(requestObject.StartTimecode);
            }

            if(requestObject.IsSetTransitions())
            {
                context.Writer.WritePropertyName("transitions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTransitionsListValue in requestObject.Transitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VideoOverlayTransitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectTransitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VideoOverlayMarshaller Instance = new VideoOverlayMarshaller();

    }
}