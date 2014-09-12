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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Thumbnails Marshaller
    /// </summary>       
    public class ThumbnailsMarshaller : IRequestMarshaller<Thumbnails, JsonMarshallerContext> 
    {
        public void Marshall(Thumbnails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAspectRatio())
            {
                context.Writer.WritePropertyName("AspectRatio");
                context.Writer.Write(requestObject.AspectRatio);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetInterval())
            {
                context.Writer.WritePropertyName("Interval");
                context.Writer.Write(requestObject.Interval);
            }

            if(requestObject.IsSetMaxHeight())
            {
                context.Writer.WritePropertyName("MaxHeight");
                context.Writer.Write(requestObject.MaxHeight);
            }

            if(requestObject.IsSetMaxWidth())
            {
                context.Writer.WritePropertyName("MaxWidth");
                context.Writer.Write(requestObject.MaxWidth);
            }

            if(requestObject.IsSetPaddingPolicy())
            {
                context.Writer.WritePropertyName("PaddingPolicy");
                context.Writer.Write(requestObject.PaddingPolicy);
            }

            if(requestObject.IsSetResolution())
            {
                context.Writer.WritePropertyName("Resolution");
                context.Writer.Write(requestObject.Resolution);
            }

            if(requestObject.IsSetSizingPolicy())
            {
                context.Writer.WritePropertyName("SizingPolicy");
                context.Writer.Write(requestObject.SizingPolicy);
            }

        }

        public readonly static ThumbnailsMarshaller Instance = new ThumbnailsMarshaller();

    }
}