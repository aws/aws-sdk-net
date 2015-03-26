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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RejectedLogEventsInfo Object
    /// </summary>  
    public class RejectedLogEventsInfoUnmarshaller : IUnmarshaller<RejectedLogEventsInfo, XmlUnmarshallerContext>, IUnmarshaller<RejectedLogEventsInfo, JsonUnmarshallerContext>
    {
        RejectedLogEventsInfo IUnmarshaller<RejectedLogEventsInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public RejectedLogEventsInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RejectedLogEventsInfo unmarshalledObject = new RejectedLogEventsInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("expiredLogEventEndIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ExpiredLogEventEndIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tooNewLogEventStartIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TooNewLogEventStartIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tooOldLogEventEndIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TooOldLogEventEndIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RejectedLogEventsInfoUnmarshaller _instance = new RejectedLogEventsInfoUnmarshaller();        

        public static RejectedLogEventsInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}