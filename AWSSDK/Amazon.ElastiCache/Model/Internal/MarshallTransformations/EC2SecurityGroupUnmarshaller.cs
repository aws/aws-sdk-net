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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   EC2SecurityGroup Unmarshaller
     /// </summary>
    internal class EC2SecurityGroupUnmarshaller : IUnmarshaller<EC2SecurityGroup, XmlUnmarshallerContext>, IUnmarshaller<EC2SecurityGroup, JsonUnmarshallerContext> 
    {
        public EC2SecurityGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            EC2SecurityGroup eC2SecurityGroup = new EC2SecurityGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        eC2SecurityGroup.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EC2SecurityGroupName", targetDepth))
                    {
                        eC2SecurityGroup.EC2SecurityGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EC2SecurityGroupOwnerId", targetDepth))
                    {
                        eC2SecurityGroup.EC2SecurityGroupOwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return eC2SecurityGroup;
                }
            }
                        


            return eC2SecurityGroup;
        }

        public EC2SecurityGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EC2SecurityGroupUnmarshaller instance;

        public static EC2SecurityGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EC2SecurityGroupUnmarshaller();

            return instance;
        }
    }
}
    
