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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AlternateMedia Object
    /// </summary>  
    public class AlternateMediaUnmarshaller : IJsonUnmarshaller<AlternateMedia, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AlternateMedia Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AlternateMedia unmarshalledObject = new AlternateMedia();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AdBreaks", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AdBreak, AdBreakUnmarshaller>(AdBreakUnmarshaller.Instance);
                    unmarshalledObject.AdBreaks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClipRange", targetDepth))
                {
                    var unmarshaller = ClipRangeUnmarshaller.Instance;
                    unmarshalledObject.ClipRange = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DurationMillis", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.DurationMillis = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LiveSourceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LiveSourceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ScheduledStartTimeMillis", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ScheduledStartTimeMillis = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceLocationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceLocationName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VodSourceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VodSourceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AlternateMediaUnmarshaller _instance = new AlternateMediaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AlternateMediaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}