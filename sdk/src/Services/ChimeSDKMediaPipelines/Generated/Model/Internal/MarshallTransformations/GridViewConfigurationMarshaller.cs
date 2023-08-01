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
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GridViewConfiguration Marshaller
    /// </summary>
    public class GridViewConfigurationMarshaller : IRequestMarshaller<GridViewConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GridViewConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActiveSpeakerOnlyConfiguration())
            {
                context.Writer.WritePropertyName("ActiveSpeakerOnlyConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ActiveSpeakerOnlyConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ActiveSpeakerOnlyConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCanvasOrientation())
            {
                context.Writer.WritePropertyName("CanvasOrientation");
                context.Writer.Write(requestObject.CanvasOrientation);
            }

            if(requestObject.IsSetContentShareLayout())
            {
                context.Writer.WritePropertyName("ContentShareLayout");
                context.Writer.Write(requestObject.ContentShareLayout);
            }

            if(requestObject.IsSetHorizontalLayoutConfiguration())
            {
                context.Writer.WritePropertyName("HorizontalLayoutConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = HorizontalLayoutConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HorizontalLayoutConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPresenterOnlyConfiguration())
            {
                context.Writer.WritePropertyName("PresenterOnlyConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = PresenterOnlyConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PresenterOnlyConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVerticalLayoutConfiguration())
            {
                context.Writer.WritePropertyName("VerticalLayoutConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = VerticalLayoutConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VerticalLayoutConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVideoAttribute())
            {
                context.Writer.WritePropertyName("VideoAttribute");
                context.Writer.WriteObjectStart();

                var marshaller = VideoAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoAttribute, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GridViewConfigurationMarshaller Instance = new GridViewConfigurationMarshaller();

    }
}