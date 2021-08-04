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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CallAnalyticsJob Object
    /// </summary>  
    public class CallAnalyticsJobUnmarshaller : IUnmarshaller<CallAnalyticsJob, XmlUnmarshallerContext>, IUnmarshaller<CallAnalyticsJob, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CallAnalyticsJob IUnmarshaller<CallAnalyticsJob, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CallAnalyticsJob Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CallAnalyticsJob unmarshalledObject = new CallAnalyticsJob();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CallAnalyticsJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CallAnalyticsJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CallAnalyticsJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CallAnalyticsJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChannelDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ChannelDefinition, ChannelDefinitionUnmarshaller>(ChannelDefinitionUnmarshaller.Instance);
                    unmarshalledObject.ChannelDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompletionTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletionTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataAccessRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentifiedLanguageScore", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.IdentifiedLanguageScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LanguageCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LanguageCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Media", targetDepth))
                {
                    var unmarshaller = MediaUnmarshaller.Instance;
                    unmarshalledObject.Media = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaSampleRateHertz", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MediaSampleRateHertz = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Settings", targetDepth))
                {
                    var unmarshaller = CallAnalyticsJobSettingsUnmarshaller.Instance;
                    unmarshalledObject.Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Transcript", targetDepth))
                {
                    var unmarshaller = TranscriptUnmarshaller.Instance;
                    unmarshalledObject.Transcript = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CallAnalyticsJobUnmarshaller _instance = new CallAnalyticsJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CallAnalyticsJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}