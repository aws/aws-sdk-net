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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HlsPackage Object
    /// </summary>  
    public class HlsPackageUnmarshaller : IUnmarshaller<HlsPackage, XmlUnmarshallerContext>, IUnmarshaller<HlsPackage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HlsPackage IUnmarshaller<HlsPackage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HlsPackage Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HlsPackage unmarshalledObject = new HlsPackage();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("adMarkers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdMarkers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryption", targetDepth))
                {
                    var unmarshaller = HlsEncryptionUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("includeIframeOnlyStream", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeIframeOnlyStream = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("playlistType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaylistType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("playlistWindowSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PlaylistWindowSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programDateTimeIntervalSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTimeIntervalSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentDurationSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentDurationSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streamSelection", targetDepth))
                {
                    var unmarshaller = StreamSelectionUnmarshaller.Instance;
                    unmarshalledObject.StreamSelection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("useAudioRenditionGroup", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseAudioRenditionGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HlsPackageUnmarshaller _instance = new HlsPackageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HlsPackageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}