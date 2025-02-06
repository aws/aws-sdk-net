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
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// H264ColorSpaceSettings Marshaller
    /// </summary>
    public class H264ColorSpaceSettingsMarshaller : IRequestMarshaller<H264ColorSpaceSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(H264ColorSpaceSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetColorSpacePassthroughSettings())
            {
                context.Writer.WritePropertyName("colorSpacePassthroughSettings");
                context.Writer.WriteStartObject();

                var marshaller = ColorSpacePassthroughSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorSpacePassthroughSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRec601Settings())
            {
                context.Writer.WritePropertyName("rec601Settings");
                context.Writer.WriteStartObject();

                var marshaller = Rec601SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Rec601Settings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRec709Settings())
            {
                context.Writer.WritePropertyName("rec709Settings");
                context.Writer.WriteStartObject();

                var marshaller = Rec709SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Rec709Settings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static H264ColorSpaceSettingsMarshaller Instance = new H264ColorSpaceSettingsMarshaller();

    }
}