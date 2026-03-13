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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Ac4Settings Object
    /// </summary>  
    public class Ac4SettingsUnmarshaller : IUnmarshaller<Ac4Settings, XmlUnmarshallerContext>, IUnmarshaller<Ac4Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Ac4Settings IUnmarshaller<Ac4Settings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Ac4Settings Unmarshall(JsonUnmarshallerContext context)
        {
            Ac4Settings unmarshalledObject = new Ac4Settings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bitrate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Bitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bitstreamMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BitstreamMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codingMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodingMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamicRangeCompressionFlatPanelTv", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DynamicRangeCompressionFlatPanelTv = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamicRangeCompressionHomeTheater", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DynamicRangeCompressionHomeTheater = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamicRangeCompressionPortableHeadphones", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DynamicRangeCompressionPortableHeadphones = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamicRangeCompressionPortableSpeakers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DynamicRangeCompressionPortableSpeakers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loRoCenterMixLevel", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LoRoCenterMixLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loRoSurroundMixLevel", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LoRoSurroundMixLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ltRtCenterMixLevel", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LtRtCenterMixLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ltRtSurroundMixLevel", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LtRtSurroundMixLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleRate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SampleRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stereoDownmix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StereoDownmix = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Ac4SettingsUnmarshaller _instance = new Ac4SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Ac4SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}