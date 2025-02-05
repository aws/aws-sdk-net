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
    /// Response Unmarshaller for ContainerSettings Object
    /// </summary>  
    public class ContainerSettingsUnmarshaller : IJsonUnmarshaller<ContainerSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ContainerSettings unmarshalledObject = new ContainerSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cmfcSettings", targetDepth))
                {
                    var unmarshaller = CmfcSettingsUnmarshaller.Instance;
                    unmarshalledObject.CmfcSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("container", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Container = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("f4vSettings", targetDepth))
                {
                    var unmarshaller = F4vSettingsUnmarshaller.Instance;
                    unmarshalledObject.F4vSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("m2tsSettings", targetDepth))
                {
                    var unmarshaller = M2tsSettingsUnmarshaller.Instance;
                    unmarshalledObject.M2tsSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("m3u8Settings", targetDepth))
                {
                    var unmarshaller = M3u8SettingsUnmarshaller.Instance;
                    unmarshalledObject.M3u8Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("movSettings", targetDepth))
                {
                    var unmarshaller = MovSettingsUnmarshaller.Instance;
                    unmarshalledObject.MovSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mp4Settings", targetDepth))
                {
                    var unmarshaller = Mp4SettingsUnmarshaller.Instance;
                    unmarshalledObject.Mp4Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mpdSettings", targetDepth))
                {
                    var unmarshaller = MpdSettingsUnmarshaller.Instance;
                    unmarshalledObject.MpdSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mxfSettings", targetDepth))
                {
                    var unmarshaller = MxfSettingsUnmarshaller.Instance;
                    unmarshalledObject.MxfSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContainerSettingsUnmarshaller _instance = new ContainerSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}