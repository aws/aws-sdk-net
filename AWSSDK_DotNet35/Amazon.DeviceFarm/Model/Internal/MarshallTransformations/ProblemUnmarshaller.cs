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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Problem Object
    /// </summary>  
    public class ProblemUnmarshaller : IUnmarshaller<Problem, XmlUnmarshallerContext>, IUnmarshaller<Problem, JsonUnmarshallerContext>
    {
        Problem IUnmarshaller<Problem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public Problem Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Problem unmarshalledObject = new Problem();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("device", targetDepth))
                {
                    var unmarshaller = DeviceUnmarshaller.Instance;
                    unmarshalledObject.Device = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("job", targetDepth))
                {
                    var unmarshaller = ProblemDetailUnmarshaller.Instance;
                    unmarshalledObject.Job = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("result", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Result = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("run", targetDepth))
                {
                    var unmarshaller = ProblemDetailUnmarshaller.Instance;
                    unmarshalledObject.Run = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suite", targetDepth))
                {
                    var unmarshaller = ProblemDetailUnmarshaller.Instance;
                    unmarshalledObject.Suite = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("test", targetDepth))
                {
                    var unmarshaller = ProblemDetailUnmarshaller.Instance;
                    unmarshalledObject.Test = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProblemUnmarshaller _instance = new ProblemUnmarshaller();        

        public static ProblemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}