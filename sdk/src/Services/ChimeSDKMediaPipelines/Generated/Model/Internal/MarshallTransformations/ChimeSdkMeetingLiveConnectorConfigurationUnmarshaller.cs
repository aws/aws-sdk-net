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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ChimeSdkMeetingLiveConnectorConfiguration Object
    /// </summary>  
    public class ChimeSdkMeetingLiveConnectorConfigurationUnmarshaller : IUnmarshaller<ChimeSdkMeetingLiveConnectorConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ChimeSdkMeetingLiveConnectorConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ChimeSdkMeetingLiveConnectorConfiguration IUnmarshaller<ChimeSdkMeetingLiveConnectorConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ChimeSdkMeetingLiveConnectorConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            ChimeSdkMeetingLiveConnectorConfiguration unmarshalledObject = new ChimeSdkMeetingLiveConnectorConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompositedVideo", targetDepth))
                {
                    var unmarshaller = CompositedVideoArtifactsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CompositedVideo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MuxType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MuxType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceConfiguration", targetDepth))
                {
                    var unmarshaller = SourceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SourceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ChimeSdkMeetingLiveConnectorConfigurationUnmarshaller _instance = new ChimeSdkMeetingLiveConnectorConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChimeSdkMeetingLiveConnectorConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618