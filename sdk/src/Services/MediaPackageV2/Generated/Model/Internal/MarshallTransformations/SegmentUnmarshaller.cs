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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Segment Object
    /// </summary>  
    public class SegmentUnmarshaller : IUnmarshaller<Segment, XmlUnmarshallerContext>, IUnmarshaller<Segment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Segment IUnmarshaller<Segment, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Segment Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Segment unmarshalledObject = new Segment();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Encryption", targetDepth))
                {
                    var unmarshaller = EncryptionUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeIframeOnlyStreams", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeIframeOnlyStreams = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Scte", targetDepth))
                {
                    var unmarshaller = ScteUnmarshaller.Instance;
                    unmarshalledObject.Scte = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentDurationSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentDurationSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TsIncludeDvbSubtitles", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TsIncludeDvbSubtitles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TsUseAudioRenditionGroup", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TsUseAudioRenditionGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SegmentUnmarshaller _instance = new SegmentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SegmentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}