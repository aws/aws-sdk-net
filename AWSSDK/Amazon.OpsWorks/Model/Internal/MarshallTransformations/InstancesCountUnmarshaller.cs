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
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new InstancesCount();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Booting", targetDepth))
                    {
                        unmarshalledObject.Booting = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ConnectionLost", targetDepth))
                    {
                        unmarshalledObject.ConnectionLost = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Online", targetDepth))
                    {
                        unmarshalledObject.Online = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Pending", targetDepth))
                    {
                        unmarshalledObject.Pending = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Rebooting", targetDepth))
                    {
                        unmarshalledObject.Rebooting = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Requested", targetDepth))
                    {
                        unmarshalledObject.Requested = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RunningSetup", targetDepth))
                    {
                        unmarshalledObject.RunningSetup = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SetupFailed", targetDepth))
                    {
                        unmarshalledObject.SetupFailed = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ShuttingDown", targetDepth))
                    {
                        unmarshalledObject.ShuttingDown = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StartFailed", targetDepth))
                    {
                        unmarshalledObject.StartFailed = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Stopped", targetDepth))
                    {
                        unmarshalledObject.Stopped = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Stopping", targetDepth))
                    {
                        unmarshalledObject.Stopping = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Terminated", targetDepth))
                    {
                        unmarshalledObject.Terminated = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Terminating", targetDepth))
                    {
                        unmarshalledObject.Terminating = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static InstancesCountUnmarshaller instance;
        public static InstancesCountUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new InstancesCountUnmarshaller();
            }
            return instance;
        }

    }
}