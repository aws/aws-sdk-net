/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   PasswordPolicy Unmarshaller
     /// </summary>
    internal class PasswordPolicyUnmarshaller : IUnmarshaller<PasswordPolicy, XmlUnmarshallerContext>, IUnmarshaller<PasswordPolicy, JsonUnmarshallerContext> 
    {
        public PasswordPolicy Unmarshall(XmlUnmarshallerContext context) 
        {
            PasswordPolicy passwordPolicy = new PasswordPolicy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("MinimumPasswordLength", targetDepth))
                    {
                        passwordPolicy.MinimumPasswordLength = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("RequireSymbols", targetDepth))
                    {
                        passwordPolicy.RequireSymbols = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("RequireNumbers", targetDepth))
                    {
                        passwordPolicy.RequireNumbers = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("RequireUppercaseCharacters", targetDepth))
                    {
                        passwordPolicy.RequireUppercaseCharacters = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("RequireLowercaseCharacters", targetDepth))
                    {
                        passwordPolicy.RequireLowercaseCharacters = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AllowUsersToChangePassword", targetDepth))
                    {
                        passwordPolicy.AllowUsersToChangePassword = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ExpirePasswords", targetDepth))
                    {
                        passwordPolicy.ExpirePasswords = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MaxPasswordAge", targetDepth))
                    {
                        passwordPolicy.MaxPasswordAge = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return passwordPolicy;
                }
            }
                        


            return passwordPolicy;
        }

        public PasswordPolicy Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static PasswordPolicyUnmarshaller instance;

        public static PasswordPolicyUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PasswordPolicyUnmarshaller();

            return instance;
        }
    }
}
    
