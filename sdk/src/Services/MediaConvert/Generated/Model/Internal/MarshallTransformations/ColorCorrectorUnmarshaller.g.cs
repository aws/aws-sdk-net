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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.MediaConvert.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ColorCorrector Object
    /// </summary>
    public partial class ColorCorrectorUnmarshaller : IJsonUnmarshaller<ColorCorrector, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ColorCorrector Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ColorCorrector();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("brightness", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Brightness = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("clipLimits", targetDepth, ref reader))
                {
                    var unmarshaller = ClipLimitsUnmarshaller.Instance;
                    unmarshalledObject.ClipLimits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("colorSpaceConversion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorSpaceConversion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("contrast", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Contrast = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("hdr10Metadata", targetDepth, ref reader))
                {
                    var unmarshaller = Hdr10MetadataUnmarshaller.Instance;
                    unmarshalledObject.Hdr10Metadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("hdrToSdrToneMapper", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HdrToSdrToneMapper = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("hue", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Hue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("maxLuminance", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxLuminance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sampleRangeConversion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SampleRangeConversion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("saturation", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Saturation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sdrReferenceWhiteLevel", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SdrReferenceWhiteLevel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ColorCorrectorUnmarshaller _instance = new ColorCorrectorUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ColorCorrectorUnmarshaller Instance => _instance;
    }
}
