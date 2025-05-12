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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for XavcSettings Object
    /// </summary>  
    public class XavcSettingsUnmarshaller : IJsonUnmarshaller<XavcSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public XavcSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            XavcSettings unmarshalledObject = new XavcSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("adaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("entropyEncoding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntropyEncoding = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FramerateControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateConversionAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FramerateConversionAlgorithm = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateDenominator", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FramerateDenominator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateNumerator", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FramerateNumerator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("perFrameMetrics", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PerFrameMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("profile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Profile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slowPal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlowPal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("softness", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Softness = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("spatialAdaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpatialAdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("temporalAdaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemporalAdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("xavc4kIntraCbgProfileSettings", targetDepth))
                {
                    var unmarshaller = Xavc4kIntraCbgProfileSettingsUnmarshaller.Instance;
                    unmarshalledObject.Xavc4kIntraCbgProfileSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("xavc4kIntraVbrProfileSettings", targetDepth))
                {
                    var unmarshaller = Xavc4kIntraVbrProfileSettingsUnmarshaller.Instance;
                    unmarshalledObject.Xavc4kIntraVbrProfileSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("xavc4kProfileSettings", targetDepth))
                {
                    var unmarshaller = Xavc4kProfileSettingsUnmarshaller.Instance;
                    unmarshalledObject.Xavc4kProfileSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("xavcHdIntraCbgProfileSettings", targetDepth))
                {
                    var unmarshaller = XavcHdIntraCbgProfileSettingsUnmarshaller.Instance;
                    unmarshalledObject.XavcHdIntraCbgProfileSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("xavcHdProfileSettings", targetDepth))
                {
                    var unmarshaller = XavcHdProfileSettingsUnmarshaller.Instance;
                    unmarshalledObject.XavcHdProfileSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static XavcSettingsUnmarshaller _instance = new XavcSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XavcSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}