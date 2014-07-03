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
    /// Response Unmarshaller for PasswordPolicy Object
    /// </summary>  
    public class PasswordPolicyUnmarshaller : IUnmarshaller<PasswordPolicy, XmlUnmarshallerContext>, IUnmarshaller<PasswordPolicy, JsonUnmarshallerContext>
    {
        public PasswordPolicy Unmarshall(XmlUnmarshallerContext context)
        {
            PasswordPolicy unmarshalledObject = new PasswordPolicy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowUsersToChangePassword", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        unmarshalledObject.AllowUsersToChangePassword = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinimumPasswordLength", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.MinimumPasswordLength = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireLowercaseCharacters", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        unmarshalledObject.RequireLowercaseCharacters = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireNumbers", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        unmarshalledObject.RequireNumbers = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireSymbols", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        unmarshalledObject.RequireSymbols = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireUppercaseCharacters", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        unmarshalledObject.RequireUppercaseCharacters = unmarshaller.Unmarshall(context);
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

        public PasswordPolicy Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static PasswordPolicyUnmarshaller instance;
        public static PasswordPolicyUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new PasswordPolicyUnmarshaller();
            }
            return instance;
        }

    }
}