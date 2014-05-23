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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstancesCount Object
    /// </summary>  
    public class InstancesCountUnmarshaller : IUnmarshaller<InstancesCount, XmlUnmarshallerContext>, IUnmarshaller<InstancesCount, JsonUnmarshallerContext>
    {
        InstancesCount IUnmarshaller<InstancesCount, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public InstancesCount Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InstancesCount unmarshalledObject = new InstancesCount();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Booting", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Booting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectionLost", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ConnectionLost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Online", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Online = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pending", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Pending = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Rebooting", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Rebooting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Requested", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Requested = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunningSetup", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RunningSetup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SetupFailed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SetupFailed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShuttingDown", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShuttingDown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartFailed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StartFailed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Stopped", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Stopped = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Stopping", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Stopping = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Terminated", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Terminated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Terminating", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Terminating = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InstancesCountUnmarshaller _instance = new InstancesCountUnmarshaller();        

        public static InstancesCountUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}