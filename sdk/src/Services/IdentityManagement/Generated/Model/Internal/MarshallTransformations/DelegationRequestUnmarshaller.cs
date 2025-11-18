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
    /// Response Unmarshaller for DelegationRequest Object
    /// </summary>  
    public class DelegationRequestUnmarshaller : IUnmarshaller<DelegationRequest, XmlUnmarshallerContext>, IUnmarshaller<DelegationRequest, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DelegationRequest Unmarshall(XmlUnmarshallerContext context)
        {
            DelegationRequest unmarshalledObject = new DelegationRequest();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ApproverId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ApproverId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreateDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DelegationRequestId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DelegationRequestId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Notes", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Notes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OnlySendByOwner", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.OnlySendByOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OwnerAccountId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerAccountId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OwnerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PermissionPolicy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PermissionPolicy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Permissions", targetDepth))
                    {
                        var unmarshaller = DelegationPermissionUnmarshaller.Instance;
                        unmarshalledObject.Permissions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RedirectUrl", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RedirectUrl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RejectionReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RejectionReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RequestMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestorId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RequestorId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestorName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RequestorName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RolePermissionRestrictionArns/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.RolePermissionRestrictionArns == null)
                        {
                            unmarshalledObject.RolePermissionRestrictionArns = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RolePermissionRestrictionArns.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SessionDuration", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.SessionDuration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("State", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UpdatedTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdatedTime = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DelegationRequest Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static DelegationRequestUnmarshaller _instance = new DelegationRequestUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DelegationRequestUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}