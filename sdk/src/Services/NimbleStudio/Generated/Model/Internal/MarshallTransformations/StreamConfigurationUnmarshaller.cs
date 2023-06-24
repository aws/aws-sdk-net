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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StreamConfiguration Object
    /// </summary>  
    public class StreamConfigurationUnmarshaller : IUnmarshaller<StreamConfiguration, XmlUnmarshallerContext>, IUnmarshaller<StreamConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StreamConfiguration IUnmarshaller<StreamConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StreamConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StreamConfiguration unmarshalledObject = new StreamConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("automaticTerminationMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutomaticTerminationMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clipboardMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClipboardMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2InstanceTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ec2InstanceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxSessionLengthInMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxSessionLengthInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxStoppedSessionLengthInMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxStoppedSessionLengthInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sessionBackup", targetDepth))
                {
                    var unmarshaller = StreamConfigurationSessionBackupUnmarshaller.Instance;
                    unmarshalledObject.SessionBackup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sessionPersistenceMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SessionPersistenceMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sessionStorage", targetDepth))
                {
                    var unmarshaller = StreamConfigurationSessionStorageUnmarshaller.Instance;
                    unmarshalledObject.SessionStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streamingImageIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StreamingImageIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("volumeConfiguration", targetDepth))
                {
                    var unmarshaller = VolumeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VolumeConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StreamConfigurationUnmarshaller _instance = new StreamConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StreamConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}