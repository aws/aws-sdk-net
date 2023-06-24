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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ArtifactsConfiguration Marshaller
    /// </summary>
    public class ArtifactsConfigurationMarshaller : IRequestMarshaller<ArtifactsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ArtifactsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAudio())
            {
                context.Writer.WritePropertyName("Audio");
                context.Writer.WriteObjectStart();

                var marshaller = AudioArtifactsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Audio, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteObjectStart();

                var marshaller = ContentArtifactsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Content, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVideo())
            {
                context.Writer.WritePropertyName("Video");
                context.Writer.WriteObjectStart();

                var marshaller = VideoArtifactsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Video, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ArtifactsConfigurationMarshaller Instance = new ArtifactsConfigurationMarshaller();

    }
}