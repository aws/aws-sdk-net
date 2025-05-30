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
    /// Response Unmarshaller for GroupDetail Object
    /// </summary>  
    public class GroupDetailUnmarshaller : IXmlUnmarshaller<GroupDetail, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GroupDetail Unmarshall(XmlUnmarshallerContext context)
        {
            GroupDetail unmarshalledObject = new GroupDetail();
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
                    if (context.TestExpression("GroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GroupId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GroupPolicyList/member", targetDepth))
                    {
                        var unmarshaller = PolicyDetailUnmarshaller.Instance;
                        if (unmarshalledObject.GroupPolicyList == null)
                        {
                            unmarshalledObject.GroupPolicyList = new List<PolicyDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.GroupPolicyList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Path", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Path = unmarshaller.Unmarshall(context);
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

        private static GroupDetailUnmarshaller _instance = new GroupDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GroupDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}