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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.IVSRealTime.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.IVSRealTime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Video Marshaller
    /// </summary>
    public partial class VideoMarshaller : IRequestMarshaller<Video, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Video requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
            }

            if (requestObject.IsSetFramerate())
            {
                context.Writer.WritePropertyName("framerate");
                if (StringUtils.IsSpecialFloatValue(requestObject.Framerate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.Framerate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Framerate.Value);
                }
            }

            if (requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("height");
                context.Writer.WriteNumberValue(requestObject.Height.Value);
            }

            if (requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("width");
                context.Writer.WriteNumberValue(requestObject.Width.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static VideoMarshaller Instance = new VideoMarshaller();
    }
}
