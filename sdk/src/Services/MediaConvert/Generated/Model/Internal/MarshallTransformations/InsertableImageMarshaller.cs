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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InsertableImage Marshaller
    /// </summary>       
    public class InsertableImageMarshaller : IRequestMarshaller<InsertableImage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InsertableImage requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDuration())
            {
                context.Writer.WritePropertyName("duration");
                context.Writer.Write(requestObject.Duration);
            }

            if(requestObject.IsSetFadeIn())
            {
                context.Writer.WritePropertyName("fadeIn");
                context.Writer.Write(requestObject.FadeIn);
            }

            if(requestObject.IsSetFadeOut())
            {
                context.Writer.WritePropertyName("fadeOut");
                context.Writer.Write(requestObject.FadeOut);
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("height");
                context.Writer.Write(requestObject.Height);
            }

            if(requestObject.IsSetImageInserterInput())
            {
                context.Writer.WritePropertyName("imageInserterInput");
                context.Writer.Write(requestObject.ImageInserterInput);
            }

            if(requestObject.IsSetImageX())
            {
                context.Writer.WritePropertyName("imageX");
                context.Writer.Write(requestObject.ImageX);
            }

            if(requestObject.IsSetImageY())
            {
                context.Writer.WritePropertyName("imageY");
                context.Writer.Write(requestObject.ImageY);
            }

            if(requestObject.IsSetLayer())
            {
                context.Writer.WritePropertyName("layer");
                context.Writer.Write(requestObject.Layer);
            }

            if(requestObject.IsSetOpacity())
            {
                context.Writer.WritePropertyName("opacity");
                context.Writer.Write(requestObject.Opacity);
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.Write(requestObject.StartTime);
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
        public readonly static InsertableImageMarshaller Instance = new InsertableImageMarshaller();

    }
}