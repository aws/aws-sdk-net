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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ClusterSubnetGroup Unmarshaller
     /// </summary>
    internal class ClusterSubnetGroupUnmarshaller : IUnmarshaller<ClusterSubnetGroup, XmlUnmarshallerContext>, IUnmarshaller<ClusterSubnetGroup, JsonUnmarshallerContext> 
    {
        public ClusterSubnetGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            ClusterSubnetGroup clusterSubnetGroup = new ClusterSubnetGroup();
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
                    if (context.TestExpression("ClusterSubnetGroupName", targetDepth))
                    {
                        clusterSubnetGroup.ClusterSubnetGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        clusterSubnetGroup.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        clusterSubnetGroup.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SubnetGroupStatus", targetDepth))
                    {
                        clusterSubnetGroup.SubnetGroupStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Subnets/Subnet", targetDepth))
                    {
                        clusterSubnetGroup.Subnets.Add(SubnetUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return clusterSubnetGroup;
                }
            }
                        


            return clusterSubnetGroup;
        }

        public ClusterSubnetGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ClusterSubnetGroupUnmarshaller instance;

        public static ClusterSubnetGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ClusterSubnetGroupUnmarshaller();

            return instance;
        }
    }
}
    
