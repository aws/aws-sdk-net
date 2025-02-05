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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChimeSdkMeetingConfiguration Marshaller
    /// </summary>
    public class ChimeSdkMeetingConfigurationMarshaller : IRequestMarshaller<ChimeSdkMeetingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ChimeSdkMeetingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArtifactsConfiguration())
            {
                context.Writer.WritePropertyName("ArtifactsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ArtifactsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ArtifactsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceConfiguration())
            {
                context.Writer.WritePropertyName("SourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ChimeSdkMeetingConfigurationMarshaller Instance = new ChimeSdkMeetingConfigurationMarshaller();

    }
}