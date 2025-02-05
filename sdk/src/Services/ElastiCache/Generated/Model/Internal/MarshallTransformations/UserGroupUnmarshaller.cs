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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserGroup Object
    /// </summary>  
    public class UserGroupUnmarshaller : IXmlUnmarshaller<UserGroup, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserGroup Unmarshall(XmlUnmarshallerContext context)
        {
            UserGroup unmarshalledObject = new UserGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinimumEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MinimumEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PendingChanges", targetDepth))
                    {
                        var unmarshaller = UserGroupPendingChangesUnmarshaller.Instance;
                        unmarshalledObject.PendingChanges = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReplicationGroups/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ReplicationGroups == null)
                        {
                            unmarshalledObject.ReplicationGroups = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ReplicationGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ServerlessCaches/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ServerlessCaches == null)
                        {
                            unmarshalledObject.ServerlessCaches = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ServerlessCaches.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserGroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserGroupId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserIds/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.UserIds == null)
                        {
                            unmarshalledObject.UserIds = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.UserIds.Add(item);
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

        private static UserGroupUnmarshaller _instance = new UserGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}