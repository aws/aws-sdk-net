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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PasswordPolicy Object
    /// </summary>  
    public class PasswordPolicyUnmarshaller : IXmlUnmarshaller<PasswordPolicy, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PasswordPolicy Unmarshall(XmlUnmarshallerContext context)
        {
            PasswordPolicy unmarshalledObject = new PasswordPolicy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowUsersToChangePassword", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AllowUsersToChangePassword = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExpirePasswords", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ExpirePasswords = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HardExpiry", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.HardExpiry = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxPasswordAge", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxPasswordAge = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinimumPasswordLength", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinimumPasswordLength = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PasswordReusePrevention", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.PasswordReusePrevention = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireLowercaseCharacters", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequireLowercaseCharacters = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireNumbers", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequireNumbers = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireSymbols", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequireSymbols = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireUppercaseCharacters", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
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

        private static PasswordPolicyUnmarshaller _instance = new PasswordPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PasswordPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}