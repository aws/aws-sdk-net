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
     ///   DBSubnetGroup Unmarshaller
     /// </summary>
    internal class DBSubnetGroupUnmarshaller : IUnmarshaller<DBSubnetGroup, XmlUnmarshallerContext>, IUnmarshaller<DBSubnetGroup, JsonUnmarshallerContext> 
    {
        public DBSubnetGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            DBSubnetGroup dBSubnetGroup = new DBSubnetGroup();
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
                    if (context.TestExpression("DBSubnetGroupName", targetDepth))
                    {
                        dBSubnetGroup.DBSubnetGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBSubnetGroupDescription", targetDepth))
                    {
                        dBSubnetGroup.DBSubnetGroupDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        dBSubnetGroup.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SubnetGroupStatus", targetDepth))
                    {
                        dBSubnetGroup.SubnetGroupStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Subnets/Subnet", targetDepth))
                    {
                        dBSubnetGroup.Subnets.Add(SubnetUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dBSubnetGroup;
                }
            }
                        


            return dBSubnetGroup;
        }

        public DBSubnetGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DBSubnetGroupUnmarshaller instance;

        public static DBSubnetGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DBSubnetGroupUnmarshaller();

            return instance;
        }
    }
}
    
