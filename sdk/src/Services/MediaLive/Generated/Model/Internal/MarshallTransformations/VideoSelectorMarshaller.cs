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
    /// VideoSelector Marshaller
    /// </summary>       
    public class VideoSelectorMarshaller : IRequestMarshaller<VideoSelector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoSelector requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetColorSpace())
            {
                context.Writer.WritePropertyName("colorSpace");
                context.Writer.Write(requestObject.ColorSpace);
            }

            if(requestObject.IsSetColorSpaceUsage())
            {
                context.Writer.WritePropertyName("colorSpaceUsage");
                context.Writer.Write(requestObject.ColorSpaceUsage);
            }

            if(requestObject.IsSetSelectorSettings())
            {
                context.Writer.WritePropertyName("selectorSettings");
                context.Writer.WriteObjectStart();

                var marshaller = VideoSelectorSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectorSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static VideoSelectorMarshaller Instance = new VideoSelectorMarshaller();

    }
}