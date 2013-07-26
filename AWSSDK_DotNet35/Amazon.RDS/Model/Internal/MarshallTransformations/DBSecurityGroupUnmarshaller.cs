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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DBSecurityGroup Unmarshaller
     /// </summary>
    internal class DBSecurityGroupUnmarshaller : IUnmarshaller<DBSecurityGroup, XmlUnmarshallerContext>, IUnmarshaller<DBSecurityGroup, JsonUnmarshallerContext> 
    {
        public DBSecurityGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            DBSecurityGroup dBSecurityGroup = new DBSecurityGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("OwnerId", targetDepth))
                    {
                        dBSecurityGroup.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBSecurityGroupName", targetDepth))
                    {
                        dBSecurityGroup.DBSecurityGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBSecurityGroupDescription", targetDepth))
                    {
                        dBSecurityGroup.DBSecurityGroupDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        dBSecurityGroup.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EC2SecurityGroups/EC2SecurityGroup", targetDepth))
                    {
                        dBSecurityGroup.EC2SecurityGroups.Add(EC2SecurityGroupUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("IPRanges/IPRange", targetDepth))
                    {
                        dBSecurityGroup.IPRanges.Add(IPRangeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dBSecurityGroup;
                }
            }
                        


            return dBSecurityGroup;
        }

        public DBSecurityGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DBSecurityGroupUnmarshaller instance;

        public static DBSecurityGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DBSecurityGroupUnmarshaller();

            return instance;
        }
    }
}
    
