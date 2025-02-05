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
    /// ContainerSettings Marshaller
    /// </summary>
    public class ContainerSettingsMarshaller : IRequestMarshaller<ContainerSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCmfcSettings())
            {
                context.Writer.WritePropertyName("cmfcSettings");
                context.Writer.WriteStartObject();

                var marshaller = CmfcSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CmfcSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("container");
                context.Writer.WriteStringValue(requestObject.Container);
            }

            if(requestObject.IsSetF4vSettings())
            {
                context.Writer.WritePropertyName("f4vSettings");
                context.Writer.WriteStartObject();

                var marshaller = F4vSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.F4vSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetM2tsSettings())
            {
                context.Writer.WritePropertyName("m2tsSettings");
                context.Writer.WriteStartObject();

                var marshaller = M2tsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.M2tsSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetM3u8Settings())
            {
                context.Writer.WritePropertyName("m3u8Settings");
                context.Writer.WriteStartObject();

                var marshaller = M3u8SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.M3u8Settings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMovSettings())
            {
                context.Writer.WritePropertyName("movSettings");
                context.Writer.WriteStartObject();

                var marshaller = MovSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MovSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMp4Settings())
            {
                context.Writer.WritePropertyName("mp4Settings");
                context.Writer.WriteStartObject();

                var marshaller = Mp4SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mp4Settings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMpdSettings())
            {
                context.Writer.WritePropertyName("mpdSettings");
                context.Writer.WriteStartObject();

                var marshaller = MpdSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MpdSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMxfSettings())
            {
                context.Writer.WritePropertyName("mxfSettings");
                context.Writer.WriteStartObject();

                var marshaller = MxfSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MxfSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerSettingsMarshaller Instance = new ContainerSettingsMarshaller();

    }
}