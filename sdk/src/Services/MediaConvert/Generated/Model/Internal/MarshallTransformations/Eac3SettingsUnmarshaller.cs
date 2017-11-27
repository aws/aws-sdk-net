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
    /// Response Unmarshaller for Eac3Settings Object
    /// </summary>  
    public class Eac3SettingsUnmarshaller : IUnmarshaller<Eac3Settings, XmlUnmarshallerContext>, IUnmarshaller<Eac3Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Eac3Settings IUnmarshaller<Eac3Settings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Eac3Settings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Eac3Settings unmarshalledObject = new Eac3Settings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("attenuationControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttenuationControl = unmarshaller.Unmarshall(context);
                    continue;
                }
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
                if (context.TestExpression("dcFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DcFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dialnorm", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Dialnorm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamicRangeCompressionLine", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DynamicRangeCompressionLine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamicRangeCompressionRf", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DynamicRangeCompressionRf = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lfeControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LfeControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lfeFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LfeFilter = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("metadataControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetadataControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("passthroughControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PassthroughControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("phaseControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhaseControl = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("surroundExMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SurroundExMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("surroundMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SurroundMode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static Eac3SettingsUnmarshaller _instance = new Eac3SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Eac3SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}