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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBProxy Object
    /// </summary>  
    public class DBProxyUnmarshaller : IXmlUnmarshaller<DBProxy, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBProxy Unmarshall(XmlUnmarshallerContext context)
        {
            DBProxy unmarshalledObject = new DBProxy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Auth/member", targetDepth))
                    {
                        var unmarshaller = UserAuthConfigInfoUnmarshaller.Instance;
                        if (unmarshalledObject.Auth == null)
                        {
                            unmarshalledObject.Auth = new List<UserAuthConfigInfo>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Auth.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CreatedDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBProxyArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBProxyArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBProxyName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBProxyName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DebugLogging", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.DebugLogging = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultAuthScheme", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultAuthScheme = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointNetworkType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EndpointNetworkType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineFamily", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineFamily = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IdleClientTimeout", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.IdleClientTimeout = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireTLS", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequireTLS = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetConnectionNetworkType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetConnectionNetworkType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UpdatedDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdatedDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcSecurityGroupIds/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.VpcSecurityGroupIds == null)
                        {
                            unmarshalledObject.VpcSecurityGroupIds = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.VpcSecurityGroupIds.Add(item);
                        continue;
                    }
                    if (context.TestExpression("VpcSubnetIds/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.VpcSubnetIds == null)
                        {
                            unmarshalledObject.VpcSubnetIds = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.VpcSubnetIds.Add(item);
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

        private static DBProxyUnmarshaller _instance = new DBProxyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBProxyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}