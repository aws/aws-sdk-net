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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BundleTask Object
    /// </summary>  
    public class BundleTaskUnmarshaller : IUnmarshaller<BundleTask, XmlUnmarshallerContext>, IUnmarshaller<BundleTask, JsonUnmarshallerContext>
    {
        public BundleTask Unmarshall(XmlUnmarshallerContext context)
        {
            BundleTask unmarshalledObject = new BundleTask();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bundleId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BundleId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("error", targetDepth))
                    {
                        var unmarshaller = BundleTaskErrorUnmarshaller.Instance;
                        unmarshalledObject.BundleTaskError = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("progress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Progress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("startTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("storage", targetDepth))
                    {
                        var unmarshaller = StorageUnmarshaller.Instance;
                        unmarshalledObject.Storage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("updateTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public BundleTask Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static BundleTaskUnmarshaller _instance = new BundleTaskUnmarshaller();        

        public static BundleTaskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}