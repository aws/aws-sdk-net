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
    /// Response Unmarshaller for ListInstanceProfilesForRole Object
    /// </summary>  
    public class ListInstanceProfilesForRoleResultUnmarshaller : IUnmarshaller<ListInstanceProfilesForRoleResult, XmlUnmarshallerContext>
    {
        public ListInstanceProfilesForRoleResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListInstanceProfilesForRoleResult result = new ListInstanceProfilesForRoleResult();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("InstanceProfiles/member", targetDepth))
                    {
                        var unmarshaller = InstanceProfileUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        result.InstanceProfiles.Add(item);
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        result.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Marker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return result;
                }
            }

            return result;
        }


        private static ListInstanceProfilesForRoleResultUnmarshaller instance;
        public static ListInstanceProfilesForRoleResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new ListInstanceProfilesForRoleResultUnmarshaller();
            }
            return instance;
        }

    }
}