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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MultiplexM2tsSettings Object
    /// </summary>  
    public class MultiplexM2tsSettingsUnmarshaller : IUnmarshaller<MultiplexM2tsSettings, XmlUnmarshallerContext>, IUnmarshaller<MultiplexM2tsSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MultiplexM2tsSettings IUnmarshaller<MultiplexM2tsSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MultiplexM2tsSettings Unmarshall(JsonUnmarshallerContext context)
        {
            MultiplexM2tsSettings unmarshalledObject = new MultiplexM2tsSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("absentInputAudioBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AbsentInputAudioBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arib", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arib = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioBufferModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioBufferModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioFramesPerPes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AudioFramesPerPes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioStreamType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioStreamType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ccDescriptor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CcDescriptor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebif", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ebif = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("esRateInPes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EsRateInPes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("klv", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Klv = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nielsenId3Behavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NielsenId3Behavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PcrControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PcrPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Control", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Control = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35PrerollPullupMilliseconds", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Scte35PrerollPullupMilliseconds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MultiplexM2tsSettingsUnmarshaller _instance = new MultiplexM2tsSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MultiplexM2tsSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}