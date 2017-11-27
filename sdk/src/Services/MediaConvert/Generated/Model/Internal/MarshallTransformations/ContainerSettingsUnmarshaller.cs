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
    /// Response Unmarshaller for ContainerSettings Object
    /// </summary>  
    public class ContainerSettingsUnmarshaller : IUnmarshaller<ContainerSettings, XmlUnmarshallerContext>, IUnmarshaller<ContainerSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ContainerSettings IUnmarshaller<ContainerSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ContainerSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ContainerSettings unmarshalledObject = new ContainerSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("container", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Container = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("f4vSettings", targetDepth))
                {
                    var unmarshaller = F4vSettingsUnmarshaller.Instance;
                    unmarshalledObject.F4vSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("m2tsSettings", targetDepth))
                {
                    var unmarshaller = M2tsSettingsUnmarshaller.Instance;
                    unmarshalledObject.M2tsSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("m3u8Settings", targetDepth))
                {
                    var unmarshaller = M3u8SettingsUnmarshaller.Instance;
                    unmarshalledObject.M3u8Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("movSettings", targetDepth))
                {
                    var unmarshaller = MovSettingsUnmarshaller.Instance;
                    unmarshalledObject.MovSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mp4Settings", targetDepth))
                {
                    var unmarshaller = Mp4SettingsUnmarshaller.Instance;
                    unmarshalledObject.Mp4Settings = unmarshaller.Unmarshall(context);
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