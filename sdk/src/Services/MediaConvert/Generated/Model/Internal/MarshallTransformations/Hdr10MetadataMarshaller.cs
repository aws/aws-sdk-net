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
    /// Hdr10Metadata Marshaller
    /// </summary>       
    public class Hdr10MetadataMarshaller : IRequestMarshaller<Hdr10Metadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Hdr10Metadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBluePrimaryX())
            {
                context.Writer.WritePropertyName("bluePrimaryX");
                context.Writer.Write(requestObject.BluePrimaryX);
            }

            if(requestObject.IsSetBluePrimaryY())
            {
                context.Writer.WritePropertyName("bluePrimaryY");
                context.Writer.Write(requestObject.BluePrimaryY);
            }

            if(requestObject.IsSetGreenPrimaryX())
            {
                context.Writer.WritePropertyName("greenPrimaryX");
                context.Writer.Write(requestObject.GreenPrimaryX);
            }

            if(requestObject.IsSetGreenPrimaryY())
            {
                context.Writer.WritePropertyName("greenPrimaryY");
                context.Writer.Write(requestObject.GreenPrimaryY);
            }

            if(requestObject.IsSetMaxContentLightLevel())
            {
                context.Writer.WritePropertyName("maxContentLightLevel");
                context.Writer.Write(requestObject.MaxContentLightLevel);
            }

            if(requestObject.IsSetMaxFrameAverageLightLevel())
            {
                context.Writer.WritePropertyName("maxFrameAverageLightLevel");
                context.Writer.Write(requestObject.MaxFrameAverageLightLevel);
            }

            if(requestObject.IsSetMaxLuminance())
            {
                context.Writer.WritePropertyName("maxLuminance");
                context.Writer.Write(requestObject.MaxLuminance);
            }

            if(requestObject.IsSetMinLuminance())
            {
                context.Writer.WritePropertyName("minLuminance");
                context.Writer.Write(requestObject.MinLuminance);
            }

            if(requestObject.IsSetRedPrimaryX())
            {
                context.Writer.WritePropertyName("redPrimaryX");
                context.Writer.Write(requestObject.RedPrimaryX);
            }

            if(requestObject.IsSetRedPrimaryY())
            {
                context.Writer.WritePropertyName("redPrimaryY");
                context.Writer.Write(requestObject.RedPrimaryY);
            }

            if(requestObject.IsSetWhitePointX())
            {
                context.Writer.WritePropertyName("whitePointX");
                context.Writer.Write(requestObject.WhitePointX);
            }

            if(requestObject.IsSetWhitePointY())
            {
                context.Writer.WritePropertyName("whitePointY");
                context.Writer.Write(requestObject.WhitePointY);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static Hdr10MetadataMarshaller Instance = new Hdr10MetadataMarshaller();

    }
}