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
    /// MotionImageInserter Marshaller
    /// </summary>
    public class MotionImageInserterMarshaller : IRequestMarshaller<MotionImageInserter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MotionImageInserter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFramerate())
            {
                context.Writer.WritePropertyName("framerate");
                context.Writer.WriteStartObject();

                var marshaller = MotionImageInsertionFramerateMarshaller.Instance;
                marshaller.Marshall(requestObject.Framerate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStringValue(requestObject.Input);
            }

            if(requestObject.IsSetInsertionMode())
            {
                context.Writer.WritePropertyName("insertionMode");
                context.Writer.WriteStringValue(requestObject.InsertionMode);
            }

            if(requestObject.IsSetOffset())
            {
                context.Writer.WritePropertyName("offset");
                context.Writer.WriteStartObject();

                var marshaller = MotionImageInsertionOffsetMarshaller.Instance;
                marshaller.Marshall(requestObject.Offset, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPlayback())
            {
                context.Writer.WritePropertyName("playback");
                context.Writer.WriteStringValue(requestObject.Playback);
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.WriteStringValue(requestObject.StartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MotionImageInserterMarshaller Instance = new MotionImageInserterMarshaller();

    }
}