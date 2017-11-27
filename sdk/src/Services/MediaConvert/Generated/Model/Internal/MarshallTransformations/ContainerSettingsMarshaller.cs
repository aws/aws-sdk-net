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
            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("container");
                context.Writer.Write(requestObject.Container);
            }

            if(requestObject.IsSetF4vSettings())
            {
                context.Writer.WritePropertyName("f4vSettings");
                context.Writer.WriteObjectStart();

                var marshaller = F4vSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.F4vSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetM2tsSettings())
            {
                context.Writer.WritePropertyName("m2tsSettings");
                context.Writer.WriteObjectStart();

                var marshaller = M2tsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.M2tsSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetM3u8Settings())
            {
                context.Writer.WritePropertyName("m3u8Settings");
                context.Writer.WriteObjectStart();

                var marshaller = M3u8SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.M3u8Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMovSettings())
            {
                context.Writer.WritePropertyName("movSettings");
                context.Writer.WriteObjectStart();

                var marshaller = MovSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MovSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMp4Settings())
            {
                context.Writer.WritePropertyName("mp4Settings");
                context.Writer.WriteObjectStart();

                var marshaller = Mp4SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mp4Settings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ContainerSettingsMarshaller Instance = new ContainerSettingsMarshaller();

    }
}