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

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AdBreak Object
    /// </summary>  
    public class AdBreakUnmarshaller : IUnmarshaller<AdBreak, XmlUnmarshallerContext>, IUnmarshaller<AdBreak, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AdBreak IUnmarshaller<AdBreak, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AdBreak Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AdBreak unmarshalledObject = new AdBreak();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdBreakMetadata", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.AdBreakMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MessageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OffsetMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.OffsetMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Slate", targetDepth))
                {
                    var unmarshaller = SlateSourceUnmarshaller.Instance;
                    unmarshalledObject.Slate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpliceInsertMessage", targetDepth))
                {
                    var unmarshaller = SpliceInsertMessageUnmarshaller.Instance;
                    unmarshalledObject.SpliceInsertMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeSignalMessage", targetDepth))
                {
                    var unmarshaller = TimeSignalMessageUnmarshaller.Instance;
                    unmarshalledObject.TimeSignalMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AdBreakUnmarshaller _instance = new AdBreakUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdBreakUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}