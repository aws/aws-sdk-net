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
    /// Response Unmarshaller for RouterInputThumbnailDetails Object
    /// </summary>  
    public class RouterInputThumbnailDetailsUnmarshaller : IUnmarshaller<RouterInputThumbnailDetails, XmlUnmarshallerContext>, IUnmarshaller<RouterInputThumbnailDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouterInputThumbnailDetails IUnmarshaller<RouterInputThumbnailDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouterInputThumbnailDetails Unmarshall(JsonUnmarshallerContext context)
        {
            RouterInputThumbnailDetails unmarshalledObject = new RouterInputThumbnailDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("thumbnail", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    unmarshalledObject.Thumbnail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("thumbnailMessages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouterInputMessage, RouterInputMessageUnmarshaller>(RouterInputMessageUnmarshaller.Instance);
                    unmarshalledObject.ThumbnailMessages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Timecode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouterInputThumbnailDetailsUnmarshaller _instance = new RouterInputThumbnailDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouterInputThumbnailDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}