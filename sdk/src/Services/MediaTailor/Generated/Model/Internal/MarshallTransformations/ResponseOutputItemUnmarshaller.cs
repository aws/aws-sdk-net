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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResponseOutputItem Object
    /// </summary>  
    public class ResponseOutputItemUnmarshaller : IUnmarshaller<ResponseOutputItem, XmlUnmarshallerContext>, IUnmarshaller<ResponseOutputItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResponseOutputItem IUnmarshaller<ResponseOutputItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ResponseOutputItem Unmarshall(JsonUnmarshallerContext context)
        {
            ResponseOutputItem unmarshalledObject = new ResponseOutputItem();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DashPlaylistSettings", targetDepth))
                {
                    var unmarshaller = DashPlaylistSettingsUnmarshaller.Instance;
                    unmarshalledObject.DashPlaylistSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HlsPlaylistSettings", targetDepth))
                {
                    var unmarshaller = HlsPlaylistSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsPlaylistSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaybackUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaybackUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResponseOutputItemUnmarshaller _instance = new ResponseOutputItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResponseOutputItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}