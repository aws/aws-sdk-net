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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LambdaFunctionFailedEventAttributes Object
    /// </summary>  
    public class LambdaFunctionFailedEventAttributesUnmarshaller : IUnmarshaller<LambdaFunctionFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<LambdaFunctionFailedEventAttributes, JsonUnmarshallerContext>
    {
        LambdaFunctionFailedEventAttributes IUnmarshaller<LambdaFunctionFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public LambdaFunctionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LambdaFunctionFailedEventAttributes unmarshalledObject = new LambdaFunctionFailedEventAttributes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("details", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Details = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Reason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scheduledEventId", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ScheduledEventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startedEventId", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StartedEventId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LambdaFunctionFailedEventAttributesUnmarshaller _instance = new LambdaFunctionFailedEventAttributesUnmarshaller();        

        public static LambdaFunctionFailedEventAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}