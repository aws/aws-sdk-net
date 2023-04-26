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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SpeakerSearchTask Object
    /// </summary>  
    public class SpeakerSearchTaskUnmarshaller : IUnmarshaller<SpeakerSearchTask, XmlUnmarshallerContext>, IUnmarshaller<SpeakerSearchTask, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SpeakerSearchTask IUnmarshaller<SpeakerSearchTask, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SpeakerSearchTask Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SpeakerSearchTask unmarshalledObject = new SpeakerSearchTask();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CallDetails", targetDepth))
                {
                    var unmarshaller = CallDetailsUnmarshaller.Instance;
                    unmarshalledObject.CallDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpeakerSearchDetails", targetDepth))
                {
                    var unmarshaller = SpeakerSearchDetailsUnmarshaller.Instance;
                    unmarshalledObject.SpeakerSearchDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpeakerSearchTaskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpeakerSearchTaskId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpeakerSearchTaskStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpeakerSearchTaskStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SpeakerSearchTaskUnmarshaller _instance = new SpeakerSearchTaskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SpeakerSearchTaskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}