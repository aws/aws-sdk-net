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
     ///   ListInstanceProfilesResult Unmarshaller
     /// </summary>
    internal class ListInstanceProfilesResultUnmarshaller : IUnmarshaller<ListInstanceProfilesResult, XmlUnmarshallerContext> 
    {
        public ListInstanceProfilesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListInstanceProfilesResult listInstanceProfilesResult = new ListInstanceProfilesResult();
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
                        listInstanceProfilesResult.InstanceProfiles.Add(InstanceProfileUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        listInstanceProfilesResult.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        listInstanceProfilesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listInstanceProfilesResult;
                }
            }
                        


            return listInstanceProfilesResult;
        }

        private static ListInstanceProfilesResultUnmarshaller instance;

        public static ListInstanceProfilesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListInstanceProfilesResultUnmarshaller();

            return instance;
        }
    }
}
    
