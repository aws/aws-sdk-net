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
    /// Response Unmarshaller for UserDetail Object
    /// </summary>  
    public class UserDetailUnmarshaller : IXmlUnmarshaller<UserDetail, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserDetail Unmarshall(XmlUnmarshallerContext context)
        {
            UserDetail unmarshalledObject = new UserDetail();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Arn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AttachedManagedPolicies/member", targetDepth))
                    {
                        var unmarshaller = AttachedPolicyTypeUnmarshaller.Instance;
                        if (unmarshalledObject.AttachedManagedPolicies == null)
                        {
                            unmarshalledObject.AttachedManagedPolicies = new List<AttachedPolicyType>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AttachedManagedPolicies.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CreateDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GroupList/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.GroupList == null)
                        {
                            unmarshalledObject.GroupList = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.GroupList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Path", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Path = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PermissionsBoundary", targetDepth))
                    {
                        var unmarshaller = AttachedPermissionsBoundaryUnmarshaller.Instance;
                        unmarshalledObject.PermissionsBoundary = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("UserId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserPolicyList/member", targetDepth))
                    {
                        var unmarshaller = PolicyDetailUnmarshaller.Instance;
                        if (unmarshalledObject.UserPolicyList == null)
                        {
                            unmarshalledObject.UserPolicyList = new List<PolicyDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.UserPolicyList.Add(item);
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

        private static UserDetailUnmarshaller _instance = new UserDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}