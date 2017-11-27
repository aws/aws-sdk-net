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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemixSettings Marshaller
    /// </summary>       
    public class RemixSettingsMarshaller : IRequestMarshaller<RemixSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RemixSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChannelMapping())
            {
                context.Writer.WritePropertyName("channelMapping");
                context.Writer.WriteObjectStart();

                var marshaller = ChannelMappingMarshaller.Instance;
                marshaller.Marshall(requestObject.ChannelMapping, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetChannelsIn())
            {
                context.Writer.WritePropertyName("channelsIn");
                context.Writer.Write(requestObject.ChannelsIn);
            }

            if(requestObject.IsSetChannelsOut())
            {
                context.Writer.WritePropertyName("channelsOut");
                context.Writer.Write(requestObject.ChannelsOut);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RemixSettingsMarshaller Instance = new RemixSettingsMarshaller();

    }
}