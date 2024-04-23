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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TransportStream Object
    /// </summary>  
    public class TransportStreamUnmarshaller : IUnmarshaller<TransportStream, XmlUnmarshallerContext>, IUnmarshaller<TransportStream, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TransportStream IUnmarshaller<TransportStream, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TransportStream Unmarshall(JsonUnmarshallerContext context)
        {
            TransportStream unmarshalledObject = new TransportStream();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("channels", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Channels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("frameRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FrameRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("frameResolution", targetDepth))
                {
                    var unmarshaller = FrameResolutionUnmarshaller.Instance;
                    unmarshalledObject.FrameResolution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Pid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleRate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SampleRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SampleSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streamType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TransportStreamUnmarshaller _instance = new TransportStreamUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransportStreamUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618