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
using System.Net;
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
    /// Response Unmarshaller for ColorCorrector Object
    /// </summary>  
    public class ColorCorrectorUnmarshaller : IUnmarshaller<ColorCorrector, XmlUnmarshallerContext>, IUnmarshaller<ColorCorrector, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ColorCorrector IUnmarshaller<ColorCorrector, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ColorCorrector Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ColorCorrector unmarshalledObject = new ColorCorrector();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("brightness", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Brightness = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clipLimits", targetDepth))
                {
                    var unmarshaller = ClipLimitsUnmarshaller.Instance;
                    unmarshalledObject.ClipLimits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("colorSpaceConversion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorSpaceConversion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contrast", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Contrast = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hdr10Metadata", targetDepth))
                {
                    var unmarshaller = Hdr10MetadataUnmarshaller.Instance;
                    unmarshalledObject.Hdr10Metadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Hue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleRangeConversion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SampleRangeConversion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("saturation", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Saturation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sdrReferenceWhiteLevel", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SdrReferenceWhiteLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ColorCorrectorUnmarshaller _instance = new ColorCorrectorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ColorCorrectorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}