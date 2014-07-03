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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Role Object
    /// </summary>  
    public class RoleUnmarshaller : IUnmarshaller<Role, XmlUnmarshallerContext>, IUnmarshaller<Role, JsonUnmarshallerContext>
    {
        public Role Unmarshall(XmlUnmarshallerContext context)
        {
            Role unmarshalledObject = new Role();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Arn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AssumeRolePolicyDocument", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.AssumeRolePolicyDocument = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreateDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Path", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Path = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.RoleId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.RoleName = unmarshaller.Unmarshall(context);
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

        public Role Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static RoleUnmarshaller instance;
        public static RoleUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new RoleUnmarshaller();
            }
            return instance;
        }

    }
}