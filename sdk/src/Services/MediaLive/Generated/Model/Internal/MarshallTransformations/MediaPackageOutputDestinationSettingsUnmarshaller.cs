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
    /// Response Unmarshaller for MediaPackageOutputDestinationSettings Object
    /// </summary>  
    public class MediaPackageOutputDestinationSettingsUnmarshaller : IUnmarshaller<MediaPackageOutputDestinationSettings, XmlUnmarshallerContext>, IUnmarshaller<MediaPackageOutputDestinationSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MediaPackageOutputDestinationSettings IUnmarshaller<MediaPackageOutputDestinationSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MediaPackageOutputDestinationSettings Unmarshall(JsonUnmarshallerContext context)
        {
            MediaPackageOutputDestinationSettings unmarshalledObject = new MediaPackageOutputDestinationSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("channelEndpointId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelEndpointId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mediaPackageRegionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaPackageRegionName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MediaPackageOutputDestinationSettingsUnmarshaller _instance = new MediaPackageOutputDestinationSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MediaPackageOutputDestinationSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}