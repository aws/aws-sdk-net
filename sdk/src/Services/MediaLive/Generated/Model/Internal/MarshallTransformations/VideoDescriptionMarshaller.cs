/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// VideoDescription Marshaller
    /// </summary>       
    public class VideoDescriptionMarshaller : IRequestMarshaller<VideoDescription, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoDescription requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCodecSettings())
            {
                context.Writer.WritePropertyName("codecSettings");
                context.Writer.WriteObjectStart();

                var marshaller = VideoCodecSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodecSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("height");
                context.Writer.Write(requestObject.Height);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRespondToAfd())
            {
                context.Writer.WritePropertyName("respondToAfd");
                context.Writer.Write(requestObject.RespondToAfd);
            }

            if(requestObject.IsSetScalingBehavior())
            {
                context.Writer.WritePropertyName("scalingBehavior");
                context.Writer.Write(requestObject.ScalingBehavior);
            }

            if(requestObject.IsSetSharpness())
            {
                context.Writer.WritePropertyName("sharpness");
                context.Writer.Write(requestObject.Sharpness);
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("width");
                context.Writer.Write(requestObject.Width);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static VideoDescriptionMarshaller Instance = new VideoDescriptionMarshaller();

    }
}