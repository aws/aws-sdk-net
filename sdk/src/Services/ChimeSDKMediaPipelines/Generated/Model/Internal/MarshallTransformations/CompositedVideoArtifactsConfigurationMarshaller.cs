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
    /// CompositedVideoArtifactsConfiguration Marshaller
    /// </summary>
    public class CompositedVideoArtifactsConfigurationMarshaller : IRequestMarshaller<CompositedVideoArtifactsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CompositedVideoArtifactsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGridViewConfiguration())
            {
                context.Writer.WritePropertyName("GridViewConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GridViewConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GridViewConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLayout())
            {
                context.Writer.WritePropertyName("Layout");
                context.Writer.WriteStringValue(requestObject.Layout);
            }

            if(requestObject.IsSetResolution())
            {
                context.Writer.WritePropertyName("Resolution");
                context.Writer.WriteStringValue(requestObject.Resolution);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CompositedVideoArtifactsConfigurationMarshaller Instance = new CompositedVideoArtifactsConfigurationMarshaller();

    }
}